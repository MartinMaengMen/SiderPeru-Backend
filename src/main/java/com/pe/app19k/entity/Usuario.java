package com.pe.app19k.entity;

import javax.persistence.*;
import javax.validation.constraints.NotEmpty;
import javax.validation.constraints.NotNull;

@Entity
@Table(name="Usuarios")
public class Usuario {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;
    @Column(name="nombre", nullable = false)
    @NotEmpty(message = "Ingrse un nombre")
    private String nombre;
    @Column(name="usuario", nullable = false, unique = true)
    @NotEmpty(message = "Ingese un usuario")
    private String usuario;
    @Column(name="contraseña", nullable = false)
    @NotEmpty(message = "Ingrese una contraseña")
    private String contraseña;
    @Column(name="dni", nullable = false, length = 8, unique = true)
    @NotEmpty(message = "Ingrese un DNI")
    private String dni;
    @Column(name="estado", nullable = false)
    @NotEmpty(message = "Ingrese un estado")
    private String estado;
    @Column(name="rol", nullable = false)
    @NotEmpty(message = "Ingrese un rol")
    private String rol;
    @Column(name="imagen")
    private byte[] imagen;
    @ManyToOne(fetch = FetchType.EAGER)
    @JoinColumn(name="id_distribuidor")
    @NotNull(message = "Ingrese un distribuidor")
    private Distribuidor distribuidor;

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

    public Distribuidor getDistribuidor() {
        return distribuidor;
    }

    public void setDistribuidor(Distribuidor distribuidor) {
        this.distribuidor = distribuidor;
    }

	public byte[] getImagen() {
		return imagen;
	}

	public void setImagen(byte[] imagen) {
		this.imagen = imagen;
	}
}
