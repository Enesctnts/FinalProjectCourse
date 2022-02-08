using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>where T:class,IEntity,new ()
    {
        List<T> GetALL(Expression<Func<T,bool>> filter = null);
        List<T> GetByAllCategory(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        
    }
}
