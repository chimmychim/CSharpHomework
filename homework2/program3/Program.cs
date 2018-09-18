using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            bool s;
            for(i=2;i<=100;i++)
            {
                s = true;
                for(int j=2;j<i;j++)
                {
                    if (i % j == 0)
                        s = false;
                }
                if (s)
                    Console.WriteLine(i.ToString());
            }
        }
    }
}
