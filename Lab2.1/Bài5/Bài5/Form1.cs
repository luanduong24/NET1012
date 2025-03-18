using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài5
{
    public partial class Form1: Form
    {
        private Dictionary<string, string> danhSachAnime = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            cboNhanVat.Items.Add("Goku");
            cboNhanVat.Items.Add("GoHan");
            cboNhanVat.Items.Add("Vegeta");

            cboNhanVat.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string nhanVat = cboNhanVat.SelectedItem.ToString();

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (danhSachAnime.ContainsKey(ten))
            {
                MessageBox.Show("Tên này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            danhSachAnime[ten] = null; 
            lstDanhSach.Items.Add($"{ten} - {nhanVat}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một nhân vật từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Hình ảnh|*.jpg;*.png;*.jpeg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string selectedName = lstDanhSach.SelectedItem.ToString().Split('-')[0].Trim();


                danhSachAnime[selectedName] = filePath;
                picNhanVat.Image = Image.FromFile(filePath);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một nhân vật để lưu thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedName = lstDanhSach.SelectedItem.ToString().Split('-')[0].Trim();

            if (danhSachAnime[selectedName] == null)
            {
                MessageBox.Show("Chưa chọn ảnh cho nhân vật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Thông tin đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnXemLai_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một nhân vật để xem lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedName = lstDanhSach.SelectedItem.ToString().Split('-')[0].Trim();

            if (danhSachAnime.ContainsKey(selectedName) && danhSachAnime[selectedName] != null)
            {
                picNhanVat.Image = Image.FromFile(danhSachAnime[selectedName]);
            }
            else
            {
                MessageBox.Show("Chưa có ảnh cho nhân vật này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                picNhanVat.Image = null;
            }
        }
    }
}
