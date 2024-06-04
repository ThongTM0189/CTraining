using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_collection
{
    internal class GenericClass<T>
    {
        private T data;

        public GenericClass(T value)
        {
            data = value;
        }

        public T GetData()
        {
            return data;
        }

        public void SetData(T value)
        {
            data = value;
        }

        public void swap(ref T a, ref T b)
        {
            T temp = a; 
            a = b; 
            b = temp;
        }
    }
}
