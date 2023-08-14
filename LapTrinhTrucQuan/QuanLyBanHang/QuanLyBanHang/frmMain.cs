using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Form1"))
            {
                Form1 frm = new Form1();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
                ActiveChildForm("Form1");
        }
        //Kiểm tra sự tồn tại của form
        bool CheckExistForm(string formName)
        {
            bool check = false;
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name==formName)
                {
                    check = true;
                    break;
                }    
            }    
            return check;
        }
        //Active 1 form
       void ActiveChildForm(string formName)
        {
            
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == formName)
                {
                    frm.Activate();
                    break;
                }
            }
            
        }

        private void mnuSP_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmSP"))
            {
                Forms.frmSP frm = new Forms.frmSP();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
                ActiveChildForm("Form1");
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmHoaDonBan"))
            {
                Forms.frmHoaDonBan frm = new Forms.frmHoaDonBan();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
                ActiveChildForm("frmHoaDonBan");
        }
    }
}
