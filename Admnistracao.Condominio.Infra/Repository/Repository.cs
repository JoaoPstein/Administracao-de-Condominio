using Admnistracao.Condominio.Domain.Entidade;
using Admnistracao.Condominio.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Admnistracao.Condominio.Infra.Repository
{
    public class Repository<TContext, TEntidade> : IRepository<TEntidade> where TEntidade : EntidadeBaseBE where TContext : DbContext
    {
        protected readonly TContext _contexto;

        public Repository(TContext contexto)
        {
            _contexto = contexto;
        }

        public virtual void Atualizar(TEntidade entidade)
        {
            _contexto.Entry(entidade).State = EntityState.Modified;
        }

        public virtual async Task Incluir(TEntidade entidade)
        {
            await _contexto.AddAsync(entidade);
        }
    }
}
