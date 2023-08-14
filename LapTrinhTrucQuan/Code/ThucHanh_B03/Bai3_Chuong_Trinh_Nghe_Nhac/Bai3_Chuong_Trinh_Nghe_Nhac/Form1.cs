using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_Chuong_Trinh_Nghe_Nhac
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            DriveInfo[] drivers = DriveInfo.GetDrives();
            foreach (DriveInfo d in drivers)
            {
                cbbODia.Items.Add(d.Name);
            }
        }

        private void cbbODia_SelectedIndexChanged(object sender, EventArgs e)
        {
            String nameDicrectory = cbbODia.SelectedItem.ToString();
            DirectoryInfo directory = new DirectoryInfo(nameDicrectory);
            DirectoryInfo[] directories = directory.GetDirectories("*.*");
            cbbThuMuc.Items.Clear();
            foreach (DirectoryInfo d in directories)
            {
                cbbThuMuc.Items.Add(d.Name);
            }
        }

        private void cbbThuMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            String nameDicrectory = cbbODia.SelectedItem.ToString();
            String nameThuMuc = cbbThuMuc.SelectedItem.ToString();
            DirectoryInfo directory = new DirectoryInfo(nameDicrectory+ nameThuMuc);
            lbTapTin.Items.Clear();
            txtLoiBaiHat.Text = "";
            FileInfo[] files = directory.GetFiles();
            foreach(FileInfo d in files)
            {
                lbTapTin.Items.Add(d);
            }
        }

        private void lbTapTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            String nameDicrectory = cbbODia.SelectedItem.ToString();
            String nameThuMuc = cbbThuMuc.SelectedItem.ToString();
            string nameMusic = lbTapTin.Text.ToString();
            axWindowsMediaPlayer1.URL = nameDicrectory + "//" + nameThuMuc + "//" + nameMusic;

            FileStream fs = new FileStream("E:\\UTC\\Why-LyricsMCK.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            String lyric = rd.ReadToEnd();
            txtLoiBaiHat.Text = lyric;
        }


    }
}
