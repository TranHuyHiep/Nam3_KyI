using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Buoi1
{
    class DanhSach
    {
        int n;
        SinhVien[] sv;

        public DanhSach()
        {
            this.n = 0;
            this.sv = null;
        }
        public void NhapDSSV()
        {
            Console.WriteLine("Nhap so luong SV: ");
            n = int.Parse(Console.ReadLine());
            sv = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                sv[i] = new SinhVien();
                sv[i].Nhap();
            }
        }
        // Dem sinh vien lam khoa luan
        public int demSinhVienLamKhoaLuan()
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (sv[i].checkKhoaLuan()) dem++;
            }
            return dem;
        }
        // Dem sinh vien lam chcuyen de
        public int demSinhVienLamChuyenDe()
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (sv[i].checkChuyenDeTotNghiep()) dem++;
            }
            return dem;
        }
    }
}