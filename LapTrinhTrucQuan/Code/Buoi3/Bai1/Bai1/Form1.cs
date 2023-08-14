using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            this.Font = new Font(this.Font.Name, this.Font.Size, this.Font.Style ^ chk.Font.Style);
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            string sinhVien;
            sinhVien = listSinhVien.SelectedItem.ToString();
            string[] sv = sinhVien.Split('|');
            txtMa.Text = sv[0];
            txtTen.Text = sv[1];
            if (sv[2] == "Nam")
            {
                radioNam.Checked = true;
            } else {
                    radioNu.Checked = true;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sex, sv;
            if(radioNam.Checked == true)
            {
                sex = "Nam";
            } else
            {
                sex = "Nữ";
            }
            sv = txtMa.Text + "|" + txtTen.Text + "|" + sex;
            listSinhVien.Items.Add(sv);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = listSinhVien.SelectedIndex;
            if(index == -1)
            {
                MessageBox.Show("Bạn cần chọn sinh viên để xóa!");
            }
            if(MessageBox.Show("Bạn có chắc muốn xóa không?", "Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listSinhVien.Items.RemoveAt(index);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listSinhVien.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Bạn cần chọn sinh viên để sửa!");
                return;
            }

            string sv, sex;
            if (radioNam.Checked == true)
            {
                sex = "Nam";
            }
            else
            {
                sex = "Nữ";
            }
            sv = txtMa.Text + "|" + txtTen.Text + "|" + sex;

            if (MessageBox.Show("Bạn có chắc muốn sửa không?", "Sửa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listSinhVien.Items[index] = sv;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 7; i <= 40; i++)
                cboFontSize.Items.Add(i.ToString());
            }

        private void cboFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int size = int.Parse(cboFontSize.SelectedItem.ToString());
            this.Font = new Font(this.Font.Name, size);
        }
    }

}
