using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO1
{
    public abstract class MainDAO<T>
    {
        public List<T> lists = new List<T>();
        public MainDAO() { }
        public void create(T entity) 
        {
            lists.Add(entity);
        }
        public virtual void Update(T entity) { }
        public void delete(T entity) 
        { 
            lists.Remove(entity);
        }
        public virtual T getById(int id) { throw new Exception(); }

        
    }
}
