using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHoa.menu
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        string strconnect = "Data Source=TRANHUYHIEP;Initial Catalog=BanHang;Integrated Security=True";

        SqlConnection sqlConnection = new SqlConnection();
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            sqlConnection = new SqlConnection(strconnect);
            SqlCommand cmd = new SqlCommand("select * from tblUser where UserName = @UserName and PassWord = @Password", sqlConnection);
            cmd.Parameters.AddWithValue("@UserName", txtName.Text);
            cmd.Parameters.AddWithValue("@Password", txtPass.Text);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            
            if (dt.Rows.Count > 0)
            {
            */
                frmMain frmSP = new frmMain();
                frmSP.ShowDialog();
            /*
        } else
            {
                MessageBox.Show("Please enter Correct Username and Password");
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
