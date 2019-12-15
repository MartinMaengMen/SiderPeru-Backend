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
    public class NumerosContactoController : ControllerBase
    {

        private INumerosContactoService NumerosContactoService;

        public NumerosContactoController(INumerosContactoService NumerosContactoService)
        {
            this.NumerosContactoService = NumerosContactoService;
        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                NumerosContactoService.GetAll()
            );
        }

     
        [HttpGet("{id}")]
        public ActionResult ObtenerPorProyecto(int ProyectoId)
        {
            return Ok(
                NumerosContactoService.LstaContactosXProy(ProyectoId)
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] NumerosContacto NumerosContacto)
        {
            return Ok(
                NumerosContactoService.Save(NumerosContacto)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] NumerosContacto NumerosContacto)
        {
            return Ok(
                NumerosContactoService.Update(NumerosContacto)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                NumerosContactoService.Delete(id)
            );
        }

    }
}