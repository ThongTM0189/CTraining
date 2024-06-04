using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_collection
{
    public class DesignPatterns
    {
        // Design Patterns là 1 cấu trúc chung do các nhà lập trình đã phát triển
        // áp dụng cấu trúc Design Patterns giúp code nhanh hơn, logic hơn, giải quyết được 1 số vấn đề chung

        // ưu điểm: dễ tiếp cận, giúp người code và người đọc code dễ hiểu, làm cho code của mình linh hoạt hơn
        // dễ bảo trì dự án, hoặc bàn giao dự án, đỡ tốn time đọc code, tiết kiệm tiền dự án
        // nhược điểm: khá nhiều để và áp dụng thì khó cho người mới, dễ nản

        private static DesignPatterns _instence;
        private DesignPatterns() { }

        public static DesignPatterns Instence { 
            get 
            {
                if(_instence == null)
                {
                    _instence = new DesignPatterns(); // ổ nhớ xlm123
                }
                return _instence; // trả ổ nhớ xlm123
            }
            private set { } 
        }
    }
}
