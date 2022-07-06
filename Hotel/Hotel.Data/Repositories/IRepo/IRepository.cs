using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Repositories.IRepo
{
    public interface IRepository<T> where T : class
    {
        Task<ICollection<T>> GetAll(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperites = null);

        Task<T> Get(string id);

        Task<T> GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperites = null);


        Task<bool> Add(T entity);

        Task<bool> Update(T entity);

        bool Delete(T entity);

        bool UpdateIsActive(string id);
    }
}
