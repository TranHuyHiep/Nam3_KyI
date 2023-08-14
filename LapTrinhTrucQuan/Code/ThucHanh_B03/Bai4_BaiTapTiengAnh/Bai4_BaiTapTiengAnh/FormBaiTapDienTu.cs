using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_BaiTapTiengAnh
{
    public partial class FormBaiTapDienTu : Form
    {
        BaiTapDienTu baiTap = new BaiTapDienTu();


        public FormBaiTapDienTu(BaiTapDienTu baiTapDienTu)
        {
            InitializeComponent();
            baiTap = baiTapDienTu;
            txtDeBai.Text = baiTapDienTu.Debai;

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int diem = 0;
            string string1 = txt01.Text;
            string string2 = txt02.Text;
            string string3 = txt03.Text;
            string string4 = txt04.Text;
            string string5 = txt05.Text;
            string string6 = txt06.Text;
            string string7 = txt07.Text;
            string string8 = txt08.Text;
            string string9 = txt09.Text;
            string string10 = txt10.Text;
            if (string1.Equals(baiTap.Dapantungcau[0]))
            {
                diem++;
                txt01.BackColor = Color.Green;
            }
            else
            {
                txt01.BackColor = Color.Red;
            }

            if (string2.Equals(baiTap.Dapantungcau[1]))
            {
                diem++;
                txt02.BackColor = Color.Green;
            }
            else
            {
                txt02.BackColor = Color.Red;
            }

            if (string3.Equals(baiTap.Dapantungcau[2]))
            {
                diem++;
                txt03.BackColor = Color.Green;
            }
            else
            {
                txt03.BackColor = Color.Red;
            }

            if (string4.Equals(baiTap.Dapantungcau[3]))
            {
                diem++;
                txt04.BackColor = Color.Green;
            }
            else
            {
                txt04.BackColor = Color.Red;
            }

            if (string5.Equals(baiTap.Dapantungcau[4]))
            {
                diem++;
                txt05.BackColor = Color.Green;
            }
            else
            {
                txt05.BackColor = Color.Red;
            }

            if (string6.Equals(baiTap.Dapantungcau[5]))
            {
                diem++;
                txt06.BackColor = Color.Green;
            }
            else
            {
                txt06.BackColor = Color.Red;
            }

            if (string7.Equals(baiTap.Dapantungcau[6]))
            {
                diem++;
                txt07.BackColor = Color.Green;
            }
            else
            {
                txt07.BackColor = Color.Red;
            }

            if (string8.Equals(baiTap.Dapantungcau[7]))
            {
                diem++;
                txt08.BackColor = Color.Green;
            }
            else
            {
                txt08.BackColor = Color.Red;
            }

            if (string9.Equals(baiTap.Dapantungcau[8]))
            {
                diem++;
                txt09.BackColor = Color.Green;
            }
            else
            {
                txt09.BackColor = Color.Red;
            }

            if (string10.Equals(baiTap.Dapantungcau[9]))
            {
                diem++;
                txt10.BackColor = Color.Green;
            }
            else
            {
                txt10.BackColor = Color.Red;
            }

            MessageBox.Show("Diem cua ban la: " + diem);
        }

        public List<string> DapAnTungCau { get; internal set; }

        private void btnDapAn_Click(object sender, EventArgs e)
        {
            txtDeBai.Text = baiTap.Dapan;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txt01.Text = ""; txt01.BackColor = Color.White;
            txt02.Text = ""; txt02.BackColor = Color.White;
            txt03.Text = ""; txt03.BackColor = Color.White;
            txt04.Text = ""; txt04.BackColor = Color.White;
            txt05.Text = ""; txt05.BackColor = Color.White;
            txt06.Text = ""; txt06.BackColor = Color.White;
            txt07.Text = ""; txt07.BackColor = Color.White;
            txt08.Text = ""; txt08.BackColor = Color.White;
            txt09.Text = ""; txt09.BackColor = Color.White;
            txt10.Text = ""; txt10.BackColor = Color.White;
            txtDeBai.Text = baiTap.Debai;
            txt01.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
