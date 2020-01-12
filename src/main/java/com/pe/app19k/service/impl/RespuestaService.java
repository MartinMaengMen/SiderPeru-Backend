package com.pe.app19k.service.impl;

import com.pe.app19k.entity.Respuesta;
import com.pe.app19k.repository.IRespuestaRepository;
import com.pe.app19k.service.IRespuestaService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;
import java.util.Optional;

@Service
public class RespuestaService implements IRespuestaService {
    @Autowired
    private IRespuestaRepository respuestaRepository;
    @Override
    public Respuesta Insert(Respuesta respuesta) throws Exception {
        return respuestaRepository.save(respuesta);
    }

    @Override
    public Respuesta Update(Respuesta respuesta) throws Exception {
        return respuestaRepository.save(respuesta);
    }
    @Transactional(readOnly=true)
    @Override
    public List<Respuesta> FindAll() throws Exception {
        return respuestaRepository.findAll();
    }
    @Transactional(readOnly=true)
    @Override
    public Optional<Respuesta> findById(Integer integer) throws Exception {
        return respuestaRepository.findById(integer);
    }

    @Override
    public void deleteById(Integer integer) throws Exception {
        respuestaRepository.deleteById(integer);
    }

	@Override
	public List<Respuesta> fetchByProjectId(Integer id) throws Exception {
		return respuestaRepository.fetchByProjectId(id);
	}
}
