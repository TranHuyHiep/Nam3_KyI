using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    internal class NhanVien
    {
        private String hoTen;
        private DateTime namSinh;
        private String diaChi;
        private double luongCoBan;
        private float heSo;
        private double phuCap;
        private double tongTien;

        public NhanVien()
        {
            this.hoTen = "";
            this.namSinh = DateTime.Now;
            this.diaChi = "";
            this.luongCoBan = 0;
            this.heSo = 0;
            this.phuCap = 0;
            this.tongTien = 0;
        }

        public NhanVien(string hoTen, DateTime namSinh, string diaChi, double luongCoBan, float heSo, double phuCap, double tongTien)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.diaChi = diaChi;
            this.luongCoBan = luongCoBan;
            this.heSo = heSo;
            this.phuCap = phuCap;
            this.tongTien = tongTien;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap ho ten: ");
            this.hoTen = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            this.namSinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dia chi: ");
            this.diaChi = Console.ReadLine();
            Console.WriteLine("Nhap luong co ban: ");
            this.luongCoBan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap he so: ");
            this.heSo = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap phu cap: ");
            this.phuCap = double.Parse(Console.ReadLine());
            this.tongTien = this.luongCoBan * this.heSo + this.phuCap;
        }

        public void In()
        {
            Console.WriteLine($" {hoTen}, {namSinh}, {diaChi}, {luongCoBan}, {heSo}, {phuCap}, {tongTien}");
        }
    }
}
