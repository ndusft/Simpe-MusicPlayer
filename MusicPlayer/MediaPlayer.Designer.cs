namespace MusicPlayer
{
    partial class MediaPlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayerForm));
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.MusicPlayerLbl = new System.Windows.Forms.Label();
            this.MusicLbox = new System.Windows.Forms.ListBox();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.linePnl = new System.Windows.Forms.Panel();
            this.LogoIco = new System.Windows.Forms.PictureBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.LoopBtn = new System.Windows.Forms.Button();
            this.MusicPicture = new System.Windows.Forms.PictureBox();
            this.MusicProgressBar = new System.Windows.Forms.ProgressBar();
            this.PlayBtn = new System.Windows.Forms.PictureBox();
            this.PauseBtn = new System.Windows.Forms.PictureBox();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.playTimeLabel = new System.Windows.Forms.Label();
            this.MaximumPlayTime = new System.Windows.Forms.Label();
            this.NextBtn = new System.Windows.Forms.PictureBox();
            this.PlayerTimer = new System.Windows.Forms.Timer(this.components);
            this.MediaPlayerWin = new AxWMPLib.AxWindowsMediaPlayer();
            this.MinimizeBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayerWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.Location = new System.Drawing.Point(579, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(24, 24);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MusicPlayerLbl
            // 
            this.MusicPlayerLbl.AutoSize = true;
            this.MusicPlayerLbl.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicPlayerLbl.Location = new System.Drawing.Point(31, 1);
            this.MusicPlayerLbl.Name = "MusicPlayerLbl";
            this.MusicPlayerLbl.Size = new System.Drawing.Size(222, 26);
            this.MusicPlayerLbl.TabIndex = 1;
            this.MusicPlayerLbl.Text = "Music Player | Sokion";
            this.MusicPlayerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MusicLbox
            // 
            this.MusicLbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.MusicLbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MusicLbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MusicLbox.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicLbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(128)))), ((int)(((byte)(43)))));
            this.MusicLbox.FormattingEnabled = true;
            this.MusicLbox.HorizontalScrollbar = true;
            this.MusicLbox.IntegralHeight = false;
            this.MusicLbox.ItemHeight = 21;
            this.MusicLbox.Location = new System.Drawing.Point(397, 48);
            this.MusicLbox.Name = "MusicLbox";
            this.MusicLbox.Size = new System.Drawing.Size(198, 198);
            this.MusicLbox.TabIndex = 2;
            this.MusicLbox.SelectedIndexChanged += new System.EventHandler(this.MusicLbox_SelectedIndexChanged);
            // 
            // SelectBtn
            // 
            this.SelectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(128)))), ((int)(((byte)(43)))));
            this.SelectBtn.Location = new System.Drawing.Point(470, 290);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(125, 32);
            this.SelectBtn.TabIndex = 3;
            this.SelectBtn.Text = "Open Song";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // linePnl
            // 
            this.linePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(128)))), ((int)(((byte)(43)))));
            this.linePnl.Location = new System.Drawing.Point(-10, 33);
            this.linePnl.Name = "linePnl";
            this.linePnl.Size = new System.Drawing.Size(628, 2);
            this.linePnl.TabIndex = 5;
            // 
            // LogoIco
            // 
            this.LogoIco.Image = ((System.Drawing.Image)(resources.GetObject("LogoIco.Image")));
            this.LogoIco.Location = new System.Drawing.Point(10, 3);
            this.LogoIco.Name = "LogoIco";
            this.LogoIco.Size = new System.Drawing.Size(24, 24);
            this.LogoIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoIco.TabIndex = 6;
            this.LogoIco.TabStop = false;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(128)))), ((int)(((byte)(43)))));
            this.ClearBtn.Location = new System.Drawing.Point(397, 290);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(67, 32);
            this.ClearBtn.TabIndex = 7;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // LoopBtn
            // 
            this.LoopBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoopBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoopBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(128)))), ((int)(((byte)(43)))));
            this.LoopBtn.Location = new System.Drawing.Point(397, 252);
            this.LoopBtn.Name = "LoopBtn";
            this.LoopBtn.Size = new System.Drawing.Size(198, 32);
            this.LoopBtn.TabIndex = 8;
            this.LoopBtn.Text = "Loop";
            this.LoopBtn.UseVisualStyleBackColor = true;
            this.LoopBtn.Click += new System.EventHandler(this.LoopBtn_Click);
            // 
            // MusicPicture
            // 
            this.MusicPicture.Image = ((System.Drawing.Image)(resources.GetObject("MusicPicture.Image")));
            this.MusicPicture.Location = new System.Drawing.Point(119, 62);
            this.MusicPicture.Name = "MusicPicture";
            this.MusicPicture.Size = new System.Drawing.Size(164, 164);
            this.MusicPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MusicPicture.TabIndex = 9;
            this.MusicPicture.TabStop = false;
            // 
            // MusicProgressBar
            // 
            this.MusicProgressBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MusicProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(128)))), ((int)(((byte)(43)))));
            this.MusicProgressBar.Location = new System.Drawing.Point(10, 260);
            this.MusicProgressBar.Name = "MusicProgressBar";
            this.MusicProgressBar.Size = new System.Drawing.Size(374, 10);
            this.MusicProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.MusicProgressBar.TabIndex = 10;
            this.MusicProgressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MusicProgressBar_MouseDown);
            // 
            // PlayBtn
            // 
            this.PlayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayBtn.Image = ((System.Drawing.Image)(resources.GetObject("PlayBtn.Image")));
            this.PlayBtn.Location = new System.Drawing.Point(10, 280);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(30, 30);
            this.PlayBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayBtn.TabIndex = 11;
            this.PlayBtn.TabStop = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PauseBtn.Image = ((System.Drawing.Image)(resources.GetObject("PauseBtn.Image")));
            this.PauseBtn.Location = new System.Drawing.Point(46, 280);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(30, 30);
            this.PauseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PauseBtn.TabIndex = 12;
            this.PauseBtn.TabStop = false;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.Location = new System.Drawing.Point(280, 280);
            this.VolumeTrackBar.Maximum = 100;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Size = new System.Drawing.Size(104, 45);
            this.VolumeTrackBar.TabIndex = 13;
            this.VolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeTrackBar.Value = 50;
            this.VolumeTrackBar.Scroll += new System.EventHandler(this.VolumeTrackBar_Scroll);
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(288, 302);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(71, 13);
            this.VolumeLabel.TabIndex = 14;
            this.VolumeLabel.Text = "Volume : 50%";
            // 
            // playTimeLabel
            // 
            this.playTimeLabel.AutoSize = true;
            this.playTimeLabel.Location = new System.Drawing.Point(9, 244);
            this.playTimeLabel.Name = "playTimeLabel";
            this.playTimeLabel.Size = new System.Drawing.Size(34, 13);
            this.playTimeLabel.TabIndex = 15;
            this.playTimeLabel.Text = "00:00";
            // 
            // MaximumPlayTime
            // 
            this.MaximumPlayTime.AutoSize = true;
            this.MaximumPlayTime.Location = new System.Drawing.Point(350, 244);
            this.MaximumPlayTime.Name = "MaximumPlayTime";
            this.MaximumPlayTime.Size = new System.Drawing.Size(34, 13);
            this.MaximumPlayTime.TabIndex = 16;
            this.MaximumPlayTime.Text = "00:00";
            // 
            // NextBtn
            // 
            this.NextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextBtn.Image = ((System.Drawing.Image)(resources.GetObject("NextBtn.Image")));
            this.NextBtn.Location = new System.Drawing.Point(82, 280);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(30, 30);
            this.NextBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextBtn.TabIndex = 18;
            this.NextBtn.TabStop = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PlayerTimer
            // 
            this.PlayerTimer.Enabled = true;
            this.PlayerTimer.Tick += new System.EventHandler(this.PlayerTimer_Tick);
            // 
            // MediaPlayerWin
            // 
            this.MediaPlayerWin.Enabled = true;
            this.MediaPlayerWin.Location = new System.Drawing.Point(7, 41);
            this.MediaPlayerWin.Name = "MediaPlayerWin";
            this.MediaPlayerWin.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayerWin.OcxState")));
            this.MediaPlayerWin.Size = new System.Drawing.Size(27, 24);
            this.MediaPlayerWin.TabIndex = 17;
            this.MediaPlayerWin.Visible = false;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeBtn.Image")));
            this.MinimizeBtn.Location = new System.Drawing.Point(549, 4);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(24, 24);
            this.MinimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeBtn.TabIndex = 19;
            this.MinimizeBtn.TabStop = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(174, 229);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(53, 13);
            this.StatusLabel.TabIndex = 21;
            this.StatusLabel.Text = "Nothing...";
            // 
            // MediaPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(607, 336);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.MediaPlayerWin);
            this.Controls.Add(this.MaximumPlayTime);
            this.Controls.Add(this.playTimeLabel);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.VolumeTrackBar);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.MusicProgressBar);
            this.Controls.Add(this.MusicPicture);
            this.Controls.Add(this.LoopBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.LogoIco);
            this.Controls.Add(this.linePnl);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.MusicLbox);
            this.Controls.Add(this.MusicPlayerLbl);
            this.Controls.Add(this.CloseBtn);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MediaPlayerForm";
            this.Text = "Media Player";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MediaPlayerForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MediaPlayerForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MediaPlayerForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayerWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.Label MusicPlayerLbl;
        private System.Windows.Forms.ListBox MusicLbox;
        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.Panel linePnl;
        private System.Windows.Forms.PictureBox LogoIco;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button LoopBtn;
        private System.Windows.Forms.PictureBox MusicPicture;
        private System.Windows.Forms.ProgressBar MusicProgressBar;
        private System.Windows.Forms.PictureBox PlayBtn;
        private System.Windows.Forms.PictureBox PauseBtn;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Label playTimeLabel;
        private System.Windows.Forms.Label MaximumPlayTime;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayerWin;
        private System.Windows.Forms.PictureBox NextBtn;
        private System.Windows.Forms.Timer PlayerTimer;
        private System.Windows.Forms.PictureBox MinimizeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label StatusLabel;
    }
}

