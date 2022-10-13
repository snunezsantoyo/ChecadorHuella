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


    }
}
