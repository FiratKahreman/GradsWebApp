using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Repository.IRepositories
{
        public interface IGenericRepository<TEntity> where TEntity : class
        {
            Task<List<TEntity>> GetAllAsync();
            Task<TEntity?> GetByIdAsync(int id);
            Task<TEntity?> GetByFilterAsync(Expression<Func<TEntity, bool>> filter);
            Task CreateAsync(TEntity entity);
            Task UpdateAsync(TEntity entity);
            Task RemoveAsync(TEntity entity);
        }
}
