using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN1_2
{
    internal class XeTai : OTO
    {
        public override double tinhTien()
        {
            float result = 0;
            if(GioThue - 1 >= 0)
            {
                result = 220000;
                result += (GioThue - 1) * 85000;
            } else
            {
                result = GioThue * 250000;
            }
            return result;
        }
    
    }
}
