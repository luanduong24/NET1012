using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài4
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
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

        private void button2_Click(object sender, EventArgs e)
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                string selectedNote = listBox2.SelectedItem.ToString();

                // Trích xuất thời gian từ ghi chú (định dạng [mm:ss])
                int start = selectedNote.IndexOf("[") + 1;
                int end = selectedNote.IndexOf("]");

                if (start >= 0 && end > start)
                {
                    string timeString = selectedNote.Substring(start, end - start);
                    string[] timeParts = timeString.Split(':');

                    if (timeParts.Length == 2 && int.TryParse(timeParts[0], out int minutes) && int.TryParse(timeParts[1], out int seconds))
                    {
                        double seekTime = (minutes * 60) + seconds;
                        axWindowsMediaPlayer1.Ctlcontrols.currentPosition = seekTime;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                    }
                }
            }
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.currentMedia != null)
            {
                double currentTime = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                TimeSpan timeSpan = TimeSpan.FromSeconds(currentTime);
                string timeFormatted = $"[{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}]";

                string note = $"{timeFormatted} {textBoxNote.Text}";

                if (listBox1.SelectedIndex >= 0)
                {
                    listBox2.Items.Add(note);
                    textBoxNote.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
