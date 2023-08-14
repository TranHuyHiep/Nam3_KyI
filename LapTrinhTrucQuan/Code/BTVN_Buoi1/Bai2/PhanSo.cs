using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Bai2
{
    internal class PhanSo
    {
        private int tuSo;
        private int mauSo;
        
        public PhanSo()
        {
            this.tuSo = 0;
            this.mauSo = 1;
        }

        public PhanSo(int tuSo)
        {
            this.tuSo = tuSo;
            this.mauSo = 1;
        }

        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }

        public void Nhap()
        {
            Console.WriteLine("Moi nhap tu so: ");
            this.tuSo = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Moi nhap mau so (Khac 0): ");
                this.mauSo = int.Parse(Console.ReadLine());
            } while (this.mauSo == 0);

        }

        public void In()
        {
            Console.WriteLine(this.tuSo + "/" + this.mauSo);
        }

        public int gcd(int a, int b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }

        public PhanSo RutGon()
        {
            int temp = gcd(this.tuSo, this.mauSo);
            return new PhanSo(this.tuSo/temp, this.mauSo/temp);
        }

        public PhanSo Tong(PhanSo ps)
        {
            return new PhanSo(this.tuSo + ps.tuSo, this.mauSo + ps.mauSo).RutGon();
        }

        public PhanSo Hieu(PhanSo ps)
        {
            return new PhanSo(this.tuSo - ps.tuSo, this.mauSo - ps.mauSo).RutGon();
        }

        public PhanSo Tich(PhanSo ps)
        {
            return new PhanSo(this.tuSo * ps.tuSo, this.mauSo * ps.mauSo).RutGon();
        }

        public PhanSo Thuong(PhanSo ps)
        {
            return new PhanSo(this.tuSo + ps.mauSo, this.mauSo + ps.tuSo).RutGon();
        }

        public String ToString()
        {
            return this.tuSo + "/" + this.mauSo;
        }
    }
}
