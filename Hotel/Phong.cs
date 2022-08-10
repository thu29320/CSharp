using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Phong
    {
        public string MaPhong { get; set; }
        public string TenPong { get; set; }
        public double GiaTien { get; set; }
        public int Tang { get; set; }
        public int SucChua { get; set; }//so nguoi o toi da

        public Phong()
        {

        }
        public Phong(string maPhong, string tenPhong, double giaTien, int tang, int sucChua)
        {
            this.MaPhong = maPhong;
            this.TenPong = tenPhong;
            this.GiaTien = giaTien;
            this.Tang = tang;
            this.SucChua = sucChua;
        }
        public void Input()
        {
            Console.Write("Nhap thong tin Phong: ");
            Console.WriteLine("Nhap ma Phong: ");
            MaPhong = Console.ReadLine();
            Console.Write("Ten Phong: ");
            TenPong = Console.ReadLine();
            Console.Write("Gia Tien: ");
            GiaTien = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Tang: ");
            Tang = int.Parse(Console.ReadLine());
            Console.WriteLine("So nguoi co the o: ");
            SucChua = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"Ma Phong: {MaPhong},  Ten Phong:  {TenPong},  Tang:  {Tang},  " +
                $"Gia Tien:  {GiaTien},   Suc Chua: {SucChua}");
        }

    }
}
