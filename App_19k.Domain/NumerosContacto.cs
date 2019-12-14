namespace App_19k.Domain
{
    public class NumerosContacto
    {
        public int NumerosContactoId { get; set; }
        public int NumComu { get; set; }

        public string NombreContacto { get; set; }

        public string Tipo_Contacto { get; set; }
        public int ProyectoId { get; set; }
        public Proyecto Proyecto{ get; set; }
    }
}