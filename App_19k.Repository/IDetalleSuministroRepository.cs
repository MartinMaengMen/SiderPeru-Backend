using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.ViewModel;

namespace App_19k.Repository.Implementacion
{
    public interface IDetalleSuministroRepository : ICrudRepository<DetalleSuministro>
    {
        DetalleSuministroViewModel DetalleXProyecto(int idProyecto);
        bool GuardarDetalleSuministro(DetalleSuministroViewModel obj);
    }
}