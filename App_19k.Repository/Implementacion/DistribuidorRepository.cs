using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.Context;

namespace App_19k.Repository.Implementacion
{
    public class DistribuidorRepository : IDistribuidorRepository
    {
        private ApplicationDbContext context;

        public DistribuidorRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Distribuidor Get(int id)
        {
            var result = new Distribuidor();
            try
            {
                result = context.Distribuidores.Single(x => x.DistribuidorId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Distribuidor> GetAll()
        {

            var result = new List<Distribuidor>();
            try
            {
                result = context.Distribuidores.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Distribuidor entity)
        {
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

        public bool Update(Distribuidor entity)
        {
            try
            {
                var DistribuidorOriginal = context.Distribuidores.Single(
                    x => x.DistribuidorId == entity.DistribuidorId
                );

                DistribuidorOriginal.DistribuidorId = entity.DistribuidorId;
                DistribuidorOriginal.NDistribuidor = entity.NDistribuidor;
               
                context.Update(DistribuidorOriginal);
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
    }
}