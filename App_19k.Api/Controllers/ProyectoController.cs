using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App_19k.Service;
using App_19k.Service.Implementacion;
using App_19k.Domain;

namespace App_19k.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProyectoController : ControllerBase
    {

        private IProyectoService ProyectoService;

        public ProyectoController(IProyectoService ProyectoService)
        {
            this.ProyectoService = ProyectoService;
        }
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                ProyectoService.DetalleXProyecto(id)
            );
        }

        [HttpGet(
            "{tTipo}&{idUsuario}&{nProyecto}&{nDistribuidor}&{grupoDistribuidor}&{nDistrito}&{nUsuario}&{numAreaTerreno}&{numAreaTotal}&{tTipoInversion}&"+
            "{tEstatusProyecto}&{tDireccion}&{numLicencia}&{dInicioSuministro}&{numTiempoSuministro}&{dFechaFinalObra}&{tTipoSolicitud}&{mPrecioSolicitado}&{nConstructora}&"+
            "{tRucConstructora}&{identificadorSider}&{fechaReg}&{grupoConstructora}&{tEstatusSolicitud}" )]//"{TTipo}&{idUsuario}&{idDistribuidor}")]  
        public ActionResult Get(
           string tTipo, string  idUsuario, string nProyecto, string  nDistribuidor, string grupoDistribuidor, string  nDistrito, string nUsuario, string  numAreaTerreno, string numAreaTotal, string  tTipoInversion,
             string tEstatusProyecto, string tDireccion, string numLicencia, string dInicioSuministro, string numTiempoSuministro, string dFechaFinalObra, string tTipoSolicitud, string mPrecioSolicitado, string nConstructora,
             string tRucConstructora, string identificadorSider,string fechaReg,string grupoConstructora,string tEstatusSolicitud
            )
        {
            //tTipo,idUsuario,idDistribuidor,nProyecto,nDistribuidor,grupoDistribuidor,nDistrito,nUsuario,numAreaTerreno,numAreaTotal,tTipoInversion
            //tEstatusProyecto,tDireccion,numLicencia,dInicioSuministro,numTiempoSuministro,dFechaFinalObra,tTipoSolicitud,mPrecioSolicitado,nConstructora
            //tRucConstructora,identificadorSider,fechaReg,grupoConstructora,tEstatusSolicitud
            return Ok(
                ProyectoService.LstaProyectos(
          /*https://localhost:5001/api/proyecto/AdministradorGeneral&1&1&-1&-1&-1&-1&-1&-1&-1&-1&-1&-1&-1&-1&-1&-1&-1&-1&-1&-1&-1&-1&-1&-1&-1&-1*/
          tTipo, Convert.ToInt32(idUsuario), nProyecto,   nDistribuidor,  grupoDistribuidor,   nDistrito,  nUsuario,   numAreaTerreno,  numAreaTotal,   tTipoInversion,
      tEstatusProyecto,  tDireccion,  numLicencia,dInicioSuministro,  numTiempoSuministro,  dFechaFinalObra,  tTipoSolicitud,  mPrecioSolicitado,  nConstructora,
      tRucConstructora, identificadorSider,  fechaReg,  grupoConstructora,  tEstatusSolicitud)         
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Proyecto Proyecto)
        {
            return Ok(
                ProyectoService.Save(Proyecto)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Proyecto Proyecto)
        {
            return Ok(
                ProyectoService.Update(Proyecto)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                ProyectoService.Delete(id)
            );
        }

    }
}