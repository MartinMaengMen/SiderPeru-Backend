using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository;
using App_19k.Repository.Implementacion;
namespace App_19k.Service.Implementacion
{
    public class SuministroService : ISuministroService
    {

        private ISuministroRepository SuministroRepository;

        public SuministroService(ISuministroRepository SuministroRepository)
        {
            this.SuministroRepository = SuministroRepository;
        }    

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Suministro Get(int id)
        {
            return SuministroRepository.Get(id);
        }

     

        public IEnumerable<Suministro> GetAll()
        {
            return SuministroRepository.GetAll();
        }

        public bool Save(Suministro entity)
        {
            return SuministroRepository.Save(entity);
        }    

        public bool Update(Suministro entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
