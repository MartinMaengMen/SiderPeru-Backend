package com.pe.app19k.repository;

import com.pe.app19k.entity.NumeroContacto;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

@Repository
public interface INumeroContactoRepository extends JpaRepository<NumeroContacto,Integer> {
	@Query("SELECT nc FROM NumeroContacto nc WHERE nc.proyecto.id = ?1")
	List<NumeroContacto> fetchByProjectId(Integer id);
}
