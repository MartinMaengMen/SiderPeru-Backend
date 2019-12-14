using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.Context;

namespace App_19k.Repository.Implementacion
{
    public class ProvinciaRepository : IProvinciaRepository
    {
        private ApplicationDbContext context;

        public ProvinciaRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Provincia Get(int id)
        {
            var result = new Provincia();
            try
            {
                result = context.Provincias.Single(x => x.ProvinciaId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Provincia> GetAll()
        {

            var result = new List<Provincia>();
            try
            {
                result = context.Provincias.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Provincia entity)
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

        public bool Update(Provincia entity)
        {
            try
            {
                var ProvinciaOriginal = context.Provincias.Single(
                    x => x.ProvinciaId == entity.ProvinciaId
                );

                ProvinciaOriginal.ProvinciaId = entity.ProvinciaId;
                ProvinciaOriginal.NProvincia = entity.NProvincia;
                ProvinciaOriginal.DepartamentoId = entity.DepartamentoId;
                context.Update(ProvinciaOriginal);
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

        public int idXnombre(int idDepartamento, string nombre)
        {
            var result = from p in context.Provincias
                         where p.DepartamentoId == idDepartamento && p.NProvincia == nombre
                         select new { p.ProvinciaId };
            int idProvincia = result.First().ProvinciaId;
            return idProvincia;
        }
    }
}