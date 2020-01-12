package com.pe.app19k.repository;

import com.pe.app19k.entity.Usuario;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

import java.util.Optional;

@Repository
public interface IUsuarioRepository extends JpaRepository<Usuario,Integer> {
    @Query(value="select * from Usuarios where usuario=?1 and contraseña=?2",nativeQuery = true)
    Optional<Usuario> buscarUsuarioRegistrado(String usuario, String contraseña);
}
