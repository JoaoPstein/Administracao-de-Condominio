using Administracao.Condominio.Service.Service;
using Admnistracao.Condominio.Domain.Interface;
using Admnistracao.Condominio.Domain.Reserva.Entidade;
using Admnistracao.Condominio.Domain.Reserva.Interfaces.Repository;
using Admnistracao.Condominio.Domain.Reserva.Interfaces.Service;

namespace Administracao.Condominio.Service.Reserva.Service
{
    public class ReservaService : BancoDadosService<ReservaBE>, IReservaService
    {
        private readonly IReservaRepository repository;

        public ReservaService(IReservaRepository _repository, IUnitOfWork unitOfWork) : base(_repository, unitOfWork)
        {
            repository = _repository;
        }

        public void SalvarReserva(ReservaBE reserva)
        {
            repository.SalvarReserva(reserva);
        }
    }
}
