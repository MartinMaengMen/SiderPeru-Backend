using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository;
using App_19k.Repository.Implementacion;
namespace App_19k.Service.Implementacion
{
    public class DistritoService : IDistritoService
    {

        private IDistritoRepository DistritoRepository;

        public DistritoService(IDistritoRepository DistritoRepository)
        {
            this.DistritoRepository = DistritoRepository;
        }    

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Distrito Get(int id)
        {
            return DistritoRepository.Get(id);
        }

     

        public IEnumerable<Distrito> GetAll()
        {
            return DistritoRepository.GetAll();
        }

        public int? idXnombre(string nDepartamento, string nProvincia, string nDistrito)
        {
            
            return DistritoRepository.idXnombre(nDepartamento, nProvincia, nDistrito);
        }

        public bool Save(Distrito entity)
        {
            return DistritoRepository.Save(entity);
        }    

        public bool Update(Distrito entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
