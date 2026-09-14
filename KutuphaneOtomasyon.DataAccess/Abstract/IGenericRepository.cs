using KutuphaneOtomasyon.Entities.Abstract;
using KutuphaneOtomasyon.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KutuphaneOtomasyon.DataAccess.Abstract
{
    public interface IGenericRepository<T> where T:BaseEntity,IEntity
    {
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
