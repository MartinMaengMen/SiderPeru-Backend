using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.Context;

namespace App_19k.Repository.Implementacion
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        private ApplicationDbContext context;

        public DepartamentoRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Departamento Get(int id)
        {
            var result = new Departamento();
            try
            {
                result = context.Departamentos.Single(x => x.DepartamentoId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Departamento> GetAll()
        {

            var result = new List<Departamento>();
            try
            {
                result = context.Departamentos.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Departamento entity)
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

        public bool Update(Departamento entity)
        {
            try
            {
                var DepartamentoOriginal = context.Departamentos.Single(
                    x => x.DepartamentoId == entity.DepartamentoId
                );

                DepartamentoOriginal.DepartamentoId = entity.DepartamentoId;
                DepartamentoOriginal.NDepartamento = entity.NDepartamento;
                
                context.Update(DepartamentoOriginal);
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

        public int idXNombre(string nombre)
        {
            var result = from d in context.Departamentos
                         where d.NDepartamento == nombre
                         select new { d.DepartamentoId };
            int idDepartamento = result.First().DepartamentoId;
            return idDepartamento;
        }
    }
}