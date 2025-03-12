using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
     

        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

        private int BCNN(int a, int b)
        {
            return Math.Abs(a * b) / UCLN(a, b);
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoThuNhat.Text, out int a) && int.TryParse(txtSoThuHai.Text, out int b))
            {
                if (rbUCLN.Checked)
                {
                    txtKetQua.Text = UCLN(a, b).ToString();
                }
                else if (rbBCNN.Checked)
                {
                    txtKetQua.Text = BCNN(a, b).ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một chức năng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBoQua_Click_1(object sender, EventArgs e)
        {
            txtSoThuNhat.Clear();
            txtSoThuHai.Clear();
            txtKetQua.Clear();
            rbUCLN.Checked = false;
            rbBCNN.Checked = false;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
