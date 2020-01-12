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

import com.pe.app19k.entity.Respuesta;
import com.pe.app19k.entity.DTO.RespuestaDTO;
import com.pe.app19k.service.IRespuestaService;

import io.swagger.annotations.ApiOperation;

@RestController
@RequestMapping("/respuesta")
public class RespuestaRestController {
	@Autowired
	private IRespuestaService respuestaService;
	
	@ApiOperation("Fetch respuestas by project id")
	@GetMapping(value = "/proyecto/{id_proyecto}", produces = MediaType.APPLICATION_JSON_VALUE)
	public ResponseEntity<List<Respuesta>> fetchByProjectId(@PathVariable("id_proyecto") Integer id_proyecto) {
		try {
			List<Respuesta> respuestas = respuestaService.fetchByProjectId(id_proyecto);
			return new ResponseEntity<List<Respuesta>>(respuestas, HttpStatus.OK);
		} catch (Exception e) {
			return new ResponseEntity<List<Respuesta>>(HttpStatus.INTERNAL_SERVER_ERROR);
		}
	}

    @ApiOperation("Save respuesta")
    @PostMapping( consumes = MediaType.APPLICATION_JSON_VALUE, produces = MediaType.APPLICATION_JSON_VALUE )
    public ResponseEntity<Respuesta> save(@Valid @RequestBody RespuestaDTO respuestaDTO) {
        try {
        	Respuesta respuesta = respuestaDTO.dtoToEntity(respuestaDTO);
        	Respuesta tmp = respuestaService.Update(respuesta);
            if( tmp != null ) {
                ResponseEntity<Respuesta> response= new ResponseEntity<>(HttpStatus.OK);
                return response.ok(tmp);
            } else {
                return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
            }
        } catch (Exception e) {
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }
    
    @ApiOperation("Update respuesta")
    @PutMapping( consumes = MediaType.APPLICATION_JSON_VALUE, produces = MediaType.APPLICATION_JSON_VALUE )
    public ResponseEntity<Object> update( @Valid @RequestBody RespuestaDTO respuestaDTO ) {
        try {
        	Respuesta respuesta = respuestaDTO.dtoToEntity(respuestaDTO);
            Optional<Respuesta> buscado = respuestaService.findById(respuesta.getId());
            if(buscado.isPresent()) {
            	respuestaService.Update(respuesta);
                return new ResponseEntity<>(HttpStatus.OK);
            } else {
                return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
            }
        } catch (Exception e) {
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }
}
