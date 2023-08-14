namespace QLDuThuyen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listDSKhachDat = new System.Windows.Forms.ListBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioCaNgay = new System.Windows.Forms.RadioButton();
            this.radioNuaNgay = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.txtDoUong = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtDoUong);
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.radioNuaNgay);
            this.groupBox1.Controls.Add(this.radioCaNgay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng đặt Tour";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listDSKhachDat);
            this.groupBox2.Location = new System.Drawing.Point(414, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 375);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Khách Hàng Đặt Tour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá Du Thuyền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn đồ uống";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tiền";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(34, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm vào DS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(224, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thêm &mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(694, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "T&hoát";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listDSKhachDat
            // 
            this.listDSKhachDat.FormattingEnabled = true;
            this.listDSKhachDat.Location = new System.Drawing.Point(15, 40);
            this.listDSKhachDat.Name = "listDSKhachDat";
            this.listDSKhachDat.Size = new System.Drawing.Size(347, 316);
            this.listDSKhachDat.TabIndex = 0;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(71, 37);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(170, 20);
            this.txtHoTen.TabIndex = 7;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(93, 144);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(148, 20);
            this.txtGia.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "$";
            // 
            // radioCaNgay
            // 
            this.radioCaNgay.AutoSize = true;
            this.radioCaNgay.Location = new System.Drawing.Point(45, 87);
            this.radioCaNgay.Name = "radioCaNgay";
            this.radioCaNgay.Size = new System.Drawing.Size(64, 17);
            this.radioCaNgay.TabIndex = 10;
            this.radioCaNgay.TabStop = true;
            this.radioCaNgay.Text = "Cả ngày";
            this.radioCaNgay.UseVisualStyleBackColor = true;
            this.radioCaNgay.CheckedChanged += new System.EventHandler(this.radioCaNgay_CheckedChanged);
            // 
            // radioNuaNgay
            // 
            this.radioNuaNgay.AutoSize = true;
            this.radioNuaNgay.Location = new System.Drawing.Point(214, 87);
            this.radioNuaNgay.Name = "radioNuaNgay";
            this.radioNuaNgay.Size = new System.Drawing.Size(71, 17);
            this.radioNuaNgay.TabIndex = 12;
            this.radioNuaNgay.TabStop = true;
            this.radioNuaNgay.Text = "Nửa ngày";
            this.radioNuaNgay.UseVisualStyleBackColor = true;
            this.radioNuaNgay.CheckedChanged += new System.EventHandler(this.radioNuaNgay_CheckedChanged);
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(267, 241);
            this.txtTien.Name = "txtTien";
            this.txtTien.ReadOnly = true;
            this.txtTien.Size = new System.Drawing.Size(108, 20);
            this.txtTien.TabIndex = 13;
            // 
            // txtDoUong
            // 
            this.txtDoUong.FormattingEnabled = true;
            this.txtDoUong.Location = new System.Drawing.Point(8, 240);
            this.txtDoUong.Name = "txtDoUong";
            this.txtDoUong.Size = new System.Drawing.Size(87, 21);
            this.txtDoUong.TabIndex = 14;
            this.txtDoUong.SelectedIndexChanged += new System.EventHandler(this.txtDoUong_SelectedIndexChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.FormattingEnabled = true;
            this.txtSoLuong.Location = new System.Drawing.Point(135, 240);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(87, 21);
            this.txtSoLuong.TabIndex = 15;
            this.txtSoLuong.SelectedIndexChanged += new System.EventHandler(this.txtSoLuong_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtSoLuong;
        private System.Windows.Forms.ComboBox txtDoUong;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.RadioButton radioNuaNgay;
        private System.Windows.Forms.RadioButton radioCaNgay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listDSKhachDat;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

