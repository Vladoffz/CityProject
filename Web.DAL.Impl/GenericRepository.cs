using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Web.DAL.Abstract;
using Web.Entities;

namespace Web.DAL.Impl
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly WebContext _dataContext;

        public GenericRepository(WebContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void DeleteEntity(T entity)
        {
            _dataContext.Set<T>().Remove(entity);
            _dataContext.SaveChanges();
        }

        public void DeleteEntity(int id)
        {
            this.DeleteEntity(this.GetEntity(id));
        }

        public T GetEntity(int  id)
        {
            return _dataContext.Set<T>().Find(id);
        }

        public void InsertEntity(T entity)
        {
            _dataContext.Set<T>().Add(entity);
            _dataContext.SaveChanges();
        }

        public IList<T> ListEntities()
        {
            return _dataContext.Set<T>().ToList();
        }

        public IList<T> ListEntities(Expression<Func<T, bool>> expression)
        {
            return _dataContext.Set<T>().Where(expression).ToList();
        }

        public void UpdateEntity(T entity)
        {
            _dataContext.Entry<T>(entity).State = EntityState.Modified;
            _dataContext.SaveChanges();
        }

    }
}
