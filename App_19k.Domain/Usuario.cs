using System;
using System.Collections.Generic;
using System.Text;

namespace App_19k.Domain
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string NUsuario { get; set; }
        public string TUserName { get; set; }
        public string TPassword { get; set; }       
        public Distribuidor ODistribuidor { get; set; }
        public int DistribuidorId { get; set; }
    }
}
