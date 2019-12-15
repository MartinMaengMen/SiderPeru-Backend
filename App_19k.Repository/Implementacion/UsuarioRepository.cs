using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.Context;
using App_19k.Repository.ViewModel;

namespace App_19k.Repository.Implementacion
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private ApplicationDbContext context;

        public UsuarioRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Usuario Get(int id)
        {
            var result = new Usuario();
            try
            {
                result = context.Usuarios.Single(x => x.UsuarioId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Usuario> GetAll()
        {

            var result = new List<Usuario>();
            try
            {
                result = context.Usuarios.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Usuario entity)
        {
            try
            {
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Usuario entity)
        {
            try
            {
                var UsuarioOriginal = context.Usuarios.Single(
                    x => x.UsuarioId == entity.UsuarioId
                );

                UsuarioOriginal.UsuarioId = entity.UsuarioId;
                UsuarioOriginal.TPassword = entity.TPassword;
                UsuarioOriginal.TUserName= entity.TUserName;


                context.Update(UsuarioOriginal);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UsuarioViewModel> ValidarUsuario(string username, string psw)
        {
            var tipo = "";
            var LstaVen = from u in context.Usuarios
                                    join v in context.Vendedores
                                    on u.UsuarioId equals v.VendedorId         
                                    join d in context.Distribuidores
                                    on u.DistribuidorId equals d.DistribuidorId
                                    where u.TUserName == username && u.TPassword == psw
                                select new { u.UsuarioId, u.NUsuario, u.TUserName,u.TPassword, v.TDni, v.TEstado, d.NDistribuidor, d.DistribuidorId};

            var LstaAdmin = from u in context.Usuarios
                                join a in context.Administradores
                                on u.UsuarioId equals a.AdministradorId
                                join d in context.Distribuidores
                                on u.DistribuidorId equals d.DistribuidorId 
                                where u.TUserName == username && u.TPassword == psw
                                select new  { u.UsuarioId, u.NUsuario, u.TUserName,u.TPassword, a.FAdminGeneral, d.NDistribuidor, d.DistribuidorId};
         
                foreach (var valor in LstaVen)
                {
                    tipo = "Vendedor";
                }
              
                foreach (var valor in LstaAdmin)
                {
                if (valor.FAdminGeneral == true)
                {
                    tipo = "Administrador General";
                }
                else
                {
                    tipo = "Administrador";
                }
            }
           
            if(tipo == "Vendedor")
            {
                var Lstacredenciales = from u in context.Usuarios
                                    join v in context.Vendedores
                                    on u.UsuarioId equals v.VendedorId         
                                    join d in context.Distribuidores
                                    on u.DistribuidorId equals d.DistribuidorId 
                                select new { u.UsuarioId, u.NUsuario,u.TUserName,u.TPassword, v.TDni, v.TEstado, d.NDistribuidor, d.DistribuidorId};
                
                
                var rpt = new List<UsuarioViewModel>();
                foreach (var credencial in Lstacredenciales)
                {
                    username = username.ToLower();
                    var usernameBD = credencial.TUserName.ToString().ToLower();
                    
                    if (usernameBD == username && credencial.TPassword == psw)
                    {
                        var usuariovm = new UsuarioViewModel();

                        usuariovm.DistribuidorId = credencial.DistribuidorId;
                        usuariovm.nDistribuidor = credencial.NDistribuidor;
                        usuariovm.NUsuario = credencial.NUsuario;
                        usuariovm.TPassword = credencial.TPassword;
                        usuariovm.TTipo = "Vendedor";
                        usuariovm.TUserName = credencial.TUserName;
                        usuariovm.UsuarioId = credencial.UsuarioId;
                        rpt.Add(usuariovm);
                    }
                }
                return rpt;
            }
            else if(tipo == "Administrador General" || tipo == "Administrador")
            {
                var Lstacredenciales = from u in context.Usuarios
                                join a in context.Administradores
                                on u.UsuarioId equals a.AdministradorId
                                join d in context.Distribuidores
                                on u.DistribuidorId equals d.DistribuidorId 
                                select new  { u.UsuarioId, u.NUsuario,u.TUserName,u.TPassword, a.FAdminGeneral, d.NDistribuidor, d.DistribuidorId};

                                
                var rpt = new List<UsuarioViewModel>();
                foreach (var credencial in Lstacredenciales)
                {
                    username = username.ToLower();
                    var usernameBD = credencial.TUserName.ToString().ToLower();
                    
                    if (usernameBD == username && credencial.TPassword == psw)
                    {
                        var usuariovm = new UsuarioViewModel();

                        usuariovm.DistribuidorId = credencial.DistribuidorId;
                        usuariovm.nDistribuidor = credencial.NDistribuidor;
                        usuariovm.NUsuario = credencial.NUsuario;
                        usuariovm.TPassword = credencial.TPassword;
                        if(credencial.FAdminGeneral == true)
                        {
                            usuariovm.TTipo = "Administrador General";
                        }
                        else
                        {
                            usuariovm.TTipo = "Administrador";
                        }
                        usuariovm.TUserName = credencial.TUserName;
                        usuariovm.UsuarioId = credencial.UsuarioId;
                        rpt.Add(usuariovm);
                    }
                }
                return rpt;
            }

            return new List<UsuarioViewModel>();
        }
    }
}