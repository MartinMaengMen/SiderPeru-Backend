package com.pe.app19k.service;

import java.util.List;

import com.pe.app19k.entity.NumeroContacto;

public interface INumeroContactoService extends CrudService<NumeroContacto,Integer> {
	List<NumeroContacto> fetchByProjectId(Integer id) throws Exception;
}
