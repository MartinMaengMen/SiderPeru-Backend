using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository;
using App_19k.Repository.Implementacion;
using App_19k.Repository.ViewModel;

namespace App_19k.Service.Implementacion
{
    public class UsuarioService : IUsuarioService
    {

        private IUsuarioRepository UsuarioRepository;

        public UsuarioService(IUsuarioRepository UsuarioRepository)
        {
            this.UsuarioRepository = UsuarioRepository;
        }    

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario Get(int id)
        {
            return UsuarioRepository.Get(id);
        }

        

        public IEnumerable<Usuario> GetAll()
        {
            return UsuarioRepository.GetAll();
        }

        public bool Save(Usuario entity)
        {
            return UsuarioRepository.Save(entity);
        }    

        public bool Update(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioViewModel> ValidarUsuario(string username, string psw)
        {
            return UsuarioRepository.ValidarUsuario(username, psw);
        }
    }
}
