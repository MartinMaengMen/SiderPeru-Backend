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
    public class ActividadEconomicaController : ControllerBase
    {

        private IActividadEconomicaService ActividadEconomicaService;

        public ActividadEconomicaController(IActividadEconomicaService ActividadEconomicaService)
        {
            this.ActividadEconomicaService = ActividadEconomicaService;
        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                ActividadEconomicaService.GetAll()
            );
        }
        [HttpGet("{id}")]
        public ActionResult ActividadXProyecto(int id)
        {
            return Ok(
                ActividadEconomicaService.LstaActEcoXProyecto(id)
            );
        }



        [HttpPost]
        public ActionResult Post([FromBody] ActividadEconomica ActividadEconomica)
        {
            return Ok(
                ActividadEconomicaService.Save(ActividadEconomica)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] ActividadEconomica ActividadEconomica)
        {
            return Ok(
                ActividadEconomicaService.Update(ActividadEconomica)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                ActividadEconomicaService.Delete(id)
            );
        }

    }
}