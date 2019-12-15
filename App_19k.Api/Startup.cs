using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using App_19k.Repository;
using App_19k.Repository.Context;
using App_19k.Repository.Implementacion;
using App_19k.Service;
using App_19k.Service.Implementacion;
using Microsoft.EntityFrameworkCore;

namespace App_19k.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
         options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            services.AddTransient<IActividadEconomicaRepository, ActividadEconomicaRepository>();
            services.AddTransient<IActividadEconomicaService, ActividadEconomicaService>();

            services.AddTransient<IVendedorRepository, VendedorRepository>();
            services.AddTransient<IVendedorService, VendedorService>();

            services.AddTransient<IDistribuidorRepository, DistribuidorRepository>();
            services.AddTransient<IDistribuidorService, DistribuidorService>();

            services.AddTransient<IDetalleSuministroRepository, DetalleSuministroRepository>();
            services.AddTransient<IDetalleSuministroService, DetalleSuministroService>();

            services.AddTransient<IDistritoRepository, DistritoRepository>();
            services.AddTransient<IDistritoService, DistritoService>();

            services.AddTransient<IProvinciaRepository, ProvinciaRepository>();
            services.AddTransient<IProvinciaService, ProvinciaService>();

            services.AddTransient<IProyectoRepository, ProyectoRepository>();
            services.AddTransient<IProyectoService, ProyectoService>();

            services.AddTransient<ISuministroRepository, SuministroRepository>();
            services.AddTransient<ISuministroService, SuministroService>();

            services.AddTransient<IVendedorRepository, VendedorRepository>();
            services.AddTransient<IVendedorService, VendedorService>();

            services.AddTransient<IAdministradorRepository, AdministradorRepository>();
            services.AddTransient<IAdministradorService, AdministradorService>();

            services.AddTransient<IEntregaRepository, EntregaRepository>();
            services.AddTransient<IEntregaService, EntregaService>();

            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IUsuarioService, UsuarioService>();

            services.AddTransient<IDepartamentoRepository, DepartamentoRepository>();
            services.AddTransient<IDepartamentoService, DepartamentoService>();

            services.AddTransient<INumerosContactoRepository, NumerosContactoRepository>();
            services.AddTransient<INumerosContactoService, NumerosContactoService>();
            
            services.AddTransient<IRespuestaRepository, RespuestaRepository>();
            services.AddTransient<IRespuestaService, RespuestaService>();

            services.AddTransient<IMarcaProveedorRepository, MarcaProveedorRepository>();
            services.AddTransient<IMarcaProveedorService, MarcaProveedorService>();



            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddCors(options =>
            {
                options.AddPolicy("Todos",
                builder => builder.WithOrigins("*").WithHeaders("*").WithMethods("*"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCors("Todos");
            app.UseMvc();
        }
    }
}
