package com.pe.app19k.restcontroller;

import com.pe.app19k.entity.Distribuidor;
import com.pe.app19k.service.IDistribuidorService;

import io.swagger.annotations.ApiOperation;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.List;

@RestController
@RequestMapping("/distribuidor")
public class DistribuidorRestController {
    @Autowired
    private IDistribuidorService distribuidorService;
    
    @ApiOperation("Fetch all distribuidores")
    @GetMapping( produces = MediaType.APPLICATION_JSON_VALUE )
    public ResponseEntity<List<Distribuidor>> fetchAll() {
        try {
            List<Distribuidor> Person = distribuidorService.FindAll();
            return new ResponseEntity< >(Person, HttpStatus.OK);
        } catch (Exception e) {
            return new ResponseEntity< >(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }
    
    @ApiOperation("Save distribuidor")
    @PostMapping( consumes = MediaType.APPLICATION_JSON_VALUE, produces = MediaType.APPLICATION_JSON_VALUE )
    public ResponseEntity<Distribuidor> save(@Valid @RequestBody Distribuidor distribuidor ) {
        try {
            Distribuidor tmp = distribuidorService.Update(distribuidor);
            if( tmp != null ) {
                ResponseEntity<Distribuidor> response= new ResponseEntity<>(HttpStatus.OK);
                return response.ok(tmp);
            } else {
                return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
            }
        } catch (Exception e) {
            return new ResponseEntity<>(HttpStatus.INTERNAL_SERVER_ERROR);
        }
    }
}
