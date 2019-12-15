using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository;
using App_19k.Repository.Implementacion;
using App_19k.Repository.ViewModel;

namespace App_19k.Service.Implementacion
{
    public class DetalleSuministroService : IDetalleSuministroService
    {

        private IDetalleSuministroRepository DetalleSuministroRepository;

        public DetalleSuministroService(IDetalleSuministroRepository DetalleSuministroRepository)
        {
            this.DetalleSuministroRepository = DetalleSuministroRepository;
        }    

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DetalleSuministro Get(int id)
        {
            return DetalleSuministroRepository.Get(id);
        }

     

        public IEnumerable<DetalleSuministro> GetAll()
        {
            return DetalleSuministroRepository.GetAll();
        }

        public DetalleSuministroViewModel DetalleXProyecto( int idProyecto)
        {
            return DetalleSuministroRepository.DetalleXProyecto(idProyecto);
        }

        public bool Save(DetalleSuministro entity)
        {
            return DetalleSuministroRepository.Save(entity);
        }    

        public bool Update(DetalleSuministro entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
