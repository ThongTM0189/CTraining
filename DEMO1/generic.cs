using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO1
{
    internal class generic<A> where A : IEnumerable<A>
    {
        public A valueA { get; set; }
        public A valueB { get; set; }
        public generic() { }
        public A getValue(A value)
        {
            return valueA;
        }
    }
}
