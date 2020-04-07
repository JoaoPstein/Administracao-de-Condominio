using Admnistracao.Condominio.Web.Usuario.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Admnistracao.Condominio.Web.Usuario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public UsuarioController()
        {

        }

        [HttpGet]
        [SwaggerResponse(200, type: typeof(UsuarioViewModel))]
        [SwaggerResponse(404, type: typeof(HttpResponse))]
        public ActionResult<HttpResponse> Get()
        {
            return Ok(new UsuarioViewModel()
            {
                Codigo = 1,
                Nome = "teste 123",
                Email = "teste@email.com",
                Ativo = true
            });
        }
    }
}