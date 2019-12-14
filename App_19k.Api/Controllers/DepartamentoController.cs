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
    public class DepartamentoController : ControllerBase
    {

        private IDepartamentoService DepartamentoService;

        public DepartamentoController(IDepartamentoService DepartamentoService)
        {
            this.DepartamentoService = DepartamentoService;
        }
        [HttpGet("{nombre}")]
        public ActionResult idXNombre(string nombre)
        {
            return Ok(
                DepartamentoService.idXNombre(nombre)
            );
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                DepartamentoService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Departamento Departamento)
        {
            return Ok(
                DepartamentoService.Save(Departamento)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Departamento Departamento)
        {
            return Ok(
                DepartamentoService.Update(Departamento)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                DepartamentoService.Delete(id)
            );
        }

    }
}