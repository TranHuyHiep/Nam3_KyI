using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuDo
{
    public partial class Form1 : Form
    {
        string number, country;
        public Form1()
        {
            InitializeComponent();
            HaGiang.Tag = "23";
            HaNoi.Tag = "29";
            HaiDuong.Tag = "34";
            BacNinh.Tag = "99";
            BacGiang.Tag = "98";
            CaoBang.Tag = "11";
            ThanhHoa.Tag = "36";
            NinhBinh.Tag = "35";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        void Empty()
        {
            foreach(Control chk in groupBox1.Controls)
            {
                if(chk is RadioButton)
                {
                    RadioButton chkCountry = (RadioButton)chk;
                    chkCountry.Checked = false;
                }
            }
        }

        private void CheckCountry(object sender, EventArgs e)
        {
            RadioButton rdoNumber = sender as RadioButton;
            if(number == rdoNumber.Text)
            {
                lblResult.Text = "Bạn đã chọn đúng!";
            } else
            {
                lblResult.Text = "Bạn đã chọn sai!";
            }

        }

        private void ClickCountry(object sender, EventArgs e)
        {
            RadioButton rdoCountry = sender as RadioButton;
            country = rdoCountry.Text;
            number = rdoCountry.Tag.ToString();
            lblResult.Text = "Mời bạn chọn số cho " + country;
            Empty();
        }
    }
}
