using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3_T55
{
    public partial class Form1 : Form
    {
        int[] a;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            a = new int[n]; 
            Random random = new Random();  
            string result = "";
            for(int i = 0; i < n; i++)
            {
                a[i] = random.Next(1, 100);
                result += a[i] + "  ";
            }
            textBox2.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
            }
            textBox3.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            for (int i = 0; i < a.Length; i++)
            {
                for(int j = i + 1; j < a.Length; j ++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j]; 
                        a[j] = temp;
                    }
                }
            }
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += a[i] + "  ";
            }
            textBox4.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
