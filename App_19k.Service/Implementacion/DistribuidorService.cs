using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository;
using App_19k.Repository.Implementacion;
namespace App_19k.Service.Implementacion
{
    public class DistribuidorService : IDistribuidorService
    {

        private IDistribuidorRepository DistribuidorRepository;

        public DistribuidorService(IDistribuidorRepository DistribuidorRepository)
        {
            this.DistribuidorRepository = DistribuidorRepository;
        }    

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Distribuidor Get(int id)
        {
            return DistribuidorRepository.Get(id);
        }

     

        public IEnumerable<Distribuidor> GetAll()
        {
            return DistribuidorRepository.GetAll();
        }

        public bool Save(Distribuidor entity)
        {
            return DistribuidorRepository.Save(entity);
        }    

        public bool Update(Distribuidor entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
