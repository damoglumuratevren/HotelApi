using Hotel.Data.Repositories.IRepo;
using Hotel.Data.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Services
{
    public class Services<T> : IService<T> where T : class
    {
        public readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<T> _repository;

        public Services( IUnitOfWork unitOfWork, IRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;   
        }

        public async Task<bool> Add(T entity)
        {
            await _repository.Add(entity);
            await _unitOfWork.SaveAsync();
            return true;
        }

        public bool Delete(string id)
        {
        _repository.Delete(id);
            return true;    
        }

        public async Task<T> Get(string id)
        {
           return await _repository.Get(id);
        }

        public async Task<ICollection<T>> GetAll(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperites = null)
        {
            return await _repository.GetAll(filter, orderBy, includeProperites);    
        }

        public async Task<T> GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperites = null)
        {
            return await _repository.GetFirstOrDefault(filter, includeProperites);  
        }

        public  T Update(T entity)
        {
          var newEntity=  _repository.Update(entity); 
            _unitOfWork.Save();
            return newEntity;
        }

        public T UpdateIsActive(T entity)
        {
            var newEntity = _repository.UpdateIsActive(entity);
            _unitOfWork.Save();
            return newEntity;
        }
    }
}
