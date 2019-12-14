using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository;
using App_19k.Repository.Implementacion;
namespace App_19k.Service.Implementacion
{
    public class MarcaProveedorService : IMarcaProveedorService
    {

        private IMarcaProveedorRepository MarcaProveedorRepository;

        public MarcaProveedorService(IMarcaProveedorRepository MarcaProveedorRepository)
        {
            this.MarcaProveedorRepository = MarcaProveedorRepository;
        }    

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public MarcaProveedor Get(int id)
        {
            return MarcaProveedorRepository.Get(id);
        }

     

        public IEnumerable<MarcaProveedor> GetAll()
        {
            return MarcaProveedorRepository.GetAll();
        }

        public bool Save(MarcaProveedor entity)
        {
            return MarcaProveedorRepository.Save(entity);
        }    

        public bool Update(MarcaProveedor entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
