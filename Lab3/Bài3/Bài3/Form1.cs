using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace Bài3
{
    public partial class Form1: Form 
    {
        private string[] files, paths;
        private ToolStripStatusLabel timeLabel;
        private Timer timer;
        public Form1()
        {
            InitializeComponent();
            InitializeStatusStrip(); 

        }
        OpenFileDialog openFileDialog;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Media Files|*.mp3;*.mpg;*.mpeg;*.avi;*.wma;*.mov;*.wav;*.mp4;*.flv;*.wmv",
                Multiselect = true,
                Title = "Chọn file nhạc"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                files = openFileDialog.SafeFileNames;
                paths = openFileDialog.FileNames;

                listBox1.Items.Clear();
                foreach (string file in files)
                {
                    listBox1.Items.Add(file);
                }
            }
        }

        private void addPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Media Files|*.mp3;*.mpg;*.mpeg;*.avi;*.wma;*.mov;*.wav;*.mp4;*.flv;*.wmv",
                Multiselect = true,
                Title = "Thêm vào danh sách phát"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               
                files = openFileDialog.SafeFileNames;
                paths = openFileDialog.FileNames;

                foreach (string file in files)
                {
                    listBox1.Items.Add(file);
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void paseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else if (listBox1.SelectedIndex >= 0)
            {
               
                axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        private void InitializeStatusStrip()
        {
            
            StatusStrip statusStrip = new StatusStrip();
            timeLabel = new ToolStripStatusLabel();
            statusStrip.Items.Add(timeLabel);
            Controls.Add(statusStrip);

          
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }

       
       
    }
}
