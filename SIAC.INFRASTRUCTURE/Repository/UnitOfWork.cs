using SIAC.CORE.Entities;
using SIAC.CORE.Entities.Premisas;
using SIAC.CORE.Interfaces;
using SIAC.INFRASTRUCTURE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAC.INFRASTRUCTURE.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AuditoriaDeCampoContext _context;
        private readonly IParamPreOffRepository _paramRepository;
        private readonly IPremisasOfflineRepository _premOffRepository;

        public UnitOfWork(AuditoriaDeCampoContext context, IParamPreOffRepository paramRepository, IPremisasOfflineRepository premOffRepository)
        {
            this._context = context;
            this._paramRepository = paramRepository;
            this._premOffRepository = premOffRepository;
        }
        public IPremisasOfflineRepository PremOffRepository => _premOffRepository ?? new PremisasOfflineRepository(_context);

        public IParamPreOffRepository ParamRepository => _paramRepository ?? new ParamPreOffRepository(_context);


        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
