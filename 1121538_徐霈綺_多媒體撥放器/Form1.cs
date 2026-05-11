using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;

namespace _1121538_徐霈綺_多媒體撥放器
{
    public partial class Form1 : Form
    {
        private string currentFilePath = "";
        private MediaElement wpfMediaElement;
        private Timer updateTimer;
        private bool isDragging = false;
        private bool isPlaying = false;

        public Form1()
        {
            InitializeComponent();
            InitializeMediaPlayer();
        }

        private void InitializeMediaPlayer()
        {
            wpfMediaElement = new MediaElement();
            wpfMediaElement.LoadedBehavior = MediaState.Manual;
            wpfMediaElement.UnloadedBehavior = MediaState.Stop;
            wpfMediaElement.MediaOpened += WpfMediaElement_MediaOpened;
            videoPanel.Child = wpfMediaElement;

            updateTimer = new Timer();
            updateTimer.Interval = 500;
            updateTimer.Tick += UpdateTimer_Tick;
        }

        private void WpfMediaElement_MediaOpened(object sender, System.Windows.RoutedEventArgs e)
        {
            if (wpfMediaElement.NaturalDuration.HasTimeSpan)
            {
                trackBarProgress.Maximum = (int)wpfMediaElement.NaturalDuration.TimeSpan.TotalSeconds;
            }
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (!isDragging && wpfMediaElement != null && wpfMediaElement.NaturalDuration.HasTimeSpan)
            {
                trackBarProgress.Value = (int)wpfMediaElement.Position.TotalSeconds;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "多媒體檔案|*.mp3;*.wav;*.mp4;*.avi;*.wmv|音樂檔案|*.mp3;*.wav|影片檔案|*.mp4;*.avi;*.wmv|所有檔案|*.*";
                ofd.Title = "選擇要播放的多媒體檔案";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StopMedia();
                    currentFilePath = ofd.FileName;
                    wpfMediaElement.Source = new System.Uri(currentFilePath);
                    lblStatus.Text = "已選擇: " + System.IO.Path.GetFileName(currentFilePath);
                    btnPlay.Enabled = true;
                    btnStop.Enabled = true;
                    btnReplay.Enabled = true;
                    btnPlay.Text = "▶";
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath)) return;

            if (isPlaying)
            {
                wpfMediaElement.Pause();
                isPlaying = false;
                btnPlay.Text = "▶";
                lblStatus.Text = "已暫停: " + System.IO.Path.GetFileName(currentFilePath);
            }
            else
            {
                wpfMediaElement.Play();
                updateTimer.Start();
                isPlaying = true;
                btnPlay.Text = "⏸";
                lblStatus.Text = "正在播放: " + System.IO.Path.GetFileName(currentFilePath);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopMedia();
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                lblStatus.Text = "已停止: " + System.IO.Path.GetFileName(currentFilePath);
            }
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath)) return;

            wpfMediaElement.Position = TimeSpan.Zero;
            wpfMediaElement.Play();
            updateTimer.Start();
            isPlaying = true;
            btnPlay.Text = "⏸";
            lblStatus.Text = "重新播放: " + System.IO.Path.GetFileName(currentFilePath);
        }

        private void StopMedia()
        {
            if (wpfMediaElement != null)
            {
                wpfMediaElement.Stop();
            }
            if (updateTimer != null)
            {
                updateTimer.Stop();
                trackBarProgress.Value = 0;
            }
            isPlaying = false;
            btnPlay.Text = "▶";
        }

        private void trackBarProgress_Scroll(object sender, EventArgs e)
        {
            if (wpfMediaElement != null && wpfMediaElement.NaturalDuration.HasTimeSpan)
            {
                wpfMediaElement.Position = TimeSpan.FromSeconds(trackBarProgress.Value);
            }
        }

        private void trackBarProgress_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
        }

        private void trackBarProgress_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopMedia();
        }
    }
}
