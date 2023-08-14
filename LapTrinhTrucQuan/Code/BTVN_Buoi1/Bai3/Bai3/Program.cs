using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a, b;
            a = new Point();
            b = new Point();
            Console.WriteLine("Nhap diem a: ");
            a.Nhap();
            Console.WriteLine("Nhap diem b: ");
            b.Nhap();

            Console.WriteLine("Toa do diem a: ");
            a.In();
            Console.WriteLine("Toa do diem b: ");
            b.In();

            Console.WriteLine("Khoang cach giua 2 diem la: " + a.KhoangCach(b));
            Console.ReadLine();
        }
    }
}
