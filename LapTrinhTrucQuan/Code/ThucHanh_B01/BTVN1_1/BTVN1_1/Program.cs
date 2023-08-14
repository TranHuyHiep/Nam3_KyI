using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so sinh vien: ");
            n = int.Parse(Console.ReadLine());
            SinhVien[] sv= new SinhVien[n];
            
            for (int i = 0; i < n; i++)
            {
                sv[i] = new SinhVien();
                sv[i].nhap();
            }

            Console.WriteLine("So sinh vien duoc lam khoa luan: ");
            for (int i = 0; i < n; i++)
            {
                if(sv[i].checkKhoaLuan() == true) sv[i].xuat(); 
            }
            Console.WriteLine("So sinh vien duoc lam chuyen de: ");
            for (int i = 0; i < n; i++)
            {
                if (sv[i].checkChuyenDe() == true) sv[i].xuat();
            }


            Console.ReadLine();
        }
    }
}
