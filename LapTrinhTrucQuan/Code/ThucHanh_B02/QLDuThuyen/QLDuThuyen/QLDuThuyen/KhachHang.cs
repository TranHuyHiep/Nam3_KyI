using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QLDuThuyen
{
    internal class KhachHang
    {
        private string hoTen;
        private string thoiGian;
        private double giaThuyen;
        private string doUong;
        private int soLuong;
        private double tien;

        public KhachHang(string hoTen, string thoiGian, double giaThuyen, string doUong, int soLuong, double tien)
        {
            this.hoTen = hoTen;
            this.thoiGian = thoiGian;
            this.giaThuyen = giaThuyen;
            this.doUong = doUong;
            this.soLuong = soLuong;
            this.tien = tien;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string ThoiGian { get => thoiGian; set => thoiGian = value; }
        public double GiaThuyen { get => giaThuyen; set => giaThuyen = value; }
        public string DoUong { get => doUong; set => doUong = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double Tien { get => tien; set => tien = value; }
    }
}
