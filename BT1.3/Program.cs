using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int tong = a + b;
            int hieu = a - b;
            int tich = a * b;
            float thuong =(float) a / b;
            
            Console.WriteLine($"Tong cua so {a} va {b} la: "+tong);
            Console.WriteLine($"Hieu cua so {a} va {b} la: "+ hieu);
            Console.WriteLine($"Tich cua so {a} va {b} la: "+tich);

            if (b != 0)
            {
                
                Console.WriteLine($"Tich cua so {a} va {b} la: "+ thuong);
            }
            else
            {
                Console.WriteLine("so chia =0, ko hop le.");
            }

        }
    }
}
