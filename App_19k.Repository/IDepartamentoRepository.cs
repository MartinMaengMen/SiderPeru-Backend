using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
namespace App_19k.Repository.Implementacion
{
    public interface IDepartamentoRepository : ICrudRepository<Departamento>
    {
        int idXNombre(string nombre);
    }
}