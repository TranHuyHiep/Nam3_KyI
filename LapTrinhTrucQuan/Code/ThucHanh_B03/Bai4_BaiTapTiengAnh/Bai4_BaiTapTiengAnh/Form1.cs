using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_BaiTapTiengAnh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bàiĐiềnTừ1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaiTapDienTu baiTapDienTu = new BaiTapDienTu();
            baiTapDienTu.Debai = "Today computers come ____(1)___ all shapes and sizes.There were still big computers for companies or universities. " +
                "There are other special computers for factories. These large computers tell the fatory machines ___(2)___ to do. But there are also small ___(3)___ " +
                "computers to use at home or in an office. There are even computers in telephones, television ___(4)___, and cars. These computers have to be small. " +
                "They are so small that you cannot ___(5)___ see all their parts.Computers are very useful, but they also can ____(6)___ problems. " +
                "One kind of problems is with the computer's memory. It is not perfect so sometimes computers ___(7)___ important information. " +
                "Another problem is with the machinery. Computers are machines, and machines can break down. When the computers break down, " +
                "they may ___(8)___ information, ___(9)___ chalk on a blackboard. Or they may stop doing anything at all. And there is ___(10)____ different kind of " +
                "problem with computers. Some doctors say they may be bad for your health. They say you should not work with computers all day.";
            baiTapDienTu.Dapan = "Today computers come (1) in all shapes and sizes.There were still big computers for companies or universities. " +
                "There are other special computers for factories. These large computers tell the fatory machines (2) what to do. But there are also small (3) personal " +
                "computers to use at home or in an office. There are even computers in telephones, television (4) sets, and cars. These computers have to be small. " +
                "They are so small that you cannot (5) even see all their parts.Computers are very useful, but they also can (6) useful problems. " +
                "One kind of problems is with the computer's memory. It is not perfect so sometimes computers (7) lose important information. " +
                "Another problem is with the machinery. Computers are machines, and machines can break down. When the computers break down, " +
                "they may (8) erase information, (9) like chalk on a blackboard. Or they may stop doing anything at all. And there is (10) another different kind of " +
                "problem with computers. Some doctors say they may be bad for your health. They say you should not work with computers all day.";
            List<string> list = new List<string>();
            list.Add("in");
            list.Add("what");
            list.Add("personal");
            list.Add("sets");
            list.Add("even");
            list.Add("useful");
            list.Add("lose");
            list.Add("erase");
            list.Add("like");
            list.Add("another");

            baiTapDienTu.Dapantungcau = list;

            FormBaiTapDienTu formBaiTapDienTu = new FormBaiTapDienTu(baiTapDienTu);
            formBaiTapDienTu.MdiParent = this;
            formBaiTapDienTu.Show();
        }
    }
}
