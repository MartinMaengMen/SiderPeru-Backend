using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App_19k.Service;
using App_19k.Service.Implementacion;
using App_19k.Domain;
using App_19k.Repository.ViewModel;

namespace App_19k.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RespuestaController : ControllerBase
    {

        private IRespuestaService RespuestaService;

        public RespuestaController(IRespuestaService RespuestaService)
        {
            this.RespuestaService = RespuestaService;
        }

        [HttpGet("{idProyecto}")]
        public ActionResult Get(int idProyecto)
        {
            return Ok(
                RespuestaService.ObtenerRpta(idProyecto)
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] RespuestaViewModel respuesta)
        {
            return Ok(
                RespuestaService.Enviar(respuesta)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] RespuestaViewModel respuesta)
        {
            return Ok(
                RespuestaService.Actualizar(respuesta)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                RespuestaService.Delete(id)
            );
        }

    }
}