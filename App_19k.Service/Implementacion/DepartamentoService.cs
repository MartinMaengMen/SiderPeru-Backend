using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository;
using App_19k.Repository.Implementacion;
namespace App_19k.Service.Implementacion
{
    public class DepartamentoService : IDepartamentoService
    {

        private IDepartamentoRepository DepartamentoRepository;

        public DepartamentoService(IDepartamentoRepository DepartamentoRepository)
        {
            this.DepartamentoRepository = DepartamentoRepository;
        }    

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Departamento Get(int id)
        {
            return DepartamentoRepository.Get(id);
        }

     

        public IEnumerable<Departamento> GetAll()
        {
            return DepartamentoRepository.GetAll();
        }

        public int idXNombre(string nombre)
        {
            return DepartamentoRepository.idXNombre(nombre);
        }

        public bool Save(Departamento entity)
        {
            return DepartamentoRepository.Save(entity);
        }    

        public bool Update(Departamento entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
