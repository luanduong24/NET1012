using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeMenu();
        }

        private void InitializeMenu()
        {
            MenuStrip menuStrip = new MenuStrip();
            ToolStripMenuItem convertMenu = new ToolStripMenuItem("Chuyển đổi hệ số");
            ToolStripMenuItem binaryMenuItem = new ToolStripMenuItem("Nhị phân");
            ToolStripMenuItem octalMenuItem = new ToolStripMenuItem("Bát phân");
            ToolStripMenuItem hexMenuItem = new ToolStripMenuItem("Thập lục phân");
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Thoát");

            binaryMenuItem.Click += ConvertToBinary;
            octalMenuItem.Click += ConvertToOctal;
            hexMenuItem.Click += ConvertToHex;
            exitMenuItem.Click += ExitMenuItem_Click;

            convertMenu.DropDownItems.Add(binaryMenuItem);
            convertMenu.DropDownItems.Add(octalMenuItem);
            convertMenu.DropDownItems.Add(hexMenuItem);
            menuStrip.Items.Add(convertMenu);
            menuStrip.Items.Add(exitMenuItem);

            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
        }
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ConvertToBinary(object sender, EventArgs e)
        {
            ConvertAndDisplay(2);
        }

        private void ConvertToOctal(object sender, EventArgs e)
        {
            ConvertAndDisplay(8);
        }

        private void ConvertToHex(object sender, EventArgs e)
        {
            ConvertAndDisplay(16);
        }

        private void ConvertAndDisplay(int baseNumber)
        {
            int decimalNumber;
            if (int.TryParse(txtDecimal.Text, out decimalNumber))
            {
                txtResult.Text = Convert.ToString(decimalNumber, baseNumber).ToUpper();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
