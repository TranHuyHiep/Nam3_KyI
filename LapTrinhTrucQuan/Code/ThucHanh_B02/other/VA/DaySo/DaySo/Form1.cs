using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaySo
{
    public partial class Form1 : Form
    {
        //int N;
        dayso ds = new dayso();
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtN.Text = String.Empty;
            txtDaySo.Text = "Day so: ";
            txtTong.Text = "Tong day: ";
            TxtSapXep.Text = "Day so sap xep giam dan la: ";
            ds = new dayso(0);
            txtN.Focus();
            //txtDaySo.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && Convert.ToInt16(e.KeyChar) != 8)
            {
                MessageBox.Show("Nhap so nguyen");
                e.Handled = true;            
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtN.Text.Trim() == "")
            {
                bntNhap.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                bntNhap.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void bntNhap_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            
            ds.Nhap(n);
            txtDaySo.Text = "Day so: " +ds.s;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTong.Text = "Tong day: " + ds.Tong();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ds.SapSep();
            TxtSapXep.Text = "Day so sap xep giam dan la: " + ds.s;
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat khong!", "Thong Bao", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }
    }
}
