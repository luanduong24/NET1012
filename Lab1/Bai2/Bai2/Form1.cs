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

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int tongTien = 0;

            if (chkCaoVoi.Checked) tongTien += 150000;
            if (chkTayTrang.Checked) tongTien += 250000;
            if (chkNhoRang.Checked) tongTien += 100000;
            if (chkTramRang.Checked) tongTien += 300000;

            txtThanhTien.Text = tongTien.ToString() + " VND";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
