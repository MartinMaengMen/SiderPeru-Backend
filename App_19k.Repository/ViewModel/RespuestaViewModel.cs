using System;

namespace App_19k.Repository.ViewModel
{
    public class RespuestaViewModel
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
        public decimal fehab { get; set; }
        public decimal preciofehab  { get; set; }
        public string observaciones { get; set; }
    }
}