using App_19k.Domain;
namespace App_19k.Repository.ViewModel
{
    public class UsuarioViewModel
    {
        public int UsuarioId { get; set; }
        public string NUsuario { get; set; }
        public string TUserName { get; set; }
        public string TPassword { get; set; }       
        public string nDistribuidor { get; set; }
        public int DistribuidorId { get; set; }
        public string TTipo {get; set; }
    }
}