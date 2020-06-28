using Admnistracao.Condominio.Domain.Reserva.Entidade;
using Admnistracao.Condominio.Domain.Reserva.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace Admnistracao.Condominio.Web.Reserva.Controller
{
    [Route("api/reserva")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly IReservaService reservaService;

        public ReservaController(IReservaService _reservaService)
        {
            reservaService = _reservaService;
        }

        [HttpPost]
        [SwaggerResponse(201, type: typeof(HttpResponse))]
        [SwaggerResponse(400, type: typeof(HttpResponse))]
        public async Task SalvarReserva(ReservaBE reserva)
        {
            await reservaService.SalvarReserva(reserva);
        }
    }
}