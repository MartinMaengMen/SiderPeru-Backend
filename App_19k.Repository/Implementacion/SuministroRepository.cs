using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.Context;

namespace App_19k.Repository.Implementacion
{
    public class SuministroRepository : ISuministroRepository
    {
        private ApplicationDbContext context;

        public SuministroRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Suministro Get(int id)
        {
            var result = new Suministro();
            try
            {
                result = context.Suministros.Single(x => x.SuministroId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Suministro> GetAll()
        {

            var result = new List<Suministro>();
            try
            {
                result = context.Suministros.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Suministro entity)
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

        public bool Update(Suministro entity)
        {
            try
            {
                var SuministroOriginal = context.Suministros.Single(
                    x => x.SuministroId == entity.SuministroId
                );

                SuministroOriginal.SuministroId = entity.SuministroId;
                SuministroOriginal.NSuministro = entity.NSuministro;
                
                context.Update(SuministroOriginal);
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