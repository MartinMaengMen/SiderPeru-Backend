using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.Context;
using App_19k.Repository.ViewModel;

namespace App_19k.Repository.Implementacion
{
    public class DetalleSuministroRepository : IDetalleSuministroRepository
    {
        private ApplicationDbContext context;

        public DetalleSuministroRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public DetalleSuministro Get(int id)
        {
            var result = new DetalleSuministro();
            try
            {
                result = context.DetalleSuministros.Single(x => x.DetalleSuministroId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<DetalleSuministro> GetAll()
        {

            var result = new List<DetalleSuministro>();
            try
            {
                result = context.DetalleSuministros.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(DetalleSuministro entity)
        {
            var idProyecto = context.Proyectos.OrderByDescending(e => e.ProyectoId).First().ProyectoId;
            entity.ProyectoId = idProyecto;
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

        public bool Update(DetalleSuministro entity)
        {
            try
            {
                var DetalleSuministroOriginal = context.DetalleSuministros.Single(
                    x => x.DetalleSuministroId == entity.DetalleSuministroId
                );

                DetalleSuministroOriginal.DetalleSuministroId = entity.DetalleSuministroId;
                DetalleSuministroOriginal.NumCantidad = entity.NumCantidad;
                DetalleSuministroOriginal.ProyectoId= entity.ProyectoId;
                DetalleSuministroOriginal.SuministroId= entity.SuministroId;
                DetalleSuministroOriginal.TTipoCantidad= entity.TTipoCantidad;
                
                context.Update(DetalleSuministroOriginal);
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

        public DetalleSuministroViewModel DetalleXProyecto(int _idProyecto)
        {
            var rpt = new DetalleSuministroViewModel();
            var lstaDetalle = context.DetalleSuministros.Where(e => e.ProyectoId == _idProyecto).ToList();
            if (lstaDetalle.Count() > 0)
            {
                foreach (var elemento in lstaDetalle)
                {
                    elemento.Suministro = context.Suministros.Single(e => e.SuministroId == elemento.SuministroId);
                }


                rpt.t6 = lstaDetalle.Single(e => e.Suministro.NSuministro == "6mm" && e.TTipoCantidad == "Toneladas").NumCantidad;
                rpt.u6 = lstaDetalle.Single(e => e.Suministro.NSuministro == "6mm" && e.TTipoCantidad == "Unidades").NumCantidad;

                rpt.t8 = lstaDetalle.Single(e => e.Suministro.NSuministro == "8mm" && e.TTipoCantidad == "Toneladas").NumCantidad;
                rpt.u8 = lstaDetalle.Single(e => e.Suministro.NSuministro == "8mm" && e.TTipoCantidad == "Unidades").NumCantidad;

                rpt.t3_4 = lstaDetalle.Single(e => e.Suministro.NSuministro == "3/4mm" && e.TTipoCantidad == "Toneladas").NumCantidad;
                rpt.u3_4 = lstaDetalle.Single(e => e.Suministro.NSuministro == "3/4mm" && e.TTipoCantidad == "Unidades").NumCantidad;

                rpt.t1_2 = lstaDetalle.Single(e => e.Suministro.NSuministro == "1/2mm" && e.TTipoCantidad == "Toneladas").NumCantidad;
                rpt.u1_2 = lstaDetalle.Single(e => e.Suministro.NSuministro == "1/2mm" && e.TTipoCantidad == "Unidades").NumCantidad;

                rpt.t12 = lstaDetalle.Single(e => e.Suministro.NSuministro == "12mm" && e.TTipoCantidad == "Toneladas").NumCantidad;
                rpt.u12 = lstaDetalle.Single(e => e.Suministro.NSuministro == "12mm" && e.TTipoCantidad == "Unidades").NumCantidad;

                rpt.t1 = lstaDetalle.Single(e => e.Suministro.NSuministro == "1mm" && e.TTipoCantidad == "Toneladas").NumCantidad;
                rpt.u1 = lstaDetalle.Single(e => e.Suministro.NSuministro == "1mm" && e.TTipoCantidad == "Unidades").NumCantidad;

                rpt.t5_8 = lstaDetalle.Single(e => e.Suministro.NSuministro == "5/8mm" && e.TTipoCantidad == "Toneladas").NumCantidad;
                rpt.u5_8 = lstaDetalle.Single(e => e.Suministro.NSuministro == "5/8mm" && e.TTipoCantidad == "Unidades").NumCantidad;

                rpt.t3_8 = lstaDetalle.Single(e => e.Suministro.NSuministro == "3/8mm" && e.TTipoCantidad == "Toneladas").NumCantidad;
                rpt.u3_8 = lstaDetalle.Single(e => e.Suministro.NSuministro == "3/8mm" && e.TTipoCantidad == "Unidades").NumCantidad;
            }
            return rpt;
           
        }

        public bool GuardarDetalleSuministro(DetalleSuministroViewModel entity)
        {
            //var id6mm = context.Suministros.Single(e => e.NSuministro == "6mm").SuministroId;
            // var id8mm = context.Suministros.Single(e => e.NSuministro == "8mm").SuministroId;
            // var id3_8mm = context.Suministros.Single(e => e.NSuministro == "3_8mm").SuministroId;
            // var id12mm = context.Suministros.Single(e => e.NSuministro == "12mm").SuministroId;
            // var id1_2mm = context.Suministros.Single(e => e.NSuministro == "1_2mm").SuministroId;
            // var id5_8mm = context.Suministros.Single(e => e.NSuministro == "5_8mm").SuministroId;
            // var id3_4mm = context.Suministros.Single(e => e.NSuministro == "3_4mm").SuministroId;
            // var id1mm = context.Suministros.Single(e => e.NSuministro == "1mm").SuministroId;
            //// int SuministroId,int ProyectoId,int NumCantidad, string TTipoCantidad
            // var idProyecto = context.Proyectos.OrderByDescending(e => e.ProyectoId).First().ProyectoId;

            // var t6  = new DetalleSuministro(id6mm, idProyecto,entity.t6,"Toneladas"); 
            // var u6  = new DetalleSuministro(id6mm, idProyecto, entity.u6, "Unidades");
            // var t8  = new DetalleSuministro(id8mm, idProyecto, entity.t8, "Toneladas");
            // var u8  = new DetalleSuministro(id8mm, idProyecto, entity.u8, "Unidades");
            // var t3_8 = new DetalleSuministro(id3_8mm, idProyecto, entity.t3_8, "Toneladas");
            // var u3_8 = new DetalleSuministro(id3_8mm, idProyecto, entity.u3_8, "Unidades");
            // var t12  = new DetalleSuministro(id12mm, idProyecto, entity.t12, "Toneladas");
            // var u12  = new DetalleSuministro(id12mm, idProyecto, entity.u12, "Unidades");
            // var t1_2 = new DetalleSuministro(id1_2mm, idProyecto, entity.t1_2, "Toneladas");
            // var u1_2 = new DetalleSuministro(id1_2mm, idProyecto, entity.u1_2, "Unidades");
            // var t5_8 = new DetalleSuministro(id5_8mm, idProyecto, entity.t5_8, "Toneladas");
            // var u5_8 = new DetalleSuministro(id5_8mm, idProyecto, entity.u5_8, "Unidades");
            // var t3_4 = new DetalleSuministro(id3_4mm, idProyecto, entity.t3_4, "Toneladas");
            // var u3_4 = new DetalleSuministro(id3_4mm, idProyecto, entity.u3_4, "Unidades");
            // var t1  = new DetalleSuministro(id1mm, idProyecto, entity.t1, "Toneladas");
            // var u1  = new DetalleSuministro(id1mm, idProyecto, entity.u1, "Unidades");
            // try
            // {
            //     context.Add(t6);
            //     context.Add(u6);
            //     context.Add(t8);
            //     context.Add(u8);
            //     context.Add(t3_8);
            //     context.Add(u3_8);
            //     context.Add(t12);
            //     context.Add(u12);
            //     context.Add(t1_2);
            //     context.Add(u1_2);
            //     context.Add(t5_8);
            //     context.Add(u5_8);
            //     context.Add(t3_4);
            //     context.Add(u3_4);
            //     context.Add(t1);
            //     context.Add(u1);
            //     context.SaveChanges();
            // }
            // catch (System.Exception)
            // {

            //     return false;
            // }
             return true;

     

        }
    }
}