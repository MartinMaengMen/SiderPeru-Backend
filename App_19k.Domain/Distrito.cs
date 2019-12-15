namespace App_19k.Domain
{
    public class Distrito
    {
        public int DistritoId { get; set; }
        public string NDistrito { get; set; }
        public int ProvinciaId { get; set; }
        public Provincia Provincia { get; set; }
    }
}