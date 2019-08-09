using DataAccess.RepositoriesInterfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.UnitOfWorksInterfaces
{
   public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        TContext DbContext { get; }

        IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : Entity;

        int ExecuteSqlCommand(string sql, params object[] parameters);
        IQueryable<TEntity> FromSql<TEntity>(string sql, params object[] parameters) where TEntity : Entity;
        void Save();
    }
}
