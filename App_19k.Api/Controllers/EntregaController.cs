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
    public class EntregaController : ControllerBase
    {

        private IEntregaService EntregaService;

        public EntregaController(IEntregaService EntregaService)
        {
            this.EntregaService = EntregaService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                EntregaService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Entrega Entrega)
        {
            return Ok(
                EntregaService.Save(Entrega)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Entrega Entrega)
        {
            return Ok(
                EntregaService.Update(Entrega)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                EntregaService.Delete(id)
            );
        }

    }
}