using System.Linq.Expressions;

namespace efapi.Interfaces;

public interface IGenericRepository<T> where T : class
{
    T GetById(string id);
    IList<T> GetAll();
    IList<T> Find(Expression<Func<T, bool>> expression);
    void Add(T entity);
    void AddRange(IList<T> entities);
    void Remove(T entity);
    void RemoveRange(IList<T> entities);
}
