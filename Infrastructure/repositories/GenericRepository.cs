using System.Linq.Expressions;
using Core.entities;
using Core.interfaces;
using Infrastructure.Data;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private readonly PharmaInvenContext _context;

    public GenericRepository(PharmaInvenContext context)
    {
        _context = context;
    }

    public virtual void Add(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual void AddRange(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(T entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }
}
