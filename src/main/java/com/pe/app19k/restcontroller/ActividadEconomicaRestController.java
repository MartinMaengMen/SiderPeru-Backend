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

import com.pe.app19k.entity.ActividadEconomica;
import com.pe.app19k.entity.DTO.ActividadEconomicaDTO;
import com.pe.app19k.service.IActividadEconomicaService;

import io.swagger.annotations.ApiOperation;

@RestController
@RequestMapping("/actividadeconomica")
public class ActividadEconomicaRestController {
	@Autowired
	private IActividadEconomicaService actividadEconomicaService;

	@ApiOperation("Fetch actividades economicas by project id")
	@GetMapping(value = "/proyecto/{id_proyecto}", produces = MediaType.APPLICATION_JSON_VALUE)
	public ResponseEntity<List<ActividadEconomica>> fetchByProjectId(@PathVariable("id_proyecto") Integer id_proyecto) {
		try {
			List<ActividadEconomica> actividadesEconomicas = actividadEconomicaService.fetchByProjectId(id_proyecto);
			return new ResponseEntity<List<ActividadEconomica>>(actividadesEconomicas, HttpStatus.OK);
		} catch (Exception e) {
			return new ResponseEntity<List<ActividadEconomica>>(HttpStatus.INTERNAL_SERVER_ERROR);
		}
	}

    @ApiOperation("Save actividad económica")
    @PostMapping( consumes = MediaType.APPLICATION_JSON_VALUE, produces = MediaType.APPLICATION_JSON_VALUE )
    public ResponseEntity<ActividadEconomica> save(@Valid @RequestBody ActividadEconomicaDTO actividadEconomicaDTO) {
        try {
        	ActividadEconomica actividadEconomica = actividadEconomicaDTO.dtoToEntity(actividadEconomicaDTO);
        	ActividadEconomica tmp = actividadEconomicaService.Update(actividadEconomica);
            if( tmp != null ) {
                ResponseEntity<ActividadEconomica> response= new ResponseEntity<>(HttpStatus.OK);
                return response.ok(tmp);
            } else {
                return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
            }
        } catch (Exception e) {
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }

    @ApiOperation("Update actividad economica")
    @PutMapping( consumes = MediaType.APPLICATION_JSON_VALUE, produces = MediaType.APPLICATION_JSON_VALUE )
    public ResponseEntity<Object> update( @Valid @RequestBody ActividadEconomicaDTO actividadEconomicaDTO ) {
        try {
        	ActividadEconomica actividadEconomica = actividadEconomicaDTO.dtoToEntity(actividadEconomicaDTO);
            Optional<ActividadEconomica> buscado = actividadEconomicaService.findById(actividadEconomica.getId());
            if(buscado.isPresent()) {
            	actividadEconomicaService.Update(actividadEconomica);
                return new ResponseEntity<>(HttpStatus.OK);
            } else {
                return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
            }
        } catch (Exception e) {
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }
}
