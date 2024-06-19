using Chapter3_demo2_OOP.BusinessObjectLayer;
using Chapter3_demo2_OOP.Service;
using System;

namespace Chapter3_demo2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            ICategoryService categoryService = new CategoryService();
            do
            {
                PrintMenu();
                option = ChooseOption();
                if (option == 6)
                {
                    Console.WriteLine("Do you wanna quit the program ? 1: yes | 2: no");
                    int quit = ChooseOption(true);
                    if (quit == 1)
                    {
                        break;
                    }
                    continue;
                }

                switch (option)
                {
                    case 1:
                        categoryService.GetCategories().ForEach(x => Console.WriteLine(x));
                        break;
                    case 2:
                        Add(categoryService);
                        break;
                    case 3:
                        Update(categoryService);
                        break;
                    case 4:
                        Delete(categoryService);
                        break;
                    case 5:
                        Console.WriteLine(SearchById(categoryService));
                        break;
                }
            }
            while (true);
        }

        static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Please choose option:");
            Console.WriteLine("1: print all");
            Console.WriteLine("2: add new");
            Console.WriteLine("3: update");
            Console.WriteLine("4: delete");
            Console.WriteLine("5: search by id");
            Console.WriteLine("6: quit");
            Console.WriteLine("--------------------------");
            Console.Write("your option: ");
        }

        static int ChooseOption(bool actionQuit = false) // default value nếu kh có parameter thì mặc định = false
        {
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out int result))
                {
                    // select option menu
                    if (!actionQuit)
                    {
                        if(result > 6 || result < 1)
                        {
                            Console.WriteLine("Please choose option form 1 to 6 !!");
                            continue;
                        }
                        return result;
                    }
                    else// option quit
                    {
                        if (result == 1 || result == 2)
                        {
                            return result;
                        }
                        Console.WriteLine("only choose 1: yes or 2: no");
                        continue;
                    }
                }
                Console.WriteLine("Please just input number, try again!!");
            }
        }
        static void tryqweqwe(ref Category result)
        {

        }
        static void tryPareInt(ref int result)
        {
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out result)) //"123"
                {
                    if (result < 0)
                    {
                        Console.WriteLine("Number should not negative!!");
                        continue;
                    }
                    break;
                }
                Console.WriteLine("Please just input number, try again!!");
            }
        }

        static void Add(ICategoryService service)
        {
            int id = 0;
            while (true)
            {
                Console.Write("Category ID: ");
                tryPareInt(ref id);
                Category checCategory = service.GetByID(id);
                if (checCategory != null)
                {
                    Console.WriteLine("ID was existed");
                    continue;
                }
                break;
            }
            Console.Write("Category Name: ");
            string name = Console.ReadLine();
            Category category = new Category { Id = id, Name = name };
            service.Insert(category);
        }

        static void Update(ICategoryService service)
        {
            int id = 0;
            while (true)
            {
                Console.Write("Category ID: ");
                tryPareInt(ref id);
                Category category = service.GetByID(id);
                if (category != null)
                {
                    Console.Write("Category Name to update: ");
                    category.Name = Console.ReadLine();
                    service.Update(category);
                    break;
                }

                Console.WriteLine("Category is not existed, try again!! ");
            }
        }

        static void Delete(ICategoryService service)
        {
            int id = 0;
            while (true)
            {
                Console.Write("Category ID: ");
                tryPareInt(ref id);
                Category category = service.GetByID(id);
                if (category != null)
                {
                    service.Delete(id);
                    break;
                }
                Console.WriteLine("ID is not existed, ttry again!! ");
            }
        }

        static Category SearchById(ICategoryService service)
        {
            int id = 0;
            while (true)
            {
                Console.Write("Category ID: ");
                tryPareInt(ref id);
                Category category = service.GetByID(id);
                if (category != null)
                {
                    return category;
                }
                Console.WriteLine("ID is not existed, ttry again!! ");
            }
        }
    }
}
