using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2_duthuyen
{
    public partial class Form1 : Form
    {
        double k = 0.0;
        double Gia = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        public void AddcbDoUong()
        {
            cbDoUong.Items.Add("Coca cola");
            cbDoUong.Items.Add("Pepsi");
            cbDoUong.Items.Add("Seven up");
        }
        public void AddSoLuong()
        {
            for(int i = 1; i <=10; i++)
                cbSoLuong.Items.Add(i.ToString());

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do you want to Exit", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) ;
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddcbDoUong();
            AddSoLuong();
            this.KeyPreview = true;
        }

        

        private void rdoCaNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCaNgay.Checked == true)
                txtGia.Text = "200";
            else if (rdoNuaNgay.Checked == true)
                txtGia.Text = "100";
        }

        private void cbDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDoUong.SelectedItem == "Coca cola")
                k = 0.5;
            else if (cbDoUong.SelectedItem == "Pepsi")
                k = 0.8;
            else k = 1.0;

        }

        private void cbSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSoLuong.SelectedIndex !=-1)
            {
                string s = cbSoLuong.SelectedItem.ToString();
                int Sl = Convert.ToInt16(s);
                Gia = Sl * k;
                txtTien.Text = "" + Gia;
            }
        }

        private void btnThemVao_Click(object sender, EventArgs e)
        {
            if(txtHT.Text.Trim()=="")
            {
                MessageBox.Show("Họ Tên không được để trống");
                return;
            }
            else
            {
                string tt;
                tt = txtHT.Text + " | ";
                if(rdoCaNgay.Checked == true)
                {
                    tt = tt + "Cả Ngày | ";
                }
                else if (rdoNuaNgay.Checked)
                {
                    tt = tt + "Nửa Ngày | ";
                }
                tt = tt + txtGia.Text + "$ | Đồ Uống " + Gia + "$ | Tổng " + (int.Parse(txtGia.Text) + Gia);
                lstDS.Items.Add(tt);


            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtHT.Text = "";
            txtGia.Text = "";
            txtTien.Text = "";
            rdoCaNgay.Checked = false;
            rdoNuaNgay.Checked = false;
            cbDoUong.SelectedIndex = -1;
            cbSoLuong.SelectedIndex = -1;
            txtHT.Focus();

        }
    }
}
