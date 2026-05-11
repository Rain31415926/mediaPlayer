namespace _1121538_徐霈綺_多媒體撥放器
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReplay = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.videoPanel = new System.Windows.Forms.Integration.ElementHost();
            this.trackBarProgress = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.btnOpen.Location = new System.Drawing.Point(150, 400);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(40, 30);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "📁";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.btnPlay.Location = new System.Drawing.Point(12, 400);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 30);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "▶";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.Enabled = false;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.btnStop.Location = new System.Drawing.Point(58, 400);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(40, 30);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "⏹";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.Enabled = false;
            // 
            // btnReplay
            // 
            this.btnReplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReplay.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.btnReplay.Location = new System.Drawing.Point(104, 400);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(40, 30);
            this.btnReplay.TabIndex = 2;
            this.btnReplay.Text = "↺";
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            this.btnReplay.Enabled = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(196, 409);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 12);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "尚未選擇檔案";
            // 
            // trackBarProgress
            // 
            this.trackBarProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarProgress.Location = new System.Drawing.Point(12, 350);
            this.trackBarProgress.Name = "trackBarProgress";
            this.trackBarProgress.Size = new System.Drawing.Size(776, 45);
            this.trackBarProgress.TabIndex = 5;
            this.trackBarProgress.Scroll += new System.EventHandler(this.trackBarProgress_Scroll);
            this.trackBarProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBarProgress_MouseDown);
            this.trackBarProgress.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarProgress_MouseUp);
            // 
            // videoPanel
            // 
            this.videoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoPanel.BackColor = System.Drawing.Color.Black;
            this.videoPanel.Location = new System.Drawing.Point(12, 12);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(776, 330);
            this.videoPanel.TabIndex = 4;
            this.videoPanel.Text = "elementHost1";
            this.videoPanel.Child = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBarProgress);
            this.Controls.Add(this.videoPanel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "多媒體播放器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Integration.ElementHost videoPanel;
        private System.Windows.Forms.TrackBar trackBarProgress;
    }
}

