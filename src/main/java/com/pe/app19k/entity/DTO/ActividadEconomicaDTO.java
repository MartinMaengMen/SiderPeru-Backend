package com.pe.app19k.entity.DTO;

import com.pe.app19k.entity.ActividadEconomica;
import com.pe.app19k.entity.Proyecto;

public class ActividadEconomicaDTO {
    private Integer id;
    private String nombre;
    private Integer id_proyecto;
    
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
	public Integer getId_proyecto() {
		return id_proyecto;
	}
	public void setId_proyecto(Integer id_proyecto) {
		this.id_proyecto = id_proyecto;
	}
    
    public ActividadEconomica dtoToEntity(ActividadEconomicaDTO dto) {
    	
    	ActividadEconomica actividadEconomica = new ActividadEconomica();
    	actividadEconomica.setId(dto.getId());
    	actividadEconomica.setNombre(dto.getNombre());
    	Proyecto proyecto = new Proyecto();
    	proyecto.setId(dto.getId_proyecto());
    	actividadEconomica.setProyecto(proyecto);
    	
    	return actividadEconomica;
    }
}
