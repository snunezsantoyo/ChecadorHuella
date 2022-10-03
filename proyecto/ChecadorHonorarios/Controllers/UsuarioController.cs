using ChecadorHonorarios.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChecadorHonorarios.Controllers
{
    public class UsuarioController
    {

        private Honorarios_Check_DGTITEntities contexto;

        public bool GuardarUsuario()
        {
            bool guardado;

            try
            {
                using (contexto = new Honorarios_Check_DGTITEntities())
                {
                    using (DbContextTransaction dbContextTransaction = contexto.Database.BeginTransaction())
                    {

                        try
                        {
                            contexto.daysIns.Add(RegistroUsuarioModel.DiasLaborales);
                            contexto.SaveChanges();

                            short pkdaysIn = RegistroUsuarioModel.DiasLaborales.daysInID;
                            RegistroUsuarioModel.Horarios.daysInID = pkdaysIn;


                            contexto.schedules.Add(RegistroUsuarioModel.Horarios);
                            contexto.SaveChanges();


                            short pkschedule = RegistroUsuarioModel.Horarios.scheduleID;


                            contexto.fingerprints.Add(RegistroUsuarioModel.Huella);
                            contexto.SaveChanges();

                            short pkfingerprint = RegistroUsuarioModel.Huella.fingerprintID;

                            RegistroUsuarioModel.Usuario.fingerprintID = pkfingerprint;
                            RegistroUsuarioModel.Usuario.scheduleID = pkschedule;


                            contexto.users.Add(RegistroUsuarioModel.Usuario);
                            contexto.SaveChanges();

                            dbContextTransaction.Commit();

                            guardado = true;
                        }
                        catch (Exception)
                        {
                            dbContextTransaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error: " + ex.Message);

            }


            return guardado;
        }



    }

}                  

 
           
          

          
