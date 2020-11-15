using SIAC.CORE.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SIAC.CORE.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task Add(T entity);
        Task Delete(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByID(int ID);
        void Update(T Entity);
    }
}