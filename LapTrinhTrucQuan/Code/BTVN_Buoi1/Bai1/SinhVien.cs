using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Buoi1
{
    class SinhVien
    {
        private string hoTen;
        private DateTime ngaySinh;
        private double diemLapTrinhTrucQuan;
        private double diemCoSoDuLieu;
        private double diemThietKeWeb;

        public SinhVien()
        {
            hoTen = "";
            ngaySinh = DateTime.Now;
            diemLapTrinhTrucQuan = 0;
            diemCoSoDuLieu = 0;
            diemThietKeWeb = 0;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            ngaySinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem mon lap trinh: ");
            diemLapTrinhTrucQuan = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem mon co so du lieu: ");
            diemCoSoDuLieu = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem mon thiet ke web: ");
            diemThietKeWeb = Double.Parse(Console.ReadLine());
        }
        // ham xac dinh sinh vien lam khoa luan
        public bool checkKhoaLuan()
        {
            return (((diemLapTrinhTrucQuan + diemCoSoDuLieu + diemThietKeWeb) / 3 >= 8) && (diemCoSoDuLieu >= 5) && (diemThietKeWeb >= 5) && (diemLapTrinhTrucQuan >= 5));
        }
        // ham xac dinh sinh vien co lam chuyen de hay khong
        public bool checkChuyenDeTotNghiep()
        {
            return (diemCoSoDuLieu >= 5) && (diemThietKeWeb >= 5) && (diemLapTrinhTrucQuan >= 5);
        }
    }
}