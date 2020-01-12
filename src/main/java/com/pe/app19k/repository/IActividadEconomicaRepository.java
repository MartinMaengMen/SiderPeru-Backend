package com.pe.app19k.repository;

import com.pe.app19k.entity.ActividadEconomica;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

@Repository
public interface IActividadEconomicaRepository extends JpaRepository<ActividadEconomica,Integer> {
	@Query("SELECT ac FROM ActividadEconomica ac WHERE ac.proyecto.id = ?1")
	List<ActividadEconomica> fetchByProjectId(Integer id);
}
