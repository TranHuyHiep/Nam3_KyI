using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class SinhVien
    {
        private String maSinhVien;
        private String hoTen;
        private Double dLapTrinh;
        private Double dCSDL;
        private Double dTB;

        public double DTB { get => dTB; set => dTB = value; }
        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }

        public SinhVien()
        {
            this.maSinhVien = "";
            this.hoTen = "";
            this.dLapTrinh = 0;
            this.dCSDL = 0;
            this.dTB = 0;
        }

        public SinhVien(string maSinhVien, string hoTen, double dLapTrinh, double dCSDL, double dTB)
        {
            this.maSinhVien = maSinhVien;
            this.hoTen = hoTen;
            this.dLapTrinh = dLapTrinh;
            this.dCSDL = dCSDL;
            this.dTB = dTB;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap ma sinh vien: ");
            this.maSinhVien = Console.ReadLine();
            Console.WriteLine("Nhap ho va ten: ");
            this.hoTen = Console.ReadLine();
            Console.WriteLine("Nhap diem lap trinh: ");
            this.dLapTrinh = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem co so du lieu: ");
            this.dCSDL = double.Parse(Console.ReadLine());
            this.dTB = (dLapTrinh + dCSDL) / 2;
        }

        public void In()
        {
            Console.WriteLine($"{maSinhVien} | {hoTen} | {dLapTrinh} | {dCSDL} | {dTB}");
        }

    }
}
