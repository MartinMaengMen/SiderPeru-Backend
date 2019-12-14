namespace App_19k.Domain
{
    public class DetalleSuministro
    {
        public DetalleSuministro()
        {

        }
        public DetalleSuministro(int SuministroId,int ProyectoId,int NumCantidad, string TTipoCantidad)
        {
            this.SuministroId = SuministroId;
            this.ProyectoId = ProyectoId;
            this.NumCantidad = NumCantidad;
            this.TTipoCantidad = TTipoCantidad;
        }
        public int DetalleSuministroId { get; set; }
        public int SuministroId { get; set; }
        public Suministro Suministro { get; set; }
        public int ProyectoId { get; set; }
        public Proyecto Proyecto { get; set; }
        public int NumCantidad { get; set; }
        public string   TTipoCantidad { get; set; }
    }
}