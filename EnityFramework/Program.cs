using EnityFramework.DataAccess1;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        MyStoreContext context = new MyStoreContext();
        List<Product> products = context.Products
                                .Include(prodcut => prodcut.Category)
                                .ToList();

        //create
        //Product product = new Product()
        //{
        //    Id = 100,
        //    CategoryId = 1,
        //    Name = "Hat 1",
        //};

        //context.Products.Add(product); // thêm 1 product vào trong table Product
        //context.SaveChanges();

        // read
        //Product product = context.Products
        //    .FirstOrDefault(pro => pro.Id == 102 && pro.Name.Length > 1);

        // update
        //Product product = context.Products.FirstOrDefault(pro => pro.Id == 102);

        //product.Name = "aaaaaaaaaaaaaaaaaaaaaaaaa";
        //context.Products.Update(product);
        //context.SaveChanges();

        // delete
        //Product product = context.Products.FirstOrDefault(pro => pro.Id == 100);

        //context.Products.Remove(product);
        //context.SaveChanges();
    }
}