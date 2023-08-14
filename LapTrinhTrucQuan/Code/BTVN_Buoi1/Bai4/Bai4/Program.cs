using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mang1Chieu a;
            int thuTu, timKiem, viTri;
            a = new Mang1Chieu();
            a.Nhap();
            a.In();
            Console.Write("\nMoi nhap thu tu sap xep (0: tang dan) (1: giam dan): ");
            thuTu = int.Parse(Console.ReadLine());
            a.SapXep(thuTu);
            a.In();

            Console.Write("\nNhap so muon tim kiem: ");
            timKiem = int.Parse(Console.ReadLine());
            viTri = a.TimKiem(timKiem);
            if(a.TimKiem(3) == -1)
            {
                Console.WriteLine("Khong tim thay " + timKiem);
            } 
            else
            {
                Console.WriteLine("Vi tri tim duoc la: " + viTri);
            }
            Console.ReadLine();
        }
    }
}
