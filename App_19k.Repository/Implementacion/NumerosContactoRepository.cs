using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.Context;

namespace App_19k.Repository.Implementacion
{
    public class NumerosContactoRepository : INumerosContactoRepository
    {
        private ApplicationDbContext context;

        public NumerosContactoRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public NumerosContacto Get(int id)
        {
            var result = new NumerosContacto();
            try
            {
                result = context.NumerosContactos.Single(x => x.NumerosContactoId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<NumerosContacto> GetAll()
        {

            var result = new List<NumerosContacto>();
            try
            {
                result = context.NumerosContactos.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(NumerosContacto entity)
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

        public bool Update(NumerosContacto entity)
        {
            try
            {
                var NumerosContactoOriginal = context.NumerosContactos.Single(
                    x => x.NumerosContactoId == entity.NumerosContactoId
                );

                NumerosContactoOriginal.NumerosContactoId = entity.NumerosContactoId;
                NumerosContactoOriginal.NumComu = entity.NumComu;
                NumerosContactoOriginal.ProyectoId= entity.ProyectoId;
                NumerosContactoOriginal.Tipo_Contacto= entity.Tipo_Contacto;
                NumerosContactoOriginal.NombreContacto = entity.NombreContacto;
                context.Update(NumerosContactoOriginal);
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

        public IEnumerable<NumerosContacto> LstaContactosXProy(int ProyectoId)
        {
            var lstaContactos = from nc in context.NumerosContactos
                                where nc.ProyectoId == ProyectoId
                                select nc;
            var listaRespuesta = lstaContactos.ToList(); //new List<NumerosContacto>();
            foreach (var valor in lstaContactos)
            {
                var obj = new NumerosContacto();
                obj.NumComu = valor.NumComu;
                obj.NumerosContactoId = valor.NumerosContactoId;
                obj.ProyectoId = valor.ProyectoId;
                obj.Tipo_Contacto = valor.Tipo_Contacto;
            }
            return listaRespuesta;
        }
    }
}