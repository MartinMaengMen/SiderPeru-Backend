package com.pe.app19k.entity.DTO;

import java.util.Date;

import com.pe.app19k.entity.Proyecto;
import com.pe.app19k.entity.Respuesta;

public class RespuestaDTO {
    private Integer id;
    private Integer diasDeValidez;
    private Double precioBase;
    private Double precioFehab;
    private Double flete;
    private Date fechaInicioValidezDeOferta;
    private Date fechaFinalValidezDeOferta;
    private Date fechaInicioVigenciaDePrecio;
    private Date fechaFinalVigenciaDePrecio;
    private Date fechaDeRegistro;
    private String observacion;
    private Integer id_proyecto;
    
	public Integer getId() {
		return id;
	}
	public void setId(Integer id) {
		this.id = id;
	}
	public Integer getDiasDeValidez() {
		return diasDeValidez;
	}
	public void setDiasDeValidez(Integer diasDeValidez) {
		this.diasDeValidez = diasDeValidez;
	}
	public Double getPrecioBase() {
		return precioBase;
	}
	public void setPrecioBase(Double precioBase) {
		this.precioBase = precioBase;
	}
	public Double getPrecioFehab() {
		return precioFehab;
	}
	public void setPrecioFehab(Double precioFehab) {
		this.precioFehab = precioFehab;
	}
	public Double getFlete() {
		return flete;
	}
	public void setFlete(Double flete) {
		this.flete = flete;
	}
	public Date getFechaInicioValidezDeOferta() {
		return fechaInicioValidezDeOferta;
	}
	public void setFechaInicioValidezDeOferta(Date fechaInicioValidezDeOferta) {
		this.fechaInicioValidezDeOferta = fechaInicioValidezDeOferta;
	}
	public Date getFechaFinalValidezDeOferta() {
		return fechaFinalValidezDeOferta;
	}
	public void setFechaFinalValidezDeOferta(Date fechaFinalValidezDeOferta) {
		this.fechaFinalValidezDeOferta = fechaFinalValidezDeOferta;
	}
	public Date getFechaInicioVigenciaDePrecio() {
		return fechaInicioVigenciaDePrecio;
	}
	public void setFechaInicioVigenciaDePrecio(Date fechaInicioVigenciaDePrecio) {
		this.fechaInicioVigenciaDePrecio = fechaInicioVigenciaDePrecio;
	}
	public Date getFechaFinalVigenciaDePrecio() {
		return fechaFinalVigenciaDePrecio;
	}
	public void setFechaFinalVigenciaDePrecio(Date fechaFinalVigenciaDePrecio) {
		this.fechaFinalVigenciaDePrecio = fechaFinalVigenciaDePrecio;
	}
	public Date getFechaDeRegistro() {
		return fechaDeRegistro;
	}
	public void setFechaDeRegistro(Date fechaDeRegistro) {
		this.fechaDeRegistro = fechaDeRegistro;
	}
	public String getObservacion() {
		return observacion;
	}
	public void setObservacion(String observacion) {
		this.observacion = observacion;
	}
	public Integer getId_proyecto() {
		return id_proyecto;
	}
	public void setId_proyecto(Integer id_proyecto) {
		this.id_proyecto = id_proyecto;
	}
    
    public Respuesta dtoToEntity(RespuestaDTO dto) {
    	
    	Respuesta respuesta = new Respuesta();
    	respuesta.setId(dto.getId());
    	respuesta.setDiasDeValidez(dto.getDiasDeValidez());
    	respuesta.setPrecioBase(dto.getPrecioBase());
    	respuesta.setPrecioFehab(dto.getPrecioFehab());
    	respuesta.setFlete(dto.getFlete());
    	respuesta.setFechaInicioValidezDeOferta(dto.getFechaInicioValidezDeOferta());
    	respuesta.setFechaFinalValidezDeOferta(dto.getFechaFinalValidezDeOferta());
    	respuesta.setFechaInicioVigenciaDePrecio(dto.getFechaInicioVigenciaDePrecio());
    	respuesta.setFechaFinalVigenciaDePrecio(dto.getFechaFinalVigenciaDePrecio());
    	respuesta.setFechaDeRegistro(dto.getFechaDeRegistro());
    	respuesta.setObservacion(dto.getObservacion());
    	Proyecto proyecto = new Proyecto();
    	proyecto.setId(dto.getId_proyecto());
    	respuesta.setProyecto(proyecto);
    	
    	return respuesta;
    }
}
