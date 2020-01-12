package com.pe.app19k.entity;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;

import java.util.Date;
@Entity
public class Respuesta {
	@Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;
    @Column(name = "dias_validez")
    private Integer diasDeValidez;
    @Column(name = "precio_base")
    private Double precioBase;
    @Column(name = "precio_fehab")
    private Double precioFehab;
    @Column(name = "flete")
    private Double flete;
    @Column(name = "fecha_inicio_validez_oferta")
    private Date fechaInicioValidezDeOferta;
    @Column(name = "fecha_final_validez_oferta")
    private Date fechaFinalValidezDeOferta;
    @Column(name = "fecha_inicio_vigencia_precio")
    private Date fechaInicioVigenciaDePrecio;
    @Column(name = "fecha_final_vigencia_precio")
    private Date fechaFinalVigenciaDePrecio;
    @Column(name = "fecha_registro")
    private Date fechaDeRegistro;
    @Column(name = "observacion")
    private String observacion;
    @ManyToOne(fetch = FetchType.EAGER)
    @JoinColumn(name="id_proyecto")
    private Proyecto proyecto;
    
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
	public Proyecto getProyecto() {
		return proyecto;
	}
	public void setProyecto(Proyecto proyecto) {
		this.proyecto = proyecto;
	}
}
