using Chapter3_demo2_OOP.BusinessObjectLayer;
using Chapter3_demo2_OOP.DataAccess;
using Chapter3_demo2_OOP.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_demo2_OOP.Service
{
    internal class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService()
        {
            _categoryRepository = new CategoryRepository();
        }

        public void Delete(int categoryId) => _categoryRepository.Delete(categoryId);

        public Category GetByID(int categoryId) => _categoryRepository.GetByID(categoryId);

        public List<Category> GetCategories() => _categoryRepository.GetCategories();

        public void Insert(Category category) => _categoryRepository.Insert(category);

        public void Update(Category category) => _categoryRepository.Update(category);
    }
}
