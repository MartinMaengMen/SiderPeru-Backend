package com.pe.app19k.service;

import com.pe.app19k.entity.Usuario;

import java.util.Optional;

public interface IUsuarioService extends CrudService<Usuario,Integer> {
    Optional<Usuario> buscarUsuarioRegistrado(String usuario, String contraseña) throws Exception;
}
