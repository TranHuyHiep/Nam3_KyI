using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vidu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhập ngu!");
            txtBanKinh.Text = "";
            double r = double.Parse(txtBanKinh.Text);
            txtChuVi.Text = (2 * 3.14 * r).ToString();
            txtDienTich.Text = (3.14 * Math.Pow(double.Parse(txtBanKinh.Text), 2)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBanKinh.Text = "";
            txtChuVi.Text = "";
            txtDienTich.Text = "";
            txtBanKinh.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBanKinh_TextChanged(object sender, EventArgs e)
        {
            if(txtBanKinh.TextLength >= 1)
            {
                if (('0' < txtBanKinh.Text[0] && txtBanKinh.Text[0] < '9') || (txtBanKinh.Text[0] == '-'))
                {
                    for (int i = 1; i < txtBanKinh.TextLength; i++)
                    {
                        if ('9' < txtBanKinh.Text[i] || txtBanKinh.Text[i] < '0')
                        {
                            MessageBox.Show("Nhập ngu!");
                            txtBanKinh.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nhập ngu!");
                    txtBanKinh.Text = "";
                }
            }
            
             
        }
    }
}
