using ChecadorHonorarios.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChecadorHonorarios
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PruebasCRUDUsuario prueba = new PruebasCRUDUsuario();
            prueba.ShowDialog();
            this.Hide();
            /*Verificar loginAdmin = new Verificar();
            loginAdmin.ShowDialog();*/
            
        }

        private void IniciarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            LoginAdmin nuevaSesion = new LoginAdmin();
            nuevaSesion.ShowDialog();
        }
    }
}
