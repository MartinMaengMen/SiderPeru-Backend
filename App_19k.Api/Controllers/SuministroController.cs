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
    public class SuministroController : ControllerBase
    {

        private ISuministroService SuministroService;

        public SuministroController(ISuministroService SuministroService)
        {
            this.SuministroService = SuministroService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                SuministroService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Suministro Suministro)
        {
            return Ok(
                SuministroService.Save(Suministro)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Suministro Suministro)
        {
            return Ok(
                SuministroService.Update(Suministro)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                SuministroService.Delete(id)
            );
        }

    }
}