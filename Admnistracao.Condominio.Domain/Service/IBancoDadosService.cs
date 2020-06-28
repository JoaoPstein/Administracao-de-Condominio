using Admnistracao.Condominio.Domain.Entidade;
using System.Threading.Tasks;

namespace Admnistracao.Condominio.Domain.Service
{
    public interface IBancoDadosService<TEntidade> where TEntidade : EntidadeBaseBE
    {
        Task Incluir(TEntidade entidade);
        Task Atualizar(TEntidade entidade);
    }
}
