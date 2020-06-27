using Administracao.Condominio.Service.Reserva.Service;
using Admnistracao.Condominio.Domain.Interface;
using Admnistracao.Condominio.Infra.Reserva.Repository;
using Admnistracao.Condominio.Infra.UoK;
using Microsoft.Extensions.DependencyInjection;

namespace Administracao.Condominio.Infra.CrossCutting.Ioc
{
    public static class IocSettings
    {
        public static void AddIoCApplication(this IServiceCollection services)
        {
            services.Scan(scan => scan
                    .FromAssemblyOf<ReservaRepository>()
                        .AddClasses(classes => classes.Where(type => type.FullName.EndsWith("Repository")))
                        .AsMatchingInterface()
                        .AsSelf()
                        .WithScopedLifetime()
                   .FromAssemblyOf<ReservaService>()
                        .AddClasses(classes => classes.Where(type => type.FullName.EndsWith("Service")))
                        .AsMatchingInterface()
                        .AsSelf()
                        .WithScopedLifetime());

            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }
    }
}
