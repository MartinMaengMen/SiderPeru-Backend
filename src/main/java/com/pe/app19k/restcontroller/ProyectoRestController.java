package com.pe.app19k.restcontroller;

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

import com.pe.app19k.entity.Proyecto;
import com.pe.app19k.entity.DTO.ProyectoDTO;
import com.pe.app19k.service.IProyectoService;

import io.swagger.annotations.ApiOperation;

@RestController
@RequestMapping("/proyecto")
public class ProyectoRestController {
	@Autowired
	private IProyectoService proyectoService;

    @ApiOperation("Fetch proyecto por id")
	@GetMapping(value="/{id}", produces=MediaType.APPLICATION_JSON_VALUE)
	public ResponseEntity<Proyecto> fetchById(@PathVariable("id") Integer id){
		try {
			Optional<Proyecto> proyecto = proyectoService.findById(id);
			if(proyecto.isPresent())
				return new ResponseEntity<Proyecto>(proyecto.get(), HttpStatus.OK);
			else
				return new ResponseEntity<Proyecto>(HttpStatus.NOT_FOUND);
		} catch (Exception e) {
			return new ResponseEntity<Proyecto>(HttpStatus.INTERNAL_SERVER_ERROR);
		}
	}
    
    @ApiOperation("Save proyecto")
    @PostMapping( consumes = MediaType.APPLICATION_JSON_VALUE, produces = MediaType.APPLICATION_JSON_VALUE )
    public ResponseEntity<Proyecto> save(@Valid @RequestBody ProyectoDTO proyectoDTO) {
        try {
        	Proyecto proyecto = proyectoDTO.dtoToEntity(proyectoDTO);
        	Proyecto tmp = proyectoService.Update(proyecto);
            if( tmp != null ) {
                ResponseEntity<Proyecto> response= new ResponseEntity<>(HttpStatus.OK);
                return response.ok(tmp);
            } else {
                return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
            }
        } catch (Exception e) {
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }
    
    @ApiOperation("Update proyecto")
    @PutMapping( consumes = MediaType.APPLICATION_JSON_VALUE, produces = MediaType.APPLICATION_JSON_VALUE )
    public ResponseEntity<Object> update( @Valid @RequestBody ProyectoDTO proyectoDTO ) {
        try {
        	Proyecto proyecto = proyectoDTO.dtoToEntity(proyectoDTO);
            Optional<Proyecto> buscado = proyectoService.findById(proyecto.getId());
            if(buscado.isPresent()) {
            	proyectoService.Update(proyecto);
                return new ResponseEntity<>(HttpStatus.OK);
            } else {
                return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
            }
        } catch (Exception e) {
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }
}
