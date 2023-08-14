using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vd1
{

    class StaticData
    {
        public static List<NguoiGui> _NguoiGui = new List<NguoiGui> ();
    } 
    public partial class Form1 : Form
    {

        private void AddComboBox()
        {
            cbThoiGianGui.Items.Add("1");
            cbThoiGianGui.Items.Add("3");
            cbThoiGianGui.Items.Add("6");
            cbThoiGianGui.Items.Add("12");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddComboBox();
            this.KeyPreview = true;
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Ban chi duoc nhap so nguyen");
                e.Handled = true;
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void bntThemMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtNgayGui.Text = "";
            txtTienGui.Text = "";
            cbThoiGianGui.Text = "";
            cbThoiGianGui.SelectedIndex = -1;
            radioPhatLoc.Checked = false;
            radioThuong.Checked = false;    
        }

        private void bntThemVao_Click(object sender, EventArgs e)
        {
            int kt = 1;
            if (txtMaKH.TextLength < 6)
            {
                MessageBox.Show("Nhập lại vì mã < 6");
                kt = 0;
            }
            if (txtDiaChi.TextLength == 0 || txtTen.TextLength == 0)
            {
                MessageBox.Show("Nhập lại vì tên hoặc địa chỉ rỗng");
                kt = 0;
            }
            double tienlai = 0;

            if (kt == 1)
            {
                if (radioThuong.Checked == true)
                {
                    if (cbThoiGianGui.SelectedItem == "1")
                    {
                        tienlai = Convert.ToInt32(txtTienGui.Text) * 0.06;
                    }
                    if (cbThoiGianGui.SelectedItem == "3")
                    {
                        tienlai = Convert.ToInt32(txtTienGui.Text) * 0.07;
                    }
                    if (cbThoiGianGui.SelectedItem == "6")
                    {
                        tienlai = Convert.ToInt32(txtTienGui.Text) * 0.08;
                    }
                    if (cbThoiGianGui.SelectedItem == "12")
                    {
                        tienlai = Convert.ToDouble(txtTienGui.Text) * 0.09;
                    }
                }
                else if (radioPhatLoc.Checked == true)
                {
                    if (cbThoiGianGui.SelectedItem == "1")
                    {
                        tienlai = Convert.ToInt32(txtTienGui.Text) * 0.07;
                    }
                    if (cbThoiGianGui.SelectedItem == "3")
                    {
                        tienlai = Convert.ToInt32(txtTienGui.Text) * 0.08;
                    }
                    if (cbThoiGianGui.SelectedItem == "6")
                    {
                        tienlai = Convert.ToInt32(txtTienGui.Text) * 0.09;
                    }
                    if (cbThoiGianGui.SelectedItem == "12")
                    {
                        tienlai = Convert.ToInt32(txtTienGui.Text) * 0.1;
                    }
                }
                lstDanhSach.Items.Add(txtMaKH.Text + " | " + txtTen.Text + " | " +
                    txtDiaChi.Text + " | " + txtNgayGui.Text + " | " + txtTienGui.Text + " | " + cbThoiGianGui.Text + " tháng | " + tienlai);
                StaticData._NguoiGui.Add(new NguoiGui(Convert.ToInt32(txtMaKH.Text), txtTen.Text, txtDiaChi.Text, Convert.ToInt32(txtTienGui.Text),
                    txtNgayGui.Text, cbThoiGianGui.Text, tienlai));
            }
        }
    }
}
