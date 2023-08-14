using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vd01
{
    
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

        private void Form1_Load(object sender, EventArgs e)
        {
            AddComboBox();

            this.KeyPreview = true;
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))

            {
                MessageBox.Show("Ban phai nhap so nguyen");
                e.Handled = true;

            }
        }

        private void bntThemMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";

            txtTen.Text = "";

            txtDiaChi.Text = "";

            txtTienGui.Text = "";

            dateTimePicker1.Text = "";

            cbThoiGianGui.Text = "";

            cbThoiGianGui.SelectedIndex = -1;

            rdoThuong.Checked = false;

            rdoPhatLoc.Checked = false;
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,

               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)

                this.Close();
        }

        private void bntThemvao_Click(object sender, EventArgs e)
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

                if (rdoThuong.Checked == true)

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
                else if (rdoPhatLoc.Checked == true)

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

                lbDanhSach.Items.Add(txtMaKH.Text + " | " + txtTen.Text + " | " +

                    txtDiaChi.Text

                    + " | " + dateTimePicker1.Text + " | " + txtTienGui.Text + " | "

                    + cbThoiGianGui.Text + " tháng | " + tienlai);
                StaticData._NguoiGui.Add(new NguoiGui(Convert.ToInt32(txtMaKH.Text), txtTen.Text, txtDiaChi.Text, Convert.ToInt32(txtTienGui.Text),

                     dateTimePicker1.Text, cbThoiGianGui.Text, tienlai

                   ));
            }
        }

        private void bntTimKiem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.ShowDialog();
        }
    }
}
