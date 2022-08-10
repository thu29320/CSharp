using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so a: ");
            int a =int.Parse( Console.ReadLine());
            Console.Write("nhap so b: ");
            int b = int.Parse(Console.ReadLine());

            if(a==b)
            {
                Console.WriteLine($"{a}={b}.");
            }
            else
            {
                if (a < b)
                {
                    Console.WriteLine($"{a}<{b}.");
                }
                else
                {
                    Console.WriteLine($"{a}>{b}.");
                }
            }
        }
    }
}
