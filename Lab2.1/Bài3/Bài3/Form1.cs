using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtTenSV.Text) || string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSV = txtMaSV.Text;
            string tenSV = txtTenSV.Text;
            string mon = cboMon.SelectedItem.ToString();
            string diem = txtDiem.Text;

            dgvSinhVien.Rows.Add(maSV, tenSV, mon, diem); // Thêm vào DataGridView

            // Xóa dữ liệu trên ô nhập sau khi thêm
            txtMaSV.Clear();
            txtTenSV.Clear();
            txtDiem.Clear();
            txtMaSV.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0) // Kiểm tra có hàng nào được chọn không
            {
                DataGridViewRow row = dgvSinhVien.SelectedRows[0]; // Lấy hàng được chọn

                // Cập nhật thông tin
                row.Cells[0].Value = txtMaSV.Text;
                row.Cells[1].Value = txtTenSV.Text;
                row.Cells[2].Value = cboMon.SelectedItem.ToString();
                row.Cells[3].Value = txtDiem.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                dgvSinhVien.Rows.RemoveAt(dgvSinhVien.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                txtMaSV.Text = row.Cells[0].Value.ToString();
                txtTenSV.Text = row.Cells[1].Value.ToString();
                cboMon.SelectedItem = row.Cells[2].Value.ToString();
                txtDiem.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
