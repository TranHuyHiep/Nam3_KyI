using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachHang
{
    public partial class Form2 : Form
    {
        List<NguoiGui> listNguoiGuis = new List<NguoiGui>();

        public Form2()
        {
            InitializeComponent();
            listNguoiGuis = StaticData._NguoiGui;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int timthay = 0;
            string ketQua = "";
            foreach (NguoiGui i in listNguoiGuis)
            {
                if (i.MaKH1 == Convert.ToInt32(tbTimKiem.Text))
                {
                    timthay = 1;
                    ketQua += "Khách hàng " + i.TenKH1 + " phải trả"
                        + i.Tien1 + " nghìn đồng\n" ;
                }
            }

            if (timthay == 0)
            {
                lbThongTinTimKiem.Text = "Khách hàng " + tbTimKiem.Text + " không có trong danh sách";
            } else
            {
                lbThongTinTimKiem.Text = ketQua;
            }

        }
    }
}
