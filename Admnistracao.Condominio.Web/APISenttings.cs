using Admnistracao.Condominio.Infra.Context;
using Admnistracao.Condominio.Web.Mapper;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Admnistracao.Condominio.Web
{
    public static class APISenttings
    {
        #region Swagger

        public static void AdicionarServicoSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Adm. Condominnio API", Version = "v1" });
            });
        }

        public static void UsarServicoSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(opt =>
            {
                opt.SwaggerEndpoint("/swagger/v1/swagger.json", "Adm. Condominnio API v1");
            });
        }

        #endregion

        #region AutoMapper

        public static void AdicionarConfiguracaoAutoMapeamento(this IServiceCollection servicos)
        {
            MapperConfiguration mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperProfile());
            });
            servicos.AddSingleton<IMapper>(sp => mapper.CreateMapper());
        }

        #endregion


        #region DataBase

        public static void AdicionarBancoDados(this IServiceCollection servicos, string connection)
        {
            servicos.AddDbContext<MainContext>(optionsAction => optionsAction.UseSqlServer(connection));
        }

        #endregion
    }
}
