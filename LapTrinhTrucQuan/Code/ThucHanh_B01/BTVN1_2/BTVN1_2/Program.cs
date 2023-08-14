using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so xe: ");
            n = int.Parse(Console.ReadLine());
            OTO[] oto = new OTO[n];
            for(int i = 0; i < n; i++)
            {
                int key;
                Console.WriteLine("Thue xe 1.Xe tai, 2.Xe du lich");
                key = int.Parse(Console.ReadLine());
                if(key == 1)
                {
                    oto[i] = new XeTai();
                    oto[i].nhap();
                } else
                {
                    oto[i] = new XeDuLich();
                    oto[i].nhap();
                }
            }
            Console.WriteLine("Tinh tien: ");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(oto[i].ToString() + " tien thue: " + oto[i].tinhTien());
            }
            Console.ReadLine();
        }
    }
}
