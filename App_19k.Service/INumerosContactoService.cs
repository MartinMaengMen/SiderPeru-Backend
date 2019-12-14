using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
namespace App_19k.Service
{
    public interface INumerosContactoService : ICrudService<NumerosContacto>
    {
        IEnumerable<NumerosContacto> LstaContactosXProy(int ProyectoId);
    }
}
