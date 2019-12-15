using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App_19k.Domain;
using App_19k.Repository.Context;
using App_19k.Repository.Implementacion;
using App_19k.Repository.ViewModel;

namespace App_19k.Repository.Implementacion
{
    public class ProyectoRepository : IProyectoRepository
    {
        private ApplicationDbContext context;

        public ProyectoRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Proyecto Get(int id)
        {
            var result = new Proyecto();
            try
            {
                result = context.Proyectos.Single(x => x.ProyectoId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Proyecto> GetAll()
        {

            var result = new List<Proyecto>();
            try
            {
                result = context.Proyectos.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Proyecto entity)
        {

            if (entity.MarcaProveedorId == -1)
            {
                var ultimaMarca = context.MarcaProveedores.OrderByDescending(e => e.MarcaProveedorId).FirstOrDefault();
                entity.MarcaProveedorId = ultimaMarca.MarcaProveedorId;
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

        public bool Update(Proyecto entity)
        {
            try
            {
                var ProyectoOriginal = context.Proyectos.Single(
                    x => x.ProyectoId == entity.ProyectoId
                );
                ProyectoOriginal.FechaInscripcion = entity.FechaInscripcion;
                ProyectoOriginal.NProyecto = entity.NProyecto;
                ProyectoOriginal.DistritoId = entity.DistritoId;
                ProyectoOriginal.VendedorId = entity.VendedorId;
                ProyectoOriginal.NumAreaTerreno = entity.NumAreaTerreno;
                ProyectoOriginal.NumAreaTotal = entity.NumAreaTotal;
                ProyectoOriginal.TTipoInversion = entity.TTipoInversion;
                ProyectoOriginal.TDireccion = entity.TDireccion;
                ProyectoOriginal.TEstatusProyecto = entity.TEstatusProyecto;
                ProyectoOriginal.NumLicencia = entity.NumLicencia;
                ProyectoOriginal.DInicioSuministro = entity.DInicioSuministro;
                ProyectoOriginal.NumTiempoSuministro = entity.NumTiempoSuministro;
                ProyectoOriginal.DFechaFinalObra = entity.DFechaFinalObra;
                ProyectoOriginal.IdentificadorSider = entity.IdentificadorSider;
                ProyectoOriginal.TEstatusSolicitud = entity.TEstatusSolicitud;
                ProyectoOriginal.TTipoSolicitud = entity.TTipoSolicitud;
                ProyectoOriginal.MPrecioSolicitado = entity.MPrecioSolicitado;
                ProyectoOriginal.NConstructora = entity.NConstructora;
                ProyectoOriginal.TRucConstructora = entity.TRucConstructora;               
                ProyectoOriginal.IdentificadorSider = entity.IdentificadorSider;
                ProyectoOriginal.FechaReg = entity.FechaReg;
                ProyectoOriginal.MarcaProveedorId= entity.MarcaProveedorId;
                ProyectoOriginal.NumToneladas = entity.NumToneladas;
                ProyectoOriginal.GrupoConstructora= entity.GrupoConstructora;
                ProyectoOriginal.Latitud= entity.Latitud;
                ProyectoOriginal.Altitud= entity.Altitud;
                ProyectoOriginal.ObservacionProyecto= entity.ObservacionProyecto;
                context.Update(ProyectoOriginal);
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

        public IEnumerable<VistaProyecto> LstaProyectos(   
                               string TTipo,
                               int idUsuario,                                                         
                               string NProyecto,                                
                               string NDistribuidor,  
                               string GrupoDistribuidor,
                               string NDistrito,                        
                               string NUsuario,
                               string NumAreaTerreno,
                               string NumAreaTotal,
                               string TTipoInversion,
                               string TEstatusProyecto,
                               string TDireccion,
                               string NumLicencia,
                               string DInicioSuministro,
                               string NumTiempoSuministro,
                               string DFechaFinalObra,
                               string TTipoSolicitud,
                               string MPrecioSolicitado,
                               string NConstructora,
                               string TRucConstructora,                            
                               string IdentificadorSider,
                               string FechaReg,
                               string GrupoConstructora,
                               string TEstatusSolicitud                       
                                )
        {
            var usuario = from u in context.Usuarios                     
                          where u.UsuarioId == idUsuario
                          select new { u.UsuarioId, u.DistribuidorId };
            var lis = usuario.ToList();
            Usuario objUsuario = new Usuario();
            objUsuario.DistribuidorId = usuario.First().DistribuidorId;
            objUsuario.UsuarioId= usuario.First().UsuarioId;


            //analizar usuario:



            var proyectos = from p in context.Proyectos
                            join v in context.Vendedores
                            on p.VendedorId equals v.VendedorId
                            join u in context.Usuarios
                            on v.VendedorId equals u.UsuarioId
                            join d in context.Distribuidores
                            on u.DistribuidorId equals d.DistribuidorId
                            join dist in context.Distritos
                            on p.DistritoId equals dist.DistritoId
                            into lj
                            from distrito in lj.DefaultIfEmpty()
                            //join marca in context.MarcaProveedores
                            //on p.MarcaProveedorId equals marca.MarcaProveedorId
                            select new
                            {
                                p.ProyectoId,
                                p.NProyecto,
                                d.DistribuidorId,
                                d.NDistribuidor,
                                DistritoId = p.DistritoId == null ? null : p.DistritoId,
                                NDistrito=p.DistritoId == null ? "" : distrito.NDistrito,
                               // NDistrito =distrito.NDistrito==null?"":distrito.NDistrito,
                                v.VendedorId,
                                u.NUsuario,
                                p.NumAreaTerreno,
                                p.NumAreaTotal,
                                p.TTipoInversion,
                                p.TEstatusProyecto,
                                p.TDireccion,
                                p.NumLicencia,
                                p.DInicioSuministro,
                                p.NumTiempoSuministro,
                                p.DFechaFinalObra,
                                p.TTipoSolicitud,
                                p.MPrecioSolicitado,
                                p.NConstructora,
                                p.TRucConstructora,

                                p.IdentificadorSider,
                                p.FechaReg,
                                p.GrupoConstructora,
                                d.GrupoDistribuidor,
                                //marca.NMarcaProveedor,                                
                                p.TEstatusSolicitud,
                                p.NumToneladas,
                                p.FechaInscripcion,
                            };

            proyectos = proyectos.OrderByDescending(e => e.ProyectoId);

            if (NProyecto!="-1"){ proyectos=proyectos.Where(e => e.NProyecto.ToUpper().Contains(NProyecto.ToUpper())); }
            if (NDistribuidor!="-1") { proyectos = proyectos.Where(e => e.NDistribuidor.ToUpper().Contains(NDistribuidor.ToUpper())); }
            if (NDistrito!="-1" ) { proyectos = proyectos.Where(e => e.NDistrito.ToUpper().Contains(NDistrito.ToUpper())); }
            if (NUsuario!= "-1") { proyectos = proyectos.Where(e => e.NUsuario.ToUpper().Contains(NUsuario.ToUpper())); }
            if (NumAreaTerreno!="-1") { proyectos = proyectos.Where(e => e.NumAreaTerreno.ToString().ToUpper().Contains(NumAreaTerreno.ToUpper())); }
            if (NumAreaTotal!="-1") { proyectos = proyectos.Where(e => e.NumAreaTotal.ToString().ToUpper().Contains(NumAreaTotal.ToUpper())); }
            if (TTipoInversion!="-1") { proyectos = proyectos.Where(e => e.TTipoInversion.ToUpper().Contains(TTipoInversion.ToUpper())); }
            if (TEstatusProyecto!="-1") { proyectos = proyectos.Where(e => e.TEstatusProyecto.ToUpper().Contains(TEstatusProyecto.ToUpper())); }
            if (TDireccion!="-1") { proyectos = proyectos.Where(e => e.TDireccion.ToUpper().Contains(TDireccion.ToUpper())); }
            if (NumLicencia!="-1") { proyectos = proyectos.Where(e => e.NumLicencia.ToUpper().Contains(NumLicencia.ToUpper())); }
            if (DInicioSuministro!="-1") { proyectos = proyectos.Where(e => e.DInicioSuministro.ToString().ToUpper().Contains(DInicioSuministro.ToUpper())); }
            if (NumTiempoSuministro!="-1") { proyectos = proyectos.Where(e => e.NumTiempoSuministro.ToString().ToUpper().Contains(NumTiempoSuministro.ToUpper())); }
            if (DFechaFinalObra!="-1") { proyectos = proyectos.Where(e => e.DFechaFinalObra.ToString().ToUpper().Contains(DFechaFinalObra.ToUpper())); }
            if (TTipoSolicitud!="-1") { proyectos = proyectos.Where(e => e.TTipoSolicitud.ToUpper().Contains(TTipoSolicitud.ToUpper())); }
            if (MPrecioSolicitado!="-1") { proyectos = proyectos.Where(e => e.MPrecioSolicitado.ToString().ToUpper().Contains(MPrecioSolicitado.ToUpper())); }
            if (NConstructora!="-1") { proyectos = proyectos.Where(e => e.NConstructora.ToUpper().Contains(NConstructora.ToUpper())); }
            if (TRucConstructora!="-1") { proyectos = proyectos.Where(e => e.TRucConstructora.ToUpper().Contains(TRucConstructora.ToUpper())); }           
            if (IdentificadorSider!="-1") { proyectos = proyectos.Where(e => e.IdentificadorSider == IdentificadorSider.ToUpper()); }
            if (FechaReg != "-1") { proyectos = proyectos.Where(e => e.FechaReg.ToString().ToUpper().Contains(FechaReg.ToUpper())); }
            if (GrupoConstructora != "-1") { proyectos = proyectos.Where(e => e.GrupoConstructora.ToString().ToUpper().Contains(GrupoConstructora.ToUpper())); }
            if (GrupoDistribuidor != "-1") { proyectos = proyectos.Where(e => e.GrupoDistribuidor.ToString().ToUpper().Contains(GrupoDistribuidor.ToUpper())); }
            if (TEstatusSolicitud != "-1") { proyectos = proyectos.Where(e => e.TEstatusSolicitud.ToString().ToUpper().Contains(TEstatusSolicitud.ToUpper())); }
          //  if (NMarcaProveedor != "-1") { proyectos = proyectos.Where(e => e.NMarcaProveedor.ToString().ToUpper().Contains(NMarcaProveedor.ToUpper())); }
          
            var LstaProyectos = new List<VistaProyecto>();

            foreach (var campo in proyectos)
            {
                var objProyecto = new VistaProyecto();
                var rpta = context.Respuestas.LastOrDefault(x=>x.ProyectoId == campo.ProyectoId);
                if(rpta != null)
                {
                    objProyecto.MPrecioAutorizadoBase = rpta.MPrecioAutorizadoBase;
                    objProyecto.Flete = rpta.Flete;
                    objProyecto.MPrecioFinal = objProyecto.MPrecioAutorizadoBase + objProyecto.Flete;
                    objProyecto.DiasValidez = rpta.DiasValidez;
                    var res = rpta.FechaInicioOferta.ToString().Split(' ');
                    var fio = res[0];
                    objProyecto.FechaInicioOferta = fio;
                    var res2 = rpta.FechaInicioOferta.AddDays(rpta.DiasValidez).ToString().Split(' ');
                    var ffo = res2[0];
                    objProyecto.FechaFinOferta = ffo;
                    var res3 = rpta.FechaInicioVigenciaPrecio.ToString().Split(' ');
                    var fivp = res3[0];
                    objProyecto.FechaInicioVigenciaPrecio = fivp;
                    var res4 = rpta.FechaFinalVigenciaPrecio.ToString().Split(' ');
                    var ffvp = res4[0];
                    objProyecto.FechaFinalVigenciaPrecio = ffvp;
                    var res5 = rpta.FechaReg.ToString().Split(' ');
                    var fap = res5[0];
                    objProyecto.FechaAutorizacionPrecio = fap;
                    objProyecto.ObservacionRpta = rpta.observaciones;
                }
                else 
                {
                    objProyecto.FechaInicioOferta = "Esperando...";
                    objProyecto.FechaFinOferta = "Esperando...";
                    objProyecto.FechaInicioVigenciaPrecio = "Esperando...";
                    objProyecto.FechaFinalVigenciaPrecio = "Esperando...";
                    objProyecto.FechaAutorizacionPrecio = "Esperando...";
                    objProyecto.ObservacionRpta = "Esperando...";
                }
                //...................................................  

                objProyecto.FechaInscripcion = campo.FechaInscripcion.ToString();
                objProyecto.ProyectoId = campo.ProyectoId;
                objProyecto.NProyecto = campo.NProyecto;
                objProyecto.DistritoId =Convert.ToInt32(campo.DistritoId);
                objProyecto.NDistrito = campo.NDistrito;
                objProyecto.VendedorId = campo.VendedorId;
                objProyecto.NVendedor = campo.NUsuario;
                objProyecto.DistribuidorId = campo.DistribuidorId;
                objProyecto.NDistribuidor = campo.NDistribuidor;
                objProyecto.NumAreaTerreno = campo.NumAreaTerreno;
                objProyecto.NumAreaTotal = campo.NumAreaTotal;
                objProyecto.TTipoInversion = campo.TTipoInversion;
                objProyecto.TDireccion = campo.TDireccion;
                objProyecto.TEstatusProyecto = campo.TEstatusProyecto;
                objProyecto.NumLicencia = campo.NumLicencia;
                objProyecto.DInicioSuministro = campo.DInicioSuministro.ToString();
                objProyecto.NumTiempoSuministro = campo.NumTiempoSuministro;
                objProyecto.DFechaFinalObra = campo.DFechaFinalObra.ToString();
                objProyecto.GrupoDistribuidor= campo.GrupoDistribuidor.ToString();
                objProyecto.GrupoConstructora= campo.GrupoConstructora.ToString();
                objProyecto.TTipoSolicitud = campo.TTipoSolicitud;
                objProyecto.MPrecioSolicitado = campo.MPrecioSolicitado;
                objProyecto.NConstructora = campo.NConstructora;
                objProyecto.TRucConstructora = campo.TRucConstructora;
   
                objProyecto.IdentificadorSider = campo.IdentificadorSider;
                objProyecto.FechaReg = campo.FechaReg.ToString();
                objProyecto.TEstatusSolicitud = campo.TEstatusSolicitud;
               // objProyecto.NMarcaProveedor = campo.NMarcaProveedor.ToString();
                objProyecto.NumToneladas = campo.NumToneladas;
                //SETEAR DEPARTAMENTO Y PROVINCIA
                var _distrito = context.Distritos.SingleOrDefault(e => e.DistritoId == objProyecto.DistritoId);
                if (_distrito != null)
                {
                    var provincia = context.Provincias.SingleOrDefault(e => e.ProvinciaId == _distrito.ProvinciaId);
                    var departamento = context.Departamentos.SingleOrDefault(e => e.DepartamentoId == provincia.DepartamentoId);
                    objProyecto.NDepartamento = departamento.NDepartamento;
                    objProyecto.NProvincia = provincia.NProvincia;
                }
                //....................................................
                LstaProyectos.Add(objProyecto);
            }

            if (TTipo == "Administrador General")
            {
                var res=LstaProyectos.Where(e => e.TEstatusSolicitud != "GUARDADA");
                return res;
            }
            else if(TTipo == "Administrador")
            {
                return LstaProyectos.Where(e => e.DistribuidorId == objUsuario.DistribuidorId);               
            }
            else
            {
                return LstaProyectos.Where(e => e.VendedorId == idUsuario);             
            }
        }

        public VistaProyecto DetalleXProyecto(int id)
        {
            var proyectos = from p in context.Proyectos
                                join v in context.Vendedores
                                on p.VendedorId equals v.VendedorId
                                join u in context.Usuarios
                                on v.VendedorId equals u.UsuarioId
                                join d in context.Distribuidores
                                on u.DistribuidorId equals d.DistribuidorId
                                join dist in context.Distritos
                                on p.DistritoId equals dist.DistritoId
                                into lj
                                from distrito in lj.DefaultIfEmpty()
                                where p.ProyectoId==id
                               // join marca in context.MarcaProveedores
                               // on p.MarcaProveedorId equals marca.MarcaProveedorId
                                select new{
                                    p.ProyectoId,
                                    p.NProyecto,
                                    d.DistribuidorId,
                                    d.NDistribuidor,
                                    DistritoId = p.DistritoId == null ? null : p.DistritoId,
                                    NDistrito = p.DistritoId == null ? "" : distrito.NDistrito,
                                    v.VendedorId,
                                    u.NUsuario,
                                    p.NumAreaTerreno,
                                    p.NumAreaTotal,
                                    p.TTipoInversion,
                                    p.TEstatusProyecto,
                                    p.TEstatusSolicitud,
                                    p.TDireccion,
                                    p.NumLicencia,
                                    p.DInicioSuministro,
                                    p.NumTiempoSuministro,
                                    p.DFechaFinalObra,
                                     p.GrupoConstructora,
                                    p.TTipoSolicitud,
                                    p.MPrecioSolicitado,
                                    p.NConstructora,
                                    p.TRucConstructora,
                                    p.Latitud,
                                    p.Altitud,
                                    p.ObservacionProyecto,
                                    p.IdentificadorSider,
                                    p.FechaReg,
                                    p.NumToneladas,
                                   p.FechaInscripcion
                                };
            var VistaProyecto = new VistaProyecto();
            VistaProyecto.LstaActividadEconomica = context.ActividadEconomicas.Where(e=>e.ProyectoId==id).ToList();
            VistaProyecto.LstaNumerosContacto = context.NumerosContactos.Where(e => e.ProyectoId == id).ToList();

            var respuestas = context.Respuestas.Where(e => e.ProyectoId == id).ToList(); 

            VistaProyecto.FechaInscripcion = proyectos.First().FechaInscripcion.ToString();
            VistaProyecto.LstaRespuestas = respuestas;        
            VistaProyecto.ProyectoId = proyectos.First().ProyectoId;
            VistaProyecto.NProyecto = proyectos.First().NProyecto;
            VistaProyecto.DistribuidorId = proyectos.First().DistribuidorId;
            VistaProyecto.NDistribuidor = proyectos.First().NDistribuidor;
            VistaProyecto.DistritoId =Convert.ToInt32(proyectos.First().DistritoId);
            VistaProyecto.NDistrito = proyectos.First().NDistrito;
            VistaProyecto.VendedorId = proyectos.First().VendedorId;
            VistaProyecto.NVendedor = proyectos.First().NUsuario;
            VistaProyecto.NumAreaTerreno = proyectos.First().NumAreaTerreno;
            VistaProyecto.NumAreaTotal = proyectos.First().NumAreaTotal;
            VistaProyecto.TTipoInversion = proyectos.First().TTipoInversion;
            VistaProyecto.TEstatusProyecto = proyectos.First().TEstatusProyecto;
            VistaProyecto.TEstatusSolicitud = proyectos.First().TEstatusSolicitud;
            VistaProyecto.TDireccion = proyectos.First().TDireccion;
            VistaProyecto.NumLicencia = proyectos.First().NumLicencia;
            VistaProyecto.NumToneladas = proyectos.First().NumToneladas;

            var _idMarca= context.Proyectos.SingleOrDefault(e => e.ProyectoId == id).MarcaProveedorId;
            if (_idMarca != null)
            {
                VistaProyecto.NMarcaProveedor =context.MarcaProveedores.SingleOrDefault(e=>e.MarcaProveedorId==_idMarca).NMarcaProveedor;
            }
            VistaProyecto.DInicioSuministro = proyectos.First().DInicioSuministro.ToString();
            VistaProyecto.MarcaProveedorId = _idMarca;
            VistaProyecto.NumTiempoSuministro = proyectos.First().NumTiempoSuministro;
            VistaProyecto.DFechaFinalObra =  proyectos.First().DFechaFinalObra.ToString();
            VistaProyecto.TTipoSolicitud = proyectos.First().TTipoSolicitud;
            VistaProyecto.MPrecioSolicitado = proyectos.First().MPrecioSolicitado;
            VistaProyecto.NConstructora = proyectos.First().NConstructora;
            VistaProyecto.TRucConstructora = proyectos.First().TRucConstructora;
            VistaProyecto.Latitud = proyectos.First().Latitud;
            VistaProyecto.Altitud = proyectos.First().Altitud;
            VistaProyecto.IdentificadorSider = proyectos.First().IdentificadorSider;
            VistaProyecto.FechaReg= proyectos.First().FechaReg.ToString();
            VistaProyecto.GrupoConstructora = proyectos.First().GrupoConstructora.ToString();
            VistaProyecto.ObservacionProyecto = proyectos.First().ObservacionProyecto;

            var _distrito = context.Distritos.SingleOrDefault(e => e.DistritoId == VistaProyecto.DistritoId);
            if (_distrito != null)
            {
                var provincia = context.Provincias.SingleOrDefault(e => e.ProvinciaId == _distrito.ProvinciaId);
                var departamento = context.Departamentos.SingleOrDefault(e => e.DepartamentoId == provincia.DepartamentoId);
                VistaProyecto.NDepartamento = departamento.NDepartamento;
                VistaProyecto.NProvincia = provincia.NProvincia;
            }

            return VistaProyecto; 
        }
       
    }
}