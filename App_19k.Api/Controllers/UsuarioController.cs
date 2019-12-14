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
    public class UsuarioController : ControllerBase
    {

        private IUsuarioService UsuarioService;

        public UsuarioController(IUsuarioService UsuarioService)
        {
            this.UsuarioService = UsuarioService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                UsuarioService.GetAll()
            );
        }
        [HttpGet ("{user}&{psw}")]
        public ActionResult validar(string user,string psw)
        {           
            return Ok(
               UsuarioService.ValidarUsuario(user,psw)
            ); 
        }

        [HttpPost]
        public ActionResult Post([FromBody] Usuario Usuario)
        {
            return Ok(
                UsuarioService.Save(Usuario)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Usuario Usuario)
        {
            return Ok(
                UsuarioService.Update(Usuario)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                UsuarioService.Delete(id)
            );
        }

    }
}