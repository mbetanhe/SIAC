using SIAC.CORE.Entities.Premisas;
using SIAC.CORE.Interfaces;
using System.Threading.Tasks;

namespace SIAC.CORE.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<ParamAuditPremOff> ParamRepository { get; }
        IPremisasOfflineRepository PremOffRepository { get; }

        void Dispose();
        void SaveChanges();
        Task SaveChangesAsync();
    }
}