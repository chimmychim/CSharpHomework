using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 7, 3, 1, 5, 8, 4, 2, 9, 6 };
            int n = 0;
            for (int i = 0; i < 8; i++)
            {
                if (a[i] > a[i + 1])
                {
                    n = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = n;
                }
            }
            Console.WriteLine("最大值为"+a[8]);

            for (int i = 0; i < 8; i++)
            {
                if (a[i] < a[i + 1])
                {
                    n = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = n;
                }
            }
            Console.WriteLine("最小值为" + a[8]);

            int s = 0;
            for (int i = 0; i < 9; i++)
            {
                s += a[i];
            }
            Console.WriteLine("和为" + s);

            double x = 0;
            double y = 0;
            y = Convert.ToDouble(s);
            x = y / 9;
            Console.WriteLine("平均数为" + x);
        }
    }
}
