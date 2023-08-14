using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN1_0
{
    internal class ThiSinh
    {
        String sbd;
        String hoTen;
        double m1, m2, m3;

        public ThiSinh()
        {
        }

        public ThiSinh(string sbd, string hoTen, double m1, double m2, double m3)
        {
            this.Sbd = sbd;
            this.HoTen = hoTen;
            this.M1 = m1;
            this.M2 = m2;
            this.M3 = m3;
        }

        public string Sbd { get => sbd; set => sbd = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public double M1 { get => m1; set => m1 = value; }
        public double M2 { get => m2; set => m2 = value; }
        public double M3 { get => m3; set => m3 = value; }

        public void nhap()
        {
            Console.Write("Nhap so bao danh: ");
            sbd = Console.ReadLine();
            Console.Write("Nhap ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap diem m1: ");
            m1 = Double.Parse(Console.ReadLine());
            Console.Write("Nhap diem m2: ");
            m2 = Double.Parse(Console.ReadLine());
            Console.Write("Nhap diem m3: ");
            m3 = Double.Parse(Console.ReadLine());
        }

        public double tinhTongDiem()
        {
            return m1 + m2 + m3;
        }

        public void xuat()
        {
            Console.Write(sbd + " | " + hoTen + " | " + m1 + " | " + m2 + " | " + m3);
        }
    }
}
