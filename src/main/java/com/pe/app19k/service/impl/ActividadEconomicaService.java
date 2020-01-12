package com.pe.app19k.service.impl;

import com.pe.app19k.entity.ActividadEconomica;
import com.pe.app19k.repository.IActividadEconomicaRepository;
import com.pe.app19k.service.IActividadEconomicaService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;
import java.util.Optional;

@Service
public class ActividadEconomicaService implements IActividadEconomicaService {
    @Autowired
    private IActividadEconomicaRepository actividadEconomicaRepository;

    @Override
    public ActividadEconomica Insert(ActividadEconomica actividadEconomica) throws Exception {
        return actividadEconomicaRepository.save(actividadEconomica);
    }

    @Override
    public ActividadEconomica Update(ActividadEconomica actividadEconomica) throws Exception {
        return actividadEconomicaRepository.save(actividadEconomica);
    }
    @Transactional(readOnly=true)
    @Override
    public List<ActividadEconomica> FindAll() throws Exception {
        return actividadEconomicaRepository.findAll();
    }
    @Transactional(readOnly=true)
    @Override
    public Optional<ActividadEconomica> findById(Integer integer) throws Exception {
        return actividadEconomicaRepository.findById(integer);
    }

    @Override
    public void deleteById(Integer integer) throws Exception {
        actividadEconomicaRepository.deleteById(integer);
    }

	@Override
	public List<ActividadEconomica> fetchByProjectId(Integer id) throws Exception {
		return actividadEconomicaRepository.fetchByProjectId(id);
	}
}
