using Admnistracao.Condominio.Domain.Interface;
using Admnistracao.Condominio.Infra.Context;
using System;
using System.Threading.Tasks;

namespace Admnistracao.Condominio.Infra.UoK
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly MainContext _context;

        public UnitOfWork(MainContext context)
        {
            _context = context;
        }

        public async Task<bool> Commit()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
