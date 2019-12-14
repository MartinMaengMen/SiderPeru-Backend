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
    public class AdministradorController : ControllerBase
    {

        private IAdministradorService AdministradorService;

        public AdministradorController(IAdministradorService AdministradorService)
        {
            this.AdministradorService = AdministradorService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                AdministradorService.FetchAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Administrador Administrador)
        {
            return Ok(
                AdministradorService.Save(Administrador)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Administrador Administrador)
        {
            return Ok(
                AdministradorService.Update(Administrador)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                AdministradorService.Delete(id)
            );
        }

    }
}