namespace App_19k.Domain
{
    public class Administrador
    {
       public int AdministradorId { get; set; }       
       public Usuario AdministradorNavigation { get; set; }
       public bool? FAdminGeneral { get; set; }
    }
}