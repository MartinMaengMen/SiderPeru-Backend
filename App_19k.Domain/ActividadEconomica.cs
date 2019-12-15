namespace App_19k.Domain
{
    public class ActividadEconomica

    {
        public int ActividadEconomicaId { get; set; }
        public string NActividadEconomica { get; set; }
       public int ProyectoId{ get; set;}
        public Proyecto Proyecto{ get; set; }
    }
}