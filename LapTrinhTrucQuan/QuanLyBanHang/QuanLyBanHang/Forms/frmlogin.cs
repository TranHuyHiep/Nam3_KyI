using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanHang.Forms
{
    public partial class frmlogin : Form
    {
        Classes.ConnectData dtbase = new Classes.ConnectData();
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //try
            //{
                dtbase.OpenConnect();
                string tk = txtTenTK.Text;
                string mk = txtMK.Text;
                if (tk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); }
                else if (mk.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); }
                else
                {
                    string sql = "Select * from tblUser where UserName='" + tk + "' and Password='" + mk + "'";
                    SqlCommand cnd = new SqlCommand(sql, dtbase.sqlConn);
                    SqlDataReader dta = cnd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        frmMain main = new frmMain();
                        main.ShowDialog();


                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại!");
                    }
                }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi Kết nối");
            //}

        }
    }
}
