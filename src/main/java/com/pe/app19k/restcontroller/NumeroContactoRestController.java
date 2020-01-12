package com.pe.app19k.restcontroller;

import java.util.List;
import java.util.Optional;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.pe.app19k.entity.NumeroContacto;
import com.pe.app19k.entity.DTO.NumeroContactoDTO;
import com.pe.app19k.service.INumeroContactoService;

import io.swagger.annotations.ApiOperation;

@RestController
@RequestMapping("/numerocontacto")
public class NumeroContactoRestController {
	@Autowired
	private INumeroContactoService numeroContactoService;

	@ApiOperation("Fetch numeros de contacto by project id")
	@GetMapping(value = "/proyecto/{id_proyecto}", produces = MediaType.APPLICATION_JSON_VALUE)
	public ResponseEntity<List<NumeroContacto>> fetchByProjectId(@PathVariable("id_proyecto") Integer id_proyecto) {
		try {
			List<NumeroContacto> numerosContacto = numeroContactoService.fetchByProjectId(id_proyecto);
			return new ResponseEntity<List<NumeroContacto>>(numerosContacto, HttpStatus.OK);
		} catch (Exception e) {
			return new ResponseEntity<List<NumeroContacto>>(HttpStatus.INTERNAL_SERVER_ERROR);
		}
	}

    @ApiOperation("Save número de contacto")
    @PostMapping( consumes = MediaType.APPLICATION_JSON_VALUE, produces = MediaType.APPLICATION_JSON_VALUE )
    public ResponseEntity<NumeroContacto> save(@Valid @RequestBody NumeroContactoDTO numeroContactoDTO) {
        try {
        	NumeroContacto numeroContacto = numeroContactoDTO.dtoToEntity(numeroContactoDTO);
        	NumeroContacto tmp = numeroContactoService.Update(numeroContacto);
            if( tmp != null ) {
                ResponseEntity<NumeroContacto> response= new ResponseEntity<>(HttpStatus.OK);
                return response.ok(tmp);
            } else {
                return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
            }
        } catch (Exception e) {
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }

    @ApiOperation("Update numero de contacto")
    @PutMapping( consumes = MediaType.APPLICATION_JSON_VALUE, produces = MediaType.APPLICATION_JSON_VALUE )
    public ResponseEntity<Object> update( @Valid @RequestBody NumeroContactoDTO numeroContactoDTO ) {
        try {
        	NumeroContacto numeroContacto = numeroContactoDTO.dtoToEntity(numeroContactoDTO);
            Optional<NumeroContacto> buscado = numeroContactoService.findById(numeroContacto.getId());
            if(buscado.isPresent()) {
            	numeroContactoService.Update(numeroContacto);
                return new ResponseEntity<>(HttpStatus.OK);
            } else {
                return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
            }
        } catch (Exception e) {
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }
}
