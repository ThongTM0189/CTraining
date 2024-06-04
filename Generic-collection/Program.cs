using System.Collections;

namespace Generic_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name1 = "name 1", name2 = "name 2";
            //GenericClass<string> genericString = new GenericClass<string>("Name");
            //Console.WriteLine(genericString.GetData());
            //genericString.swap(ref name1, ref name2);

            //int num1 = 1, num2 = 2;
            //GenericClass<int> genericInt = new GenericClass<int>(123);
            //Console.WriteLine(genericInt.GetData());
            //genericInt.swap(ref num1, ref num2);

            //GenericClass<User> genericUser = new GenericClass<User>(new User());
            //Console.WriteLine(genericUser.GetData());

            List<string> list = new List<string>();
            ICollection<string> collection = new List<string>();
            IEnumerable<double> enumerable = new List<double>();
            Dictionary<int, string> keys = new Dictionary<int, string>();
            LinkedList<string> strings = new LinkedList<string>();
            // tìm tất cả các phần từ = "123" đưa vào 1 list mới
            collection.Where(item => item.Equals("123")).ToList(); // làm chức năng search in table
            // lệnh LINQ trên tương đương tới foreach dưới đây
            List<string> newlist = new List<string>();
            foreach (var item in list)
            {
                if (item.Equals("123"))
                {
                    newlist.Add(item);
                }
            }

            // tìm phần từ đầu tiên = "123"
            string find = collection.First(item => item.Equals("123"));
            // tìm phần từ đầu tiên = "123" nếu không có trả về null
            string find1 = collection.FirstOrDefault(item => item.Equals("123"));// làm chức năng detail

            // sort lại list theo id tăng dần
            ICollection<User> users = new List<User>();
            var sort1 = users.OrderBy(item => item.Id).ToList();
            // sort lại list theo name giảm dần
            var sort2 = users.OrderBy(item => item.Name).Reverse().ToList();
            // trả về 1 mảng sau khi bỏ qua 3 phần tử đầu tiên
            var newL = users.Skip(3);
            // bỏ qua 3 phần từ và chỉ lấy 3 phần tử tiếp theo
            var newL1 = users.Skip(3).Take(3);
            // áp dụng làm phân trang
            int numberOfItem = 10;                          // lúc này trong cache tạo ra 1 vùng nhớ cho biến
            int currentPage = 1; // index từ 0              // lúc này trong cache tạo ra 1 vùng nhớ cho biến
            int skipItem = numberOfItem * currentPage;

            var paging = users.Skip(skipItem).Take(numberOfItem);


            string name = "123"; // lúc này trong cache tạo ra 1 vùng nhớ cho name
            User user1 = new User()
            {
                Id = 1,
                Name = "123"
            };
            User user2 = user1;
        }
    }
}
