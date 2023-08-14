using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN1_1
{
    internal class SinhVien
    {
        String hoTen;
        String ngaySinh;
        double dLapTrinh;
        double dCoSoDuLieu;
        double dThietKeWeb;

        public SinhVien()
        {
        }

        public SinhVien(string hoTen, string ngaySinh, double dLapTrinh, double dCoSoDuLieu, double dThietKeWeb)
        {
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.DLapTrinh = dLapTrinh;
            this.DCoSoDuLieu = dCoSoDuLieu;
            this.DThietKeWeb = dThietKeWeb;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public double DLapTrinh { get => dLapTrinh; set => dLapTrinh = value; }
        public double DCoSoDuLieu { get => dCoSoDuLieu; set => dCoSoDuLieu = value; }
        public double DThietKeWeb { get => dThietKeWeb; set => dThietKeWeb = value; }
        
        public Boolean checkKhoaLuan()
        {
            double tb = (dLapTrinh + dCoSoDuLieu + DThietKeWeb) / 3;
            if (tb >= 8 && dLapTrinh >= 5 && dCoSoDuLieu >= 5 && DThietKeWeb >= 5) return true;
            return false;
        }

        public Boolean checkChuyenDe()
        {
            if (dLapTrinh >= 5 && dCoSoDuLieu >= 5 && DThietKeWeb >= 5) return true;
            return false;
        }

        public void nhap()
        {
            Console.WriteLine("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            ngaySinh = Console.ReadLine();
            Console.WriteLine("Nhap diem lap trinh: ");
            DLapTrinh = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem co so du lieu: ");
            DCoSoDuLieu = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem thiet ke web: ");
            dThietKeWeb = double.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", HoTen, ngaySinh, DLapTrinh, DCoSoDuLieu, dThietKeWeb);
        }
    }
}
