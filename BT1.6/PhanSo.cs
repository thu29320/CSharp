using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1._6
{
    class PhanSo
    {
        private int TuSo { get; set; }
        int mauSo;
        private int MauSo { get=>mauSo;
            set => mauSo = value != 0 ? value : 1;
             }
        public PhanSo() { }

       public PhanSo(int tu, int mau)
        {
            TuSo = tu;
            MauSo = mau;
        }
        public PhanSo Cong(PhanSo another)
        {
            PhanSo result = new PhanSo();
            result.TuSo = TuSo * another.MauSo + MauSo * another.TuSo;
            result.MauSo = MauSo * another.MauSo;
            return result;
        }
        public string Display()
        {
            return string.Format("{0}/{1}", TuSo, MauSo);
        }
    }
}
