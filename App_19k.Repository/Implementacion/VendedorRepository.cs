using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.Context;
using App_19k.Repository.ViewModel;

namespace App_19k.Repository.Implementacion
{
    public class VendedorRepository : IVendedorRepository
    {
        private ApplicationDbContext context;

        public VendedorRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Vendedor Get(int id)
        {
            var result = new Vendedor();
            try
            {
                result = context.Vendedores.Single(x => x.VendedorId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Vendedor> GetAll()
        {
            var result = new List<Vendedor>();
            try
            {
                result = context.Vendedores.ToList();
            }
            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<VendedorViewModel> FetchAll()
        {
            var result = new List<VendedorViewModel>();
            var vendedores = from v in context.Vendedores
                                join u in context.Usuarios
                                on v.VendedorId equals u.UsuarioId                                
                                select new {v.VendedorId,v.TDni,v.TEstado};
            try
            {
                foreach(var vendedor in vendedores)
                {
                    var ven = new VendedorViewModel();
                    ven.TDni = vendedor.TDni;
                    ven.VendedorId = vendedor.VendedorId;
                    ven.TEstado = vendedor.TEstado;
                    result.Add(ven);
                }
            }
            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Vendedor entity)
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

        public bool Update(Vendedor entity)
        {
            try
            {
                var VendedorOriginal = context.Vendedores.Single(
                    x => x.VendedorId == entity.VendedorId
                );

                VendedorOriginal.VendedorId = entity.VendedorId;
                VendedorOriginal.VendedorNavigation.NUsuario = entity.VendedorNavigation.NUsuario;
                VendedorOriginal.TDni = entity.TDni;
                VendedorOriginal.TEstado = entity.TEstado;          

                context.Update(VendedorOriginal);
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