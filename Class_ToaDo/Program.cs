using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ToaDo
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5,5);
            Point p2 = new Point(7,7);

            double kc = p1.KhoangCach(p2);
            Console.WriteLine("kc: "+ kc);
            Console.ReadKey();
        }
    }
}
