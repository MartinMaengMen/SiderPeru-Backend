using System;

namespace App_19k.Domain
{
    public class Entrega
    {
       public int EntregaId { get; set; }
        public int DetalleSuministroId { get; set; }
        public DetalleSuministro DetalleSuministro { get; set; }
        public int Cantidad { get; set; }
        public DateTime DFechaEntrega { get; set; }
    }
}