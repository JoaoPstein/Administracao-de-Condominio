using Admnistracao.Condominio.Domain.Entidade;
using Admnistracao.Condominio.Domain.Interface;
using Admnistracao.Condominio.Domain.Repository;
using Admnistracao.Condominio.Domain.Service;

namespace Administracao.Condominio.Service.Service
{
    public class BancoDadosService<TEntidade> : Service, IBancoDadosService<TEntidade>, IService where TEntidade : EntidadeBaseBE
    {
        protected readonly IRepository<TEntidade> repository;
        protected readonly IUnitOfWork unitOfWork;

        public BancoDadosService(IRepository<TEntidade> _repository, IUnitOfWork _unitOfWork)
        {
            repository = _repository;
            unitOfWork = _unitOfWork;
        }
    }
}
