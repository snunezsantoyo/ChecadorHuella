using ChecadorHonorarios.Controllers;
using ChecadorHonorarios.Models;
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
    public partial class CapturarSchedule : Form
    {


        public CapturarSchedule()
        {

            InitializeComponent();

        }

        private void CapturarSchedule_Load(object sender, EventArgs e)
        {
            FormatoEntradaSalida();
            InstruccionesLabel.Text = "Selecciona los días laborales para el usuario " + UsuarioModel.Usuario.name + " :";
            if (UsuarioModel.Editar) LlenarHorarios();

        }

        public void LlenarHorarios()
        {
            Agregar.Text = "Editar";
            string entrada = UsuarioModel.Horarios.timeIn.Value.Hours.ToString() + ":"
                + UsuarioModel.Horarios.timeOut.Value.Minutes.ToString();

            EntradaPicker.Value = Convert.ToDateTime(entrada);

            string salida = UsuarioModel.Horarios.timeOut.Value.Hours.ToString() + ":"
                + UsuarioModel.Horarios.timeOut.Value.Minutes.ToString();

            SalidaPicker.Value = Convert.ToDateTime(salida);


            scheduleList.SetItemChecked(0, UsuarioModel.DiasLaborales.monday.Value);
            scheduleList.SetItemChecked(1, UsuarioModel.DiasLaborales.tuesday.Value);
            scheduleList.SetItemChecked(2, UsuarioModel.DiasLaborales.wednesday.Value);
            scheduleList.SetItemChecked(3, UsuarioModel.DiasLaborales.thursday.Value);
            scheduleList.SetItemChecked(4, UsuarioModel.DiasLaborales.friday.Value);
            scheduleList.SetItemChecked(5, UsuarioModel.DiasLaborales.saturday.Value);
            
        }





        private void FormatoEntradaSalida()
        {


            EntradaPicker.Format = DateTimePickerFormat.Custom;
            EntradaPicker.CustomFormat = "HH:mm";
            EntradaPicker.ShowUpDown = true;
            EntradaPicker.Value = Convert.ToDateTime("08:30");


            SalidaPicker.Format = DateTimePickerFormat.Custom;
            SalidaPicker.CustomFormat = "HH:mm";
            SalidaPicker.ShowUpDown = true;
            SalidaPicker.Value = Convert.ToDateTime("16:00");

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            DefaultFalso();
            foreach (var check in scheduleList.CheckedItems)
            {

                switch (check)
                {
                    case "Lunes":
                        UsuarioModel.DiasLaborales.monday = true;
                        break;
                    case "Martes":
                        UsuarioModel.DiasLaborales.tuesday = true;
                        break;
                    case "Miercoles":
                        UsuarioModel.DiasLaborales.wednesday = true;
                        break;
                    case "Jueves":
                        UsuarioModel.DiasLaborales.thursday = true;
                        break;
                    case "Viernes":
                        UsuarioModel.DiasLaborales.friday = true;
                        break;
                    case "Sabado":
                        UsuarioModel.DiasLaborales.saturday = true;
                        break;
                }

            }
            UsuarioModel.Horarios.timeIn = new TimeSpan(hours: EntradaPicker.Value.Hour, minutes: EntradaPicker.Value.Minute, seconds: 0);
            //MessageBox.Show(RegistroUsuarioModel.Horarios.timeIn.ToString());
            UsuarioModel.Horarios.timeOut = new TimeSpan(hours: SalidaPicker.Value.Hour, minutes: SalidaPicker.Value.Minute, seconds: 0);

            Registrar formHuella = new Registrar();
            formHuella.ShowDialog();
            this.Close();
        }

        public void DefaultFalso()
        {
            UsuarioModel.DiasLaborales.monday = false;

            UsuarioModel.DiasLaborales.tuesday = false;

            UsuarioModel.DiasLaborales.wednesday = false;

            UsuarioModel.DiasLaborales.thursday = false;

            UsuarioModel.DiasLaborales.friday = false;

            UsuarioModel.DiasLaborales.saturday = false;
        }
    }
}
