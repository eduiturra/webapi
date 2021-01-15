using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace webapi.data.Respositories
{
    public interface IRepositorioGenerico<T>
     where T : class
    {
        void Add(T entity);
        void AddRange(System.Collections.Generic.IEnumerable<T> entities);
        System.Collections.Generic.IEnumerable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        T Get(int? id);
        T GetCodigo(string id);
        T GetGuid(Guid id);
        System.Collections.Generic.IEnumerable<T> GetAll();
        void Remove(T entity);
        void RemoveRange(System.Collections.Generic.IEnumerable<T> entities);
        void Update(T entity);
        Task<IEnumerable<T>> FindByAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
    }
}