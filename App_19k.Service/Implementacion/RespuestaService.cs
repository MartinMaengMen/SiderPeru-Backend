using System;
using System.Collections.Generic;
using System.Text;
using App_19k.Domain;
using App_19k.Repository;
using App_19k.Repository.Implementacion;
using App_19k.Repository.ViewModel;

namespace App_19k.Service.Implementacion
{
    public class RespuestaService : IRespuestaService
    {
        private IRespuestaRepository RespuestaRepository;

        public RespuestaService(IRespuestaRepository RespuestaRepository)
        {
            this.RespuestaRepository = RespuestaRepository;
        }

        public bool Actualizar(RespuestaViewModel respuesta)
        {
            return RespuestaRepository.Actualizar(respuesta);
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Enviar(RespuestaViewModel respuesta)
        {
            return RespuestaRepository.Enviar(respuesta);
        }

        public Respuesta Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Respuesta> GetAll()
        {
            throw new NotImplementedException();
        }

        public Respuesta ObtenerRpta(int idProyecto)
        {
            return RespuestaRepository.ObtenerRpta(idProyecto);
        }

        public bool Save(Respuesta entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Respuesta entity)
        {
            throw new NotImplementedException();
        }
    }
}