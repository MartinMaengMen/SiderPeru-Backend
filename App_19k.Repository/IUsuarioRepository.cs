using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.ViewModel;

namespace App_19k.Repository
{
    public interface IUsuarioRepository : ICrudRepository<Usuario>
    {
        IEnumerable<UsuarioViewModel> ValidarUsuario(string username,string psw);
    }
}
