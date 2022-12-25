using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        public static void ChuanHoa(string s)
        {
            s = s.Trim();  // Xóa đầu cuối
            Regex trimmer = new Regex(@"\s\s+"); // Xóa khoảng trắng thừa trong chuỗi
            s = trimmer.Replace(s, " ");
            Console.Write(s);
        }
        static void Main(string[] args)
        {
            ChuanHoa("\"                                           tran                                                                                                         ");
            Console.ReadKey();
        }
    }
}
