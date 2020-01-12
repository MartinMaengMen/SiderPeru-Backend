package com.pe.app19k.entity.DTO;

import java.util.Date;

import com.pe.app19k.entity.Proyecto;
import com.pe.app19k.entity.Usuario;

public class ProyectoDTO {
	
	//VARIABLES DEL PROYECTO
    private Integer id;
    private String nombre;
    private String identificadorSiderperu;
    private String tipoDeInversion;
    private String statusDeProyecto;
    private String numeroDeLicencia;
    private Integer areaDelTerreno;
    private Integer areaTotal;
    private byte[] imagen;
    private Date fechaFinalDeObra;
    private Date fechaDeRegistro;
    
    //VARIABLES DE UBICACION DEL PROYECTO
    private String distrito;
    private String provincia;
    private String departamento;
    private String direccion;
    private Double altitud;
    private Double latitud;
    
    //VARIABLES DEL SUMINISTRO
    private Integer toneladas;
    private Integer tiempoDeSuministro;
    private String proveedor;
    private Date fechaDeInicioSuministro;
    
    //VARIABLES DE LA SOLICITUD
    private String tipoDeSolicitud;
    private String statusDeSolicitud;
    private String observacion;
    private Double precioSolicitado;
    
    //VARIABLES DE LA CONSTRUCTORA
    private String nombreDeConstructora;
    private String rucDeConstructora;
    private String grupoDeConstructora;
    private Date fechaDeInscripcionDeConstructora;
    
    //VARIABLES DEL USUARIO
    private Integer id_usuario;

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

	public Integer getId_usuario() {
		return id_usuario;
	}

	public void setId_usuario(Integer id_usuario) {
		this.id_usuario = id_usuario;
	}
    
    public Proyecto dtoToEntity(ProyectoDTO dto) {
    	
    	Proyecto proyecto = new Proyecto();
    	proyecto.setId(dto.getId());
    	proyecto.setNombre(dto.getNombre());
    	proyecto.setIdentificadorSiderperu(dto.getIdentificadorSiderperu());
    	proyecto.setTipoDeInversion(dto.getTipoDeInversion());
    	proyecto.setStatusDeProyecto(dto.getStatusDeProyecto());
    	proyecto.setNumeroDeLicencia(dto.getNumeroDeLicencia());
    	proyecto.setAreaDelTerreno(dto.getAreaDelTerreno());
    	proyecto.setAreaTotal(dto.getAreaTotal());
    	proyecto.setImagen(dto.getImagen());
    	proyecto.setFechaFinalDeObra(dto.getFechaFinalDeObra());
    	proyecto.setFechaDeRegistro(dto.getFechaDeRegistro());
    	proyecto.setDistrito(dto.getDistrito());
    	proyecto.setProvincia(dto.getProvincia());
    	proyecto.setDepartamento(dto.getDepartamento());
    	proyecto.setDireccion(dto.getDireccion());
    	proyecto.setAltitud(dto.getAltitud());
    	proyecto.setLatitud(dto.getLatitud());
    	proyecto.setToneladas(dto.getToneladas());
    	proyecto.setTiempoDeSuministro(dto.getTiempoDeSuministro());
    	proyecto.setProveedor(dto.getProveedor());
    	proyecto.setFechaDeInicioSuministro(dto.getFechaDeInicioSuministro());
    	proyecto.setTipoDeSolicitud(dto.getTipoDeSolicitud());
    	proyecto.setStatusDeSolicitud(dto.getStatusDeSolicitud());
    	proyecto.setObservacion(dto.getObservacion());
    	proyecto.setPrecioSolicitado(dto.getPrecioSolicitado());
    	proyecto.setNombreDeConstructora(dto.getNombreDeConstructora());
    	proyecto.setRucDeConstructora(dto.getRucDeConstructora());
    	proyecto.setGrupoDeConstructora(dto.getGrupoDeConstructora());
    	proyecto.setFechaDeInscripcionDeConstructora(dto.getFechaDeInscripcionDeConstructora());
    	Usuario usuario = new Usuario();
    	usuario.setId(dto.getId_usuario());
    	proyecto.setUsuario(usuario);
    	
    	return proyecto;
    }
}
