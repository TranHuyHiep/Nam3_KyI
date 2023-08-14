using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH4_CoSoDuLieu
{
    public partial class frmMatHang : Form
    {
        public frmMatHang()
        {
            InitializeComponent();
        }

        classes.DataBaseProcess dataBaseProcess = new classes.DataBaseProcess();

        // phương thức ẩn hiện các control trong group bõ chi tiết
        private void hienChiTiet(bool hien)
        {
            txtMaSP.Enabled = hien;
            txtTenSP.Enabled = hien;
            dtpNgayHH.Enabled = hien;
            dtpNgaySX.Enabled = hien;
            txtDonVi.Enabled = hien;
            txtDonGia.Enabled = hien;
            txtGhiChu.Enabled = hien;
            //Ẩn hiện 2 nút Lưu và Hủy
            btnLuu.Enabled = hien;
            btnHuy.Enabled = hien;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // cập nhật nhãn trên tiêu đề
            lblTieuDe.Text = "TÌM KIẾM MẶT HÀNG";
            // cấm nút sửa và xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //viết câu lệnh sql cho tìm kím
            string sql = "select * from tblMatHang where MaSP is not null";
            // tìm theo MaSP khác rỗng
            if(txtTKMaSP.Text.Trim() != "")
            {
                sql += " and MaSP like '%" + txtTKMaSP.Text + "%'";
            }
            // kiểm tra tên sản phẩm
            if(txtTKTenSP.Text.Trim() != "")
            {
                sql += " and TenSP like N'%" + txtTKTenSP.Text + "%'";
            }

            // load dữ liệu tìm được lên dataGridView
            dgvSanPham.DataSource = dataBaseProcess.DataReader(sql);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "TB", MessageBoxButtons.YesNo,
MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void frmMatHang_Load_1(object sender, EventArgs e)
        {
            // load dữ liệu lên data gridview
            dgvSanPham.DataSource = dataBaseProcess.DataReader("select * from tblMatHang");
            // ẩn nút sửa, xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            // ẩn groupbox chi tiết
            hienChiTiet(false);
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Hiển thị nút sửa
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            // bắt lỗi người sử dụng click linh tinh lên datagridview
            try
            {
                txtMaSP.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
                txtTenSP.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
                dtpNgaySX.Value = (DateTime) dgvSanPham.CurrentRow.Cells[2].Value;
                dtpNgayHH.Value = (DateTime) dgvSanPham.CurrentRow.Cells[3].Value;
                txtDonVi.Text = dgvSanPham.CurrentRow.Cells[4].Value.ToString();
                txtDonGia.Text = dgvSanPham.CurrentRow.Cells[5].Value.ToString();
                txtGhiChu.Text = dgvSanPham.CurrentRow.Cells[6].Value.ToString();
            } catch(Exception ex)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa mặt hàng " + txtMaSP.Text + " không ?", 
                "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lblTieuDe.Text = "XÓA MẶT HÀNG";
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                hienChiTiet(true);
            }
        }

        private void XoaTrangChiTiet()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            dtpNgaySX.Value = DateTime.Today;
            dtpNgayHH.Value = DateTime.Today;
            txtDonVi.Text = "";
            txtDonGia.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "THÊM MẶT HÀNG";
            XoaTrangChiTiet();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            hienChiTiet(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "CẬP NHẬT MẶT HÀNG";
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            hienChiTiet(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            // sử dụng control ErrorProvider để hiển thị lỗi
            // Kiểm tra tên sản phẩm có bị để trống không
            if(txtTenSP.Text.Trim() == "")
            {
                errChiTiet.SetError(txtTenSP, "Bạn không thể để trống tên sản phẩm!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            // kiểm tra ngày sản xuất, lỗi nếu người sử dụng nhập vào
            // ngày sản xuất lớn hơn ngày hiện tại
            if(dtpNgaySX.Value > DateTime.Now)
            {
                errChiTiet.SetError(dtpNgaySX, "Ngày sản xuất không hợp lệ!");
                return;
            } 
            else
            {
                errChiTiet.Clear();
            }
            // kiểm tra ngày hết hạn xem có lớn hơn ngày sản xuất không
            if(dtpNgayHH.Value < dtpNgaySX.Value)
            {
                errChiTiet.SetError(dtpNgayHH, "Ngày hết hạn nhỏ hơn ngày sản xuất!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            // Kiểm tra đơn vị xem có để trống không
            if (txtDonVi.Text.Trim() == "")
            {
                errChiTiet.SetError(txtDonVi, "Bạn không thể để trống đơn vị!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            // Kiểm tra đơn giá có để trống không
            if (txtDonGia.Text.Trim() == "")
            {
                errChiTiet.SetError(txtDonGia, "Bạn không thể để trống đơn giá!");
                return;
            }
            else
            {
                errChiTiet.Clear();
            }
            
            // Nếu nút thêm enable thì thực hiện thêm mới
            if(btnThem.Enabled == true)
            {
                // kiểm tra xem ô nhập MaSP có bị trống không
                if(txtMaSP.Text.Trim() == "")
                {
                    errChiTiet.SetError(txtMaSP, "Bạn không thể để trống mã sản phẩm này!");
                    return;
                }
                else
                {
                    // kiểm tra xem mã sản phẩm đã tồn tại chưa để tránh việc insert mới bị lỗi
                    sql = "select * from tblMatHang where MaSP = N'" + txtMaSP.Text + "'";
                    DataTable dataTable = dataBaseProcess.DataReader(sql);
                    if(dataTable.Rows.Count > 0)
                    {
                        errChiTiet.SetError(txtMaSP, "Mã sản phẩm trùng trong dữ liệu!");
                        return;
                    }
                    errChiTiet.Clear();
                }
                // INSERTR TO SQL
                sql = "INSERT  INTO  SanPham(MaSP, TenSP, NgaySX, NgayHH, DonVi, DonGia, GhiChu) VALUES("; sql += "'" + txtMaSP.Text + "',N'" + txtTenSP.Text +
                    "', convert(datetime, '" + dtpNgaySX.Value.Date + "', 5) " +
                    "', convert(datetime, '" + dtpNgayHH.Value.Date + "', 5) " + 
                    "',N'" + txtDonVi.Text + "', '" + txtDonGia.Text + "',N'" + txtGhiChu.Text + "')";
            }

            // nếu nút sửa enalble thì thực hiện sửa
            if (btnSua.Enabled == true)
            {
                sql = "Update tblMatHang SET ";
                sql += "TenSP = N'" + txtTenSP.Text + "',";
                sql += "NgaySX = '" + dtpNgaySX.Value.Date + "',";
                sql += "NgayHH = '" + dtpNgayHH.Value.Date + "',";
                sql += "DonVi = N'" + txtDonVi.Text + "',";
                sql += "DonGia = '" + txtDonGia.Text + "',";
                sql += "GhiChu = N'" + txtGhiChu.Text + "' ";
                sql += "Where MaSP = '" + txtMaSP.Text + "'";
            }
            
            // nếu nút xóa enable thì thực hiện xóa
            if(btnXoa.Enabled == true)
            {
                sql = "delete from tblMatHang where MaSP = '" + txtMaSP.Text + "'";
            }
            dataBaseProcess.DataChange(sql);
            // cập nhật lại dataGrid
            sql = "select * from tblMatHang";
            dgvSanPham.DataSource = dataBaseProcess.DataReader(sql);
            hienChiTiet(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // thiết lập các nút như ban đầu
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            // xóa trang chi tiết
            XoaTrangChiTiet();
            // cấm nhập vào
            hienChiTiet(false);
        }
    }
}
