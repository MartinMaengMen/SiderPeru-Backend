using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.Context;

namespace App_19k.Repository.Implementacion
{
    public class EntregaRepository : IEntregaRepository
    {
        private ApplicationDbContext context;

        public EntregaRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Entrega Get(int id)
        {
            var result = new Entrega();
            try
            {
                result = context.Entregas.Single(x => x.EntregaId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Entrega> GetAll()
        {

            var result = new List<Entrega>();
            try
            {
                result = context.Entregas.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Entrega entity)
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

        public bool Update(Entrega entity)
        {
            try
            {
                var EntregaOriginal = context.Entregas.Single(
                    x => x.EntregaId == entity.EntregaId
                );

                EntregaOriginal.EntregaId = entity.EntregaId;
                EntregaOriginal.Cantidad= entity.Cantidad;
                EntregaOriginal.DetalleSuministroId= entity.DetalleSuministroId;
                EntregaOriginal.DFechaEntrega= entity.DFechaEntrega;
                context.Update(EntregaOriginal);
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