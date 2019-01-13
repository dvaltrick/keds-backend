using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace keds.DAO
{
    interface IDao<T>
    {
        T add(T toAdd);

        T update(T toUpdate);

        void delete(Guid toDelete);

        T find(Guid toFind);

        IEnumerable<T> findAll();
    }
}
