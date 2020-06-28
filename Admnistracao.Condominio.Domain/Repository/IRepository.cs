using Admnistracao.Condominio.Domain.Entidade;
using System.Threading.Tasks;

namespace Admnistracao.Condominio.Domain.Repository
{
    public interface IRepository<TEntidade> where TEntidade : EntidadeBaseBE
    {
        Task Incluir(TEntidade entidade);
        void Atualizar(TEntidade entidade);
    }
}
