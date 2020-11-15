using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SIAC.CORE.Interfaces;
using SIAC.INFRASTRUCTURE.Data;
using SIAC.INFRASTRUCTURE.Repository;

namespace SIAC.API
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

            services.AddControllers();

            //Agregamos el contexto de datos.
            services.AddDbContext<AuditoriaDeCampoContext>(opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("DBCon"));
            });

            //Agregamos los servicios.
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IPremisasOfflineRepository, PremisasOfflineRepository>();

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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
