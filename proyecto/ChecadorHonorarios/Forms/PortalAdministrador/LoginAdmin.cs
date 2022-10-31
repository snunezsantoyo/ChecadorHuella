using ChecadorHonorarios.Controllers;
using ChecadorHonorarios.Forms;
using ChecadorHonorarios.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;       //Librería para arrastrar la ventana
using System.Windows.Forms;

namespace ChecadorHonorarios
{
    public partial class LoginAdmin : Form
    {
      //  private Honorarios_Check_DGTITEntities contexto;
        private LoginAdminController LoginAdminController;

        private void LoginAdmin_Load(object sender, EventArgs e)
        {
           
        }
        public LoginAdmin()
        {
            InitializeComponent();

           //Checa si el boton mostrar contraseña esta siendo presionado

            visibleOff.MouseDown += (sender, args) =>
            {
                //En caso de que este siendo presionado muestra la contraseña
                visibleOn.Visible = true;
                visibleOff.Visible = false;
                ContraseñaText.PasswordChar = '\0';
            };

            visibleOff.MouseUp += (sender, args) =>
            {
                visibleOn.Visible = false;
                visibleOff.Visible = true;
                //Cuando deja de ser presioando la vuelve a ocultar
                ContraseñaText.PasswordChar = '*';
            };


        }

        private void Entrar_Click(object sender, EventArgs e)
        {

            //Validar que los campos usuario y contraseña no esten vacios
        if (UsuarioText.Text == "" || ContraseñaText.Text == "" || UsuarioText.Text == "Usuario" || ContraseñaText.Text == "Contraseña")
            {
                if (UsuarioText.Text == "" || UsuarioText.Text == "Usuario")
                {                  
                    UsuarioVacio();
                }
                    else emptyUsuario.Visible = false;

                if (ContraseñaText.Text == "" || ContraseñaText.Text == "Contraseña")
                {               
                    ContraseñaVacio();
                }
                    else emptyContraseña.Visible = false;    
            }
            else
            {
                string usuario = UsuarioText.Text;
                string contraseña = ContraseñaText.Text;
                LoginAdminController = new LoginAdminController();
                if (LoginAdminController.ChecarAdmin(usuario, contraseña))
                {
                    this.Hide();
                    limpiar();
                     PrincipalAdmin NuevoPortal = new PrincipalAdmin();
                    NuevoPortal.ShowDialog();
                    this.Close();

                }
              
                limpiar();
            }

          

        }
        
        //Si el campo Usuario esta vacio se ejecuta la siguiente funcion
        private void UsuarioVacio()
        {
         //emptyUsuario es la etiqueta que indica que debes llenar el campo usuario
            emptyUsuario.ForeColor = Color.Red;
            emptyUsuario.Text = "Ingrese un usuario";
            emptyUsuario.Visible = true;

        }
        //Si el campo Contraseña esta vacio se ejecuta la siguiente funcion
        private void ContraseñaVacio()
        {
         //emptyContraseña es la etiqueta que indica que debes llenar el campo contraseña
            emptyContraseña.ForeColor = Color.Red;
            emptyContraseña.Text = "Ingrese contraseña";
            emptyContraseña.Visible = true;

        }

        //Funcion para limpiar cajas de texto y etiquetas de aviso
        private void limpiar()
        {
            UsuarioText.Clear();
            ContraseñaText.Clear();
            emptyUsuario.Visible = false;
            emptyContraseña.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    
        private void UsuarioText_MouseClick(object sender, MouseEventArgs e)
        {
            if (UsuarioText.Text == "Usuario") UsuarioText.Clear();
            emptyUsuario.Visible = false;
        }

        private void ContraseñaText_MouseClick(object sender, MouseEventArgs e)
        {
            if (ContraseñaText.Text == "Contraseña")
            {
                ContraseñaText.Clear();
                ContraseñaText.PasswordChar = '*';
            }
            emptyContraseña.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureHuella_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsuarioModel.Verificar = true;
            CaptureForm checar = new CaptureForm();
            checar.ShowDialog();
            this.Close();
        }

        private void ContraseñaText_Enter(object sender, EventArgs e)
        {
            if (ContraseñaText.Text == "Contraseña")
            {
                ContraseñaText.Clear();
                ContraseñaText.PasswordChar = '*';
            }
            emptyContraseña.Visible = false;
        }
    }
}
