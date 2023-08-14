using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int minute, second;
            minute = int.Parse(txtMinutes.Text);
            second = int.Parse(txtSecond.Text);
            if(second > 0 && second <= 59)
            {
                second = second - 1;
            }else
            {
                if(second == 0 && minute > 0)
                {
                    second = 59;
                    minute = minute - 1;
                }
                if(second == 0 && minute == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Hết giờ!");
                }
            }
            txtMinutes.Text = minute.ToString();
            txtSecond.Text = second.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMinutes.Text = "0";
            txtSecond.Text = "0";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
