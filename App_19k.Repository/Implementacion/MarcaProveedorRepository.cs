using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.Context;

namespace App_19k.Repository.Implementacion
{
    public class MarcaProveedorRepository : IMarcaProveedorRepository
    {
        private ApplicationDbContext context;

        public MarcaProveedorRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public MarcaProveedor Get(int id)
        {
            var result = new MarcaProveedor();
            try
            {
                result = context.MarcaProveedores.Single(x => x.MarcaProveedorId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<MarcaProveedor> GetAll()
        {

            var result = new List<MarcaProveedor>();
            try
            {
                result = context.MarcaProveedores.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(MarcaProveedor entity)
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

        public bool Update(MarcaProveedor entity)
        {
            try
            {
                var MarcaProveedorOriginal = context.MarcaProveedores.Single(
                    x => x.MarcaProveedorId == entity.MarcaProveedorId
                );

                MarcaProveedorOriginal.MarcaProveedorId = entity.MarcaProveedorId;
                MarcaProveedorOriginal.NMarcaProveedor = entity.NMarcaProveedor;
                
                context.Update(MarcaProveedorOriginal);
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