using ChecadorHonorarios.Models;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
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
                            contexto.daysIns.Add(UsuarioModel.DiasLaborales);
                            contexto.SaveChanges();

                            short pkdaysIn = UsuarioModel.DiasLaborales.daysInID;
                            UsuarioModel.Horarios.daysInID = pkdaysIn;


                            contexto.schedules.Add(UsuarioModel.Horarios);
                            contexto.SaveChanges();


                            short pkschedule = UsuarioModel.Horarios.scheduleID;


                            contexto.fingerprints.Add(UsuarioModel.Huella);
                            contexto.SaveChanges();

                            short pkfingerprint = UsuarioModel.Huella.fingerprintID;

                            UsuarioModel.Usuario.fingerprintID = pkfingerprint;
                            UsuarioModel.Usuario.scheduleID = pkschedule;


                            contexto.users.Add(UsuarioModel.Usuario);
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

        public void ValidarUsuario()
        {

        }

        public user BuscarUsuarioByID(short UsuarioID)
        {
            try
            {
                if (UsuarioID == 0) throw new Exception("Ingresa un id");

                using (contexto = new Honorarios_Check_DGTITEntities())
                {
                    user usuario = (from u in contexto.users
                                    where u.userID == UsuarioID
                                    select u).FirstOrDefault<user>();

                    if (usuario == null)
                        throw new Exception("No se encontraron resultados para tu busqueda");

                    return usuario;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public bool EliminarUsuario(short UsuarioID)
        {

            bool eliminado;
            try
            {
                if (UsuarioID == 0) throw new Exception("Ingresa un id");
                using (contexto = new Honorarios_Check_DGTITEntities())
                {
                    user usuario = (from u in contexto.users
                                    where u.userID == UsuarioID
                                    select u).FirstOrDefault();

                    if (usuario == null)
                        throw new Exception("No se encontraron resultados para tu busqueda");

                    usuario.deleted = true;
                    contexto.SaveChanges();
                    eliminado = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return eliminado;
        }

        public List<user> ListarUsuarios()
        {
            try
            {
                using (contexto = new Honorarios_Check_DGTITEntities())
                {
                    List<user> lstUsuario = (from u in contexto.users
                                             select u).ToList();
                    return lstUsuario;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void EditarUsuarios()
        {

        }
    }


}






