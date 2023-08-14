using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Bai01
{
    public partial class Form1 : Form
    {
        List<MonHoc> monHocs = new List<MonHoc>();
        public bool IsNumber(string pText)
        {
            Regex regex = null;
            try
            {
                regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$"); return regex.IsMatch(pText);
            }
            catch (Exception ex)
            {
                return regex.IsMatch(pText);
            }
        }
        private void AddcomBoBox()
        {
            comboBoxMonHoc.Items.Add("Tin học đại cương");
            comboBoxMonHoc.Items.Add("Giải tích F1");
            comboBoxMonHoc.Items.Add("Tiếng Anh A0");
            comboBoxMonHoc.Items.Add("Triết học Mác – Lênin");
            comboBoxMonHoc.Items.Add("Vật lý F1");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddcomBoBox();
            this.KeyPreview = true;
        }

        private void comboBoxMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxMonHoc.SelectedItem == "Tin học đại cương" || comboBoxMonHoc.SelectedItem == "Triết học Mác – Lênin")
            {
                txtSoTin.Text = "2";
            }
            else 
            {
                txtSoTin.Text = "3";
            }
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if()
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (txtDiem.Text == "")
            {
                MessageBox.Show("Khong duoc bo trong");
                return;
            }
            if(IsNumber(txtDiem.Text.Trim()) == false)
            {
                MessageBox.Show("Ban phai nhap so vao o diem");
                txtDiem.Text = "";
                txtDiem.Focus();
                return;
            }
            else
            {
                listBoxDS.Items.Add(comboBoxMonHoc.Text + " - " + txtSoTin.Text + " - " + txtDiem.Text);
                monHocs.Add(new MonHoc(comboBoxMonHoc.Text, Convert.ToInt32(txtSoTin.Text), Convert.ToDouble(txtDiem.Text)));
                txtDiem.Text = "";
                comboBoxMonHoc.SelectedIndex = -1;
                txtSoTin.Text = "";
            }
        }

        private void bntTinh_Click(object sender, EventArgs e)
        {
            if(monHocs.Count == 0)
            {
                MessageBox.Show("Chua co mon hoc, Ban can phai nhap mon hoc!");
            }
            else
            {
                int TongTin = 0;
                double TongDiem = 0.0, Diemtb = 0.0, T = 0.0, S= 0.0;
                foreach(MonHoc monHoc in monHocs)
                {
                    TongTin += monHoc.Tin;
                    //TongDiem += monHoc.Diem;
                    T += (monHoc.Diem * monHoc.Tin);
                }
                S = T / TongTin;
                txtTongSoTin.Text = "" + TongTin;
                txtTongSoDiem.Text = "" + T;
                txtDTB.Text = "" + S.ToString("0.0");
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }
    }
}
