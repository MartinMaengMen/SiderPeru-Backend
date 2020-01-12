package com.pe.app19k.entity;

import javax.persistence.*;

import java.util.Date;

@Entity
@Table(name="Proyectos")
public class Proyecto {

	//VARIABLES DEL PROYECTO
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;
    @Column(name = "nombre")
    private String nombre;
    @Column(name = "identificador_siderperu", unique = true)
    private String identificadorSiderperu;
    @Column(name = "tipo_inversion")
    private String tipoDeInversion;
    @Column(name = "status_proyecto")
    private String statusDeProyecto;
    @Column(name = "numero_licencia")
    private String numeroDeLicencia;
    @Column(name = "area_terreno")
    private Integer areaDelTerreno;
    @Column(name = "area_total")
    private Integer areaTotal;
    @Column(name = "imagen")
    private byte[] imagen;
    @Temporal(TemporalType.DATE)
    @Column(name = "fecha_final_obra")
    private Date fechaFinalDeObra;
    @Temporal(TemporalType.TIMESTAMP)
    @Column(name = "fecha_registro")
    private Date fechaDeRegistro;
    
    //VARIABLES DE UBICACION DEL PROYECTO
    @Column(name = "distrito")
    private String distrito;
    @Column(name = "provincia")
    private String provincia;
    @Column(name = "departamento")
    private String departamento;
    @Column(name = "direccion")
    private String direccion;
    @Column(name = "altitud")
    private Double altitud;
    @Column(name = "latitud")
    private Double latitud;
    
    //VARIABLES DEL SUMINISTRO
    @Column(name = "toneladas")
    private Integer toneladas;
    @Column(name = "tiempo_suministro")
    private Integer tiempoDeSuministro;
    @Column(name = "proveedor")
    private String proveedor;
    @Temporal(TemporalType.DATE)
    @Column(name = "fecha_inicio_suministro")
    private Date fechaDeInicioSuministro;
    
    //VARIABLES DE LA SOLICITUD
    @Column(name = "tipo_solicitud")
    private String tipoDeSolicitud;
    @Column(name = "status_solicitud")
    private String statusDeSolicitud;
    @Column(name = "observacion")
    private String observacion;
    @Column(name = "precio_solicitado")
    private Double precioSolicitado;
    
    //VARIABLES DE LA CONSTRUCTORA
    @Column(name = "nombre_constructora")
    private String nombreDeConstructora;
    @Column(name = "ruc_constructora", length = 11)
    private String rucDeConstructora;
    @Column(name = "grupo_constructora")
    private String grupoDeConstructora;
    @Temporal(TemporalType.DATE)
    @Column(name = "fecha_inscripcion_constructora")
    private Date fechaDeInscripcionDeConstructora;
    
    //VARIABLES DEL USUARIO
    @ManyToOne(fetch = FetchType.EAGER)
    @JoinColumn(name="id_usuario")
    private Usuario usuario;

	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getIdentificadorSiderperu() {
		return identificadorSiderperu;
	}

	public void setIdentificadorSiderperu(String identificadorSiderperu) {
		this.identificadorSiderperu = identificadorSiderperu;
	}

	public String getTipoDeInversion() {
		return tipoDeInversion;
	}

	public void setTipoDeInversion(String tipoDeInversion) {
		this.tipoDeInversion = tipoDeInversion;
	}

	public String getStatusDeProyecto() {
		return statusDeProyecto;
	}

	public void setStatusDeProyecto(String statusDeProyecto) {
		this.statusDeProyecto = statusDeProyecto;
	}

	public String getNumeroDeLicencia() {
		return numeroDeLicencia;
	}

	public void setNumeroDeLicencia(String numeroDeLicencia) {
		this.numeroDeLicencia = numeroDeLicencia;
	}

	public Integer getAreaDelTerreno() {
		return areaDelTerreno;
	}

	public void setAreaDelTerreno(Integer areaDelTerreno) {
		this.areaDelTerreno = areaDelTerreno;
	}

	public Integer getAreaTotal() {
		return areaTotal;
	}

	public void setAreaTotal(Integer areaTotal) {
		this.areaTotal = areaTotal;
	}

