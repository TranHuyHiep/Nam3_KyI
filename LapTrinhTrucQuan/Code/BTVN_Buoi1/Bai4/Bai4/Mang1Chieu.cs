using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Mang1Chieu
    {
        private int n;
        private int []a;

        public Mang1Chieu()
        {
            this.n = 0;
        }

        public Mang1Chieu (int n)
        {
            this.n = n;
            a = new int [n];
        }

        public void Nhap()
        {
            Console.WriteLine("Moi nhap so phan tu cua mang: ");
            this.n = int.Parse(Console.ReadLine());
            a = new int [n];
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write("a[" + i + "]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public void In()
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        public void SapXep(int thuTu)
        {
            if(thuTu == 0)
            {
                for(int i = 0; i < a.Length - 1; i++)
                {
                    for(int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] > a[j])
                        {
                            int temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                }
            } 
            else
            {
                for(int i = 0; i < a.Length - 1; i++)
                {
                    for(int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] < a[j])
                        {
                            int temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                }
            }
        }

        public int TimKiem(int m)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] == m)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

