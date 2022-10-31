using ChecadorHonorarios.Forms;
using ChecadorHonorarios.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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

        public schedule BuscarScheduleByID(short scheduleID)
        {
            try
            {
                if (scheduleID == 0) throw new Exception("Ingresa un id");

                using (contexto = new Honorarios_Check_DGTITEntities())
                {
                    schedule horario = (from sch in contexto.schedules
                                    where sch.scheduleID == scheduleID
                                    select sch).FirstOrDefault<schedule>();

                    if (horario == null)
                        throw new Exception("No se encontraron resultados para tu busqueda");

                    return horario;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public daysIn BuscarDiasByID(short diasID)
        {
            try
            {
                if (diasID == 0) throw new Exception("Ingresa un id");

                using (contexto = new Honorarios_Check_DGTITEntities())
                {
                    daysIn dias = (from d in contexto.daysIns
                                          where d.daysInID == diasID
                                          select d).FirstOrDefault<daysIn>();

                    if (dias == null)
                        throw new Exception("No se encontraron resultados para tu busqueda");

                    return dias;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public fingerprint BuscarHuellaByID(short huellaID)
        {
            try
            {
                if (huellaID == 0) throw new Exception("Ingresa un id");

                using (contexto = new Honorarios_Check_DGTITEntities())
                {
                    fingerprint huella = (from h in contexto.fingerprints
                                        where h.fingerprintID == huellaID
                                        select h).FirstOrDefault<fingerprint>();

                    if (huella == null)
                        throw new Exception("No se encontraron resultados para tu busqueda");

                    return huella;
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

        public void HabilitarEditarUsuarios(short UsuarioID)
        {
            UsuarioModel.Usuario = BuscarUsuarioByID(UsuarioID);
            UsuarioModel.Huella = BuscarHuellaByID(UsuarioModel.Usuario.fingerprintID);
            UsuarioModel.Horarios = BuscarScheduleByID(UsuarioModel.Usuario.scheduleID);
            UsuarioModel.DiasLaborales = BuscarDiasByID(UsuarioModel.Horarios.daysInID);

            UsuarioModel.Editar = true;
            PrincipalAdminController.CambioInfo_Cerrar = new CapturarUsuario();
        }

        public void EditarUsuarios()
        {

        }

    }


}






