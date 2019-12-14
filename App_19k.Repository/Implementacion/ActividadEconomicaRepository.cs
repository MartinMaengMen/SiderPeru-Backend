using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.Context;

namespace App_19k.Repository.Implementacion
{
    public class ActividadEconomicaRepository : IActividadEconomicaRepository
    {
        private ApplicationDbContext context;

        public ActividadEconomicaRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public ActividadEconomica Get(int id)
        {
            var result = new ActividadEconomica();
            try
            {
                result = context.ActividadEconomicas.Single(x => x.ProyectoId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<ActividadEconomica> GetAll()
        {

            var result = new List<ActividadEconomica>();
            try
            {
                result = context.ActividadEconomicas.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(ActividadEconomica entity)
        {
            if (entity.ProyectoId == -1)
            {
                var idProyecto = context.Proyectos.OrderByDescending(e => e.ProyectoId).First().ProyectoId;
                entity.ProyectoId = idProyecto;
            }
            try
            {
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(ActividadEconomica entity)
        {
            try
            {
                var ActividadEconomicaOriginal = context.ActividadEconomicas.Single(
                    x => x.ActividadEconomicaId == entity.ActividadEconomicaId
                );

                ActividadEconomicaOriginal.ActividadEconomicaId = entity.ActividadEconomicaId;
                ActividadEconomicaOriginal.NActividadEconomica = entity.NActividadEconomica;
                ActividadEconomicaOriginal.ProyectoId = entity.ProyectoId;       
                context.Update(ActividadEconomicaOriginal);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ActividadEconomica> LstaActEcoXProyecto(int idProyecto)
        {
            var lstaActEcoXproy = context.ActividadEconomicas.Where(e => e.ProyectoId == idProyecto).ToList();
            return lstaActEcoXproy;
        }
    }
}