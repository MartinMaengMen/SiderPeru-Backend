package com.pe.app19k.entity.DTO;

import com.pe.app19k.entity.NumeroContacto;
import com.pe.app19k.entity.Proyecto;

public class NumeroContactoDTO {

    private Integer id;
    private String telefono;
    private String nombre;
    private String tipo;
    private Integer id_proyecto;
    
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
	public Integer getId_proyecto() {
		return id_proyecto;
	}
	public void setId_proyecto(Integer id_proyecto) {
		this.id_proyecto = id_proyecto;
	}
    
    public NumeroContacto dtoToEntity(NumeroContactoDTO dto) {
    	
    	NumeroContacto numeroContacto = new NumeroContacto();
    	numeroContacto.setId(dto.getId());
    	numeroContacto.setTelefono(dto.getTelefono());
    	numeroContacto.setNombre(dto.getNombre());
    	numeroContacto.setTipo(dto.getTipo());
    	Proyecto proyecto = new Proyecto();
    	proyecto.setId(dto.getId_proyecto());
    	numeroContacto.setProyecto(proyecto);
    	
    	return numeroContacto;
    }
}
