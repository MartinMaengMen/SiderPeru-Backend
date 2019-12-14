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
    public class MarcaProveedorController : ControllerBase
    {

        private IMarcaProveedorService MarcaProveedorService;

        public MarcaProveedorController(IMarcaProveedorService MarcaProveedorService)
        {
            this.MarcaProveedorService = MarcaProveedorService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                MarcaProveedorService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] MarcaProveedor MarcaProveedor)
        {
            return Ok(
                MarcaProveedorService.Save(MarcaProveedor)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] MarcaProveedor MarcaProveedor)
        {
            return Ok(
                MarcaProveedorService.Update(MarcaProveedor)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                MarcaProveedorService.Delete(id)
            );
        }

    }
}