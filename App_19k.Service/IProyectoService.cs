using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.ViewModel;

namespace App_19k.Service
{
    public interface IProyectoService : ICrudService<Proyecto>
    {
       
        IEnumerable<VistaProyecto> LstaProyectos(
                               string TTipo,
                               int idUsuario,                               
                               string NProyecto,
                               string NDistribuidor,
                               string GrupoDistribuidor,
                               string NDistrito,
                               string NUsuario,
                               string NumAreaTerreno,
                               string NumAreaTotal,
                               string TTipoInversion,
                               string TEstatusProyecto,
                               string TDireccion,
                               string NumLicencia,
                               string DInicioSuministro,
                               string NumTiempoSuministro,
                               string DFechaFinalObra,
                               string TTipoSolicitud,
                               string MPrecioSolicitado,
                               string NConstructora,
                               string TRucConstructora,                       
                               string IdentificadorSider,
                               string FechaReg,
                               string GrupoConstructora,
                               string TEstatusSolicitud
                            

            );
        VistaProyecto DetalleXProyecto(int id);
    }
}
