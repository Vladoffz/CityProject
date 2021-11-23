using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Web.DAL.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        T GetEntity(int id);
        IList<T> ListEntities();
        IList<T> ListEntities(Expression<Func<T, bool>> expression);
        void InsertEntity(T entity);
        void UpdateEntity(T entity);
        void DeleteEntity(T entity);
        void DeleteEntity(int id);
    }
}
