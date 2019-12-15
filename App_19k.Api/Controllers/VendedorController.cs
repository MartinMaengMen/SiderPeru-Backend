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
    public class VendedorController : ControllerBase
    {

        private IVendedorService VendedorService;

        public VendedorController(IVendedorService VendedorService)
        {
            this.VendedorService = VendedorService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                VendedorService.FetchAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Vendedor Vendedor)
        {
            return Ok(
                VendedorService.Save(Vendedor)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Vendedor Vendedor)
        {
            return Ok(
                VendedorService.Update(Vendedor)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                VendedorService.Delete(id)
            );
        }

    }
}