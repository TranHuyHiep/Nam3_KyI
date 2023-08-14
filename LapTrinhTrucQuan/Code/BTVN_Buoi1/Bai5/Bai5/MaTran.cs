using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class MaTran
    {
        private int m;
        private int n;
        private int [,]a;

        public int M { get => m; set => m = value; }
        public int N { get => n; set => n = value; }

        public MaTran(int m, int n)
        {
            this.m = m;
            this.n = n;
            this.a = new int[this.m,this.n];        
        }

        public MaTran()
        {
            this.m = 0;
            this.n = 0;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap so hang: ");
            this.m = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot: ");
            this.n = int.Parse(Console.ReadLine());
            this.a = new int[this.m, this.n];
            for(int i = 0; i < this.m; i++)
            {
                for(int j = 0; j < this.n; j++)
                {
                    Console.Write("a[" + i + "][" + j + "]: ");
                    this.a[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }
        
        public void In()
        {
            for (int i = 0; i < this.m; i++)
            {
                for(int j = 0; j < this.n; j++)
                {
                    Console.Write(a[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        public MaTran Tong(MaTran mt)
        {
            MaTran result;
            result = new MaTran(this.m, this.n);
            for(int i = 0; i < this.m; i++)
            {
                for (int j = 0; j < this.n; j++)
                {
                    result.a[i, j] = this.a[i, j] + mt.a[i, j];
                }
            }
            return result;
        }

        public MaTran Hieu(MaTran mt)
        {
            MaTran result;
            result = new MaTran(this.m, this.n);
            for (int i = 0; i < this.m; i++)
            {
                for (int j = 0; j < this.n; j++)
                {
                    result.a[i, j] = this.a[i, j] - mt.a[i, j];
                }
            }
            return result;
        }

        public MaTran Tich(MaTran mt)
        {
            MaTran result;
            result = new MaTran(this.m, mt.n);
            for (int i = 0; i < this.m; i++)
            {
                for (int j = 0; j < mt.n; j++)
                {
                    int temp = 0;
                    for(int k = 0; k < this.n; k++)
                    {
                        temp += this.a[i, k] * mt.a[k, j];
                    }
                    result.a[i, j] = temp;
                }
            }
            return result;
        }

        public MaTran ChuyenVi()
        {
            MaTran result;
            result = new MaTran(this.n, this.m);
            for(int i = 0; i < this.n; i++)
            {
                for(int j = 0; j < this.m; j++)
                {
                    result.a[i, j] = this.a[j, i];
                }
            }
            return result;
        } 

        public bool KiemTraMaTranVuong()
        {
            return n == m;
        }

    }
}
