using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository;
using App_19k.Repository.Implementacion;
namespace App_19k.Service.Implementacion
{
    public class NumerosContactoService : INumerosContactoService
    {

        private INumerosContactoRepository NumerosContactoRepository;

        public NumerosContactoService(INumerosContactoRepository NumerosContactoRepository)
        {
            this.NumerosContactoRepository = NumerosContactoRepository;
        }    

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public NumerosContacto Get(int id)
        {
            return NumerosContactoRepository.Get(id);
        }

     

        public IEnumerable<NumerosContacto> GetAll()
        {
            return NumerosContactoRepository.GetAll();
        }

        public IEnumerable<NumerosContacto> LstaContactosXProy(int ProyectoId)
        {
            return NumerosContactoRepository.LstaContactosXProy(ProyectoId);
        }

        public bool Save(NumerosContacto entity)
        {
            return NumerosContactoRepository.Save(entity);
        }    

        public bool Update(NumerosContacto entity)
        {
            return NumerosContactoRepository.Update(entity);
        }

       
    }
}
