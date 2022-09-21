using ChecadorHonorarios.Model;
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
        private Honorarios_Check_DGTITEntities contexto;
        private void LoginAdmin_Load(object sender, EventArgs e)
        {
            contexto = new Honorarios_Check_DGTITEntities();
        }
        public LoginAdmin()
        {
            InitializeComponent();
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
                checarAdmin();
            }

            

         
        }

        private void checarAdmin()
        {
            try
            {
                string usuario = UsuarioText.Text;
                string contraseña = ContraseñaText.Text;

                // administrator admin = new administrator();
                using (contexto)
                {
                    var admin = contexto.administrators
                    .Where(a => a.email == usuario && a.admPassword == contraseña)
                    .FirstOrDefault();

                    if (admin.administratorID == 1)
                    {
                        MessageBox.Show("Funciona: " + admin.email);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void mostrarContraseña_MouseDown(object sender, EventArgs e)
        {
            ContraseñaText.PasswordChar = '\0';
        }

        public void mostrarContraseña_MouseUp(object sender, EventArgs e)
        {
            ContraseñaText.PasswordChar = '*';
        }

       


    }
}
