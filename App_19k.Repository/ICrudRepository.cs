using System;
using System.Collections.Generic;
using System.Text;

namespace App_19k.Repository
{
    public interface ICrudRepository<T>
    {
        bool Save(T entity);
        bool Update(T entity);
        bool Delete(int id);
        IEnumerable<T> GetAll();
        T Get(int id);
    }
}
