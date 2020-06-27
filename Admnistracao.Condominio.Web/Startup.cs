using Administracao.Condominio.Infra.CrossCutting.Ioc;
using Admnistracao.Condominio.Infra.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Admnistracao.Condominio.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddMvcOptions(o => o.EnableEndpointRouting = false);
            services.AdicionarServicoSwagger();
            services.AdicionarConfiguracaoAutoMapeamento();
            services.AdicionarBancoDados(Configuration.GetConnectionString("Default"));
            services.AddIoCApplication();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, MainContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
            app.UsarServicoSwagger();
            app.UseHttpsRedirection();
            context.Database.Migrate();
        }
    }
}
