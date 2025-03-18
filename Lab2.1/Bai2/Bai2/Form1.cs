using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTenLop.Text) &&
        !string.IsNullOrWhiteSpace(txtBoMon.Text) &&
        !string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                ListViewItem item = new ListViewItem(txtTenLop.Text); 
                item.SubItems.Add(txtBoMon.Text); 
                item.SubItems.Add(txtSoLuong.Text);

                lvDanhSach.Items.Add(item); 

                
                txtTenLop.Clear();
                txtBoMon.Clear();
                txtSoLuong.Clear();
                txtTenLop.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvDanhSach.SelectedItems)
                {
                    lvDanhSach.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDanhSach.SelectedItems[0];
                item.SubItems[0].Text = txtTenLop.Text;
                item.SubItems[1].Text = txtBoMon.Text;
                item.SubItems[2].Text = txtSoLuong.Text;

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDanhSach.SelectedItems[0];
                txtTenLop.Text = item.SubItems[0].Text;
                txtBoMon.Text = item.SubItems[1].Text;
                txtSoLuong.Text = item.SubItems[2].Text;
            }
        }
    }
}
