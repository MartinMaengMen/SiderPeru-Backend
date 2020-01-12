package com.pe.app19k.entity.DTO;

import com.pe.app19k.entity.Distribuidor;
import com.pe.app19k.entity.Usuario;

public class UsuarioDTO {
    private Integer id;
    private String nombre;

    private String usuario;

    private String contraseña;

    private String dni;

    private String estado;

    private String rol;

    private Integer distribuidorId;

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getUsuario() {
        return usuario;
    }

    public void setUsuario(String usuario) {
        this.usuario = usuario;
    }

    public String getContraseña() {
        return contraseña;
    }

    public void setContraseña(String contraseña) {
        this.contraseña = contraseña;
    }

    public String getDni() {
        return dni;
    }

    public void setDni(String dni) {
        this.dni = dni;
    }

    public String getEstado() {
        return estado;
    }

    public void setEstado(String estado) {
        this.estado = estado;
    }

    public String getRol() {
        return rol;
    }

    public void setRol(String rol) {
        this.rol = rol;
    }

    public Integer getDistribuidorId() {
        return distribuidorId;
    }

    public void setDistribuidorId(Integer distribuidorId) {
        this.distribuidorId = distribuidorId;
    }
    public Usuario dtoToEntity(UsuarioDTO dto){
        Usuario usuario=new Usuario();
        usuario.setId(dto.id);
        usuario.setNombre(dto.nombre);
        usuario.setUsuario(dto.usuario);
        usuario.setContraseña(dto.contraseña);
        usuario.setDni(dto.dni);
        usuario.setEstado(dto.estado);
        usuario.setRol(dto.rol);
        Distribuidor distribuidor=new Distribuidor();
        distribuidor.setId(dto.id);
        usuario.setDistribuidor(distribuidor);
        return usuario;
    }
}
