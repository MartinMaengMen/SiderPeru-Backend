namespace App_19k.Domain
{
    public class Provincia
    {
        public int ProvinciaId { get; set; }
        public string NProvincia { get; set; }
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
    }
}