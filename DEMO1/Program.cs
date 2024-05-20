using DEMO1;
using model;
using System.Collections;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

public class Program
{
    private static void Main(string[] args)
    {
        User user = new User();
        for (int i = 0; i < 10; i++)
        {
            user.lists.Add(new User()
            {
                id = i,
                name = $"Test {i}",
                email = $"Test{i}@gmail.com",
                classRoom = $"Class {i}",
                age = i * 5,
            });
        }

        // create
        user.create(new User()
        {
            id = user.lists.Count,
            name = $"Test {user.lists.Count}",
            email = $"Test{user.lists.Count}@gmail.com",
            classRoom = $"Class {user.lists.Count}",
            age = user.lists.Count * 5,
        });


        // search
        //string name = Console.ReadLine();
        //string email = Console.ReadLine();

        //User user1 = user.lists.FirstOrDefault(x => x.name == name && x.email == email);
        //if(user1 != null) { Console.WriteLine(user1.ToString()); }

        // collection
        do
        {
            bool checkInputId = Int32.TryParse(Console.ReadLine(), out int conditionId);
            bool checkInputAge = Int32.TryParse(Console.ReadLine(), out int conditionAge);
            if (!checkInputId || !checkInputAge)
            {
                Console.WriteLine("please input number");
                continue;
            }

            List<User> user1 = user.lists
            .Where(x => x.id > conditionId && x.age > conditionAge).ToList();

            foreach (var item in user1)
            {
                Console.WriteLine(item.ToString());
            }
            break;
        } while (true);
    }
}