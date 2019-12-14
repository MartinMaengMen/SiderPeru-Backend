using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
namespace App_19k.Repository.Implementacion
{
    public interface IDistritoRepository : ICrudRepository<Distrito>
    {
        int? idXnombre(string nDepartamento, string nProvincia, string nDistrito);
    }
}