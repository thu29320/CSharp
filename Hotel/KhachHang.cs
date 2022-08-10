using System;
using static System.Console;
namespace KhachSan
{
    
    class KhachHang
    {
        public string CMND { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string GioiTinh { get; set; }
        public string QueQuan { get; set; }

        public KhachHang()
        {

        }
        public KhachHang(string cmnd, string hoTen, int tuoi,string gioiTinh,string queQuan)
        {
            this.CMND = cmnd;
            this.HoTen = hoTen;
            this.Tuoi = tuoi;
            this.GioiTinh = gioiTinh;
            this.QueQuan = queQuan;
        }
        public void Input()
        {
            Console.Write("Nhap thong tin khach hang: ");
            Console.WriteLine("Nhap so CMND: ");
            CMND = Console.ReadLine();
            Console.Write("Ho va Ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap Tuoi: ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Gioi Tinh: ");
            GioiTinh = Console.ReadLine();
            Console.WriteLine("Nhap Que Quan: ");
            QueQuan = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine("Thong tin khach hang: ");
            Console.Write("Ho va Ten: ",HoTen);
            Console.WriteLine(" so CMND: ", CMND);
            Console.WriteLine(" Tuoi: ",Tuoi);
            Console.WriteLine(" Gioi Tinh: ",GioiTinh);
            Console.WriteLine(" Que Quan: ",QueQuan);



        }
    }
}
