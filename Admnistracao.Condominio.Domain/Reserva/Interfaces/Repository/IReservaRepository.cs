using Admnistracao.Condominio.Domain.Repository;
using Admnistracao.Condominio.Domain.Reserva.Entidade;

namespace Admnistracao.Condominio.Domain.Reserva.Interfaces.Repository
{
    public interface IReservaRepository: IRepository<ReservaBE>
    {
        void SalvarReserva(ReservaBE reserva);
    }
}
