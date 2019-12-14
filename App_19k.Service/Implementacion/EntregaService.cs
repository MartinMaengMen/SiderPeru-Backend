using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository;
using App_19k.Repository.Implementacion;
namespace App_19k.Service.Implementacion
{
    public class EntregaService : IEntregaService
    {

        private IEntregaRepository EntregaRepository;

        public EntregaService(IEntregaRepository EntregaRepository)
        {
            this.EntregaRepository = EntregaRepository;
        }    

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Entrega Get(int id)
        {
            return EntregaRepository.Get(id);
        }

     

        public IEnumerable<Entrega> GetAll()
        {
            return EntregaRepository.GetAll();
        }

        public bool Save(Entrega entity)
        {
            return EntregaRepository.Save(entity);
        }    

        public bool Update(Entrega entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
