namespace DaySo
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDaySo = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.Label();
            this.TxtSapXep = new System.Windows.Forms.Label();
            this.bntNhap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bntLamLai = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhap n:";
            // 
            // txtDaySo
            // 
            this.txtDaySo.AutoSize = true;
            this.txtDaySo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaySo.Location = new System.Drawing.Point(42, 113);
            this.txtDaySo.Name = "txtDaySo";
            this.txtDaySo.Size = new System.Drawing.Size(67, 20);
            this.txtDaySo.TabIndex = 1;
            this.txtDaySo.Text = "Day so:";
            // 
            // txtTong
            // 
            this.txtTong.AutoSize = true;
            this.txtTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.Location = new System.Drawing.Point(42, 174);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(87, 20);
            this.txtTong.TabIndex = 2;
            this.txtTong.Text = "Tong day: ";
            // 
            // TxtSapXep
            // 
            this.TxtSapXep.AutoSize = true;
            this.TxtSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSapXep.Location = new System.Drawing.Point(42, 232);
            this.TxtSapXep.Name = "TxtSapXep";
            this.TxtSapXep.Size = new System.Drawing.Size(226, 20);
            this.TxtSapXep.TabIndex = 3;
            this.TxtSapXep.Text = "Day so sap xep giam dan la: ";
            // 
            // bntNhap
            // 
            this.bntNhap.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bntNhap.Enabled = false;
            this.bntNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNhap.Location = new System.Drawing.Point(46, 307);
            this.bntNhap.Name = "bntNhap";
            this.bntNhap.Size = new System.Drawing.Size(120, 55);
            this.bntNhap.TabIndex = 1;
            this.bntNhap.Text = "&Nhap";
            this.bntNhap.UseVisualStyleBackColor = false;
            this.bntNhap.Click += new System.EventHandler(this.bntNhap_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(195, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Tinh tong";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(340, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "&Sap xep";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bntLamLai
            // 
            this.bntLamLai.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bntLamLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLamLai.Location = new System.Drawing.Point(490, 305);
            this.bntLamLai.Name = "bntLamLai";
            this.bntLamLai.Size = new System.Drawing.Size(119, 56);
            this.bntLamLai.TabIndex = 4;
            this.bntLamLai.Text = "&Lam Lai";
            this.bntLamLai.UseVisualStyleBackColor = false;
            this.bntLamLai.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(116, 51);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(565, 22);
            this.txtN.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtN, "Nhap so nguyen");
            this.txtN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(637, 306);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 56);
            this.button5.TabIndex = 5;
            this.button5.Text = "&Thoat";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.bntLamLai);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bntNhap);
            this.Controls.Add(this.TxtSapXep);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.txtDaySo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtDaySo;
        private System.Windows.Forms.Label txtTong;
        private System.Windows.Forms.Label TxtSapXep;
        private System.Windows.Forms.Button bntNhap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bntLamLai;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

