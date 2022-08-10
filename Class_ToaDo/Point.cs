using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ToaDo
{
    class Point
    {
        public int Ox { get; set; }
        public int Oy { get; set; }

        public Point() { }
        public Point(int ox, int oy)
        {
            Ox = ox;
            Oy = oy;
        }
        public double  KhoangCach(Point another)
        {
            return Math.Sqrt(Math.Pow(Ox - another.Ox, 2) + Math.Pow(Oy - another.Oy, 2));
        }
        public string Display()
        {
            return string.Format("({1},{2})", Ox,Oy);
        }
    }
}
