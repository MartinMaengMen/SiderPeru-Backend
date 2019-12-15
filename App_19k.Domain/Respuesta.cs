using System;

namespace App_19k.Domain
{
    public class Respuesta
    {
        public int RespuestaId { get; set; }
        public decimal MPrecioAutorizadoBase { get; set; }
        public decimal Flete { get; set; }
        public int DiasValidez { get; set; }
        public DateTime FechaInicioOferta { get; set; }
        public DateTime FechaInicioVigenciaPrecio { get; set; }
        public DateTime FechaFinalVigenciaPrecio { get; set; }
        public int ProyectoId {get;set;}
        public DateTime FechaReg { get; set; }
        public Proyecto Proyecto { get; set; }
        public decimal fehab { get; set; }
        public decimal preciofehab { get; set; }
        public string observaciones { get; set; }
    }
}