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

namespace QuanLyBanHang
{
    public partial class Form1 : Form
    {
        Classes.ConnectData connData = new Classes.ConnectData();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            //Kiểm tra sự đầy đủ của dữ liệu
            if(txtMa.Text.Trim()=="")
            {
                MessageBox.Show("Bạn cần nhập mã Chất liệu");
                txtMa.Focus();
                return;
            }    
            if(txtTen.Text.Trim()=="")
            {
                MessageBox.Show("Bạn cần nhập tên chất liệu");
                txtTen.Focus();
                return;
            }
            //Kiểm tra có trùng mã không
            DataTable dtCheck = connData.ReadData("Select * from tblChatLieu where MaChatLieu='" + txtMa.Text + "'");
            if(dtCheck.Rows.Count>0)
            {
                MessageBox.Show("Bị trùng mã");
                txtMa.Focus();
                return;
            }    

            string sqlInsert = "insert into tblChatlieu values('"+txtMa.Text+"',N'"+txtTen.Text+"')";
            connData.UpdateData(sqlInsert);
            MessageBox.Show("Thêm mới thành công");
            LoadData();
            ResetValue();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvChatLieu.Columns[0].HeaderText = "Mã Chất liệu";
            dgvChatLieu.Columns[1].HeaderText = "Tên Chất liệu";
            dgvChatLieu.BackgroundColor = Color.DeepSkyBlue;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            
        }
        void LoadData()
        {
            dgvChatLieu.DataSource = connData.ReadData("Select MaChatLieu,TenChatLieu "+
                "from tblChatLieu");
        }

        private void dgvChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvChatLieu.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvChatLieu.CurrentRow.Cells[1].Value.ToString();
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtMa.Text.Trim()=="")
            {
                MessageBox.Show("Bạn phải chọn phần tử để sửa");
                return;

            }
            connData.UpdateData("update tblChatLieu Set TenChatLieu=N'" + txtTen.Text +
                "'where MaChatLieu='" + txtMa.Text + "'");
            LoadData();
            btnBoQua_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải chọn phần tử để xóa");
                return;

            }
            if(MessageBox.Show("Bạn có muốn xóa?","TB",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {
                    connData.UpdateData("Delete tblChatLieu where MaChatLieu='" + txtMa.Text + "'");
                    LoadData();
                    btnBoQua_Click(sender, e);
                }
                catch
                {
                    MessageBox.Show("Xóa không thành cong, do dữ liệu có liên quan đến sản phẩm khác!");
                }
            }    
           
        }
        void ResetValue()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtMa.Focus();

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            ResetValue();
        }
    }
}
