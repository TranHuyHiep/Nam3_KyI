using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nghich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == "anh")
            {
                textBox1.Text = "1";
            }
            if (comboBox1.SelectedItem == "hiep")
            {
                textBox1.Text = "2";
            }
            if (comboBox1.SelectedItem == "duc")
            {
                textBox1.Text = "3";
            }
            if (comboBox1.SelectedItem == "dinh")
            {
                textBox1.Text = "4";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
