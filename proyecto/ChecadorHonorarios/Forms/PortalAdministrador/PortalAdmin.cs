using ChecadorHonorarios.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChecadorHonorarios.Forms
{
    public partial class PortalAdmin : Form
    {
        public PortalAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoAdmin nuevoAdmin = new NuevoAdmin();
            nuevoAdmin.ShowDialog();           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CapturarUsuario formRegistrar = new CapturarUsuario();
            formRegistrar.ShowDialog();
        }
    }
}
