namespace Bai02
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
            this.comboBoxSL = new System.Windows.Forms.ComboBox();
            this.comboBoxDoUong = new System.Windows.Forms.ComboBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonNuaNgay = new System.Windows.Forms.RadioButton();
            this.radioButtonCaNgay = new System.Windows.Forms.RadioButton();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bntThemMoi = new System.Windows.Forms.Button();
            this.bntThemVao = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bntThoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxSL);
            this.groupBox1.Controls.Add(this.comboBoxDoUong);
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButtonNuaNgay);
            this.groupBox1.Controls.Add(this.radioButtonCaNgay);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bntThemMoi);
            this.groupBox1.Controls.Add(this.bntThemVao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 427);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng đặt Tour";
            // 
            // comboBoxSL
            // 
            this.comboBoxSL.DropDownHeight = 100;
            this.comboBoxSL.FormattingEnabled = true;
            this.comboBoxSL.IntegralHeight = false;
            this.comboBoxSL.Location = new System.Drawing.Point(214, 257);
            this.comboBoxSL.Name = "comboBoxSL";
            this.comboBoxSL.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSL.TabIndex = 16;
            this.comboBoxSL.SelectedIndexChanged += new System.EventHandler(this.comboBoxSL_SelectedIndexChanged);
            // 
            // comboBoxDoUong
            // 
            this.comboBoxDoUong.FormattingEnabled = true;
            this.comboBoxDoUong.Location = new System.Drawing.Point(46, 257);
            this.comboBoxDoUong.Name = "comboBoxDoUong";
            this.comboBoxDoUong.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDoUong.TabIndex = 15;
            this.comboBoxDoUong.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoUong_SelectedIndexChanged);
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(372, 257);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(100, 23);
            this.txtTien.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Chọn đồ uống";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(137, 148);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(173, 23);
            this.txtGia.TabIndex = 10;
            this.txtGia.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Giá du thuyền";
            // 
            // radioButtonNuaNgay
            // 
            this.radioButtonNuaNgay.AutoSize = true;
            this.radioButtonNuaNgay.Location = new System.Drawing.Point(214, 107);
            this.radioButtonNuaNgay.Name = "radioButtonNuaNgay";
            this.radioButtonNuaNgay.Size = new System.Drawing.Size(92, 21);
            this.radioButtonNuaNgay.TabIndex = 8;
            this.radioButtonNuaNgay.TabStop = true;
            this.radioButtonNuaNgay.Text = "Nửa Ngày";
            this.radioButtonNuaNgay.UseVisualStyleBackColor = true;
            this.radioButtonNuaNgay.Click += new System.EventHandler(this.radioButtonCaNgay_Click);
            // 
            // radioButtonCaNgay
            // 
            this.radioButtonCaNgay.AutoSize = true;
            this.radioButtonCaNgay.Location = new System.Drawing.Point(46, 107);
            this.radioButtonCaNgay.Name = "radioButtonCaNgay";
            this.radioButtonCaNgay.Size = new System.Drawing.Size(83, 21);
            this.radioButtonCaNgay.TabIndex = 6;
            this.radioButtonCaNgay.TabStop = true;
            this.radioButtonCaNgay.Text = "Cả Ngày";
            this.radioButtonCaNgay.UseVisualStyleBackColor = true;
            this.radioButtonCaNgay.Click += new System.EventHandler(this.radioButtonCaNgay_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(102, 47);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(173, 23);
            this.txtTen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Họ Tên";
            // 
            // bntThemMoi
            // 
            this.bntThemMoi.Location = new System.Drawing.Point(309, 376);
            this.bntThemMoi.Name = "bntThemMoi";
            this.bntThemMoi.Size = new System.Drawing.Size(133, 32);
            this.bntThemMoi.TabIndex = 2;
            this.bntThemMoi.Text = "Thêm Mới";
            this.bntThemMoi.UseVisualStyleBackColor = true;
            this.bntThemMoi.Click += new System.EventHandler(this.bntThemMoi_Click);
            // 
            // bntThemVao
            // 
            this.bntThemVao.Location = new System.Drawing.Point(69, 376);
            this.bntThemVao.Name = "bntThemVao";
            this.bntThemVao.Size = new System.Drawing.Size(133, 32);
            this.bntThemVao.TabIndex = 3;
            this.bntThemVao.Text = "Thêm vào DS";
            this.bntThemVao.UseVisualStyleBackColor = true;
            this.bntThemVao.Click += new System.EventHandler(this.bntThemVao_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(594, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 427);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng đặt Tour";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(559, 388);
            this.listBox1.TabIndex = 0;
            // 
            // bntThoat
            // 
            this.bntThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThoat.Location = new System.Drawing.Point(951, 492);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(133, 53);
            this.bntThoat.TabIndex = 0;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1207, 557);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxSL;
        private System.Windows.Forms.ComboBox comboBoxDoUong;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonNuaNgay;
        private System.Windows.Forms.RadioButton radioButtonCaNgay;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntThemMoi;
        private System.Windows.Forms.Button bntThemVao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

