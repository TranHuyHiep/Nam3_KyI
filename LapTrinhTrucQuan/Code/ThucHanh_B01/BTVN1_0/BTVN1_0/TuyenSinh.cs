using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN1_0
{
    internal class TuyenSinh : ThiSinh
    {
        String khuVuc;

        public TuyenSinh() : base()
        {
        }


        public string KhuVuc { get => khuVuc; set => khuVuc = value; }

        public void nhap()
        {
            base.nhap();
            Console.Write("Nhap khu vuc (1, 2, 3): ");
            khuVuc = Console.ReadLine();
        }

        public void xuat()
        {
            base.xuat();
            Console.WriteLine(" | " + khuVuc + " | tong: " + tinhTongDiem());
        }

        public double tinhTongDiem()
        {
            double dKhuVuc = 0;
            if(khuVuc == "2")
            {
                dKhuVuc = 1;
            }
            else if (khuVuc == "3")
            {
                dKhuVuc = 2;
            }
            return base.tinhTongDiem() + dKhuVuc;
        }
    }
}
