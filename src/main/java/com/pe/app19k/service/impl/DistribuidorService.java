package com.pe.app19k.service.impl;

import com.pe.app19k.entity.Distribuidor;
import com.pe.app19k.repository.IDistribuidorRepository;
import com.pe.app19k.service.IDistribuidorService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;
import java.util.Optional;

@Service
public class DistribuidorService implements IDistribuidorService {
    @Autowired
    private IDistribuidorRepository distribuidorRepository;
    @Override
    public Distribuidor Insert(Distribuidor distribuidor) throws Exception {
        return distribuidorRepository.save(distribuidor);
    }

    @Override
    public Distribuidor Update(Distribuidor distribuidor) throws Exception {
        return distribuidorRepository.save(distribuidor);
    }
    @Transactional(readOnly=true)
    @Override
    public List<Distribuidor> FindAll() throws Exception {
        return distribuidorRepository.findAll();
    }
    @Transactional(readOnly=true)
    @Override
    public Optional<Distribuidor> findById(Integer integer) throws Exception {
        return distribuidorRepository.findById(integer);
    }

    @Override
    public void deleteById(Integer integer) throws Exception {
        distribuidorRepository.deleteById(integer);
    }
}
