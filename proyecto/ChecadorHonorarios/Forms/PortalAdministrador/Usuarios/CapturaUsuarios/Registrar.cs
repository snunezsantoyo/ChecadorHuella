using ChecadorHonorarios.Controllers;
using ChecadorHonorarios.Forms;
using ChecadorHonorarios.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChecadorHonorarios
{
    public partial class Registrar : Form
    {
        private DPFP.Template Template;
        private Honorarios_Check_DGTITEntities contexto;
        private UsuarioController RUController;
        public Registrar()
        {
            InitializeComponent();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {
            contexto = new Honorarios_Check_DGTITEntities();
            Listar();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioModel.Verificar = false;
            CaptureForm capturar = new CaptureForm();
            
            capturar.OnTemplate += this.OnTemplate;
            PrincipalAdminController.CambioInfo_Cerrar = capturar;           
            PrincipalAdminController.CambioInfo_Hide = this;
            this.Hide();          
        }

      

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                BtnAgregar.Enabled = (Template != null);
                if (Template != null)
                {
                    MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment");
                }
                else
                {
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
                }
            }));
        }

        private void Listar()
        {
            try
            {
                var usuario =
                    from u in contexto.users
                    join sc in contexto.schedules on u.scheduleID equals sc.scheduleID
                    join dy in contexto.daysIns on sc.daysInID equals dy.daysInID
                    select new
                    {                       
                        u.jobPosition,
                        sc.timeIn,
                        sc.timeOut,
                        dy.monday,
                        dy.tuesday,
                        dy.wednesday,
                        dy.thursday,
                        dy.friday,
                        dy.saturday
                    };

                if (usuario != null)
                {
                    DgvListar.DataSource = usuario.ToList();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] streamHuella = Template.Bytes;

                UsuarioModel.Huella.huella = streamHuella;
                RUController = new UsuarioController();
                if (RUController.GuardarUsuario())
                {
                    MessageBox.Show("Agregado correctamente");
                    Listar();
                    Template = null;
                    BtnAgregar.Enabled = false;
                    PrincipalAdminController.HideForm = false;
                    PrincipalAdminController.CambioInfo_Hide = null;
                    PrincipalAdminController.CambioInfo_Cerrar = new PruebasCRUDUsuario();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el usuario correctamente");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Registrar_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
