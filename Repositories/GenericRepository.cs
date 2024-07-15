using System.Linq.Expressions;
using efapi.Data;
using efapi.Interfaces;

namespace efapi.Repositories;

public class GenericRepository<T>(DataContext context) : IGenericRepository<T>
    where T : class
{
    public void Add(T entity)
    {
       context.Set<T>().AddAsync(entity);
    }

    public void AddRange(IList<T> entities)
    {
        context.Set<T>().AddRangeAsync(entities);
    }

    public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {
        return context.Set<T>().Where(expression);
    }   

    public IEnumerable<T> GetAll()
    {
        return context.Set<T>().ToList();
    }

    public T? GetById(string id)
    {
        return context.Set<T>().Find(id);
    }

    public void Remove(T entity)
    {
        context.Set<T>().Remove(entity);
    }

    public void RemoveRange(IList<T> entities)
    {
        context.Set<T>().RemoveRange(entities);
    }
}
