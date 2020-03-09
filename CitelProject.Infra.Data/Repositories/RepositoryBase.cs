using CitelProject.Domain.Interfaces.Repositories;
using CitelProject.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CitelProject.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected DataContext _db = new DataContext();

        public void Add(TEntity obj)
        {
            _db.Set<TEntity>().Add(obj);
            _db.SaveChanges();
        }

        public void Dispose()
        {
            
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _db.Set<TEntity>()
                .AsNoTracking()
                .ToList();
        }

        public TEntity GetById(int id)
        {
            return _db.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            _db.Set<TEntity>().Remove(obj);
            _db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _db.Entry(obj).State = EntityState.Modified;
            _db.SaveChanges();

        }
    }
}
