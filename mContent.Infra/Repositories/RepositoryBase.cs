namespace mContent.Infra.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    using mContent.Infra.Data.Context;
    using System.Linq;

    public class RepositoryBase<TEntity> : IDisposable, Domain.Interfaces.Repositories.IRepositoryBase<TEntity>
        where TEntity : class
    {
        protected mContentContext Db = new mContentContext();

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}