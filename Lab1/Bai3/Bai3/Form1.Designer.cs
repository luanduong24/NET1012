namespace Bai3
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
            this.lblSoThuNhat = new System.Windows.Forms.Label();
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.lblSoThuHai = new System.Windows.Forms.Label();
            this.txtSoThuNhat = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBCNN = new System.Windows.Forms.RadioButton();
            this.rbUCLN = new System.Windows.Forms.RadioButton();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.rbKTCP = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSoThuNhat);
            this.groupBox1.Controls.Add(this.txtSoThuHai);
            this.groupBox1.Controls.Add(this.lblSoThuHai);
            this.groupBox1.Controls.Add(this.txtSoThuNhat);
            this.groupBox1.Location = new System.Drawing.Point(57, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập";
            // 
            // lblSoThuNhat
            // 
            this.lblSoThuNhat.AutoSize = true;
            this.lblSoThuNhat.Location = new System.Drawing.Point(22, 34);
            this.lblSoThuNhat.Name = "lblSoThuNhat";
            this.lblSoThuNhat.Size = new System.Drawing.Size(72, 16);
            this.lblSoThuNhat.TabIndex = 5;
            this.lblSoThuNhat.Text = "Số thứ nhất";
            // 
            // txtSoThuHai
            // 
            this.txtSoThuHai.Location = new System.Drawing.Point(100, 81);
            this.txtSoThuHai.Name = "txtSoThuHai";
            this.txtSoThuHai.Size = new System.Drawing.Size(147, 22);
            this.txtSoThuHai.TabIndex = 4;
            // 
            // lblSoThuHai
            // 
            this.lblSoThuHai.AutoSize = true;
            this.lblSoThuHai.Location = new System.Drawing.Point(22, 81);
            this.lblSoThuHai.Name = "lblSoThuHai";
            this.lblSoThuHai.Size = new System.Drawing.Size(65, 16);
            this.lblSoThuHai.TabIndex = 3;
            this.lblSoThuHai.Text = "Số thứ hai";
            // 
            // txtSoThuNhat
            // 
            this.txtSoThuNhat.Location = new System.Drawing.Point(100, 31);
            this.txtSoThuNhat.Name = "txtSoThuNhat";
            this.txtSoThuNhat.Size = new System.Drawing.Size(147, 22);
            this.txtSoThuNhat.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbKTCP);
            this.groupBox2.Controls.Add(this.rbBCNN);
            this.groupBox2.Controls.Add(this.rbUCLN);
            this.groupBox2.Location = new System.Drawing.Point(425, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // rbBCNN
            // 
            this.rbBCNN.AutoSize = true;
            this.rbBCNN.Location = new System.Drawing.Point(27, 75);
            this.rbBCNN.Name = "rbBCNN";
            this.rbBCNN.Size = new System.Drawing.Size(92, 20);
            this.rbBCNN.TabIndex = 1;
            this.rbBCNN.TabStop = true;
            this.rbBCNN.Text = "Tìm BCNN";
            this.rbBCNN.UseVisualStyleBackColor = true;
            // 
            // rbUCLN
            // 
            this.rbUCLN.AutoSize = true;
            this.rbUCLN.Location = new System.Drawing.Point(27, 34);
            this.rbUCLN.Name = "rbUCLN";
            this.rbUCLN.Size = new System.Drawing.Size(90, 20);
            this.rbUCLN.TabIndex = 0;
            this.rbUCLN.TabStop = true;
            this.rbUCLN.Text = "Tìm UCLN";
            this.rbUCLN.UseVisualStyleBackColor = true;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(99, 222);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(52, 16);
            this.lblKetQua.TabIndex = 2;
            this.lblKetQua.Text = "Kết quả";
            this.lblKetQua.Click += new System.EventHandler(this.lblKetQua_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(166, 219);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(453, 22);
            this.txtKetQua.TabIndex = 3;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(157, 280);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(98, 31);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click_1);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(305, 280);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(98, 31);
            this.btnBoQua.TabIndex = 5;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(444, 280);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 31);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // rbKTCP
            // 
            this.rbKTCP.AutoSize = true;
            this.rbKTCP.Location = new System.Drawing.Point(27, 107);
            this.rbKTCP.Name = "rbKTCP";
            this.rbKTCP.Size = new System.Drawing.Size(176, 20);
            this.rbKTCP.TabIndex = 2;
            this.rbKTCP.TabStop = true;
            this.rbKTCP.Text = "Kiểm tra số chính phương";
            this.rbKTCP.UseVisualStyleBackColor = true;
            this.rbKTCP.CheckedChanged += new System.EventHandler(this.rbKTCP_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoThuHai;
        private System.Windows.Forms.Label lblSoThuHai;
        private System.Windows.Forms.TextBox txtSoThuNhat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbBCNN;
        private System.Windows.Forms.RadioButton rbUCLN;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblSoThuNhat;
        private System.Windows.Forms.RadioButton rbKTCP;
    }
}

