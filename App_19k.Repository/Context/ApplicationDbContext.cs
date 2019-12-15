using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using App_19k.Domain;
namespace App_19k.Repository.Context
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }



        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<Entrega> Entregas { get; set; }
        public virtual DbSet<Administrador> Administradores{ get; set; }
        public virtual DbSet<DetalleSuministro> DetalleSuministros { get; set; }
        public virtual DbSet<Distribuidor> Distribuidores { get; set; }
        public virtual DbSet<Distrito> Distritos { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<Proyecto> Proyectos { get; set; }
        public virtual DbSet<Suministro> Suministros { get; set; }
        public virtual DbSet<Vendedor> Vendedores { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<NumerosContacto> NumerosContactos{ get; set; }
        public virtual DbSet<MarcaProveedor> MarcaProveedores{ get; set; }
        public virtual DbSet<Respuesta> Respuestas{ get; set; }
        public virtual DbSet<ActividadEconomica> ActividadEconomicas{ get; set; }



    }
}
