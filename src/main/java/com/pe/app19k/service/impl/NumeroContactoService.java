package com.pe.app19k.service.impl;

import com.pe.app19k.entity.NumeroContacto;
import com.pe.app19k.repository.INumeroContactoRepository;
import com.pe.app19k.service.INumeroContactoService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;
import java.util.Optional;

@Service
public class NumeroContactoService implements INumeroContactoService {
    @Autowired
    private INumeroContactoRepository numeroContactoRepository;
    @Override
    public NumeroContacto Insert(NumeroContacto numeroContacto) throws Exception {
        return numeroContactoRepository.save(numeroContacto);
    }

    @Override
    public NumeroContacto Update(NumeroContacto numeroContacto) throws Exception {
        return numeroContactoRepository.save(numeroContacto);
    }
    @Transactional(readOnly=true)
    @Override
    public List<NumeroContacto> FindAll() throws Exception {
        return numeroContactoRepository.findAll();
    }
    @Transactional(readOnly=true)
    @Override
    public Optional<NumeroContacto> findById(Integer integer) throws Exception {
        return numeroContactoRepository.findById(integer);
    }

    @Override
    public void deleteById(Integer integer) throws Exception {
        numeroContactoRepository.deleteById(integer);
    }

	@Override
	public List<NumeroContacto> fetchByProjectId(Integer id) throws Exception {
		return numeroContactoRepository.fetchByProjectId(id);
	}
}
