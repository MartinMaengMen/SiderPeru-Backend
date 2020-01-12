package com.pe.app19k.entity;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.validation.constraints.NotEmpty;
import javax.validation.constraints.NotNull;

@Entity
public class NumeroContacto {
	@Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;
    @Column(name = "telefono", length = 9, nullable = false)
    @NotEmpty(message = "Ingrese un número de teléfono")
    private String telefono;
    @Column(name = "nombre", nullable = false)
    @NotEmpty(message = "Ingrese un nombre de contacto")
    private String nombre;
    @Column(name = "tipo", nullable = false)
    @NotEmpty(message = "Ingrese el tipo de contacto")
    private String tipo;
    @ManyToOne(fetch = FetchType.EAGER)
    @JoinColumn(name="id_proyecto")
    @NotNull(message = "Ingrese un proyecto")
    private Proyecto proyecto;
    
	public Integer getId() {
		return id;
	}
	public void setId(Integer id) {
		this.id = id;
	}
	public String getTelefono() {
		return telefono;
	}
	public void setTelefono(String telefono) {
		this.telefono = telefono;
	}
	public String getNombre() {
		return nombre;
	}
	public void setNombre(String nombre) {
		this.nombre = nombre;
	}
	public String getTipo() {
		return tipo;
	}
	public void setTipo(String tipo) {
		this.tipo = tipo;
	}
	public Proyecto getProyecto() {
		return proyecto;
	}
	public void setProyecto(Proyecto proyecto) {
		this.proyecto = proyecto;
	}

}
