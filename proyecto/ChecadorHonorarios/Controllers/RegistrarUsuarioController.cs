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
    public class RegistrarUsuarioController
    {

        private Honorarios_Check_DGTITEntities contexto;


        public void GuardarHorario()
        {

        }
        public void GuardarHuella()
        {

        }

        public bool GuardarUsuario()
        {

            contexto = new Honorarios_Check_DGTITEntities();
            try
            {
                contexto.daysIns.Add(RegistroUsuarioModel.DiasLaborales);
                contexto.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error insertando 'días laborales': {0}", ex.Message));
                return false;
            }

            short pkdaysIn = RegistroUsuarioModel.DiasLaborales.daysInID;
            RegistroUsuarioModel.Horarios.daysInID = pkdaysIn;

            try
            {
                contexto.schedules.Add(RegistroUsuarioModel.Horarios);
                contexto.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(String.Format("Error insertando 'Horarios': {0}", ex.Message));
                return false;
            }

            short pkschedule = RegistroUsuarioModel.Horarios.scheduleID;

            try
            {
                contexto.fingerprints.Add(RegistroUsuarioModel.Huella);
                contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error insertando 'Huella': {0}", ex.Message));
                return false;
            }

            short pkfingerprint = RegistroUsuarioModel.Huella.fingerprintID;

            RegistroUsuarioModel.Usuario.fingerprintID = pkfingerprint;
            RegistroUsuarioModel.Usuario.scheduleID = pkschedule;

            try
            {
                contexto.users.Add(RegistroUsuarioModel.Usuario);
                contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error insertando 'Usuario': {0}", ex.Message));
                return false;
            }

            return true;

        }

        public bool GuardarUsuario2()
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


                            contexto.users.Add(new user());
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

 
           
          

          
