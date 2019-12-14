using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.Context;

namespace App_19k.Repository.Implementacion
{
    public class DistritoRepository : IDistritoRepository
    {
        private ApplicationDbContext context;

        public DistritoRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Distrito Get(int id)
        {
            var result = new Distrito();
            try
            {
                result = context.Distritos.Single(x => x.DistritoId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Distrito> GetAll()
        {

            var result = new List<Distrito>();
            try
            {
                result = context.Distritos.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Distrito entity)
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

        public bool Update(Distrito entity)
        {
            try
            {
                var DistritoOriginal = context.Distritos.Single(
                    x => x.DistritoId == entity.DistritoId
                );

                DistritoOriginal.DistritoId = entity.DistritoId;
                DistritoOriginal.NDistrito = entity.NDistrito;
                DistritoOriginal.ProvinciaId = entity.ProvinciaId;
                context.Update(DistritoOriginal);
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

        public int? idXnombre(string nDepartamento, string nProvincia, string nDistrito)
        {
            int idDepartamento;
            int idProvincia;
            int idDistrito;
                var result_1 = (from d in context.Departamentos
                               where d.NDepartamento == nDepartamento
                               select new { d.DepartamentoId }).ToList();
           
            if (result_1.Count!=0)
            {
                idDepartamento = result_1.FirstOrDefault().DepartamentoId;
            }
            else
            {
                Departamento objDep = new Departamento();
                objDep.NDepartamento = nDepartamento;               
                context.Add(objDep);
                context.SaveChanges();
                idDepartamento = context.Departamentos.OrderByDescending(e => e.DepartamentoId).FirstOrDefault().DepartamentoId;
            }
            
            

                var result_2 = (from p in context.Provincias
                               where p.DepartamentoId == idDepartamento && p.NProvincia == nProvincia
                               select new { p.ProvinciaId }).ToList();
                

            if (result_2.Count!=0)
            {
                idProvincia = result_2.First().ProvinciaId;
            }
            else
            {
                Provincia objPro = new Provincia();
                objPro.NProvincia = nProvincia;
                objPro.DepartamentoId = idDepartamento;
                context.Add(objPro);
                context.SaveChanges();
                idProvincia = context.Provincias.OrderByDescending(e => e.ProvinciaId).FirstOrDefault().ProvinciaId;
            }

            var result_3 = (from d in context.Distritos
                               where d.ProvinciaId == idProvincia && d.NDistrito == nDistrito
                               select new { d.DistritoId }).ToList(); 

            if (result_3.Count != 0)
            {
                idDistrito = result_3.First().DistritoId;
            }
            else
            {
                Distrito objDist = new Distrito();
                objDist.NDistrito = nDistrito;
                objDist.ProvinciaId = idProvincia;
                context.Add(objDist);
                context.SaveChanges();
                idDistrito = context.Distritos.OrderByDescending(e => e.DistritoId).FirstOrDefault().DistritoId;
            }

            return idDistrito;
           
        }
    }
}