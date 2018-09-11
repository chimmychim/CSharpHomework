using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            string b = "";
            int c = 0;
            int d = 0;
            Console.Write("输入一个数: ");
            a = Console.ReadLine();
            c = Int32.Parse(a);
            Console.Write("再输入一个数: ");
            b = Console.ReadLine();
            d = Int32.Parse(b);
            Console.WriteLine("两个数的乘积为: " + c * d);
        }
    }
}
