using Class_OOP.model2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace account // tượng chugnw cho package tương tự bên java
{
    public class User2 : User
    {
        public static string staticTest1 { get; set; } = "static1";
        public string staticTest2 { get; set; } = "static2";
        public User2() : base() { } // base tương đương với super() bên java

        public int id { get; set; } // tương đương với getter, setter bên java
        public string name { get; set; } = "code123";// default value
        // khi không khai báo thuộc tính này thì mặc có giá trị của DF value

        public string email { get; set; }
    }
}
