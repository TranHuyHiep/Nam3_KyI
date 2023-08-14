using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSach ds = new DanhSach();
            ds.Nhap();
            Console.WriteLine("Danh sach vua nhap la: ");
            ds.In();
            Console.WriteLine("Danh sach sinh vien tren 8.0: ");
            ds.LietKeDTB8();
            Console.WriteLine("Danh sach sinh vien sau khi sap xep: ");
            ds.SapXepTheoMSV();
            ds.In();

            Console.ReadLine();
        }
    }
}
