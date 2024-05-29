
using account;

internal class Program
{
    private static void Main(string[] args)
    {
       User2 sutdent = new User2();
        // nếu gọi thuộc tính sau dấu = thì nó là getter, cont trước là setter
        // string name = user2.email; // getter
        // sau khi gọi getter thì hàm get của attribute sẽ được thực thi
        // user2.email = "123"; // setter
        // với setter cũng tương tự như getter
        // user2.email = "setter"
        // thì ở đây giá trị "setter" là giá trị của value trong hàm set
        // giá trị value trong set là giá trị đứng sau dấu = của setter

        //Console.WriteLine(user2.email);
        //Console.WriteLine(user2.email);
        // output: code123, 1


        // is và as cho class
        // is dùng để kiểm tra datatype của 1 biến
        //if (sutdent is User2)
        //{ 
        //    Console.WriteLine("User2"); 
        //}
        //else 
        //{ 
        //    Console.WriteLine("kh phai User2"); 
        //}
        // as lệnh gán/ép kiểu dữ liệu cho 1 biến
        // chú ý: nếu ép kiểu phải cùng cấp độ (số với số, object với object)
        //object n = "123"; // ban đầu đang là 1 object 
        //User2 user = n as User2;// object này được gán thành kiểu User2
        // khi ép kiểu kh chỉ ép mỗi datatype mà còn ép cả giá trị của biến
        // ở đây kh thể ép "123" thành giá trị User2 được nên sẽ null
        // đối với kiểu số kh thể có giá trị null
        // nên ta ép kiểu theo bth (int)double
        Console.WriteLine(User2.staticTest1);
        Console.WriteLine(sutdent.staticTest2);
    }
    // 2 hàm tương đương nhau
    // => tương ứng mới chữ return
    public int test2(int a, int b) => a + b;
    public int test(int a, int b)
    {
        return a + b;
    }
}