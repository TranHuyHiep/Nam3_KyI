using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2_T55
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int tong = a + b;
            textBox3.Text = tong.ToString();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
