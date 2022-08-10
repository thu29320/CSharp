using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("so {0} la so chan.", n);
            }
            else { Console.WriteLine("so {0} la so le.", n); }
             if (n % 3 == 0)
            {
                Console.WriteLine("so {0} chia het cho 3.", n);
            }
            Console.WriteLine("so {0} khong chia het cho 3.", n);
        }
    }
 }

    
    

