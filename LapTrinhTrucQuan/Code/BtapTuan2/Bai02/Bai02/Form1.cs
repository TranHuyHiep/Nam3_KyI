using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        double d = 0.0;
        double Gia = 0.0;
        private void AddCombobox1()
        {
            comboBoxDoUong.Items.Add("Coca Cola");
            comboBoxDoUong.Items.Add("Pepsi");
            comboBoxDoUong.Items.Add("Seven Up");
        }
        private void AddConmbobox2()
        {
            for(int i= 1; i <= 10; i++)
            {
                comboBoxSL.Items.Add(i.ToString());
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddCombobox1();
            AddConmbobox2();
            this.KeyPreview = true;
        }

        private void bntThemMoi_Click(object sender, EventArgs e)
        {
            txtGia.Text = "";
            txtTen.Text = "";
            txtTien.Text = "";
            comboBoxSL.SelectedIndex = -1;
            comboBoxDoUong.SelectedIndex = -1;
            radioButtonCaNgay.Checked = false;
            radioButtonNuaNgay.Checked = false;
            //d = 0;

            txtTen.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonCaNgay_Click(object sender, EventArgs e)
        {
            if (radioButtonCaNgay.Checked)
            {
                txtGia.Text = "200";
            }else
            {
                txtGia.Text = "100";
            }
        }

        private void comboBoxDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxDoUong.SelectedItem == "Coca Cola")
            {
                d = 0.5;
            }else if(comboBoxDoUong.SelectedItem == "Pepsi")
            {
                d = 0.8;
            }
            else
            {
                d = 1.0;
            }
        }

        private void comboBoxSL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSL.SelectedIndex != -1)
            {
                string s = comboBoxSL.SelectedItem.ToString();
                int Sl = Convert.ToInt16(s);
                Gia = Sl * d;
                txtTien.Text = "" + Gia;
            }
        }

        private void bntThemVao_Click(object sender, EventArgs e)
        {
            if(txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Ten khong duoc bo trong!");
                return;
            }
            else
            {
                string items;
                items = txtTen.Text + " | ";
                if (radioButtonCaNgay.Checked)
                {
                    items = items + "ca ngay | ";
                }
                else
                {
                    items = items + "nua ngay | ";
                }
                items = items + txtGia.Text + "$ | " + "Do uong " + Gia + " | " +"Tong" + (int.Parse(txtGia.Text) + Gia);
                listBox1.Items.Add(items);
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo,

               MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)

                this.Close();
        }
    }
}
