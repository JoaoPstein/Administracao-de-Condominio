using Administracao.Condominio.Service.Service;
using Admnistracao.Condominio.Domain.Interface;
using Admnistracao.Condominio.Domain.Reserva.Entidade;
using Admnistracao.Condominio.Domain.Reserva.Interfaces.Repository;
using Admnistracao.Condominio.Domain.Reserva.Interfaces.Service;
using System.Threading.Tasks;

namespace Administracao.Condominio.Service.Reserva.Service
{
    public class ReservaService : BancoDadosService<ReservaBE>, IReservaService
    {
        private readonly IReservaRepository _repository;

        public ReservaService(IReservaRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
            _repository = repository;
        }

        public async Task SalvarReserva(ReservaBE reserva)
        {
            await _repository.Incluir(reserva);
            await _unitOfWork.Commit();
        }
    }
}
