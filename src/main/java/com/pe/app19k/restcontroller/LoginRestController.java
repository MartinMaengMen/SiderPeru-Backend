package com.pe.app19k.restcontroller;
import com.pe.app19k.entity.Login;
import com.pe.app19k.entity.Usuario;
import com.pe.app19k.service.IUsuarioService;

import io.swagger.annotations.ApiOperation;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import javax.servlet.http.HttpSession;
import javax.validation.Valid;
import java.util.Optional;

@RestController
@RequestMapping("/login")
public class LoginRestController {
    @Autowired
    private IUsuarioService usuarioService;
    
    @ApiOperation("Users login function")
    @PostMapping( consumes = MediaType.APPLICATION_JSON_VALUE, produces = MediaType.APPLICATION_JSON_VALUE )
    public ResponseEntity<String> login(@Valid @RequestBody Login login, HttpSession session) {
        try {
            Optional<Usuario> tmp = usuarioService.buscarUsuarioRegistrado(login.getUsuario(),login.getContraseña());
            if( tmp != null ) {
                ResponseEntity<Usuario> response= new ResponseEntity<>(HttpStatus.OK);
                //Aqui se crea la variable de sesion
                session.setAttribute("usuario",login.getUsuario());
                return response.ok(login.getUsuario());
            } else {
                return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
            }
        } catch (Exception e) {
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }

}
