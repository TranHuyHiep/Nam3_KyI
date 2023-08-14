using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace THBai1
{
    class HinhChuNhat {
        double dai;
        double rong;

        public double Dai { get => dai; set => dai = value; }
        public double Rong { get => rong; set => rong = value; }

        public HinhChuNhat(double dai, double rong)
        {
            this.dai = dai;
            this.rong = rong;
        }

        public HinhChuNhat()
        {
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap chieu dai: ");
            dai = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            rong = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("chieu dai " + dai.ToString("0.00") + " chieu rong " + rong.ToString("0.00"));
        }

        public double TinhDT()
        {
            return dai * rong;
        }

    }

    class CanHo
    {
        long maPhong;
        HinhChuNhat kichThuoc;
        public CanHo()
        {
            maPhong = 0;
            kichThuoc = new HinhChuNhat();
        }

        public CanHo(long maPhong, HinhChuNhat kichThuoc)
        {
            MaPhong = maPhong;
            KichThuoc = kichThuoc;
            MaPhong = maPhong;
            KichThuoc = kichThuoc;
        }

        public long MaPhong { get => maPhong; set => maPhong = value; }
        internal HinhChuNhat KichThuoc { get => kichThuoc; set => kichThuoc = value; }
        
        public void NhapCanHo()
        {
            Console.WriteLine("Nhap ma phong: ");
            maPhong = long.Parse(Console.ReadLine());
            kichThuoc = new HinhChuNhat();
            kichThuoc.Nhap();
        }
        
        public void XuatCanHo()
        {
            Console.WriteLine("Ma phong: " + maPhong);
            kichThuoc.Xuat();
            Console.WriteLine("Dien tich " + kichThuoc.TinhDT());
        }
    }

    class CanHoNew : CanHo
    {
        string huongBanCong;

        public CanHoNew() : base()
        {
            huongBanCong = "Nam";
        }

        public string HuongBanCong { get => huongBanCong; set => huongBanCong = value; }

        public void NhapCanHoNew()
        {
            base.NhapCanHo();
            Console.WriteLine("Nhap huong ban cong: ");
            huongBanCong = Console.ReadLine();
        }

        public void XuatCanHoNew()
        {
            base.XuatCanHo();
            Console.WriteLine("Huong ban cong: " + huongBanCong);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so can ho: ");
            n = int.Parse(Console.ReadLine());
            CanHoNew[] ch = new CanHoNew[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap can ho thu: " + (i + 1));
                ch[i] = new CanHoNew();
                ch[i].NhapCanHoNew();
            }
            for (int i = 0; i < n; i++)
            {
                ch[i].XuatCanHo();
            }
            double max = ch[0].KichThuoc.TinhDT();
            for(int i = 1; i < n; i++)
            {
                if (max < ch[i].KichThuoc.TinhDT())
                {
                    max = ch[i].KichThuoc.TinhDT();
                }
            }
            Console.WriteLine("\nCan hoc co dien tich max: ");
            for (int i = 1; i < n; i++)
            {
                if (max == ch[i].KichThuoc.TinhDT())
                {
                    ch[i].XuatCanHoNew();
                }
            }

            string huong;
            Console.WriteLine("Nhap huong can ho muon tim: ");
            huong = Console.ReadLine();
            for(int i = 0; i < n; i++)
            {
                if(huong == ch[i].HuongBanCong)
                {
                    ch[i].XuatCanHoNew();
                }
            }
            Console.ReadLine();

        }
    }
}
