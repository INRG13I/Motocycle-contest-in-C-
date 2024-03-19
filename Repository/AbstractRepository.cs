using Motocycle_contest.Domain;

namespace Motocycle_contest.Repository;

using System;
using System.Collections.Generic;

public class AbstractRepository<T, ID> : Repository<T, ID> where T : Identifier<ID>
{
    protected Dictionary<ID, T> elem;

    public AbstractRepository()
    {
        elem = new Dictionary<ID, T>();
    }

    public void Add(T el)
    {
        if (elem.ContainsKey(el.GetId()))
        {
            throw new InvalidOperationException("Element already exists!!!");
        }
        else
        {
            elem.Add(el.GetId(), el);
        }
    }

    public void Delete(T el)
    {
        if (elem.ContainsKey(el.GetId()))
        {
            elem.Remove(el.GetId());
        }
    }

    public void Update(T el, ID id)
    {
        if (elem.ContainsKey(id))
        {
            elem[id] = el;
        }
        else
        {
            throw new InvalidOperationException("Element doesn’t exist");
        }
    }

    public T FindById(ID id)
    {
        if (elem.ContainsKey(id))
        {
            return elem[id];
        }
        else
        {
            throw new InvalidOperationException("Element doesn't exist");
        }
    }

    public IEnumerable<T> FindAll()
    {
        return elem.Values;
    }

    public ICollection<T> GetAll()
    {
        return elem.Values;
    }
}
