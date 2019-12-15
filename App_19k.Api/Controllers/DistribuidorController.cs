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
    public class DistribuidorController : ControllerBase
    {

        private IDistribuidorService DistribuidorService;

        public DistribuidorController(IDistribuidorService DistribuidorService)
        {
            this.DistribuidorService = DistribuidorService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                DistribuidorService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Distribuidor Distribuidor)
        {
            return Ok(
                DistribuidorService.Save(Distribuidor)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Distribuidor Distribuidor)
        {
            return Ok(
                DistribuidorService.Update(Distribuidor)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                DistribuidorService.Delete(id)
            );
        }

    }
}