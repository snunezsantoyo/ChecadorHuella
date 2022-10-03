﻿using ChecadorHonorarios.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChecadorHonorarios
{
    public partial class Verificar : CaptureForm
    {
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        private Honorarios_Check_DGTITEntities contexto;

        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }
        protected override void Init()
        {
            base.Init();
            base.Text = "Verificación de Huella Digital";
            Verificator = new DPFP.Verification.Verification();    // Create a fingerprint template verificator
            UpdateStatus(0);
        }
        private void UpdateStatus(int FAR)
        {
            // Show "False accept rate" value
            SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR));
        }
        public Verificar()
        {
            contexto = new Honorarios_Check_DGTITEntities();
            InitializeComponent();
        }

        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                DPFP.Template template = new DPFP.Template();
                Stream stream;

                foreach (var finger in contexto.fingerprints)
                {
                    stream = new MemoryStream(finger.huella);
                    template = new DPFP.Template(stream);

                    Verificator.Verify(features, template, ref result);
                    UpdateStatus(result.FARAchieved);
                    if (result.Verified)
                    {
                        var usuario = (from u in contexto.users 
                                       where u.fingerprintID == finger.fingerprintID
                                       select u.name).FirstOrDefault();

                        if (string.IsNullOrEmpty(usuario))
                            MessageBox.Show("El usuario no esta registrado");                                              
                        else                        
                            MakeReport("The fingerprint was VERIFIED. " + usuario);                      
                           
                        break;
                    }



                }



            }
        }


        private void Verificar_Load(object sender, EventArgs e)
        {

        }
    }
}
