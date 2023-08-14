namespace Vd1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bntTimKiem = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntThemVao = new System.Windows.Forms.Button();
            this.bntThemMoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTienGui = new System.Windows.Forms.TextBox();
            this.txtNgayGui = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbThoiGianGui = new System.Windows.Forms.ComboBox();
            this.radioThuong = new System.Windows.Forms.RadioButton();
            this.radioPhatLoc = new System.Windows.Forms.RadioButton();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbThoiGianGui);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtNgayGui);
            this.groupBox1.Controls.Add(this.txtTienGui);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bntThemMoi);
            this.groupBox1.Controls.Add(this.bntThemVao);
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 501);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhap thong tin khach hang";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(466, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(681, 408);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sach khach hang";
            // 
            // bntTimKiem
            // 
            this.bntTimKiem.Location = new System.Drawing.Point(765, 455);
            this.bntTimKiem.Name = "bntTimKiem";
            this.bntTimKiem.Size = new System.Drawing.Size(150, 45);
            this.bntTimKiem.TabIndex = 2;
            this.bntTimKiem.Text = "&Tim kiem";
            this.bntTimKiem.UseVisualStyleBackColor = true;
            // 
            // bntThoat
            // 
            this.bntThoat.Location = new System.Drawing.Point(969, 455);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(150, 45);
            this.bntThoat.TabIndex = 3;
            this.bntThoat.Text = "&Thoat";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // bntThemVao
            // 
            this.bntThemVao.Location = new System.Drawing.Point(50, 432);
            this.bntThemVao.Name = "bntThemVao";
            this.bntThemVao.Size = new System.Drawing.Size(103, 33);
            this.bntThemVao.TabIndex = 3;
            this.bntThemVao.Text = "Them Vao";
            this.bntThemVao.UseVisualStyleBackColor = true;
            this.bntThemVao.Click += new System.EventHandler(this.bntThemVao_Click);
            // 
            // bntThemMoi
            // 
            this.bntThemMoi.Location = new System.Drawing.Point(240, 432);
            this.bntThemMoi.Name = "bntThemMoi";
            this.bntThemMoi.Size = new System.Drawing.Size(103, 33);
            this.bntThemMoi.TabIndex = 4;
            this.bntThemMoi.Text = "Them Moi";
            this.bntThemMoi.UseVisualStyleBackColor = true;
            this.bntThemMoi.Click += new System.EventHandler(this.bntThemMoi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ma KH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ho va Ten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dia Chi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "So tien gui";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngay Gui";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Thoi gian gui";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(109, 63);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(234, 22);
            this.txtMaKH.TabIndex = 11;
            this.txtMaKH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKH_KeyPress);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(109, 111);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(234, 22);
            this.txtTen.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(109, 157);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(234, 22);
            this.txtDiaChi.TabIndex = 13;
            // 
            // txtTienGui
            // 
            this.txtTienGui.Location = new System.Drawing.Point(109, 203);
            this.txtTienGui.Name = "txtTienGui";
            this.txtTienGui.Size = new System.Drawing.Size(234, 22);
            this.txtTienGui.TabIndex = 14;
            this.txtTienGui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKH_KeyPress);
            // 
            // txtNgayGui
            // 
            this.txtNgayGui.Location = new System.Drawing.Point(109, 250);
            this.txtNgayGui.Name = "txtNgayGui";
            this.txtNgayGui.Size = new System.Drawing.Size(234, 22);
            this.txtNgayGui.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioPhatLoc);
            this.groupBox3.Controls.Add(this.radioThuong);
            this.groupBox3.Location = new System.Drawing.Point(37, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 59);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loai tiet kiem";
            // 
            // cbThoiGianGui
            // 
            this.cbThoiGianGui.FormattingEnabled = true;
            this.cbThoiGianGui.Location = new System.Drawing.Point(132, 293);
            this.cbThoiGianGui.Name = "cbThoiGianGui";
            this.cbThoiGianGui.Size = new System.Drawing.Size(121, 24);
            this.cbThoiGianGui.TabIndex = 18;
            // 
            // radioThuong
            // 
            this.radioThuong.AutoSize = true;
            this.radioThuong.Location = new System.Drawing.Point(24, 21);
            this.radioThuong.Name = "radioThuong";
            this.radioThuong.Size = new System.Drawing.Size(74, 20);
            this.radioThuong.TabIndex = 0;
            this.radioThuong.TabStop = true;
            this.radioThuong.Text = "Thuong";
            this.radioThuong.UseVisualStyleBackColor = true;
            // 
            // radioPhatLoc
            // 
            this.radioPhatLoc.AutoSize = true;
            this.radioPhatLoc.Location = new System.Drawing.Point(176, 21);
            this.radioPhatLoc.Name = "radioPhatLoc";
            this.radioPhatLoc.Size = new System.Drawing.Size(80, 20);
            this.radioPhatLoc.TabIndex = 1;
            this.radioPhatLoc.TabStop = true;
            this.radioPhatLoc.Text = "Phat Loc";
            this.radioPhatLoc.UseVisualStyleBackColor = true;
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 16;
            this.lstDanhSach.Location = new System.Drawing.Point(6, 21);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(669, 372);
            this.lstDanhSach.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 528);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntTimKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNgayGui;
        private System.Windows.Forms.TextBox txtTienGui;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntThemMoi;
        private System.Windows.Forms.Button bntThemVao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntTimKiem;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.ComboBox cbThoiGianGui;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioPhatLoc;
        private System.Windows.Forms.RadioButton radioThuong;
        private System.Windows.Forms.ListBox lstDanhSach;
    }
}

