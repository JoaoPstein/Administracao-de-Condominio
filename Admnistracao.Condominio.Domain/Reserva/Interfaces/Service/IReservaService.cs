using Admnistracao.Condominio.Domain.Reserva.Entidade;
using System.Threading.Tasks;

namespace Admnistracao.Condominio.Domain.Reserva.Interfaces.Service
{
    public interface IReservaService
    {
        Task SalvarReserva(ReservaBE reserva);
    }
}
