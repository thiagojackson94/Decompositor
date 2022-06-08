using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using TesteFramework.Interface;
using TesteFramework.Servicos;

namespace TesteFramework.API
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
            InstanciarSwaggerGen(services);
            InstanciarInjecaoDependencia(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });
        }

        public void InstanciarSwaggerGen(IServiceCollection services)
        {
            // Swagger
            services.AddSwaggerGen(c => {

                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Teste Framework",
                    Version = "v1",
                });
            });
        }

        public void InstanciarInjecaoDependencia(IServiceCollection services)
        {
            services.AddTransient<IDecompositor, Decompositor>();
            services.AddTransient<IDivisores, Divisores>();
            services.AddTransient<IDivisoresNumPrimos, DivisorNumPrimos>();
        }
    }
}
