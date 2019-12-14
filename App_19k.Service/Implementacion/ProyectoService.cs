using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository;
using App_19k.Repository.Implementacion;
using App_19k.Repository.ViewModel;
namespace App_19k.Service.Implementacion
{
    public class ProyectoService : IProyectoService
    {

        private IProyectoRepository ProyectoRepository;

        public ProyectoService(IProyectoRepository ProyectoRepository)
        {
            this.ProyectoRepository = ProyectoRepository;
        }    

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public VistaProyecto DetalleXProyecto(int id)
        {
            return ProyectoRepository.DetalleXProyecto(id);
        }

        public Proyecto Get(int id)
        {
            return ProyectoRepository.Get(id);
        }

     

        public IEnumerable<Proyecto> GetAll()
        {
            return ProyectoRepository.GetAll();
        }

       

        public IEnumerable<VistaProyecto> LstaProyectos(
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
                               )
        {
            return ProyectoRepository.LstaProyectos(
                               TTipo,
                               idUsuario,                              
                               NProyecto,
                               NDistribuidor,
                               GrupoDistribuidor,
                               NDistrito,
                               NUsuario,
                               NumAreaTerreno,
                               NumAreaTotal,
                               TTipoInversion,
                               TEstatusProyecto,
                               TDireccion,
                               NumLicencia,
                               DInicioSuministro,
                               NumTiempoSuministro,
                               DFechaFinalObra,
                               TTipoSolicitud,
                               MPrecioSolicitado,
                               NConstructora,
                               TRucConstructora,                             
                               IdentificadorSider,
                               FechaReg,
                               GrupoConstructora,
                               TEstatusSolicitud
                            
                );
        }

        public bool Save(Proyecto entity)
        {
            return ProyectoRepository.Save(entity);
        }    

        public bool Update(Proyecto entity)
        {
            return ProyectoRepository.Update(entity);
        }

   

    }
}
/*
fechareg
numtoneladas
 */