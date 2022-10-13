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
    public partial class NuevoAdmin : Form
    {
        private Honorarios_Check_DGTITEntities contexto;

        public NuevoAdmin()
        {
            InitializeComponent();
        }

        private void NewAdmin_Load(object sender, EventArgs e)
        {
            contexto = new Honorarios_Check_DGTITEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            administrator admin = new administrator()
            {

            };
        }
    }
}
