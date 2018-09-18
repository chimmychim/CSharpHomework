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
            string num1 = "";
            int num2 = 0;
            int num3 = 2;
            System.Console.Write("请输入一个整数:");
            num1 = Console.ReadLine();
            num2 = Int32.Parse(num1);
            while ( num3 <= num2)
            {
                if (num2 % num3 == 0)
                {
                    //if(num3==2)
                    //    Console.WriteLine(2);
                    //for(int n=3;num3>n;n++)
                    //    if(num3%n!=0)
                    Console.WriteLine(num3);
                    //else
                    //    Console.WriteLine();
                    num2 = num2 / num3;
                    while (num2 % num3 == 0)
                        num2 = num2 / num3;
                }
                else 
                    num3 ++;
            }
        }
    }
}
