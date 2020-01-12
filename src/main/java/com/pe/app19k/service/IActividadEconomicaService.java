package com.pe.app19k.service;

import java.util.List;

import com.pe.app19k.entity.ActividadEconomica;

public interface IActividadEconomicaService extends CrudService<ActividadEconomica,Integer> {
	List<ActividadEconomica> fetchByProjectId(Integer id) throws Exception;
}
