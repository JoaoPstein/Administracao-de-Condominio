using Admnistracao.Condominio.Domain.Repository;
using Admnistracao.Condominio.Domain.Reserva.Entidade;
using System.Threading.Tasks;

namespace Admnistracao.Condominio.Domain.Reserva.Interfaces.Repository
{
    public interface IReservaRepository: IRepository<ReservaBE>
    {
        Task SalvarReserva(ReservaBE reserva);
    }
}
