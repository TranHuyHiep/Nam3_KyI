using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN1_2
{
    abstract class OTO
    {
        String hoTen;
        float gioThue;

        public OTO()
        {
        }

        public OTO(string hoTen, float gioThue)
        {
            this.HoTen = hoTen;
            this.GioThue = gioThue;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public float GioThue { get => gioThue; set => gioThue = value; }

        public void nhap()
        {
            Console.WriteLine("Nhap ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap gio thue: ");
            gioThue = float.Parse(Console.ReadLine());
        }

        public abstract double tinhTien();

        public String ToString()
        {
            return HoTen + " " + GioThue;
        }
    }
}
