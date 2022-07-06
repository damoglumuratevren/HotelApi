using Hotel.Data.Repositories.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Repositories.Repo
{
    public class Repository<T> : IRepository<T> where T : class MyClass
    {
        public Task<bool> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<T>> GetAll(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperites = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperites = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }

        public bool UpdateIsActive(string id)
        {
            throw new NotImplementedException();
        }
    }
    {
    }
}
