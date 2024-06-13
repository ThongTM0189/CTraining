using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_demo2_OOP.BusinessObjectLayer
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Category: ID = {this.Id}, Name = {this.Name}";
        }
    }
}
