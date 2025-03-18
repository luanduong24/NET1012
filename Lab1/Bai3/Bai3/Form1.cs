using System;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool IsPerfectSquare(int num)
        {
            if (num < 0) return false;
            int sqrt = (int)Math.Sqrt(num);
            return sqrt * sqrt == num;
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
            if (!int.TryParse(txtSoThuNhat.Text, out int a))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rbUCLN.Checked || rbBCNN.Checked)
            {
                if (!int.TryParse(txtSoThuHai.Text, out int b))
                {
                    MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho số thứ hai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtKetQua.Text = rbUCLN.Checked ? UCLN(a, b).ToString() : BCNN(a, b).ToString();
            }
            else if (rbKTCP.Checked)
            {
                txtKetQua.Text = IsPerfectSquare(a) ? $"{a} là số chính phương." : $"{a} không phải số chính phương.";
                txtKetQua.ForeColor = IsPerfectSquare(a) ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một chức năng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBoQua_Click_1(object sender, EventArgs e)
        {
            txtSoThuNhat.Clear();
            txtSoThuHai.Clear();
            txtKetQua.Clear();
            rbUCLN.Checked = rbBCNN.Checked = rbKTCP.Checked = false;
            txtSoThuHai.Enabled = true;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbKTCP_CheckedChanged(object sender, EventArgs e)
        {
            txtSoThuHai.Enabled = !rbKTCP.Checked;
        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {

        }
    }
}
