using ChecadorHonorarios.Forms;
using ChecadorHonorarios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChecadorHonorarios.Controllers
{
    internal class LoginAdminController
    {
        private Honorarios_Check_DGTITEntities contexto;


        //Función para checar que el usuario ingresado y la contraseña sean validos 
        public bool ChecarAdmin(string usuario, string contraseña)
        {
            bool ingresar = false;
            try
            {
                contexto = new Honorarios_Check_DGTITEntities();                
                using (contexto)
                {
                    var admin = contexto.administrators
                    .Where(a => a.email == usuario && a.admPassword == contraseña)
                    .FirstOrDefault();

                    if (admin != null)  ingresar = true;
                    else
                    {
                        admin = contexto.administrators
                        .Where(a => a.nickname == usuario && a.admPassword == contraseña)
                        .FirstOrDefault();

                        if (admin != null) ingresar = true;
                        
                        else throw new Exception("Los datos ingresados son incorrectos!");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return ingresar;
        }

    }
}
