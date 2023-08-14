using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QLDiem
{
    internal class MonHoc
    {
        private string maMH;
        private int soTin;
        private double diem;

        public MonHoc(string maMH, int soTin, double diem)
        {
            this.MaMH = maMH;
            this.SoTin = soTin;
            this.Diem = diem;
        }

        public string MaMH { get => maMH; set => maMH = value; }
        public int SoTin { get => soTin; set => soTin = value; }
        public double Diem { get => diem; set => diem = value; }

        public string toString()
        {
            return MaMH + " " + SoTin + " " + Diem;
        }
    }
}
