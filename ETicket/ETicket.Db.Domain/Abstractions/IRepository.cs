﻿
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Threading.Tasks;
using ETicket.Db.Domain.Entities;
using System.Threading;

namespace ETicket.Db.Domain.Abstractions
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task<TEntity> FindAsync(CancellationToken cancellationToken, params object[] keyValues);

        void Add(TEntity item);

        void Update(TEntity item);

        void Delete(TEntity item);

        void DeleteRange(IEnumerable<TEntity> items);

        IQueryable<TEntity> Queryable(params Expression<Func<TEntity, object>>[] includeProperties);

        IQueryable<TEntity> Queryable(string[] includeProperties);

    }
}