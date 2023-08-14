namespace Bai01
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
            this.bntThem = new System.Windows.Forms.Button();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtSoTin = new System.Windows.Forms.TextBox();
            this.comboBoxMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxDS = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongSoTin = new System.Windows.Forms.TextBox();
            this.txtTongSoDiem = new System.Windows.Forms.TextBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bntTinh = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntThem);
            this.groupBox1.Controls.Add(this.txtDiem);
            this.groupBox1.Controls.Add(this.txtSoTin);
            this.groupBox1.Controls.Add(this.comboBoxMonHoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 504);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điểm sinh viên";
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(97, 346);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(123, 44);
            this.bntThem.TabIndex = 14;
            this.bntThem.Text = "Thêm vào &DS";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(97, 204);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(195, 22);
            this.txtDiem.TabIndex = 7;
            this.txtDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiem_KeyPress);
            // 
            // txtSoTin
            // 
            this.txtSoTin.Location = new System.Drawing.Point(97, 144);
            this.txtSoTin.Name = "txtSoTin";
            this.txtSoTin.ReadOnly = true;
            this.txtSoTin.Size = new System.Drawing.Size(195, 22);
            this.txtSoTin.TabIndex = 6;
            // 
            // comboBoxMonHoc
            // 
            this.comboBoxMonHoc.FormattingEnabled = true;
            this.comboBoxMonHoc.Location = new System.Drawing.Point(31, 84);
            this.comboBoxMonHoc.Name = "comboBoxMonHoc";
            this.comboBoxMonHoc.Size = new System.Drawing.Size(261, 24);
            this.comboBoxMonHoc.TabIndex = 5;
            this.comboBoxMonHoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonHoc_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tín";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên môn học";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxDS);
            this.groupBox2.Location = new System.Drawing.Point(378, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 257);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các môn học";
            // 
            // listBoxDS
            // 
            this.listBoxDS.FormattingEnabled = true;
            this.listBoxDS.ItemHeight = 16;
            this.listBoxDS.Location = new System.Drawing.Point(6, 21);
            this.listBoxDS.Name = "listBoxDS";
            this.listBoxDS.Size = new System.Drawing.Size(587, 228);
            this.listBoxDS.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng số tín";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng điểm";
            // 
            // txtTongSoTin
            // 
            this.txtTongSoTin.Location = new System.Drawing.Point(503, 317);
            this.txtTongSoTin.Name = "txtTongSoTin";
            this.txtTongSoTin.ReadOnly = true;
            this.txtTongSoTin.Size = new System.Drawing.Size(118, 22);
            this.txtTongSoTin.TabIndex = 8;
            // 
            // txtTongSoDiem
            // 
            this.txtTongSoDiem.Location = new System.Drawing.Point(787, 317);
            this.txtTongSoDiem.Name = "txtTongSoDiem";
            this.txtTongSoDiem.ReadOnly = true;
            this.txtTongSoDiem.Size = new System.Drawing.Size(122, 22);
            this.txtTongSoDiem.TabIndex = 9;
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(562, 380);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(203, 22);
            this.txtDTB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(424, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Điểm trung bình";
            // 
            // bntTinh
            // 
            this.bntTinh.Location = new System.Drawing.Point(462, 451);
            this.bntTinh.Name = "bntTinh";
            this.bntTinh.Size = new System.Drawing.Size(123, 44);
            this.bntTinh.TabIndex = 12;
            this.bntTinh.Text = "&Tính";
            this.bntTinh.UseVisualStyleBackColor = true;
            this.bntTinh.Click += new System.EventHandler(this.bntTinh_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.Location = new System.Drawing.Point(731, 451);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(123, 44);
            this.bntThoat.TabIndex = 13;
            this.bntThoat.Text = "T&hoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 523);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntTinh);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTongSoDiem);
            this.Controls.Add(this.txtTongSoTin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtSoTin;
        private System.Windows.Forms.ComboBox comboBoxMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxDS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongSoTin;
        private System.Windows.Forms.TextBox txtTongSoDiem;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bntTinh;
        private System.Windows.Forms.Button bntThoat;
    }
}

