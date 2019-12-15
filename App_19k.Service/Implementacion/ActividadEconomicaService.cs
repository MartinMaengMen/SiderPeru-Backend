using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository;
using App_19k.Repository.Implementacion;
namespace App_19k.Service.Implementacion
{
    public class ActividadEconomicaService : IActividadEconomicaService
    {

        private IActividadEconomicaRepository ActividadEconomicaRepository;

        public ActividadEconomicaService(IActividadEconomicaRepository ActividadEconomicaRepository)
        {
            this.ActividadEconomicaRepository = ActividadEconomicaRepository;
        }    

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ActividadEconomica Get(int id)
        {
            return ActividadEconomicaRepository.Get(id);
        }

     

        public IEnumerable<ActividadEconomica> GetAll()
        {
            return ActividadEconomicaRepository.GetAll();
        }

        public IEnumerable<ActividadEconomica> LstaActEcoXProyecto(int idProyecto)
        {
            return ActividadEconomicaRepository.LstaActEcoXProyecto(idProyecto);
        }

        public bool Save(ActividadEconomica entity)
        {
            return ActividadEconomicaRepository.Save(entity);
        }    

        public bool Update(ActividadEconomica entity)
        {
            return ActividadEconomicaRepository.Update(entity);
        }

       
    }
}
