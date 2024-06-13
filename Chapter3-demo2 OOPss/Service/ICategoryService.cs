using Chapter3_demo2_OOP.BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_demo2_OOP.Service
{
    internal interface ICategoryService
    {
        public void Insert(Category category);
        public void Update(Category category);
        public void Delete(int categoryId);
        public List<Category> GetCategories();
        public Category GetByID(int categoryId);
    }
}
