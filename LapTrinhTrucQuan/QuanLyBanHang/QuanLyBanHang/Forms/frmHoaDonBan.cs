using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyBanHang.Forms
{
    public partial class frmHoaDonBan : Form
    {
        Classes.CommonFunctions functions=new Classes.CommonFunctions();
        Classes.ConnectData data = new Classes.ConnectData();
        public frmHoaDonBan()
        {
            InitializeComponent();
            DataTable dtNhanVien =data.ReadData("select * from tblNhanVien");
            DataTable dtKH = data.ReadData("select * from tblKhach");
            DataTable dtHang = data.ReadData("select * from tblHang");
            DataTable dtHDBan = data.ReadData("select * from tblHDBan");
            functions.FillComboBox(cbMaNV, dtNhanVien, "Manhanvien", "Manhanvien");
            functions.FillComboBox(cbMaKH, dtKH, "Makhach", "Makhach");
            functions.FillComboBox(cbMaHang, dtHang, "Mahang", "Mahang");
            functions.FillComboBox(cboMaHDB, dtHDBan, "Mahdban", "mahdban");
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            DataTable dtNhanVien = data.ReadData("select * from tblNhanVien");
            DataTable dtKH = data.ReadData("select * from tblKhach");
            DataTable dtHang = data.ReadData("select * from tblHang");
            DataTable dtHDBan = data.ReadData("select * from tblHDBan");
            functions.FillComboBox(cbMaNV, dtNhanVien, "Manhanvien", "Manhanvien");
            functions.FillComboBox(cbMaKH, dtKH, "Makhach", "Makhach");
            functions.FillComboBox(cbMaHang, dtHang, "Mahang", "Mahang");
            functions.FillComboBox(cboMaHDB, dtHDBan, "Mahdban", "mahdban");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dtMaHD = data.ReadData("select * from tblHDBan where MaHDBan='" + cboMaHDB.Text + "'");
            DataTable dtchitietHDB = data.ReadData("Select tblChiTietHDBan.MaHang,"+
                "TenHang,tblCHiTietHDBan.SoLuong,DonGiaBan,GiamGia,ThanhTien from tblChiTietHDBan inner join tblHang on tblChiTietHDBan.MaHang=tblHang.MaHang " +
                "where MaHDBan='"+cboMaHDB.Text+"'");
            txtMaHDB.Text = cboMaHDB.Text;
            dtpNgayBan.Text = dtMaHD.Rows[0]["NgayBan"].ToString();
            cbMaNV.SelectedValue = dtMaHD.Rows[0]["MaNhanVien"];
            cbMaKH.SelectedValue = dtMaHD.Rows[0]["makhach"];
            dgvMH.DataSource = dtchitietHDB;
            lblTongTien.Text = dtMaHD.Rows[0]["tongtien"].ToString();


        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtNV = data.ReadData("Select TenNhanVien from tblNhanVien where MaNhanVien='" + cbMaNV.SelectedValue + "'");
            try
            {
                txtTenNV.Text = dtNV.Rows[0]["TenNhanVien"].ToString();
            }
            catch { }
           

        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtKH = data.ReadData("select *from tblKach where MaKhach ='" + cbMaKH.SelectedValue + "'");
                txtTenKH.Text = dtKH.Rows[0]["TenKhach"].ToString();
                txtDiaChi.Text = dtKH.Rows[0]["diachi"].ToString();
                txtDT.Text = dtKH.Rows[0]["DienThoai"].ToString();

            }
            catch { }
        }

        private void cbMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtHang = data.ReadData("select *from tblHang where MaHang='"+cbMaHang.SelectedValue + "'");
                txtTenHang.Text = dtHang.Rows[0]["TenHang"].ToString();
                txtDonGia.Text = dtHang.Rows[0]["DonGiaBan"].ToString();

            }
            catch { }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("bạn chỉ nhâp số");
                e.Handled = true;
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            float sl, dg, gg, tt;
            try
            {
                if (txtGiamGia.Text.Trim() == "")
                    gg = 0;
                else
                    gg = float.Parse(txtGiamGia.Text);
                if(txtSoLuong.Text.Trim()=="")
                    sl=0;
                else
                    sl = float.Parse(txtSoLuong.Text);
                dg = float.Parse(txtDonGia.Text);
                tt = dg * sl * (1 - gg / 100);
                txtThanhTien.Text = tt.ToString();
            }
            catch { }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaHDB.Text = functions.AutoCode("tblHDBan", "MaHDBan", "HDB" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString());
            
        }
        void ResetValues()
        {
            txtMaHDB.Text = "";
            cbMaKH.Text = "";
            dtpNgayBan.Text = "";
            dgvMH.DataSource = null;

        }

        private void txtMaHDB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sqlinsertHDB;
            float soluong, tongtien, slcon;
            DateTime dtNgayBan;
            if(cbMaNV.Text.Trim()=="")
            {
                MessageBox.Show("chua nhap ma nv");
                return;
            }
            if(cbMaKH.Text.Trim()=="")
            {
                MessageBox.Show("chua co thong tin khach hang");
                return ;
            }
            if(cbMaHang.Text.Trim()=="")
            {
                MessageBox.Show("chua nhap thong tin san pham");
                return;
            }
            if (txtSoLuong.Text.Trim()=="")
            {
                MessageBox.Show("ban chua nhap so luong");
                txtSoLuong.Focus();
                return;
            }

            dtNgayBan= Convert.ToDateTime(dtpNgayBan.Value.ToLongDateString());
            DataTable dataTable = data.ReadData("select * from tblHDBan where MaHDBan='" + txtMaHDB.Text + "'");
            if(dataTable.Rows.Count==0) // chua ton tai hoa don
            {
                sqlinsertHDB = "insert into tblHDBan values('"+txtMaHDB.Text+"','"+cbMaNV.SelectedValue+"','"
                    +String.Format("{0:MM/dd/yyyy}", dtNgayBan)+"','"+cbMaKH.SelectedValue+"','"+txtThanhTien.Text+"')";
                data.UpdateData(sqlinsertHDB);
            }
            DataTable dt = data.ReadData("select * from tblhang where MaHang='" +cbMaHang.SelectedValue+"'");
            slcon = float.Parse(dt.Rows[0]["SoLuong"].ToString());
            soluong = float.Parse(txtSoLuong.Text);
            if(slcon<soluong)
            {
                MessageBox.Show("ko con hang" + txtTenHang);
                txtSoLuong.Focus();
                return;
            }
            slcon = slcon - soluong;
            //insert bangChiTiethdb
            data.UpdateData("insert into tblChiTietHDBan values('"+txtMaHDB.Text+"','"+cbMaHang.SelectedValue+"',"+(int)soluong+",'"+txtGiamGia.Text+"','"+txtThanhTien.Text+"')");
            data.UpdateData("update tblHang set SoLuong="+(int)slcon+"where MaHang='"+cbMaHang.SelectedValue+"'");
            DataTable dtchitiet = data.ReadData("Select tblChiTietHDBan.MaHang," +
                "TenHang,tblCHiTietHDBan.SoLuong,DonGiaBan,GiamGia,ThanhTien from tblChiTietHDBan inner join tblHang on tblChiTietHDBan.MaHang=tblHang.MaHang " +
                "where MaHDBan='" + txtMaHDB.Text + "'");
            tongtien = 0;
            for(int i=0; i<dtchitiet.Rows.Count; i++)
            {
                tongtien = tongtien + float.Parse(dtchitiet.Rows[i]["ThanhTien"].ToString());

            }
            data.UpdateData("update tblHDBan set TongTien='" + tongtien.ToString() + "'where MaHDban='" + txtMaHDB + "'");
            dgvMH.DataSource = dtchitiet;
            lblTongTien.Text = "Tong tien: " + tongtien.ToString();
        
        
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btlHuy_Click(object sender, EventArgs e)
        {
            //update so luong
            float slcon, slmua;
            for(int i=0; i<dgvMH.Rows.Count-1; i++)
            {
                DataTable dthang = data.ReadData("select * from tblHang where MaHang=" + dgvMH.Rows[i].Cells[0].Value.ToString());
                slcon = float.Parse(dthang.Rows[0]["SoLuong"].ToString());
                slmua = float.Parse(dgvMH.Rows[i].Cells[2].Value.ToString());
                slcon = slcon + slmua;
                data.UpdateData("update tblHang set SoLuong="+ (int)slcon + "where MaHang='" + dgvMH.Rows[i].Cells[0].Value.ToString());
                
            }
            data.UpdateData("delete tblHDBan where MaHDBan='" + txtMaHDB + "'");
            //reset value
        }

        private void Xuat_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1];
            exRange.Font.Size = 15;
            exRange.Font.Bold = true;
            exRange.Font.Color = Color.Blue;
            exRange.Value = "SIEU THI MINI HUY HIEP";

            Excel.Range dc = (Excel.Range)exSheet.Cells[2, 1];
            dc.Font.Size = 13;
            dc.Font.Color = Color.Blue;
            dc.Value = "So 300 duong My Dinh";

            // in chu HOA DON BAN
            exSheet.Range["D4"].Font.Size = 20;
            exSheet.Range["D4"].Font.Bold = true;
            exSheet.Range["D4"].Font.Color = Color.Red;
            exSheet.Range["D4"].Value = "HOA DON BAN";

            

            // in cac thong tin chung
            exSheet.Range["A5:A8"].Font.Size = 12;
            exSheet.Range["A5"].Value = "Mã hóa đơn: " + txtMaHDB.Text;
            exSheet.Range["A6"].Value = "Khách hàng: " + cboMaHDB.SelectedValue.ToString() +
                    "-" + txtTenKH.Text;
            exSheet.Range["A7"].Value = "Địa chỉ: " + txtDiaChi.Text;
            exSheet.Range["A8"].Value = "Điện thoại: " + txtDT.Text;

            // in dong tieu de
            exSheet.Range["A10:G10"].Font.Size = 12;
            exSheet.Range["A10:G10"].Font.Bold = true;
            exSheet.Range["C10"].ColumnWidth = 25;
            exSheet.Range["G10"].ColumnWidth = 25;
            exSheet.Range["E10"].ColumnWidth = 20;

            exSheet.Range["A10"].Value = "STT";
            exSheet.Range["B10"].Value = "Mã hàng";
            exSheet.Range["C10"].Value = "Tên hàng";
            exSheet.Range["D10"].Value = "Số lượng";
            exSheet.Range["E10"].Value = "Đơn giá bán";
            exSheet.Range["F10"].Value = "Giảm giá";
            exSheet.Range["G10"].Value = "Thành tiền";



            exSheet.Range["B16"].Value = "Nhan vien: " + txtTenNV.Text;


            // in danh sách các chi tiét sp trong hóa đơn
            int dong = 11;
            for(int i = 0; i < dgvMH.Rows.Count - 1; i++)
            {
                exSheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = dgvMH.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = dgvMH.Rows[i].Cells[1].Value.ToString(); 
                exSheet.Range["D" + (dong + i).ToString()].Value = dgvMH.Rows[i].Cells[2].Value.ToString();
                exSheet.Range["E" + (dong + i).ToString()].Value = dgvMH.Rows[i].Cells[3].Value.ToString();
                exSheet.Range["F" + (dong + i).ToString()].Value = dgvMH.Rows[i].Cells[4].Value.ToString() + "%";
                exSheet.Range["G" + (dong + i).ToString()].Value = dgvMH.Rows[i].Cells[5].Value.ToString() + " đồng";
            }
            dong = dong + dgvMH.Rows.Count;
            exSheet.Range["F" + dong.ToString()].Value = "Tổng tiền: " + lblTongTien.Text + " đồng";
            exSheet.Name = txtMaHDB.Text;

            exBook.Activate();

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel 97-2002 WorkBook|*.xls|Excel Workbook|*.xlsx|All Files|*.*";
            save.FilterIndex = 2;
            if(save.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(save.FileName.ToLower());
            }
            exApp.Quit();

        }
    }
}
