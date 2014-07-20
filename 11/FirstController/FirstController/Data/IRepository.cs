using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace FirstController.Data
{
    public interface IRepository<T>
    {
        IQueryable<T> All();

        bool Any(Expression<Func<T, bool>> predicate);

        int Count { get; }

        T Create(T t);

        int Delete(T t);

        T Find(Expression<Func<T, bool>> predicate);

        IQueryable<T> FindAll(Expression<Func<T, bool>> predicate);

        int Update(T t);
    }
}