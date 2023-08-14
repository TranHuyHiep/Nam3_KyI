using System;
using System.Windows.Forms;

namespace QLBanHoa
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public static string userName = "";
        private void chatLieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            if (!CheckExistForm("Form1"))
            {
                Form1 frm = new Form1();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            } else
            {
                ActiveForm("Form1");
            }
            */
        }
        // kiểm tra sự tồn tại của form

        bool CheckExistForm(string formName)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if(frm.Name == formName)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        // active 1 form
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

        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmSP"))
            {
                menu.frmSP frm = new menu.frmSP();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                ActiveChildForm("frmSP");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void hoaDonBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmSP"))
            {
                menu.frmHDBan frm = new menu.frmHDBan();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            else
            {
                ActiveChildForm("frmSP");
            }
        }
    }
}
