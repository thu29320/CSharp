using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("nhap so c: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("nhap so d: ");
            int d = int.Parse(Console.ReadLine());
            

            if (a == b&&b == c&&c == d)
            {
                Console.WriteLine("ko co so nho nhat.");

            }
            else
            { int min = a;

                if(a>b)
                {
                    min = b;
                }
                if (b > c)
                {
                    min = c;
                }
                if (c > d)
                {
                    min = d;
                }
                Console.WriteLine("So nho nhat la:" +min);
            }
        }
    }
}
