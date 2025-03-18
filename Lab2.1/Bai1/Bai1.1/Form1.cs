using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstDSSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cboViTri.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSanPham.Text))
            {
                lstDSSanPham.Items.Add(txtSanPham.Text);
                txtSanPham.Clear();
                CapNhatComboBox();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstDSSanPham.SelectedIndex >= 0)
            {
                lstDSSanPham.Items.RemoveAt(lstDSSanPham.SelectedIndex);
                CapNhatComboBox();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaDS_Click(object sender, EventArgs e)
        {
            if (lstDSSanPham.Items.Count > 0)
            {
                lstDSSanPham.Items.Clear();
                cboViTri.Items.Clear();
            }
            else
            {
                MessageBox.Show("Danh sách sản phẩm đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CapNhatComboBox()
        {
            cboViTri.Items.Clear();
            for (int i = 0; i < lstDSSanPham.Items.Count; i++)
            {
                cboViTri.Items.Add(i.ToString());
            }
            if (cboViTri.Items.Count > 0)
                cboViTri.SelectedIndex = 0;
        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSanPhamVT.Text) && cboViTri.SelectedIndex >= 0)
            {
                int viTri = cboViTri.SelectedIndex;
                lstDSSanPham.Items.Insert(viTri, txtSanPhamVT.Text);
                txtSanPhamVT.Clear();
                CapNhatComboBox();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập sản phẩm và chọn vị trí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                bool found = false;
                foreach (var item in lstDSSanPham.Items)
                {
                    if (item.ToString().Equals(txtTimKiem.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                    MessageBox.Show("Sản phẩm có trong danh sách!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không tìm thấy sản phẩm!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

