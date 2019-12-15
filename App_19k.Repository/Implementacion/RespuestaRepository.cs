using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.Context;
using App_19k.Repository.ViewModel;

namespace App_19k.Repository.Implementacion
{
    public class RespuestaRepository : IRespuestaRepository
    {
        private ApplicationDbContext context;

        public RespuestaRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Actualizar(RespuestaViewModel respuesta)
        {
            Respuesta rpta = new Respuesta {
                RespuestaId = respuesta.RespuestaId,
                MPrecioAutorizadoBase = respuesta.MPrecioAutorizadoBase,
                Flete = respuesta.Flete,
                DiasValidez = respuesta.DiasValidez,
                FechaInicioOferta = respuesta.FechaInicioOferta,
                FechaInicioVigenciaPrecio = respuesta.FechaInicioVigenciaPrecio,
                FechaFinalVigenciaPrecio = respuesta.FechaFinalVigenciaPrecio,
                ProyectoId = respuesta.ProyectoId,
                FechaReg = respuesta.FechaReg,
                Proyecto = context.Proyectos.FirstOrDefault(x=>x.ProyectoId == respuesta.ProyectoId),
                observaciones = respuesta.observaciones,
            };
            try{
                context.Respuestas.Update(rpta);
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
            throw new NotImplementedException();
        }

        public bool Enviar(RespuestaViewModel respuesta)
        {
            Respuesta rpta = new Respuesta {
                MPrecioAutorizadoBase = respuesta.MPrecioAutorizadoBase,
                Flete = respuesta.Flete,
                DiasValidez = respuesta.DiasValidez,
                FechaInicioOferta = respuesta.FechaInicioOferta,
                FechaInicioVigenciaPrecio = respuesta.FechaInicioVigenciaPrecio,
                FechaFinalVigenciaPrecio = respuesta.FechaFinalVigenciaPrecio,
                ProyectoId = respuesta.ProyectoId,
                FechaReg = respuesta.FechaReg,
                fehab = respuesta.fehab,
                preciofehab = respuesta.preciofehab,
                Proyecto = context.Proyectos.FirstOrDefault(x=>x.ProyectoId == respuesta.ProyectoId),
                observaciones = respuesta.observaciones,
            };
            
            decimal variacionPrecioFeHab = 0;
            int variacionDiasValidez = 0;

            if(context.Respuestas.LastOrDefault(x=>x.ProyectoId == respuesta.ProyectoId) != null)
            {
                if(rpta.MPrecioAutorizadoBase == 0)
                {
                    rpta.MPrecioAutorizadoBase = context.Respuestas.LastOrDefault(x=>x.ProyectoId == respuesta.ProyectoId).MPrecioAutorizadoBase;
                }
                else
                {
                    variacionPrecioFeHab += (rpta.MPrecioAutorizadoBase - context.Respuestas.LastOrDefault(x=>x.ProyectoId == respuesta.ProyectoId).MPrecioAutorizadoBase);

                }

                if(rpta.Flete == 0) 
                {
                    rpta.Flete = context.Respuestas.LastOrDefault(x=>x.ProyectoId == respuesta.ProyectoId).Flete;
                }
                else
                {
                    variacionPrecioFeHab += (rpta.Flete - context.Respuestas.LastOrDefault(x=>x.ProyectoId == respuesta.ProyectoId).Flete);
                }
                
                if(rpta.fehab == 0) 
                {
                    rpta.fehab = context.Respuestas.LastOrDefault(x=>x.ProyectoId == respuesta.ProyectoId).fehab;
                }
                else
                {
                    variacionPrecioFeHab += (rpta.fehab - context.Respuestas.LastOrDefault(x=>x.ProyectoId == respuesta.ProyectoId).fehab);
                }

                rpta.preciofehab = context.Respuestas.LastOrDefault(x=>x.ProyectoId == respuesta.ProyectoId).preciofehab + variacionPrecioFeHab;

                if(rpta.DiasValidez == 0)
                {
                    rpta.DiasValidez = context.Respuestas.LastOrDefault(x=>x.ProyectoId == respuesta.ProyectoId).DiasValidez;
                }
                else
                {
                    variacionDiasValidez += (rpta.DiasValidez - context.Respuestas.LastOrDefault(x=>x.ProyectoId == respuesta.ProyectoId).DiasValidez);
                }

                if(rpta.FechaInicioOferta.ToString() == "1/1/1999 00:00:00") 
                {
                    rpta.FechaInicioOferta = context.Respuestas.LastOrDefault(x=>x.ProyectoId == respuesta.ProyectoId).FechaInicioOferta;
                }

                if(rpta.FechaInicioVigenciaPrecio.ToString() == "1/1/1999 00:00:00") rpta.FechaInicioVigenciaPrecio = context.Respuestas.LastOrDefault(x=>x.ProyectoId == respuesta.ProyectoId).FechaInicioVigenciaPrecio;
                if(rpta.FechaFinalVigenciaPrecio.ToString() == "1/1/1999 00:00:00") rpta.FechaFinalVigenciaPrecio = context.Respuestas.LastOrDefault(x=>x.ProyectoId == respuesta.ProyectoId).FechaFinalVigenciaPrecio;
            }
            
            

            Proyecto proyecto = rpta.Proyecto;
            proyecto.TEstatusSolicitud = "EN NEGOCIACION";

            try{
                context.Respuestas.Add(rpta);
                context.SaveChanges();
                context.Proyectos.Update(proyecto);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
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
            var lstaRpta = context.Respuestas.LastOrDefault(x=>x.ProyectoId == idProyecto);

            return lstaRpta;
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