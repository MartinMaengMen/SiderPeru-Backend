package com.pe.app19k.repository;

import com.pe.app19k.entity.Distribuidor;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface IDistribuidorRepository extends JpaRepository<Distribuidor,Integer> {

}
