using System.Net.Sockets;
using Motocycle_contest.Domain;

namespace Motocycle_contest.Repository;

using System.Collections.Generic;

public interface Repository<T, Tid> where T : Identifier<Tid>
{
    void Add(T elem);
    void Delete(T elem);
    void Update(T elem, Tid id);
    T FindById(Tid id);
    IEnumerable<T> FindAll();
    ICollection<T> GetAll();
}

