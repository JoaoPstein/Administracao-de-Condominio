using Admnistracao.Condominio.Domain.Entidade;
using Admnistracao.Condominio.Domain.Interface;
using Admnistracao.Condominio.Domain.Repository;
using Admnistracao.Condominio.Domain.Service;
using System.Threading.Tasks;

namespace Administracao.Condominio.Service.Service
{
    public class BancoDadosService<TEntidade> : Service, IBancoDadosService<TEntidade>, IService where TEntidade : EntidadeBaseBE
    {
        protected readonly IRepository<TEntidade> _repository;
        protected readonly IUnitOfWork _unitOfWork;

        public BancoDadosService(IRepository<TEntidade> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task Atualizar(TEntidade entidade)
        {
            await _repository.Incluir(entidade);
            await _unitOfWork.Commit();
        }

        public async Task Incluir(TEntidade entidade)
        {
            _repository.Atualizar(entidade);
            await _unitOfWork.Commit();
        }
    }
}
