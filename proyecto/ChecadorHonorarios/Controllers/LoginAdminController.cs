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
       


        public void ChecarAdmin(string usuario, string contraseña)
        {
            try
            {
                contexto = new Honorarios_Check_DGTITEntities();
                // administrator admin = new administrator();
                using (contexto)
                {
                    var admin = contexto.administrators
                    .Where(a => a.email == usuario && a.admPassword == contraseña)
                    .FirstOrDefault();

                    if (admin != null)
                    {
                        MessageBox.Show("Funciona: " + admin.email);
                    }
                    else
                    {
                        MessageBox.Show("No existen registros");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

       

    }






}
