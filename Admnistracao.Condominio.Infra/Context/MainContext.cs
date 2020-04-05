using Microsoft.EntityFrameworkCore;

namespace Admnistracao.Condominio.Infra.Context
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options) : base(options)
        {
        }
    }
}
