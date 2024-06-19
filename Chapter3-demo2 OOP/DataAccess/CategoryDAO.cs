using Chapter3_demo2_OOP.BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_demo2_OOP.DataAccess
{
    internal class CategoryDAO
    {
        private static List<Category> categories = new List<Category>()
        {
            new Category{Id = 1, Name= "cate 1"},
            new Category{Id = 2, Name= "cate 2"},
            new Category{Id = 3, Name= "cate 3"},
            new Category{Id = 4, Name= "cate 4"},
        };

        public CategoryDAO() { }
        public static List<Category> GetCategories()
        {
            return categories;
        }

        public static void Insert(Category category)
        {
            categories.Add(category);
        }

        public static Category GetByID(int categoryID)
        {
            return categories.FirstOrDefault(x => x.Id == categoryID);
        }

        public static void Delete(int categoryID)
        {
            Category category = GetByID(categoryID);
            if (category != null)
            {
                categories.Remove(category);
            }
        }

        public static void Update(Category categoryUpdate)
        {
            categories.ForEach(cate =>
            {
                if (cate.Id == categoryUpdate.Id)
                {
                    cate.Name = categoryUpdate.Name;
                    return;
                }
            });
        }
    }
}
