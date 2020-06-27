using Admnistracao.Condominio.Domain.Reserva.Entidade;
using Microsoft.EntityFrameworkCore;

namespace Admnistracao.Condominio.Infra.Context
{
    public class MainContext : BaseContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {


        }

        public DbSet<ReservaBE> Reservas { get; set; }         
    }
}
