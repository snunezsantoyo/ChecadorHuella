﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Registrar formRegistrar = new Registrar();
            formRegistrar.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Verificar loginAdmin = new Verificar();
            loginAdmin.ShowDialog();
            /*LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.ShowDialog();*/
        }
    }
}
