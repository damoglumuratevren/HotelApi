﻿using Hotel.Data.Repositories.IRepo;
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

        public Task<bool> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
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

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }

        public T UpdateIsActive(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
