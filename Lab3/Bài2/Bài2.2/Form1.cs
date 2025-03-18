using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace Bài2._2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeWebView();
        }
        private async void InitializeWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.Source = new Uri("https://github.com/luanduong24"); 
        }
        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadWebPage();
                e.SuppressKeyPress = true; 
            }
        }
        private void LoadWebPage()
        {
            string url = txtAddress.Text.Trim();
            if (!string.IsNullOrWhiteSpace(url))
            {
                if (!url.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                {
                    url = "https://" + url; 
                }

                try
                {
                    webView21.Source = new Uri(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("URL không hợp lệ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LoadWebPage();
        }
    }
}
