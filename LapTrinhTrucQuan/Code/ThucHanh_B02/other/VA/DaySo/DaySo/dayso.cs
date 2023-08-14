using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySo
{
    internal class dayso
    {
        int n;
        int[] a;
        public string s;

        public dayso()
        {
            this.n = 0;
            this.a = null;
        }

        public dayso(int n = 0)
        {
            this.n = n;
            this.a = null;
        }

        public void Nhap(int n)
        {
            Random rd = new Random();
            this.n = n;
            this.a = new int[this.n];
            for(int i = 0; i < this.n; i++)
            {
                this.a[i] = rd.Next(1, 100);
                this.s += this.a[i].ToString().Trim() + " ";
            }
        }
        public void Xuat()
        {
            for(int i = 0; i < this.n; i++)
            {
                Console.Write(this.a[i] + "  ");
            }
        }

        public int Tong()
        {
            int S = 0;
            for (int i = 0; i < this.n; i++)
            {
                S += this.a[i];
            }
            return S;
        }

        public void SapSep()
        {
            this.s = "";
            for(int i = 0; i < this.n; i++)
            {
                for(int j = i + 1; j < this.n; j++)
                {
                    if (this.a[i] < this.a[j])
                    {
                        int c = this.a[i];
                        this.a[i] = this.a[j];
                        this.a[j] = c;
                    }
                }
            }
            for(int i = 0; i < this.n; i++)
            {
                this.s += this.a[i].ToString().Trim() + " ";
            }
        }
    }
}
