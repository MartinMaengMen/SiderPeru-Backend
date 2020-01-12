package com.pe.app19k.service;

import java.util.List;
import java.util.Optional;

public interface CrudService<T,ID> {
    T Insert(T t)throws Exception;
    T Update(T t)throws Exception;
    List<T> FindAll() throws Exception;
    Optional<T> findById(ID id) throws Exception;
    void deleteById(ID id)throws Exception;
}
