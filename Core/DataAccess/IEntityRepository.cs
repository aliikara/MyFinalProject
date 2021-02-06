using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // Generic Constraint --> Jenerik Kısıt.
    // class : Referans Tip Olabilir.
    // IEntity : IEntity Olabilir veya IEntity implemente eden bir nesne olabilir.
    //new() : New'lenebilir olmalı.
    public interface IEntityRepository <T> where T:class , IEntity , new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

       // List<T> GetAllByCategory(int categoryId);
    }
}
