using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.ViewModel;

namespace App_19k.Service
{
    public interface IAdministradorService : ICrudService<Administrador>
    {
        IEnumerable<AdministradorViewModel> FetchAll();
    }
}
