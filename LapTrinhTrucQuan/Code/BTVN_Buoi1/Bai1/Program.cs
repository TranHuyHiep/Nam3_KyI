using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Buoi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSach danhSach = new DanhSach();
            danhSach.NhapDSSV();
            Console.WriteLine("So sinh vien lam khoa luan la: " + danhSach.demSinhVienLamKhoaLuan());
            Console.WriteLine("So sinh vien lam chuyen de tot nghiep la: " + danhSach.demSinhVienLamChuyenDe());
            Console.ReadLine();
        }
    }
}
