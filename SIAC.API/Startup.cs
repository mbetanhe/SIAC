using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SIAC.CORE.Interfaces;
using SIAC.CORE.Services;
using SIAC.INFRASTRUCTURE.Data;
using SIAC.INFRASTRUCTURE.Filters;
using SIAC.INFRASTRUCTURE.Repository;
using System;

namespace SIAC.API
{
    public class Startup
    {
        readonly string CORS_POLICY = "CORS_POLICY";


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: CORS_POLICY,
                                  builder =>
                                  {
                                      builder.AllowAnyOrigin()
                                      .AllowAnyMethod()
                                      .AllowAnyHeader();
                                  });
            });

            services.AddControllers(opt => {
                opt.Filters.Add<GlobalExceptionFilter>();
            });

            //Servicio de automaper.
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //Agregamos el contexto de datos.
            services.AddDbContext<AuditoriaDeCampoContext>(opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("DBCon"));
            });

            //Agregamos los servicios.
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IPremOffService, PremOffService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IPremisasOfflineRepository, PremisasOfflineRepository>();
            services.AddTransient<IParamPreOffRepository, ParamPreOffRepository>();

            //Agregamos el servicio de documentacion
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SIAC.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SIAC.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(CORS_POLICY);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