	public byte[] getImagen() {
		return imagen;
	}

	public void setImagen(byte[] imagen) {
		this.imagen = imagen;
	}

	public Date getFechaFinalDeObra() {
		return fechaFinalDeObra;
	}

	public void setFechaFinalDeObra(Date fechaFinalDeObra) {
		this.fechaFinalDeObra = fechaFinalDeObra;
	}

	public Date getFechaDeRegistro() {
		return fechaDeRegistro;
	}

	public void setFechaDeRegistro(Date fechaDeRegistro) {
		this.fechaDeRegistro = fechaDeRegistro;
	}

	public String getDistrito() {
		return distrito;
	}

	public void setDistrito(String distrito) {
		this.distrito = distrito;
	}

	public String getProvincia() {
		return provincia;
	}

	public void setProvincia(String provincia) {
		this.provincia = provincia;
	}

	public String getDepartamento() {
		return departamento;
	}

	public void setDepartamento(String departamento) {
		this.departamento = departamento;
	}

	public String getDireccion() {
		return direccion;
	}

	public void setDireccion(String direccion) {
		this.direccion = direccion;
	}

	public Double getAltitud() {
		return altitud;
	}

	public void setAltitud(Double altitud) {
		this.altitud = altitud;
	}

	public Double getLatitud() {
		return latitud;
	}

	public void setLatitud(Double latitud) {
		this.latitud = latitud;
	}

	public Integer getToneladas() {
		return toneladas;
	}

	public void setToneladas(Integer toneladas) {
		this.toneladas = toneladas;
	}

	public Integer getTiempoDeSuministro() {
		return tiempoDeSuministro;
	}

	public void setTiempoDeSuministro(Integer tiempoDeSuministro) {
		this.tiempoDeSuministro = tiempoDeSuministro;
	}

	public String getProveedor() {
		return proveedor;
	}

	public void setProveedor(String proveedor) {
		this.proveedor = proveedor;
	}

	public Date getFechaDeInicioSuministro() {
		return fechaDeInicioSuministro;
	}

	public void setFechaDeInicioSuministro(Date fechaDeInicioSuministro) {
		this.fechaDeInicioSuministro = fechaDeInicioSuministro;
	}

	public String getTipoDeSolicitud() {
		return tipoDeSolicitud;
	}

	public void setTipoDeSolicitud(String tipoDeSolicitud) {
		this.tipoDeSolicitud = tipoDeSolicitud;
	}

	public String getStatusDeSolicitud() {
		return statusDeSolicitud;
	}

	public void setStatusDeSolicitud(String statusDeSolicitud) {
		this.statusDeSolicitud = statusDeSolicitud;
	}

	public String getObservacion() {
		return observacion;
	}

	public void setObservacion(String observacion) {
		this.observacion = observacion;
	}

	public Double getPrecioSolicitado() {
		return precioSolicitado;
	}

	public void setPrecioSolicitado(Double precioSolicitado) {
		this.precioSolicitado = precioSolicitado;
	}

	public String getNombreDeConstructora() {
		return nombreDeConstructora;
	}

	public void setNombreDeConstructora(String nombreDeConstructora) {
		this.nombreDeConstructora = nombreDeConstructora;
	}

	public String getRucDeConstructora() {
		return rucDeConstructora;
	}

	public void setRucDeConstructora(String rucDeConstructora) {
		this.rucDeConstructora = rucDeConstructora;
	}

	public String getGrupoDeConstructora() {
		return grupoDeConstructora;
	}

	public void setGrupoDeConstructora(String grupoDeConstructora) {
		this.grupoDeConstructora = grupoDeConstructora;
	}

	public Date getFechaDeInscripcionDeConstructora() {
		return fechaDeInscripcionDeConstructora;
	}

	public void setFechaDeInscripcionDeConstructora(Date fechaDeInscripcionDeConstructora) {
		this.fechaDeInscripcionDeConstructora = fechaDeInscripcionDeConstructora;
	}

	public Usuario getUsuario() {
		return usuario;
	}

	public void setUsuario(Usuario usuario) {
		this.usuario = usuario;
	}
}
