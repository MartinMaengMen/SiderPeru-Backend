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
    public class ProvinciaController : ControllerBase
    {

        private IProvinciaService ProvinciaService;

        public ProvinciaController(IProvinciaService ProvinciaService)
        {
            this.ProvinciaService = ProvinciaService;
        }

        [HttpGet("{idDepartamento}&{nombre}")]
        public ActionResult Get(int idDepartamento,string nombre)
        {
            return Ok(
                ProvinciaService.idXnombre(idDepartamento,nombre)
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Provincia Provincia)
        {
            return Ok(
                ProvinciaService.Save(Provincia)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Provincia Provincia)
        {
            return Ok(
                ProvinciaService.Update(Provincia)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                ProvinciaService.Delete(id)
            );
        }

    }
}