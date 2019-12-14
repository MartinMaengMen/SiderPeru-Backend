using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository;
using App_19k.Repository.Implementacion;
namespace App_19k.Service.Implementacion
{
    public class ProvinciaService : IProvinciaService
    {

        private IProvinciaRepository ProvinciaRepository;

        public ProvinciaService(IProvinciaRepository ProvinciaRepository)
        {
            this.ProvinciaRepository = ProvinciaRepository;
        }    

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Provincia Get(int id)
        {
            return ProvinciaRepository.Get(id);
        }

     

        public IEnumerable<Provincia> GetAll()
        {
            return ProvinciaRepository.GetAll();
        }

        public int idXnombre(int idDepartamento, string nombre)
        {
            return ProvinciaRepository.idXnombre(idDepartamento, nombre);
        }

        public bool Save(Provincia entity)
        {
            return ProvinciaRepository.Save(entity);
        }    

        public bool Update(Provincia entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
