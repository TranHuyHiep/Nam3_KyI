using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BTVN1_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so thi sinh: ");
            n = int.Parse(Console.ReadLine());
            TuyenSinh[] tuyenSinh = new TuyenSinh[n];
            for(int i = 0; i < n; i++)
            {
                tuyenSinh[i] = new TuyenSinh();
                tuyenSinh[i].nhap();
            }
            Console.WriteLine("Danh sach trung tuyen: ");
            for(int i = 0; i < n; i++)
            {
                if (tuyenSinh[i].tinhTongDiem() >= 26)
                {
                    tuyenSinh[i].xuat();
                }
            }
            Console.ReadLine();
        }
    }
}
