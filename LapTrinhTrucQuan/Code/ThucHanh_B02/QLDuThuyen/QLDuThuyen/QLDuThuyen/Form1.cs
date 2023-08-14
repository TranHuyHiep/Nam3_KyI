using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDuThuyen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát không", "Thông báo", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            radioCaNgay.Checked = false;
            radioNuaNgay.Checked = false;
            txtGia.Text = "";
            txtDoUong.Text = "";
            txtSoLuong.Text = "";
            txtTien.Text = "";
            txtHoTen.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillDo();
            this.KeyPreview = true;
        }

        void fillDo()
        {
            txtDoUong.Items.Add("Coca cola");
            txtDoUong.Items.Add("Pepsi");
            txtDoUong.Items.Add("Seven up");
            txtSoLuong.Items.Add("1");
            txtSoLuong.Items.Add("2");
            txtSoLuong.Items.Add("3");
            txtSoLuong.Items.Add("4");
            txtSoLuong.Items.Add("5");
            txtSoLuong.Items.Add("6");
            txtSoLuong.Items.Add("7");
            txtSoLuong.Items.Add("8");
            txtSoLuong.Items.Add("9");
            txtSoLuong.Items.Add("10");
        }

        private void radioCaNgay_CheckedChanged(object sender, EventArgs e)
        {
            txtGia.Text = "200";
        }

        private void radioNuaNgay_CheckedChanged(object sender, EventArgs e)
        {
            txtGia.Text = "100";
        }

        private void txtDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtSoLuong.SelectedItem == null)
            {
                return;
            }
            double gia = 0;
            if(txtDoUong.SelectedItem.ToString() == "Coca cola")
            {
                gia = 0.5;
            } 
            else if (txtDoUong.SelectedItem.ToString() == "Pepsi")
            {
                gia = 0.8;
            }
            else if (txtDoUong.SelectedItem.ToString() == "Seven up")
            {
                gia = 1.0;
            }
            txtTien.Text = (gia * int.Parse(txtSoLuong.Text)).ToString();
        }

        private void txtSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtDoUong.SelectedItem == null)
            {
                return;
            }
            double gia = 0;
            if (txtDoUong.SelectedItem.ToString() == "Coca cola")
            {
                gia = 0.5;
            }
            else if (txtDoUong.SelectedItem.ToString() == "Pepsi")
            {
                gia = 0.8;
            }
            else if (txtDoUong.SelectedItem.ToString() == "Seven up")
            {
                gia = 1.0;
            }
            txtTien.Text = (gia * int.Parse(txtSoLuong.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = txtHoTen.Text;
            double tong = 0;
            if (radioCaNgay != null)
            {
                result += " | " + "Cả ngày" + " | " + "200$";
                tong += 200;
            }
            else if ((radioNuaNgay != null))
            {
                result += " | " + "Nửa ngày" + " | " + "100$";
                tong += 100;
            }

            if(txtTien != null)
            {
                double gia = 0;
                if (txtDoUong.SelectedItem.ToString() == "Coca cola")
                {
                    gia = 0.5;
                }
                else if (txtDoUong.SelectedItem.ToString() == "Pepsi")
                {
                    gia = 0.8;
                }
                else if (txtDoUong.SelectedItem.ToString() == "Seven up")
                {
                    gia = 1.0;
                }
                tong += double.Parse(txtTien.Text);
                result += " | Đồ Uống " + txtTien.Text + "$ | Tổng " + tong + "$"; 
            }
            listDSKhachDat.Items.Add(result);
        }
    }
}
