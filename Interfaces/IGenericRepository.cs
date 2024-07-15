using System.Linq.Expressions;

namespace efapi.Interfaces;

public interface IGenericRepository<T> where T : class
{
    T? GetById(string id);
    IEnumerable<T> GetAll();
    IEnumerable<T> Find(Expression<Func<T, bool>> expression);
    void Add(T entity);
    void AddRange(IList<T> entities);
    void Remove(T entity);
    void RemoveRange(IList<T> entities);
}
