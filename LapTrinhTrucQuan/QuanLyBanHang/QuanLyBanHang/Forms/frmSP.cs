using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmSP : Form
    {
        Classes.CommonFunctions function = new Classes.CommonFunctions();
        Classes.ConnectData data = new Classes.ConnectData();
        string fileAnh;

        public frmSP()
        {
            InitializeComponent();
            DataTable dtChatLieu = data.ReadData("Select * from tblChatLieu");
            function.FillComboBox(cboChatLieu, dtChatLieu, "TenChatLieu", "MaChatLieu");
        }

        private void frmSP_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvHang.Columns[0].HeaderText = "Mã hàng";
            dgvHang.Columns[1].HeaderText = "Tên hàng";
            dgvHang.Columns[2].HeaderText = "Chất liệu";
            dgvHang.Columns[3].HeaderText = "Số lượng";
            dgvHang.Columns[4].HeaderText = "Đơn giá nhập";
            dgvHang.Columns[5].HeaderText = "Đơn giá bán";
            dgvHang.Columns[6].HeaderText = "Ảnh";
            dgvHang.Columns[7].HeaderText = "Ghi chú";
            ResetValue();
        }

        void LoadData()
        {
            DataTable dtHang = data.ReadData("Select * from tblhang");
            dgvHang.DataSource = dtHang;           
        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvHang.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvHang.CurrentRow.Cells[1].Value.ToString();
            cboChatLieu.SelectedValue= dgvHang.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text= dgvHang.CurrentRow.Cells[3].Value.ToString();
            txtDonGiaNhap.Text= dgvHang.CurrentRow.Cells[4].Value.ToString();
            txtDonGiaBan.Text=dgvHang.CurrentRow.Cells[5].Value.ToString();
            txtGhiChu.Text= dgvHang.CurrentRow.Cells[7].Value.ToString();
            fileAnh= dgvHang.CurrentRow.Cells[6].Value.ToString();
            try
            {
                picAnh.Image = Image.FromFile(Application.StartupPath + "\\Images\\Products\\" + fileAnh);
            }
            catch
            {
                picAnh.Image = null;
            }
            btnThem.Enabled = false;
            btnsua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            string[] image;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "JPEG Images|*.jpg|PNG Images|*.png|All files|*.*";
            openFile.FilterIndex = 1;
            openFile.InitialDirectory=Application.StartupPath;
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(openFile.FileName);
                image = openFile.FileName.ToString().Split('\\');
                fileAnh = image[image.Length-1];
                
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra tính hợp lệ và đầy đủ của dữ liệu-->Tự viết
            //Kiểm tra có trùng mã hàng không
            DataTable dtCheckHang = data.ReadData("Select * from tblHang where MaHang='" + txtMa.Text + "'");
            if(dtCheckHang.Rows.Count>0)
            {
                MessageBox.Show("Mã hàng đã có, mời bạn nhập mã khác");
                txtMa.Focus();
                return;
            }
            //Thêm mới hàng vào DataBase 
            string sqlInsert = "insert into tblHang values('" + txtMa.Text + "',N'" + txtTen.Text + "','" + cboChatLieu.SelectedValue +
                "'," + int.Parse(txtSoLuong.Text) + "," + float.Parse(txtDonGiaNhap.Text) + "," + float.Parse(txtDonGiaBan.Text) +
                ",'"+fileAnh+"',N'"+txtGhiChu.Text+"')";
            data.UpdateData(sqlInsert);
            LoadData();
            MessageBox.Show("Thêm mới thành công");
            ResetValue();

        }

        void ResetValue()

        {
            txtMa.Text = "";
            txtTen.Text = "";
            cboChatLieu.Text = "";
            txtSoLuong.Text = "";
            txtGhiChu.Text = "";
            txtDonGiaBan.Text = "";
            txtDonGiaNhap.Text = "";
            picAnh.Image = null;
            fileAnh = "";
            txtMa.Focus();
            btnThem.Enabled = true;
            btnsua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa không?", "Có hay không",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    data.UpdateData("delete tblHang where MaHang='" + txtMa.Text + "'");
                    LoadData();
                    ResetValue();
                }
                catch
                {
                    MessageBox.Show("Bạn không được xóa vì nó liên quan đến các hóa đơn.");
                }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            //Kiểm tra tính đầy đủ và chính xác của dữ liệu --> Tự check
            //Sửa dữ liệu
            data.UpdateData("update tblHang set TenHang=N'" + txtTen.Text +
                "',MaChatLieu='"+cboChatLieu.SelectedValue+"',SoLuong="+int.Parse(txtSoLuong.Text)+
                ",DonGiaNhap="+float.Parse(txtDonGiaNhap.Text)+",DonGiaBan="+float.Parse(txtDonGiaBan.Text)+",Anh='"+
                fileAnh+"',GhiChu=N'"+txtGhiChu.Text+"' where MaHang='"+txtMa.Text+"'");
            LoadData();
            ResetValue();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cboChatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                this.Close();
            }
            return;
        }
    }
}
