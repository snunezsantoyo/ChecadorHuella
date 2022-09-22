using ChecadorHonorarios.Controllers;
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
    public partial class CapturarUsuario : Form
    {
        private RegistrarUsuarioController RUController;
        public CapturarUsuario()
        {
            InitializeComponent();

            //Se inicializa el DatetimePicker como vacio para posteriormente poder validarlo
            NacimientoPicker.Format = DateTimePickerFormat.Custom;
            NacimientoPicker.CustomFormat = " ";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            RUController = new RegistrarUsuarioController();
            if (ValidarDatosUsuario())
            {

                
              RUController.guardarUsuario(Nombretxt.Text, Apellidotxt1.Text, Apellidotxt2.Text,
              Correotxt.Text, Puestotxt.Text, NacimientoPicker.Value );

            }
        }

        private bool ValidarDatosUsuario()
        {
            
            if (Nombretxt.Text.Length == 0 || Apellidotxt1.Text.Length == 0 || Apellidotxt2.Text.Length == 0 ||
              Correotxt.Text.Length == 0   || Puestotxt.Text.Length == 0 || NacimientoPicker.Text == " ")
            {

                    if (Nombretxt.Text.Length == 0)
                    {
                        NombreVacio();
                    }
                    else NombreVLabel.Visible = false;

                    if (Apellidotxt1.Text.Length == 0)
                    {
                        PaternoVacio();
                    }
                    else PaternoVLabel.Visible = false;
                     if (Apellidotxt2.Text.Length == 0)
                    {
                        MaternoVacio();
                    }
                    else MaternoVLabel.Visible = false;

                    if (Correotxt.Text.Length == 0)
                    {
                        CorreoVacio();
                    }
                    else CorreoVLabel.Visible = false;
                     if (Puestotxt.Text.Length == 0)
                    {
                        PuestoVacio();
                    }
                    else PuestoVLabel.Visible = false;

                    if (NacimientoPicker.Text == " ")
                    {
                        NacimientoVacio();
                    }
                    else NacimientoVLabel.Visible = false;
                }
                else
                {
                     return true;
                }

            return false;
        }

        private void NombreVacio()
        {
            //emptyUsuario es la etiqueta que indica que debes llenar el campo usuario
            NombreVLabel.ForeColor = Color.Red;
            NombreVLabel.Text = "Este campo es obligatorio";
            NombreVLabel.Visible = true;

        }

        private void PaternoVacio()
        {
            //emptyUsuario es la etiqueta que indica que debes llenar el campo usuario
            PaternoVLabel.ForeColor = Color.Red;
            PaternoVLabel.Text = "Este campo es obligatorio";
            PaternoVLabel.Visible = true;
        }

        private void MaternoVacio() 
        {
            //emptyUsuario es la etiqueta que indica que debes llenar el campo usuario
            MaternoVLabel.ForeColor = Color.Red;
            MaternoVLabel.Text = "Este campo es obligatorio";
            MaternoVLabel.Visible = true;
        }

        private void CorreoVacio() 
        {
            //emptyUsuario es la etiqueta que indica que debes llenar el campo usuario
            CorreoVLabel.ForeColor = Color.Red;
            CorreoVLabel.Text = "Este campo es obligatorio";
            CorreoVLabel.Visible = true;
        }

        private void PuestoVacio() 
        {
            //emptyUsuario es la etiqueta que indica que debes llenar el campo usuario
            PuestoVLabel.ForeColor = Color.Red;
            PuestoVLabel.Text = "Este campo es obligatorio";
            PuestoVLabel.Visible = true;
        }

        private void NacimientoVacio() 
        {
            //emptyUsuario es la etiqueta que indica que debes llenar el campo usuario
            NacimientoVLabel.ForeColor = Color.Red;
            NacimientoVLabel.Text = "Este campo es obligatorio";
            NacimientoVLabel.Visible = true;
        }

        private void CapturarUsuario_Load(object sender, EventArgs e)
        {
 
        }

        private void NacimientoPicker_ValueChanged(object sender, EventArgs e)
        {
            //Una vez que el usuario hace click cambiamos la configuracion del datePicker para que el usuario pueda ver la fecha que ha seleccionado

            NacimientoPicker.Format = DateTimePickerFormat.Short;
            NacimientoPicker.CustomFormat = null;
        }
    }
}
