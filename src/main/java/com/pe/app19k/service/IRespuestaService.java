package com.pe.app19k.service;

import java.util.List;

import com.pe.app19k.entity.Respuesta;

public interface IRespuestaService extends CrudService<Respuesta,Integer> {
	List<Respuesta> fetchByProjectId(Integer id) throws Exception; 
}
