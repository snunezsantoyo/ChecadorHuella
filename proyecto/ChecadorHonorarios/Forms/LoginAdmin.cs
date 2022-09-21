using ChecadorHonorarios.Controllers;
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



            mostrarContraseña.MouseDown += (sender, args) =>
            {
                ContraseñaText.PasswordChar = '\0';
            };

            mostrarContraseña.MouseUp += (sender, args) =>
            {
               
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
                    //emptyUsuario es la etiqueta que indica que debes llenar el campo usuario
                    emptyUsuario.ForeColor = Color.Red;
                    emptyUsuario.Text = "Ingrese un usuario";
                    emptyUsuario.Visible = true;

                }
                    else emptyUsuario.Visible = false;

                if (ContraseñaText.Text == "")
                { 
                    //emptyContraseña es la etiqueta que indica que debes llenar el campo contraseña
                    emptyContraseña.ForeColor = Color.Red;
                    emptyContraseña.Text = "Ingrese contraseña";
                    emptyContraseña.Visible = true;
                }
                    else emptyContraseña.Visible = false;    
            }
            else
            {
                string usuario = UsuarioText.Text;
                string contraseña = ContraseñaText.Text;
                LoginAdminController = new LoginAdminController();
                LoginAdminController.ChecarAdmin(usuario, contraseña);
                UsuarioText.Clear();
                ContraseñaText.Clear();

            }

            

         
        }


    }
}
