using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaTran a, b, tong, hieu, tich, chuyenVi;
            a = new MaTran();
            b = new MaTran();
            tong = new MaTran();
            hieu = new MaTran();
            tich = new MaTran();
            chuyenVi = new MaTran();
            a.Nhap();
            b.Nhap();
            Console.WriteLine("Ma tran a: ");
            a.In();
            Console.WriteLine("Ma tran b: ");
            b.In();

            if(a.N == b.N && a.M == b.M)
            {
                Console.WriteLine("Ma tran tong a + b: ");
                tong = a.Tong(b);
                tong.In();

                Console.WriteLine("Ma tran hieu a - b: ");
                hieu = a.Hieu(b);
                hieu.In();
            }

            if(a.N == b.M)
            {
                Console.WriteLine("Ma tran tich a * b: ");
                tich = a.Tich(b);
                tich.In();
            }

            Console.WriteLine("Ma tran chuyen vi: ");
            chuyenVi = a.ChuyenVi();
            chuyenVi.In();

            if(a.KiemTraMaTranVuong())
            {
                Console.WriteLine("Ma tran A la ma tran vuong");
            } 
            else
            {
                Console.WriteLine("Ma tran A khong la ma tran vuong");

            }

            Console.ReadLine();
        }
    }
}
