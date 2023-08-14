namespace ThuDo
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.HaNoi = new System.Windows.Forms.RadioButton();
            this.HaGiang = new System.Windows.Forms.RadioButton();
            this.HaiDuong = new System.Windows.Forms.RadioButton();
            this.ThanhHoa = new System.Windows.Forms.RadioButton();
            this.CaoBang = new System.Windows.Forms.RadioButton();
            this.NinhBinh = new System.Windows.Forms.RadioButton();
            this.BacNinh = new System.Windows.Forms.RadioButton();
            this.BacGiang = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BacGiang);
            this.groupBox2.Controls.Add(this.BacNinh);
            this.groupBox2.Controls.Add(this.NinhBinh);
            this.groupBox2.Controls.Add(this.CaoBang);
            this.groupBox2.Controls.Add(this.ThanhHoa);
            this.groupBox2.Controls.Add(this.HaiDuong);
            this.groupBox2.Controls.Add(this.HaGiang);
            this.groupBox2.Controls.Add(this.HaNoi);
            this.groupBox2.Location = new System.Drawing.Point(85, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Country";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(451, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "23";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.CheckCountry);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(28, 73);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "29";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.CheckCountry);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(28, 108);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(37, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "34";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.CheckCountry);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(28, 141);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "36";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.CheckCountry);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(28, 174);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(37, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "11";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.CheckCountry);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(28, 209);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(37, 17);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.Text = "35";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.CheckCountry);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(28, 242);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(37, 17);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.Text = "99";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.CheckCountry);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(28, 277);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(37, 17);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.Text = "98";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.CheckCountry);
            // 
            // HaNoi
            // 
            this.HaNoi.AutoSize = true;
            this.HaNoi.Location = new System.Drawing.Point(40, 39);
            this.HaNoi.Name = "HaNoi";
            this.HaNoi.Size = new System.Drawing.Size(58, 17);
            this.HaNoi.TabIndex = 1;
            this.HaNoi.TabStop = true;
            this.HaNoi.Text = "Ha Noi";
            this.HaNoi.UseVisualStyleBackColor = true;
            this.HaNoi.CheckedChanged += new System.EventHandler(this.ClickCountry);
            // 
            // HaGiang
            // 
            this.HaGiang.AutoSize = true;
            this.HaGiang.Location = new System.Drawing.Point(40, 73);
            this.HaGiang.Name = "HaGiang";
            this.HaGiang.Size = new System.Drawing.Size(70, 17);
            this.HaGiang.TabIndex = 2;
            this.HaGiang.TabStop = true;
            this.HaGiang.Text = "Ha Giang";
            this.HaGiang.UseVisualStyleBackColor = true;
            this.HaGiang.CheckedChanged += new System.EventHandler(this.ClickCountry);
            // 
            // HaiDuong
            // 
            this.HaiDuong.AutoSize = true;
            this.HaiDuong.Location = new System.Drawing.Point(40, 108);
            this.HaiDuong.Name = "HaiDuong";
            this.HaiDuong.Size = new System.Drawing.Size(76, 17);
            this.HaiDuong.TabIndex = 3;
            this.HaiDuong.TabStop = true;
            this.HaiDuong.Text = "Hai Duong";
            this.HaiDuong.UseVisualStyleBackColor = true;
            this.HaiDuong.CheckedChanged += new System.EventHandler(this.ClickCountry);
            // 
            // ThanhHoa
            // 
            this.ThanhHoa.AutoSize = true;
            this.ThanhHoa.Location = new System.Drawing.Point(40, 141);
            this.ThanhHoa.Name = "ThanhHoa";
            this.ThanhHoa.Size = new System.Drawing.Size(79, 17);
            this.ThanhHoa.TabIndex = 4;
            this.ThanhHoa.TabStop = true;
            this.ThanhHoa.Text = "Thanh Hoa";
            this.ThanhHoa.UseVisualStyleBackColor = true;
            this.ThanhHoa.CheckedChanged += new System.EventHandler(this.ClickCountry);
            // 
            // CaoBang
            // 
            this.CaoBang.AutoSize = true;
            this.CaoBang.Location = new System.Drawing.Point(40, 174);
            this.CaoBang.Name = "CaoBang";
            this.CaoBang.Size = new System.Drawing.Size(72, 17);
            this.CaoBang.TabIndex = 5;
            this.CaoBang.TabStop = true;
            this.CaoBang.Text = "Cao Bang";
            this.CaoBang.UseVisualStyleBackColor = true;
            this.CaoBang.CheckedChanged += new System.EventHandler(this.ClickCountry);
            // 
            // NinhBinh
            // 
            this.NinhBinh.AutoSize = true;
            this.NinhBinh.Location = new System.Drawing.Point(40, 209);
            this.NinhBinh.Name = "NinhBinh";
            this.NinhBinh.Size = new System.Drawing.Size(71, 17);
            this.NinhBinh.TabIndex = 6;
            this.NinhBinh.TabStop = true;
            this.NinhBinh.Text = "Ninh Binh";
            this.NinhBinh.UseVisualStyleBackColor = true;
            this.NinhBinh.CheckedChanged += new System.EventHandler(this.ClickCountry);
            // 
            // BacNinh
            // 
            this.BacNinh.AutoSize = true;
            this.BacNinh.Location = new System.Drawing.Point(40, 242);
            this.BacNinh.Name = "BacNinh";
            this.BacNinh.Size = new System.Drawing.Size(69, 17);
            this.BacNinh.TabIndex = 7;
            this.BacNinh.TabStop = true;
            this.BacNinh.Text = "Bac Ninh";
            this.BacNinh.UseVisualStyleBackColor = true;
            this.BacNinh.CheckedChanged += new System.EventHandler(this.ClickCountry);
            // 
            // BacGiang
            // 
            this.BacGiang.AutoSize = true;
            this.BacGiang.Location = new System.Drawing.Point(40, 277);
            this.BacGiang.Name = "BacGiang";
            this.BacGiang.Size = new System.Drawing.Size(75, 17);
            this.BacGiang.TabIndex = 8;
            this.BacGiang.TabStop = true;
            this.BacGiang.Text = "Bac Giang";
            this.BacGiang.UseVisualStyleBackColor = true;
            this.BacGiang.CheckedChanged += new System.EventHandler(this.ClickCountry);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(67, 381);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton BacGiang;
        private System.Windows.Forms.RadioButton BacNinh;
        private System.Windows.Forms.RadioButton NinhBinh;
        private System.Windows.Forms.RadioButton CaoBang;
        private System.Windows.Forms.RadioButton ThanhHoa;
        private System.Windows.Forms.RadioButton HaiDuong;
        private System.Windows.Forms.RadioButton HaGiang;
        private System.Windows.Forms.RadioButton HaNoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblResult;
    }
}

