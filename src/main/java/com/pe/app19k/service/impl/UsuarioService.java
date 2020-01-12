package com.pe.app19k.service.impl;

import com.pe.app19k.entity.Usuario;
import com.pe.app19k.repository.IUsuarioRepository;
import com.pe.app19k.service.IUsuarioService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;
import java.util.Optional;

@Service
public class UsuarioService implements IUsuarioService {
    @Autowired
    private IUsuarioRepository usuarioRepository;
    @Override
    public Usuario Insert(Usuario usuario) throws Exception {
        return usuarioRepository.save(usuario);
    }

    @Override
    public Usuario Update(Usuario usuario) throws Exception {
        return usuarioRepository.save(usuario);
    }
    @Transactional(readOnly=true)
    @Override
    public List<Usuario> FindAll() throws Exception {
        return usuarioRepository.findAll();
    }
    @Transactional(readOnly=true)
    @Override
    public Optional<Usuario> findById(Integer integer) throws Exception {
        return usuarioRepository.findById(integer);
    }

    @Override
    public void deleteById(Integer integer) throws Exception {
        usuarioRepository.deleteById(integer);
    }
    @Override
    public Optional<Usuario> buscarUsuarioRegistrado(String usuario,String contraseña) throws Exception{
        return usuarioRepository.buscarUsuarioRegistrado(usuario,contraseña);
    }
}
