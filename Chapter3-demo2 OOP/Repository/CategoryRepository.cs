using Chapter3_demo2_OOP.BusinessObjectLayer;
using Chapter3_demo2_OOP.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_demo2_OOP.Repository
{
    internal class CategoryRepository : ICategoryRepository
    {
        public void Delete(int categoryId) => CategoryDAO.Delete(categoryId);

        public Category GetByID(int categoryId) => CategoryDAO.GetByID(categoryId);

        public List<Category> GetCategories() => CategoryDAO.GetCategories();

        public void Insert(Category category) => CategoryDAO.Insert(category);

        public void Update(Category category) => CategoryDAO.Update(category);
    }
}
