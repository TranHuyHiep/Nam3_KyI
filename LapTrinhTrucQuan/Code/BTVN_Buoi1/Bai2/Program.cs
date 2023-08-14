using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhanSo a, b;
            a = new PhanSo();
            b = new PhanSo(); ;

            Console.WriteLine("Moi nhap phan so thu nhat: ");
            a.Nhap();

            Console.WriteLine("Moi nhap phan so thu hai: ");
            b.Nhap();


            Console.WriteLine("Tong hai phan so la: ");
            Console.WriteLine(a.ToString() + " + " + b.ToString() + " = " + a.Tong(b).ToString());


            Console.WriteLine("Hieu hai phan so la: ");
            Console.WriteLine(a.ToString() + " - " + b.ToString() + " = " + a.Hieu(b).ToString());

            Console.WriteLine("Tich hai phan so la: ");
            Console.WriteLine(a.ToString() + " * " + b.ToString() + " = " + a.Tich(b).ToString());

            Console.WriteLine("Thuong hai phan so la: ");
            Console.WriteLine(a.ToString() + " / " + b.ToString() + " = " + a.Thuong(b).ToString());
            Console.ReadLine();
        }
    }
}
