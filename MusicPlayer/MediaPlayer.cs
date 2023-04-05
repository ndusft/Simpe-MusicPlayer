using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicPlayer
{
    public partial class MediaPlayerForm : Form
    {
        bool isClicked = false;
        private bool mouseDown;
        private Point lastLocation;
        String[] paths, files; 
        public MediaPlayerForm()
        {
            InitializeComponent();
            VolumeTrackBar.Value = 50;
            VolumeLabel.Text = "Volume : 50%";
        }

        private void MediaPlayerForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MediaPlayerForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MediaPlayerForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "MP3 files (*.mp3)|*.mp3";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    if (!MusicLbox.Items.Contains(files[i]))
                    {
                        MusicLbox.Items.Add(files[i]);
                    }
                }
            }
        }

        private void MusicLbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MusicLbox.SelectedIndex >= 0 && MusicLbox.SelectedIndex < paths.Length)
            {
                MediaPlayerWin.URL = paths[MusicLbox.SelectedIndex];
                MediaPlayerWin.Ctlcontrols.play();
                StatusLabel.Text = "Playing...";
                try
                {
                    var file = TagLib.File.Create(paths[MusicLbox.SelectedIndex]);
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    MusicPicture.Image = Image.FromStream(new MemoryStream(bin));
                }
                catch { }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            MusicLbox.Items.Clear();
        }

        private void LoopBtn_Click(object sender, EventArgs e)
        {
            if (isClicked)
            {
                isClicked = false;
                MediaPlayerWin.settings.autoStart = false;
                MediaPlayerWin.settings.setMode("loop", false);

                LoopBtn.ForeColor = ColorTranslator.FromHtml("#B0802B");
                LoopBtn.Text = "Loop";
            } else
            {
                isClicked = true;
                MediaPlayerWin.settings.autoStart = true;
                MediaPlayerWin.settings.setMode("loop", true);

                LoopBtn.ForeColor = ColorTranslator.FromHtml("#D4632B");
                LoopBtn.Text = "Unloop";
            }
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            MediaPlayerWin.Ctlcontrols.play();
            StatusLabel.Text = "Playing...";
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            MediaPlayerWin.Ctlcontrols.pause();
            StatusLabel.Text = "Paused...";
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (MusicLbox.SelectedIndex < MusicLbox.Items.Count-1)
            {
                MusicLbox.SelectedIndex = MusicLbox.SelectedIndex + 1;
            }
        }

        private void PlayerTimer_Tick(object sender, EventArgs e)
        {
            if (MediaPlayerWin.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                MusicProgressBar.Maximum = (int)MediaPlayerWin.Ctlcontrols.currentItem.duration;
                MusicProgressBar.Value = (int)MediaPlayerWin.Ctlcontrols.currentPosition;
            }
            try
            {
                playTimeLabel.Text = MediaPlayerWin.Ctlcontrols.currentPositionString;
                
                if (MediaPlayerWin.Ctlcontrols.currentItem != null)
                {
                    MaximumPlayTime.Text = MediaPlayerWin.Ctlcontrols.currentItem.durationString.ToString();
                }
            } catch { }
        }

        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            MediaPlayerWin.settings.volume = VolumeTrackBar.Value;
            VolumeLabel.Text = "Volume : " + VolumeTrackBar.Value.ToString() + "%";
        }

        private void MusicProgressBar_MouseDown(object sender, MouseEventArgs e)
        {
            MediaPlayerWin.Ctlcontrols.currentPosition = MediaPlayerWin.currentMedia.duration * e.X / MusicProgressBar.Width;
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
