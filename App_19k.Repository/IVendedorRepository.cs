using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.ViewModel;

namespace App_19k.Repository.Implementacion
{
    public interface IVendedorRepository : ICrudRepository<Vendedor>
    {
        IEnumerable<VendedorViewModel> FetchAll();
    }
}