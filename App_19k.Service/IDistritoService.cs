using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
namespace App_19k.Service
{
    public interface IDistritoService : ICrudService<Distrito>
    {
        int? idXnombre(string nDepartamento, string nProvincia,string nDistrito);
    }
}
