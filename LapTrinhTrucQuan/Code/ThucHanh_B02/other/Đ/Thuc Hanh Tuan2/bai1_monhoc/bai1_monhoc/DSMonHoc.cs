using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_monhoc
{
    internal class DSMonHoc
    {
        private string TenMH;
        private int SoTC;
        private Double Diem;


        public DSMonHoc(string tenMH, int soTC, double diem)
        {
            TenMH = tenMH;
            SoTC = soTC;
            Diem = diem;
        }
        public string TenMH1 { get =>TenMH; set => TenMH=value; }
        public int SoTC1 { get=>SoTC; set=>SoTC=value; }
        public double Diem1 { get=>Diem; set=>Diem=value; }
    }
    

}
