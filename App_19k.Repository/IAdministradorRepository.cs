using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.ViewModel;

namespace App_19k.Repository.Implementacion
{
    public interface IAdministradorRepository : ICrudRepository<Administrador>
    {
        IEnumerable<AdministradorViewModel> FetchAll();
    }
}