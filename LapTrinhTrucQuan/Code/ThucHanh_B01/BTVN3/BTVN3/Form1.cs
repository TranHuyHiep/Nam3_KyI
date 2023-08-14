using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtResult.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, denta;
            String result = "";
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            c = double.Parse(txtC.Text);
            denta = b * b - 4 * a * c;
            if(denta < 0)
            {
                result = "Phuong trinh vo nghiem";
            } else if(denta == 0)
            {
                result = "Phuong trinh co nghiem kep x = " + (-b / a);
            } else
            {
                result = "x1 = " + (-b - Math.Sqrt(denta)) / (2 * a) + "\r\n" + "x2 = " + (-b + Math.Sqrt(denta)) / (2 * a);
            }
            txtResult.Text = result;
        }
    }
}
