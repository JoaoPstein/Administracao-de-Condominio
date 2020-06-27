using Admnistracao.Condominio.Domain.Reserva.Entidade;
using Admnistracao.Condominio.Domain.Reserva.Interfaces.Repository;
using Admnistracao.Condominio.Infra.Context;
using Admnistracao.Condominio.Infra.Repository;

namespace Admnistracao.Condominio.Infra.Reserva.Repository
{
    public class ReservaRepository : Repository<MainContext, ReservaBE>, IReservaRepository
    {
        public ReservaRepository(MainContext context): base(context)
        {

        }

        public void SalvarReserva(ReservaBE reserva)
        {
            
        }
    }
}
