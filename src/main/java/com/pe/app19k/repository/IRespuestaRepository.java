package com.pe.app19k.repository;

import com.pe.app19k.entity.Respuesta;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

@Repository
public interface IRespuestaRepository extends JpaRepository<Respuesta,Integer> {
	//METODO QUE DEVUELVE UNA LISTA DE PROYECTOS FILTRADOS POR EL ID DE UN PROYECTO
	@Query("SELECT r FROM Respuesta WHERE r.proyecto.id = ?1")
	List<Respuesta> fetchByProjectId(Integer id);
}
