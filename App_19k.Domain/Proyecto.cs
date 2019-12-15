using System;
using System.ComponentModel.DataAnnotations;

namespace App_19k.Domain
{
    public class Proyecto
    {
        public int ProyectoId { get;set;}
        public string NProyecto{get;set;}
        public int? DistritoId{get;set;}
        public Distrito Distrito{get;set;}
        public int? VendedorId { get;set;}
        public Vendedor Vendedor{get;set;}
        
        public decimal? NumAreaTerreno{get;set;}
        public decimal? NumAreaTotal{ get; set; }
        public string TTipoInversion{get;set;}
        public string TEstatusProyecto{get;set;}
        public string TEstatusSolicitud { get; set; }
        public string NumLicencia { get; set; }        
        public DateTime? DInicioSuministro{get;set;}
        public int? NumTiempoSuministro {get;set;}
        public DateTime? DFechaFinalObra{get;set;}  
        public string TTipoSolicitud{get;set;}
        public decimal? MPrecioSolicitado{get;set;}
        public string NConstructora{get;set;}
        public string TRucConstructora{get;set;}
       
        public string IdentificadorSider{ get; set; }
        public DateTime? FechaReg { get; set; }
        public string GrupoConstructora { get; set; }
        public string TDireccion { get; set; }
        public int? MarcaProveedorId { get; set; }
        public MarcaProveedor MarcaProveedor { get; set; }
        public decimal? NumToneladas { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Altitud { get; set; }
        public string ObservacionProyecto { get; set; }

        public DateTime? FechaInscripcion { get; set; }

    }
}