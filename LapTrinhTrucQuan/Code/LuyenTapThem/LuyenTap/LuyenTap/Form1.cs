using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuyenTap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Connection connection = new Connection();

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.onloadData();
            dgvHienThi.DataSource = connection.readData("select * from tblMatHang");
        }
    }
}
