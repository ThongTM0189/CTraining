using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Generic
{
    internal interface DAO<T>
    {
        public T Get(int id);
        public T Update(T entity);
        public T Delete(int id);
        public IEnumerable<T> GetAll();
    }
}
