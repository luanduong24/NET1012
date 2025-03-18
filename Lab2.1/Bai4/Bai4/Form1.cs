using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1: Form
    {
        public DataTable dataSinhVien = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataSinhVien.Columns.Add("Mã sinh viên");
            dataSinhVien.Columns.Add("Tên sinh viên");
            dataSinhVien.Columns.Add("Môn");
            dataSinhVien.Columns.Add("Điểm");

            dgvSinhVien.DataSource = dataSinhVien;

            cboMon.Items.Add("C#2");
            cboMon.Items.Add("Web");
            cboMon.Items.Add("Chính trị");
            cboMon.Items.Add("CSDL");
            cboMon.SelectedIndex = 0;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtTenSV.Text) || string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            dataSinhVien.Rows.Add(txtMaSV.Text, txtTenSV.Text, cboMon.SelectedItem.ToString(), txtDiem.Text);

            
            txtMaSV.Clear();
            txtTenSV.Clear();
            txtDiem.Clear();
            txtMaSV.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0) 
            {
                DataGridViewRow row = dgvSinhVien.SelectedRows[0]; 

               
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
                int index = dgvSinhVien.SelectedRows[0].Index; 
                dataSinhVien.Rows.RemoveAt(index); 
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
                txtMaSV.Text = dataSinhVien.Rows[e.RowIndex]["Mã sinh viên"].ToString();
                txtTenSV.Text = dataSinhVien.Rows[e.RowIndex]["Tên sinh viên"].ToString();
                cboMon.SelectedItem = dataSinhVien.Rows[e.RowIndex]["Môn"].ToString();
                txtDiem.Text = dataSinhVien.Rows[e.RowIndex]["Điểm"].ToString();
            }
        }

        
    }
}
