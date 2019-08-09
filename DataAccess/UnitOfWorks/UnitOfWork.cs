using DataAccess.Repositories;
using DataAccess.RepositoriesInterfaces;
using DataAccess.UnitOfWorksInterfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.UnitOfWorks
{
   public class UnitOfWork<TContext>: IUnitOfWork<TContext> where TContext : DbContext
    {
        private readonly TContext _context;
        private bool disposed = false;
        private Dictionary<Type, object> _repositories;
        
        public UnitOfWork(TContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public TContext DbContext => _context;
        public IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : Entity
        {
            if(_repositories == null)
            {
                _repositories = new Dictionary<Type, object>();
            }
            var type = typeof(TEntity);
            if(!_repositories.ContainsKey(type))
            {
                _repositories[type] = new GenericRepository<TEntity>(_context);
            }
            return (IGenericRepository<TEntity>)_repositories[type];
        }
        public int ExecuteSqlCommand(string sql, params object[] parameters) => _context.Database.ExecuteSqlCommand(sql, parameters);
        public IQueryable<TEntity> FromSql<TEntity>(string sql, params object[] parameters) where TEntity : Entity
        {
           return (IQueryable<TEntity>)_context.Set<Entity>().FromSql(sql, parameters);
        }
        public int Save()
        {
           return _context.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if (disposing)
                {
                    _repositories.Clear();
                    _context.Dispose();
                }
                this.disposed = true;

            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }
    }
}
