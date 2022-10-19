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

            mostrarContraseña.MouseDown += (sender, args) =>
            {
                //En caso de que este siendo presionado muestra la contraseña
                ContraseñaText.PasswordChar = '\0';
            };

            mostrarContraseña.MouseUp += (sender, args) =>
            {
               //Cuando deja de ser presioando la vuelve a ocultar
                ContraseñaText.PasswordChar = '*';
            };


        }

        private void Entrar_Click(object sender, EventArgs e)
        {

            //Validar que los campos usuario y contraseña no esten vacios
        if (UsuarioText.Text == "" || ContraseñaText.Text == "")
            {
                if (UsuarioText.Text == "")
                {                  
                    UsuarioVacio();
                }
                    else emptyUsuario.Visible = false;

                if (ContraseñaText.Text == "")
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
                    limpiar();
                     PrincipalAdmin NuevoPortal = new PrincipalAdmin();
                    NuevoPortal.ShowDialog();
                    this.Hide();

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


    }
}
