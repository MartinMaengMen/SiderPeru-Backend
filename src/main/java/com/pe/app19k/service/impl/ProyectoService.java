package com.pe.app19k.service.impl;

import com.pe.app19k.entity.Proyecto;
import com.pe.app19k.repository.IProyectoRepository;
import com.pe.app19k.service.IProyectoService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;
import java.util.Optional;

@Service
public class ProyectoService implements IProyectoService {
    @Autowired
    private IProyectoRepository proyectoRepository;
    @Override
    public Proyecto Insert(Proyecto proyecto) throws Exception {
        return proyectoRepository.save(proyecto);
    }

    @Override
    public Proyecto Update(Proyecto proyecto) throws Exception {
        return proyectoRepository.save(proyecto);
    }
    @Transactional(readOnly=true)
    @Override
    public List<Proyecto> FindAll() throws Exception {
        return proyectoRepository.findAll();
    }
    @Transactional(readOnly=true)
    @Override
    public Optional<Proyecto> findById(Integer integer) throws Exception {
        return proyectoRepository.findById(integer);
    }

    @Override
    public void deleteById(Integer integer) throws Exception {
        proyectoRepository.deleteById(integer);
    }
}
