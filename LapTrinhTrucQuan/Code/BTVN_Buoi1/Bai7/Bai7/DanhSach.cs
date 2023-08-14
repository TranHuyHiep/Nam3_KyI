using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class DanhSach
    {
        private int n;
        private SinhVien[] DS;

        public DanhSach()
        {
            this.n = 0;
            DS = null;
        }

        public DanhSach(int n, SinhVien[] dS)
        {
            this.n = n;
            DS = dS;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap so luong sinh vien: ");
            this.n = int.Parse(Console.ReadLine());
            DS = new SinhVien[n];
            for(int i = 0; i < this.n; i++)
            {
                DS[i] = new SinhVien();
                DS[i].Nhap();
            }
        }

        public void In()
        {
            for(int i = 0; i < this.n; i++)
            {
                DS[i].In();
            }
        }

        public void LietKeDTB8()
        {
            for (int i = 0; i < this.n; i++)
            {
                if (DS[i].DTB > 8.0)
                {
                    DS[i].In();
                }
            }
        }

        public void SapXepTheoMSV()
        {
            for (int i = 0; i < this.n; i++)
            {
                for(int j = i + 1; j < this.n; j++)
                {
                    if (String.Compare(DS[i].MaSinhVien,DS[j].MaSinhVien) < 0)
                    {
                        SinhVien temp = DS[i];
                        DS[i] = DS[j];
                        DS[j] = temp;
                    }
                }
            }
        }
    }
}
