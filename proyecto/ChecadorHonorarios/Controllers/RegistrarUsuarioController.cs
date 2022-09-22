using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChecadorHonorarios.Controllers
{
    internal class RegistrarUsuarioController
    {
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string correo;
        private string puesto;
        private string fechaNacimiento;


        public void guardarUsuario(string nombre, string apellidoPaterno, string apellidoMaterno,
        string correo, string puesto, DateTime fechaNacimiento)
        {
            this.nombre = nombre;   
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno; 
            this.correo = correo;
            this.puesto = puesto;
            this.fechaNacimiento = fechaNacimiento.ToShortDateString();

           // MessageBox.Show(this.fechaNacimiento);
        }

      

    }
}
