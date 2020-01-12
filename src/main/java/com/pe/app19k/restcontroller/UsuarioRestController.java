package com.pe.app19k.restcontroller;

import com.pe.app19k.entity.Usuario;
import com.pe.app19k.entity.DTO.UsuarioDTO;
import com.pe.app19k.service.IUsuarioService;

import io.swagger.annotations.ApiOperation;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import javax.servlet.http.HttpSession;
import javax.validation.Valid;
import java.util.List;
import java.util.Optional;

@RestController
@RequestMapping("/usuario")
public class UsuarioRestController {
    @Autowired
    private IUsuarioService usuarioService;
    
    @ApiOperation("Fetch all usuarios")
    @GetMapping( produces = MediaType.APPLICATION_JSON_VALUE )
    public ResponseEntity<List<Usuario>> fetchAll() {
        try {
            List<Usuario> Person = usuarioService.FindAll();
            return new ResponseEntity< >(Person, HttpStatus.OK);
        } catch (Exception e) {
            return new ResponseEntity< >(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }
    //Este es el ejemplo para obtener el valor guardado en una variable de sesion
    /*
    @GetMapping(path = "/session", produces = MediaType.APPLICATION_JSON_VALUE )
    public ResponseEntity<String> fetchUser(HttpSession session) {
        try {
            return new ResponseEntity(session.getAttribute("usuario"), HttpStatus.OK);
        } catch (Exception e) {
            return new ResponseEntity< >(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }
     */
    
    @ApiOperation("Save usuario")
    @PostMapping(consumes = MediaType.APPLICATION_JSON_VALUE, produces = MediaType.APPLICATION_JSON_VALUE )
    public ResponseEntity<Usuario> save(@Valid @RequestBody UsuarioDTO usuarioDTO ) {
        try {
        	Usuario usuario = usuarioDTO.dtoToEntity(usuarioDTO);
            Usuario tmp = usuarioService.Update(usuario);
            if( tmp != null ) {
                ResponseEntity<Usuario> response= new ResponseEntity<>(HttpStatus.OK);
                return response.ok(tmp);
            } else {
                return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
            }
        } catch (Exception e) {
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }

    @ApiOperation("Update usuario")
    @PutMapping( consumes = MediaType.APPLICATION_JSON_VALUE, produces = MediaType.APPLICATION_JSON_VALUE )
    public ResponseEntity<Object> update( @Valid @RequestBody UsuarioDTO usuarioDTO ) {
        try {
        	Usuario usuario = usuarioDTO.dtoToEntity(usuarioDTO);
        	Optional<Usuario> buscado = usuarioService.findById(usuario.getId());
            if(buscado.isPresent()) {
                usuarioService.Update(usuario);
                return new ResponseEntity<>(HttpStatus.OK);
            } else {
                return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
            }
        } catch (Exception e) {
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }
}
