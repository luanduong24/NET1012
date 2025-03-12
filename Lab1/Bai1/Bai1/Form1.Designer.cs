namespace Bai1
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
            this.lblSo1 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.lblSo2 = new System.Windows.Forms.Label();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSo1
            // 
            this.lblSo1.AutoSize = true;
            this.lblSo1.Location = new System.Drawing.Point(276, 83);
            this.lblSo1.Name = "lblSo1";
            this.lblSo1.Size = new System.Drawing.Size(72, 16);
            this.lblSo1.TabIndex = 0;
            this.lblSo1.Text = "Số thứ nhất";
            this.lblSo1.Click += new System.EventHandler(this.lblSo1_Click);
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(411, 83);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(230, 22);
            this.txtSo1.TabIndex = 1;
            this.txtSo1.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            // 
            // lblSo2
            // 
            this.lblSo2.AutoSize = true;
            this.lblSo2.Location = new System.Drawing.Point(276, 130);
            this.lblSo2.Name = "lblSo2";
            this.lblSo2.Size = new System.Drawing.Size(65, 16);
            this.lblSo2.TabIndex = 2;
            this.lblSo2.Text = "Số thứ hai";
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(411, 130);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(230, 22);
            this.txtSo2.TabIndex = 3;
            this.txtSo2.TextChanged += new System.EventHandler(this.txtSo2_TextChanged);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(411, 240);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(229, 22);
            this.txtKetQua.TabIndex = 4;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(276, 246);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(52, 16);
            this.lblKetQua.TabIndex = 5;
            this.lblKetQua.Text = "Kết quả";
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(295, 187);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(46, 32);
            this.btnCong.TabIndex = 6;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(364, 187);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(46, 32);
            this.btnTru.TabIndex = 7;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(433, 187);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(46, 32);
            this.btnChia.TabIndex = 8;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(503, 187);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(46, 32);
            this.btnNhan.TabIndex = 9;
            this.btnNhan.Text = "x";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(582, 187);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(46, 32);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 360);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.lblSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.lblSo1);
            this.Name = "Form1";
            this.Text = "Máy tính bỏ túi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSo1;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.Label lblSo2;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnDel;
    }
}

