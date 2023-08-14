using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, x2, y1, y2, kc, goc;
            x1 = double.Parse(txtX1.Text);
            y1 = double.Parse(txtY1.Text);
            x2 = double.Parse(txtX2.Text);
            y2 = double.Parse(txtY1.Text);
            kc = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            txtKC.Text = kc.ToString();
        }   
    }
}
