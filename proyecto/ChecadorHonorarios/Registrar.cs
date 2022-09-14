﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChecadorHonorarios
{
    public partial class Registrar : Form
    {
        private DPFP.Template Template;
       // private Honorarios_Check_DGTITEntities contexto;
        public Registrar()
        {
            InitializeComponent();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {
          //  contexto = new Honorarios_Check_DGTITEntities();

            

        }

        private void Listar()
        {
            try
            {

            }
            catch (Exception ex)
            {
                //var fingerprint = from 

                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            CapturarHuella capturar = new CapturarHuella();
            capturar.OnTemplate += this.OnTemplate;
            capturar.ShowDialog();
            

        }

        private void OnTemplate (DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                BtnAgregar.Enabled = (Template != null);
                if (Template != null)
                {
                    MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment");
                    txtHuella.Text = "Huella capturada correctamente";
                }
                else
                {
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
                }
            }));
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
