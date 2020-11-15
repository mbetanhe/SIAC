using Microsoft.EntityFrameworkCore;
using SIAC.CORE.Entities;
using SIAC.CORE.Interfaces;
using SIAC.INFRASTRUCTURE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAC.INFRASTRUCTURE.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AuditoriaDeCampoContext _context;
        protected readonly DbSet<T> _entity;

        public BaseRepository(AuditoriaDeCampoContext context)
        {
            _context = context;
            _entity = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            //Obtenemos el resultado ejecutando una tarea.
            IEnumerable<T> Resultado = await Task.Run(() =>
            {
                return _entity.AsEnumerable().Take(10);
            });

            return Resultado;
        }

        public async Task<T> GetByID(int ID)
        {
            return await _entity.FindAsync(ID);
        }

        public async Task Add(T entity)
        {
            _entity.Add(entity);
            await _context.SaveChangesAsync();
        }

        public void Update(T Entity)
        {
            _entity.Update(Entity);
        }

        public async Task Delete(int id)
        {
            var res = await GetByID(id);
            _entity.Remove(res);

            await _context.SaveChangesAsync();
        }
    }
}
