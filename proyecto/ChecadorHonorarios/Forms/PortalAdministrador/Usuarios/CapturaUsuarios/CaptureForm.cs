using ChecadorHonorarios.Models;
using DPFP.Verification;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Linq;

namespace ChecadorHonorarios
{
    /* NOTE: This form is a base for the EnrollmentForm and the VerificationForm,
		All changes in the CaptureForm will be reflected in all its derived forms.
	*/
    delegate void Function();

    public partial class CaptureForm : Form, DPFP.Capture.EventHandler
    {
        //Variables globales
        private DPFP.Capture.Capture Capturer;
        //Variables Verificacion 
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        private Honorarios_Check_DGTITEntities contexto;
        //Variables Registrar
        public delegate void OnTemplateEventHandler(DPFP.Template template);
        public event OnTemplateEventHandler OnTemplate;
        private DPFP.Processing.Enrollment Enroller;
        public CaptureForm()
        {
            InitializeComponent();
        }

        protected virtual void Init()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();              // Create a capture operation.

                if (null != Capturer)
                    Capturer.EventHandler = this;                   // Subscribe for capturing events.
                else
                    throw new Exception("No se pudo iniciar la operación de captura");
            }
            catch
            {
                MessageBox.Show("No se pudo iniciar la operación de captura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (UsuarioModel.Verificar)
            {
                this.Text = "Verificación de Huella Digital";
                Verificator = new DPFP.Verification.Verification();    // Create a fingerprint template verificator
            }
            else
            {
                base.Text = "Dar de alta huella";
                Enroller = new DPFP.Processing.Enrollment();
                UpdateStatus();
            }
        }
        private void UpdateStatus()
        {
            // Show number of samples needed.
            MessageBox.Show(String.Format("Fingerprint samples needed: {0}", Enroller.FeaturesNeeded));
        }
        protected virtual void Process(DPFP.Sample Sample)
        {
            // Draw fingerprint sample image.
            ConvertSampleToBitmap(Sample);
            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);
            if (features != null)
            {
                if (UsuarioModel.Verificar)
                {
                    Verification.Result result = new Verification.Result();

                    DPFP.Template template = new DPFP.Template();
                    Stream stream;
                    contexto = new Honorarios_Check_DGTITEntities();
                    foreach (var finger in contexto.fingerprints)
                    {
                        stream = new MemoryStream(finger.huella);
                        template = new DPFP.Template(stream);

                        Verificator.Verify(features, template, ref result);
                        if (result.Verified)
                        {
                            var usuario = (from u in contexto.users
                                           where u.fingerprintID == finger.fingerprintID
                                           select u.name).FirstOrDefault();

                            if (!string.IsNullOrEmpty(usuario))
                                MessageBox.Show("The fingerprint was VERIFIED. " + usuario);
                                                      
                            break;
                        }
                    }
                    MessageBox.Show("El usuario no esta registrado");
                }
                else
                {
                    try
                    {
                        //MakeReport("The fingerprint feature set was created.");
                        Enroller.AddFeatures(features);     // Add feature set to template.
                    }
                    finally
                    {
                        UpdateStatus();

                        // Check if template has been created.
                        switch (Enroller.TemplateStatus)
                        {
                            case DPFP.Processing.Enrollment.Status.Ready:   // report success and stop capturing
                                OnTemplate(Enroller.Template);
                                // SetPrompt("Click Close, and then click Fingerprint Verification.");
                                Stop();
                                break;

                            case DPFP.Processing.Enrollment.Status.Failed:  // report failure and restart capturing
                                Enroller.Clear();
                                Stop();
                                UpdateStatus();
                                OnTemplate(null);
                                Start();
                                break;
                        }
                    }
                }
            }
        }

        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                }
                catch
                {
                    throw; //new Exception("No se puede iniciar la captura");
                }
            }
        }

        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    throw new Exception("No se puede terminar la captura");
                }
            }
        }

        #region Form Event Handlers:

        private void CaptureForm_Load(object sender, EventArgs e)
        {
            Init();
            Start();                                                // Start capture operation.
        }

        private void CaptureForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();
        }
        #endregion

        #region EventHandler Members:

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            //MakeReport("La muestra ha sido capturada");
            //SetPrompt("Escanea tu misma huella otra vez");
            Process(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            //MakeReport("La huella fue removida del lector");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            //MakeReport("El lector fue tocado");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            //MakeReport("El Lector de huellas ha sido conectado");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            //MakeReport("El Lector de huellas ha sido desconectado");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            /*if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
				MakeReport("La calidad de la muestra es BUENA");
			else
				MakeReport("La calidad de la muestra es MALA");*/
        }
        #endregion

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();  // Create a sample convertor.
            Bitmap bitmap = null;                                                           // TODO: the size doesn't matter
            Convertor.ConvertToPicture(Sample, ref bitmap);                                 // TODO: return bitmap as a result
            return bitmap;
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();  // Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }



    }
}