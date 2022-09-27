using ChecadorHonorarios.Controllers;
using ChecadorHonorarios.Data;
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
            InstruccionesLabel.Text = "Selecciona los días laborales para el usuario " + RegistroUsuarioModel.Usuario.name + " :";
            

        }

        private void FormatoEntradaSalida()
        {
            
            
            EntradaPicker.Format = DateTimePickerFormat.Custom;
            EntradaPicker.CustomFormat = "HH:mm";
            EntradaPicker.ShowUpDown = true;
            EntradaPicker.Value = Convert.ToDateTime("09:00");
           

            SalidaPicker.Format = DateTimePickerFormat.Custom;
            SalidaPicker.CustomFormat = "HH:mm";
            SalidaPicker.ShowUpDown = true;
            SalidaPicker.Value = Convert.ToDateTime("16:00");

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            foreach (var check in scheduleList.CheckedItems)
            {
                switch (check)
                {
                    case "Lunes":
                        RegistroUsuarioModel.DiasLaborales.monday = true;
                        break;
                    case "Martes":
                        RegistroUsuarioModel.DiasLaborales.tuesday = true;
                        break;
                    case "Miercoles":
                        RegistroUsuarioModel.DiasLaborales.wednesday = true;
                        break;
                    case "Jueves":
                        RegistroUsuarioModel.DiasLaborales.thursday = true;
                        break;
                    case "Viernes":
                        RegistroUsuarioModel.DiasLaborales.friday = true;
                        break;
                    case "Sabado":
                        RegistroUsuarioModel.DiasLaborales.saturday = true;
                        break;
                }

            }
            RegistroUsuarioModel.Horarios.timeIn = new TimeSpan(hours: EntradaPicker.Value.Hour, minutes: EntradaPicker.Value.Minute, seconds: 0);
            //MessageBox.Show(RegistroUsuarioModel.Horarios.timeIn.ToString());
            RegistroUsuarioModel.Horarios.timeOut = new TimeSpan(hours: SalidaPicker.Value.Hour, minutes: SalidaPicker.Value.Minute, seconds: 0);

            Registrar formHuella = new Registrar();
            formHuella.ShowDialog();
            this.Close();
        }


    }
}
