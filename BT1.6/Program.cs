using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo p1 = new PhanSo(4,7);
            PhanSo p2 = new PhanSo(3,5);

            PhanSo p3=p1.Cong(p2);
            Console.WriteLine("{0} + {1} = {2}", p1.Display(), p2.Display(), p3.Display());
            Console.Read();
        }
    }
}
