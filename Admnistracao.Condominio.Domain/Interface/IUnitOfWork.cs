using System;
using System.Threading.Tasks;

namespace Admnistracao.Condominio.Domain.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}
