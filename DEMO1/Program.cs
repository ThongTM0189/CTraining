using DEMO1;
using model;
using System.Collections;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

public class Program
{
    private static void Main(string[] args)
    {
        // comment code ctrl + k + c
        // uncomment code ctrl + k + u
        //var name = "string";// xác định datatype lúc khai báo
        //name = "string";

        //// dynamic xác định datatype trong lúc thực thi
        //dynamic name2 = 123; // name2 có datatype là int
        //name2 = "string";// name2 có datatype là string

        //int i = 2;
        //object obj = i; // boxing đưa 1 datatype về dạng object
        //int i2 = (int)obj; // unboxing đưa 1 object về lại 1 datatype
        //boxing(() => { });

        //String interpolation
        //string name = "code c#";
        //int age = 2;
        //Console.WriteLine($"name: {name}, age: {age}");
        // output sẽ là name: code c#, age: 2

        // ref và out
        //  int a = 0;  // bộ nhớ rep3
        //  int b = 0;  // bộ nhớ bx321
        //TestRefOut(a, ref b, out int c);
        // sau khi thực hiện out thì bộ nhớ của c là sd456
        // Console.WriteLine($"{a}, {b}, {c}");
        // ref đc dùng trong trường hợp muốn tương tác với giá trị sẵn có
        // vd: tính tiền lương sau đó update staff
        // out đc dùng trong sử thuật toán tạo ra giá trị mới
        // vd: chuyển từ string qua int
        //Int32.TryParse( "123", out int outputInt );

        // Tuple
        // cho phép 1 hàm trả về nhiều giá trị với nhiều kiểu dữ liệu
        // giảm thiểu được việc tạo ra các class rác
        // var (value1, value2, value3) = testTuple();
        // Console.WriteLine($"{value1}, {value2}, {value3}");
        // trường sử dùng tường là các controller trả về giá trị sau xử lý
        // và trạng thái trong lúc xử lý
        // vd contrller insertUser giá trị trả về là 1 User
        // và 1 trạng thái insert thành công hay không

        // Discard
        // bỏ qua giá trị tương tác, hoặc giá trị trả về out
        // khi không muốn lấy giá trị trả về của mà chỉ cần thuật toán xử lý
        //var test = "";
        // vd: khong cần giá trị sau khi parse
        // mà chỉ cần check có phải số hay không
        //if (int.TryParse(test, out _))
        //{
        //    Console.WriteLine("valid number");
        //}
        //else { 
        //    Console.WriteLine("invalid number"); 
        //}

        // pattern matching
        //is
        //var input = 123;
        //if(input is int)
        //{
        //    Console.WriteLine("valid number");
        //}
        // when
        //switch(input)
        //{
        //    case int n when n > 0:

        //        break;
        //}
        // vd trên tương đương với 2 if 1 là input phải là int 2 là input > 0

        // null-condition
        // cho phép các datatype kh thể null được phép null
        //int? age = null;
        // kiểm tra các giá trị null trước khi thực thi hàm
        //User user = new User();
        //var ar = user?.name?.ToCharArray();
        // nếu user kh null và tên của user kh null thì tạo charArray
        //TestNullCondition(null);

        // primary class
        Class1 user = new(123);
    }

    // null-condition có thể sử dụng cho cả function
    public static int? TestNullCondition(int? age)
    {
        return null;
    }

    public static void DiscardTest(out int number)
    {
        number = 0;
    }
    public static (User, string, int) testTuple()
    {
        return (new User(), "string", 456);
    }

    // mọi tương tác với ref và out sẽ được ghi đè lên bộ nhớ
    public static void TestRefOut(int a, ref int b, out int c)
    {
        a = 1; // r2e343 = 1
        b = 2; // bx321 = 2
        c = 3; // sd456 = 3
    }

    // boxing parameter để linh hoạt giá trị truyền vào
    public static void boxing(object test)// box
    {
        // trước khi xử lý nhớ unboxing
    }
}