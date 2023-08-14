using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<MonHoc> listMonHoc = new List<MonHoc>();

        private void Form1_Load(object sender, EventArgs e)
        {
            fillDuLieu();
            this.KeyPreview = true;
        }

        void fillDuLieu()
        {
            cbTenMH.Items.Add("Tin học đại cương");
            cbTenMH.Items.Add("Giải tích F1");
            cbTenMH.Items.Add("Tiếng Anh A0");
            cbTenMH.Items.Add("Triết học Mác – Lênin");
            cbTenMH.Items.Add("Vật lý F1");
        }

        private void cbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbTenMH.SelectedIndex; 
            if(index == 0)
            {
                txtSoTin.Text = "2";
            }
            else if(index == 1)
            {
                txtSoTin.Text = "3";
            }
            else if (index == 2)
            {
                txtSoTin.Text = "3";
            }
            else if (index == 3)
            {
                txtSoTin.Text = "2";
            }
            else if (index == 4)
            {
                txtSoTin.Text = "3";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listMonHoc.Add(new MonHoc(cbTenMH.SelectedItem.ToString(), int.Parse(txtSoTin.Text), double.Parse(txtDiem.Text)));
            lstDSMH.Items.Add(cbTenMH.SelectedItem.ToString() + " | " + int.Parse(txtSoTin.Text) + " | " + double.Parse(txtDiem.Text));
        }

        private void tinh_Click(object sender, EventArgs e)
        {
            int tongTin = 0;
            double tongDiem = 0;
            double diemTB = 0;
            foreach (MonHoc item in listMonHoc)
            {
                tongTin += item.SoTin;
                tongDiem += item.Diem;
                diemTB += (item.SoTin * item.Diem);
            }
            diemTB = Math.Round(diemTB / tongTin, 2);
            txtDiemTB.Text = diemTB.ToString();
            txtTongTin.Text = tongTin.ToString();
            txtTongDiem.Text = tongDiem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
