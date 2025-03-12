using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSo1_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double so1, so2;
            if (double.TryParse(txtSo1.Text, out so1) && double.TryParse(txtSo2.Text, out so2))
            {
                txtKetQua.Text = (so1 + so2).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double so1, so2;
            if (double.TryParse(txtSo1.Text, out so1) && double.TryParse(txtSo2.Text, out so2))
            {
                txtKetQua.Text = (so1 - so2).ToString();
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double so1, so2;
            if (double.TryParse(txtSo1.Text, out so1) && double.TryParse(txtSo2.Text, out so2))
            {
                txtKetQua.Text = (so1 * so2).ToString();
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double so1, so2;
            if (double.TryParse(txtSo1.Text, out so1) && double.TryParse(txtSo2.Text, out so2))
            {
                if (so2 != 0)
                    txtKetQua.Text = (so1 / so2).ToString();
                else
                    MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtKetQua.Clear();
        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string text = textBox.Text;
                // Chỉ giữ lại các ký tự là số
                textBox.Text = new string(text.Where(char.IsDigit).ToArray());
                // Đưa con trỏ về cuối chuỗi để tránh nhảy về đầu
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void txtSo2_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string text = textBox.Text;
                textBox.Text = new string(text.Where(char.IsDigit).ToArray());
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
    }
}
