using App_19k.Domain;
using System;
using System.Collections.Generic;

namespace App_19k.Repository.ViewModel
{
    public class VistaProyecto
    {
        public int ProyectoId { get; set; }
        public string NDepartamento { get; set; }
        public string NProvincia{ get; set; }
        public string NProyecto { get; set; }
        public int? MarcaProveedorId { get; set; }
        public string NMarcaProveedor{ get; set; }
        public int? DistribuidorId { get; set; }
        public string NDistribuidor { get; set; }
        public string GrupoDistribuidor { get; set; }
        public int? DistritoId { get; set; }     
        public string NDistrito { get; set; }
        public int? VendedorId { get; set; }
        public string NVendedor { get; set; }
        public decimal? NumAreaTerreno{ get; set; }
        public decimal? NumAreaTotal { get; set; }
        public string TTipoInversion { get; set; }
        public string TEstatusProyecto { get; set; }
        public string TEstatusSolicitud { get; set; }
        public string NumLicencia { get; set; }
        public string DInicioSuministro { get; set; }
        public int? NumTiempoSuministro { get; set; }
        public string DFechaFinalObra { get; set; }
        public string GrupoConstructora { get; set; }
        public string TTipoSolicitud { get; set; }
        public decimal? MPrecioSolicitado { get; set; }
        public string NConstructora { get; set; }
        public string TRucConstructora { get; set; }    
        public string IdentificadorSider { get; set; }
        public string FechaReg { get; set; }
        public string TDireccion { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Altitud { get; set; }
        public decimal? NumToneladas { get; set; }
        public decimal? MPrecioAutorizadoBase { get; set; }
        public decimal? Flete { get; set; }
        public decimal? MPrecioFinal { get; set; }
        public int? DiasValidez { get; set; }
        public string FechaInicioOferta { get; set; }
        public string FechaFinOferta { get; set; }
        public string FechaInicioVigenciaPrecio { get; set; }
        public string FechaFinalVigenciaPrecio { get; set; }
        public string FechaAutorizacionPrecio { get; set; }
        public string ObservacionRpta { get; set; }
        public string ObservacionProyecto { get; set; }
        public string FechaInscripcion { get; set; }
        public DetalleSuministroViewModel LstaDetalleSuministro { get; set; }
        public List<Respuesta> LstaRespuestas { get; set; }
        public List<ActividadEconomica> LstaActividadEconomica { get; set; }
        public List<NumerosContacto> LstaNumerosContacto{ get; set; }

    }
}