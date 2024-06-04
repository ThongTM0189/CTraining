namespace Collection_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ta khai báo 1 Gen với datatype là string
            Gen<string> genString = new Gen<string>();
            // tương ứng với các kiểu generic cũng là string public T getValue(T value)
            string test1 = genString.getValue("code 123");

            Gen<int> genInteger = new Gen<int>();
            int test2 = genInteger.getValue(123);

            Gen<int> genInt = new Gen<int>();
            Gen<double> genDouble = new Gen<double>();
            double test3 = genDouble.getValue(123.0d);

            Gen<float> genFloat = new Gen<float>();
            float test4 = genFloat.getValue(123.0f);
        }
    }
}
