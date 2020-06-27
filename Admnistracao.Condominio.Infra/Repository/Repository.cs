using Admnistracao.Condominio.Domain.Entidade;
using Admnistracao.Condominio.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Admnistracao.Condominio.Infra.Repository
{
    public class Repository<TContext, TEntidade> : IRepository<TEntidade> where TEntidade : EntidadeBaseBE where TContext : DbContext
    {
        protected readonly TContext _contexto;

        public Repository(TContext contexto)
        {
            _contexto = contexto;
        }
    }
}
