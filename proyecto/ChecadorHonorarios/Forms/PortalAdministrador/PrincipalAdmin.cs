using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;       //Librería para arrastrar la ventana
using ChecadorHonorarios.Forms;
using ChecadorHonorarios.Controllers;
using ChecadorHonorarios.Models;

namespace ChecadorHonorarios
{


    public partial class PrincipalAdmin : Form
    {
        public PrincipalAdmin()
        {
            InitializeComponent();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea abandonar el portal?", "ADVERTENCIA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                LoginAdmin newAdmin = new LoginAdmin();
                newAdmin.ShowDialog();
                this.Close();
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*El siguiente código se usa para que la ventana se pueda mover al arrastrar la barra de Titulo*/

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

   
        private void MostrarContenido(Object fH)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {              
                    PrincipalAdminController.LimpiarPanel = true;
                    this.panelContenedor.Controls.RemoveAt(0);          
                
              if (PrincipalAdminController.CancelarProceso)
                {
                    if (PrincipalAdminController.CambioInfo_Cerrar != null) PrincipalAdminController.CambioInfo_Cerrar.Close();
                    if (PrincipalAdminController.CambioInfo_Hide != null) PrincipalAdminController.CambioInfo_Hide.Close();

                    PrincipalAdminController.CancelarProceso = false;
                }
              
            }
            PrincipalAdminController.LimpiarPanel = false;
            Form formHijo = fH as Form;
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formHijo);
            this.panelContenedor.Tag = formHijo;
            formHijo.Show();


        }
        private void MostrarContenido(Object fH, bool hide)
        {
            if (this.panelContenedor.Controls.Count > 0 && hide)
            {
                PrincipalAdminController.LimpiarPanel = true;
                this.panelContenedor.Controls.RemoveAt(0);
                PrincipalAdminController.LimpiarPanel = false;
                Form formHijo = fH as Form;
                formHijo.TopLevel = false;
                formHijo.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(formHijo);
                this.panelContenedor.Tag = formHijo;
                formHijo.Show();

            }
            else
            {
                PrincipalAdminController.LimpiarPanel = false;
                Form formHijo = fH as Form;
                formHijo.TopLevel = false;
                formHijo.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(formHijo);
                this.panelContenedor.Tag = formHijo;
                formHijo.Show();

            }

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();
            if (UsuarioModel.Editar)
            {
               
                DialogResult dialogResult = MessageBox.Show("¿Desea abandonar la pagina actual? , Si abandona la pagina se perderan los cambios.", "ADVERTENCIA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                    usuarioController.LimpiarCampos();
                    PrincipalAdminController.EstadoForm_Set("CLOSE");
                    UsuarioModel.Editar = false;
                    PrincipalAdminController.CancelarProceso = true;
                    MostrarContenido(new CapturarUsuario());
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            }
            else
            {
                usuarioController.LimpiarCampos();
                PrincipalAdminController.EstadoForm_Set("CLOSE");
                UsuarioModel.Editar = false;
                MostrarContenido(new CapturarUsuario());
            }
            
        }

        private void panelContenedor_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (!PrincipalAdminController.LimpiarPanel)
            {
                /* CLOSE       (1, 0)              -> Cuando cerramos una pantalla */
                if (PrincipalAdminController.CloseForm && !PrincipalAdminController.HideForm) MostrarContenido(PrincipalAdminController.CambioInfo_Cerrar);
                else if (PrincipalAdminController.CloseForm && PrincipalAdminController.HideForm)
                    MostrarContenido(PrincipalAdminController.CambioInfo_Hide, true);
                PrincipalAdminController.CambioInfo_Cerrar.VisibleChanged += (object send, EventArgs args) =>
                    {
                        /*HIDE        (0, 1)              -> Cuando escondemos una pantalla */
                        if (!PrincipalAdminController.CloseForm  &&  PrincipalAdminController.HideForm)
                           MostrarContenido(PrincipalAdminController.CambioInfo_Cerrar, false);
                        /* SHOW        (1, 1)              -> Cuando queremos mostrar una pantalla que esta escondida*/
                        
                    };

            }

        }

        private void panelContenedor_Esconder()
        {

        }


        private void btnVer_Click(object sender, EventArgs e)
        {
            PrincipalAdminController.EstadoForm_Set("CLOSE");
            MostrarContenido(new PruebasCRUDUsuario());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            
                DialogResult dialogResult = MessageBox.Show("¿Desea abandonar el portal?", "ADVERTENCIA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Hide();
                    LoginAdmin newAdmin = new LoginAdmin();
                    newAdmin.ShowDialog();
                    this.Close();
                }
                               
        }


        private void PrincipalAdmin_Load(object sender, EventArgs e)
        {
            PrincipalAdminController.EstadoForm_Set("INIT");
            MostrarContenido(new PantallaPrincipal());
        }
    }
}
