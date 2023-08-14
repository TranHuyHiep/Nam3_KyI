using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHoa.menu
{
    public partial class frmHDBan : Form
    {
        classes.CommonFunctions commonFunction = new classes.CommonFunctions();
        classes.ConnectData connectData = new classes.ConnectData();
        public frmHDBan()
        {
            InitializeComponent();
            DataTable dtNhanVien = connectData.ReadData("Select * from tblNhanVien");
            DataTable dtKh = connectData.ReadData("select * from tblKhachHang");
            DataTable dtHang = connectData.ReadData("select * from tblHang");
            DataTable dtHDBan = connectData.ReadData("select * from tblHDBan");
            commonFunction.FillComboBox(cboMaNV, dtNhanVien, "MaNhanVien", "MaKhach");
            commonFunction.FillComboBox(cboMaKhach, dtKh, "MaKhach", "MaKhach");
            commonFunction.FillComboBox(cboMaHang, dtHang, "MaHang", "MaHang");
            commonFunction.FillComboBox(cboMaHD, dtHDBan, "MaHDBan", "MaHDBan");
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void frmHDBan_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dtHDBan = connectData.ReadData("select * from tblHDBan where MaHDBan='" + cboMaHD.Text + "'");
            DataTable dtChiTietHDBan = connectData.ReadData("select tblChiTietHDBan.MaHang, TenHang, tblChiTietHDBan.SoLuong, " +
                "DonGiaBan, GiamGia, ThanhTien from tblChiTietHDBan inner join tblHang on tblChiTietHDBan.MaHang = tblHang.MaHang" +
                " where MaHDBan='" + cboMaHD.Text + "'");
            txtMaHD.Text = cboMaHD.Text;
            dateNgayBan.Text = dtHDBan.Rows[0]["NgayBan"].ToString();
            cboMaNV.SelectedValue = dtHDBan.Rows[0]["MaNhanVien"];
            cboMaKhach.SelectedValue = dtHDBan.Rows[0]["MaKhach"];
            dgvChiTietHD.DataSource = dtChiTietHDBan;
            txtTongTien.Text = dtHDBan.Rows[0]["TongTien"].ToString(); 

        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtNV = connectData.ReadData("select TenNhanVien from tblNhanVien" +
                    " where MaNhanVien='" + cboMaNV + "'");
                txtTenNhanVien.Text = dtNV.Rows[0]["TenKhach"].ToString();
            }
            catch
            {

            }

        }

        private void cboMaKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtKH = connectData.ReadData("select * from tblKhach where " +
                    "MaKach = '" + cboMaKhach.SelectedValue + "'");
                txtTenKhach.Text = dtKH.Rows[0]["TenNhanVien"].ToString();
                txtDiaChi.Text = dtKH.Rows[0]["DonGiaBan"].ToString();
            } catch
            {

            }

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                MessageBox.Show("Bạn chỉ nhập sô nguyên!");
                e.Handled = true;
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            float sl, dg, gg, tt;
            if(txtGiamGia.Text.Trim() == "")
            {
                gg = 0;
            } 
            else
            {
                gg = float.Parse(txtGiamGia.Text);
            }
            if(txtSoLuong.Text.Trim() == "")
            {
                sl = 0;
            }
            else
            {
                sl = float.Parse(txtSoLuong.Text);
            }
            dg = float.Parse(txtDonGia.Text);
            tt = dg * sl * ((1 - gg) / 100);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = commonFunction.AutoCode("tblHDBan", "MaHDBan", "HDB" +
                DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() +
                DateTime.Now.Year.ToString());
        }
        void ResetValue()
        {
            txtMaHD.Text = "";
            dateNgayBan.Text = "";
            cboMaHang.Text = "";
            cboMaKhach.Text = "";
            txtTenHang.Text = "";
            txtTenKhach.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtDonGia.Text = "";
            txtGiamGia.Text = "";
            txtMaHD.Text = "";
            txtTongTien.Text = "";
            txtThanhTien.Text = "";
            dgvChiTietHD.DataSource = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sqlinsertHDBan;
            float slMua, slCon, tongtien;
            // kiểm tra tính đầy đủ của dữ liệu
            if(cboMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có thông tin nhân viên bán");
                return;
            }
            if(cboMaKhach.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có thông tin khách hàng");
                return;
            }
            if(cboMaHang.Text.Trim() == "")
            {
                MessageBox.Show("Chưa có thông tin sản phẩm");
                return;
            }
            if(txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng sản phẩm");
                return;
            }
            // khi lưu hóa đơn xảy ra hai trường hợp.
            // TH1: tblHDBan đã có hóa đơn với mã vừa sinh => update lại hóa đơn
            // TH2: chưa có hóa đơn                        => insert hóa đơn
            DataTable dtHDBan = DataTable.ReadData("select * from tblHDBan where MaHDBan='" +
                txtMaHD.Text + "'");
            dtNgayBan = Convert.ToDateTime(dataNgayBan.Value.ToLongDateString());
            if(dtHDBan.Rows.Count == 0)
            {
                sqlinsertHDBan = "insert into tblHDBan values('" + 
                    txtMaHD.Text + "', '" +
                    cboMaNV.Text + "'," +
                    String.Format("{0:MM/dd/yyyy}", dtNgayBan) + ",'" +
                    cboMaKhach.SelectedValue + "','" +
                    txtThanhTien.Text + "')";
                data.UpdateData(sqlinsertHDBan);
            }

            // tblHD đã tồn tại
            // 1. kiểm tra số lượng còn không
            DataTable dtHang = DataTable.ReadData("select * from tblHang where MaHang = '" +
                cboMaHang.SelectedValue + "'");
            slCon = float.Parse(dtHang.Rows[0]["SoLuong"]).ToString();
            slMua = float.Parse(txtSoLuong.Text);
            if(slCon < slMua)
            {
                MessageBox.Show("Không còn đủ số lượng. Sản phẩm " + txtTenHang.Text + " chỉ còn " + slCon);
                txtSoLuong.Focus();
                return;
            }
            slCon = slCon - slMua;
            // insert vào bảng tblChiTiet
            data.UpdateData("insert into tblChiTietHDBan values('" + txtMaHD.Text +
                "','" + cboMaHang.SelectedValue + 
                "'," + (int) slMua +
                ",'" + txtGiamGia.Text +
                "','" + txtThanhTien.Text +
                "')");
            // update lại bảng tblHang
            data.UpdateData("update tblHang set SoLuong = " + (int)slCon + " where MaHang = " +
                cboMaHang.SelectedValue);
            // update tblcHDBan cho tổng tiền
            DataTale dtChiTiet = data.ReadData("select * from tblChiTietHDBan = " +
                txtMaHD.Text);
            tongtien = 0;
            for(int i  = 0; i < dtChiTiet.Rows.Count; i++)
            {
                tongtien = tongtien + float.Parse(dtChiTiet.Rows[i]["ThanhTien"].ToString());
            }
            data.UpdateData("update tblHDBan set TongTien = '" +
                tongtien.ToString() +
                "' where MaHDBan = '" + txtMaHD.Text);
            // hiển thị dữ liệu lên datagridview
            dgvChiTietHD.DataSource = dtChiTiet;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // hủy hóa đơn
            // 1. Update lại số lượng hàng trong bảng tblHang
            float slCon, slMua;
            for(int i = 0; i < dgvChiTietHD.Rows.Count - 1; i++)
            {
                DataTable dtHang = data.ReadData("select * from tblHang where MaHang = " +
                    dgvChiTietHD.Rows[i].Cells[0].Value.ToString());
                slCon = float.Parse(dtHang.Rows[0]["SoLuong"].ToString());
                slMua = float.Parse(dgvChiTietHD.Rows[i].Cells[2].Value.ToString());
                slCon = slCon + slMua;
                data.UpdateData("Update tblHang set SoLuong = " +
                    (int)slCon + "where MaHang = '" +
                    dgvChiTietHD.Rows[i].Cells[0].Value);
            }
            // 2. xóa hóa đơn ra khỏi database
            data.Update("delete tblHDBan where MaHDBan = '" + txtMaHD.Text + "'");
            ResetValue();
        }

        private void dgvChiTietHD_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
