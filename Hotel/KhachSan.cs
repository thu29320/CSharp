using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class KhachSan
    {
        int i;
        public string MaKS { get; set; }
        public string TenKS { get; set; }
        public string DiaChi { get; set; }
        public string LoaiKS { get; set; }
        public List<Phong> DanhSachPhong {get; set;}

        
        public KhachSan(string maKS, string tenKS, string diaChi, string loaiKS ,string[] danhSachPhong)
        {
            this.MaKS = maKS;
            this.TenKS = tenKS;
            this.DiaChi = diaChi;
          this.LoaiKS = loaiKS;
           
        }
        public void Input()
        {
            Console.Write("Nhap thong tin khach san: ");
            Console.WriteLine("Nhap na Khach San: ");
            MaKS = Console.ReadLine();
            Console.Write("Ten Khach San: ");
            TenKS = Console.ReadLine();
            Console.WriteLine("Nhap Dia Chi: ");
            DiaChi = Console.ReadLine();
            Console.WriteLine("Nhap Loai Khach San: ");
            LoaiKS = Console.ReadLine();
            Console.WriteLine("Nhap Danh Sach Phong: ");
            DanhSachPhong[i] = Console.ReadLine();
        }
        public void Output()
        {

        }
    }
}
