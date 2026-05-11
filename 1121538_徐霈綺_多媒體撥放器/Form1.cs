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
            videoPanel.Child = wpfMediaElement;
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
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath)) return;

            wpfMediaElement.Play();

            lblStatus.Text = "正在播放: " + System.IO.Path.GetFileName(currentFilePath);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopMedia();
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                lblStatus.Text = "已停止: " + System.IO.Path.GetFileName(currentFilePath);
            }
        }

        private void StopMedia()
        {
            if (wpfMediaElement != null)
            {
                wpfMediaElement.Stop();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopMedia();
        }
    }
}
