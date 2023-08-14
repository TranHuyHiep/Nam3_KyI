using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1_monhoc
{
    public partial class Form1 : Form
    {
        List<DSMonHoc> lstds = new List<DSMonHoc>();
        public Form1()
        {
            InitializeComponent();
        }
        public void AddComboBox()
        {
            cbMonHoc.Items.Add("Tin học đại cương");
            cbMonHoc.Items.Add("Giải tích F1");
            cbMonHoc.Items.Add("Tiếng Anh A0");
            cbMonHoc.Items.Add("Triết học Mác-Lênin");
            cbMonHoc.Items.Add("Vật lý F1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddComboBox();
            this.KeyPreview = true;
        }

        private void cbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMonHoc.SelectedItem == "Tin học đại cương"||cbMonHoc.SelectedItem== "Triết học Mác-Lênin")
                txtTC.Text = "2";
            if (cbMonHoc.SelectedItem == "Giải tích F1" || cbMonHoc.SelectedItem == "Tiếng Anh A0"||cbMonHoc.SelectedItem== "Vật lý F1")
                txtTC.Text = "3";

        }
        

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int TongTC = 0;
            double TongDiem = 0;
            double T = 0;
            foreach (DSMonHoc i in lstds)
            {
                TongTC += i.SoTC1;
                TongDiem += i.Diem1;
                T += i.Diem1*i.SoTC1 ;
            }
            txtTongTC.Text = TongTC.ToString();
            txtTongDiem.Text = TongDiem.ToString();
            double TBC = T / TongTC;
            txtDiemTrungBinh.Text= TBC.ToString();
        }

        private void btnThemVaoDS_Click(object sender, EventArgs e)
        {
            int kt = 1;
            if (txtDiem.Text == "")
            {
                MessageBox.Show("Nhập lại vì thiếu điểm!");
                kt = 0;
            }
            if (kt==1)
            {
                lstMonHoc.Items.Add(cbMonHoc.Text + "|" + txtTC.Text + "|" + txtDiem.Text);
            }
            lstds.Add(new DSMonHoc(cbMonHoc.Text,Convert.ToInt32(txtTC.Text),Convert.ToInt64(txtDiem.Text)));
           
        }
    }
}
