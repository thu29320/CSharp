using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public string Lop { get; set; }
        public string MonHoc { get; set; }
        public float Diem { get; set; }

        public  SinhVien()
        {


        }
        public SinhVien(string mssv,string hoTen, string lop,string monHoc,float diem)
        {
            this.MSSV = mssv;
            this.HoTen = hoTen;
            this.Lop = lop;
            this.MonHoc = monHoc;
            this.Diem = diem;
        }

        public void Input()
        {
            Console.Write("MSSV:        ");
            MSSV = Console.ReadLine();
            Console.Write("Ho va Ten:   ");
            HoTen = Console.ReadLine();
            Console.Write("Lop:         ");
            Lop = Console.ReadLine();
            Console.Write("Mon Hoc:     ");
            MonHoc = Console.ReadLine();
            Console.Write("Diem:        ");
            Diem = float.Parse( Console.ReadLine());
            Console.WriteLine("=====================================================");

        }
        public void Output()
        {
            Console.WriteLine("MSSV:      "   + MSSV);
            Console.WriteLine("Ho ten:    " + HoTen);
            Console.WriteLine("Lop:       " + Lop);
            Console.WriteLine("Mon Hoc:   " + MonHoc);
            Console.WriteLine("Diem:      " + Diem);
            Console.WriteLine("=====================================================");


        }
        static void Main(string[] args)
        {
            SinhVien SV1 = new SinhVien();
            SinhVien SV2 = new SinhVien();
            SV1.Input();
            //SV1.Output();
            SV2.Input();
            //SV2.Output();
            if(SV1.Diem>SV2.Diem)
            {
                Console.WriteLine("=====================================================");

                Console.WriteLine("Thong tin sinh vien co diem cao hon la: " );
                SV1.Output();
            }
            else
            {
                Console.WriteLine("=====================================================");

                Console.WriteLine("Thong tin sinh vien co diem cao hon la: ");
                SV2.Output();
            }
        }
    }
}
