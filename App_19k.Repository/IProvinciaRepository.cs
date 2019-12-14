using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
namespace App_19k.Repository.Implementacion
{
    public interface IProvinciaRepository : ICrudRepository<Provincia>
    {
        int idXnombre(int idDepartamento, string nombre);
    }
}