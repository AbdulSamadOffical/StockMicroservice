﻿using Stock.Domain.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Infrastructure.Persistence.Repository
{
    public class InMemoryGenericRepository<T> : IGenericRepository<T> where T : class
    {
        void IGenericRepository<T>.Add(T entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IGenericRepository<T>.Find(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IGenericRepository<T>.GetAll()
        {
            throw new NotImplementedException();
        }

        T IGenericRepository<T>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<T>.Remove(T entity)
        {
            throw new NotImplementedException();
        }

        void IGenericRepository<T>.RemoveRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
