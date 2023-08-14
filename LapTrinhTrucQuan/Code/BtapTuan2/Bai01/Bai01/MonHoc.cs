using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class MonHoc
    {
        private string _ten;
        private int _tin;
        private double _diem;

        public MonHoc()
        {
            _ten = "";
            _tin = 0;
            _diem = 0;
        }
        public MonHoc(string ten, int tin, double diem)
        {
            _ten = ten;
            _tin = tin;
            _diem = diem;
        }

        public string Ten { get => _ten; set => _ten = value; }
        public int Tin { get => _tin; set => _tin = value; }
        public double Diem { get => _diem; set => _diem = value; }
    }
}
