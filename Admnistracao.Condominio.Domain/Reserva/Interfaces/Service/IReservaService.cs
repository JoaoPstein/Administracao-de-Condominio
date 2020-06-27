using Admnistracao.Condominio.Domain.Reserva.Entidade;

namespace Admnistracao.Condominio.Domain.Reserva.Interfaces.Service
{
    public interface IReservaService
    {
        void SalvarReserva(ReservaBE reserva);
    }
}
