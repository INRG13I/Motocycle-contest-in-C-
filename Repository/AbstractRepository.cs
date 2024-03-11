using Motocycle_contest.Domain;

namespace Motocycle_contest.Repository;

public abstract class AbstractRepository<T> : IRepository<T> where T : IEntity
{
    protected List<T> entityList = new List<T>();
    public T GetById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Add(T entity)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }
}