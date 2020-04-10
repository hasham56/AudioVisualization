using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Un4seen.Bass.Misc;
using Un4seen.Bass.AddOn.Sfx;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Tags;

namespace AudioVisualizer1
{
    public partial class mediaPlayer : Form
    {
        public mediaPlayer()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            settingBtn.Hide();
            playBtn.Hide();
            player.Hide();
            settings.Hide();
            pauseSong.Hide();
            focus.Focus();
        }
        private void playBtn_Click(object sender, EventArgs e)
        {
            playBtn.Hide();
            player.Show();
            focus.Focus();
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            settingBtn.Hide();
            settings.Show();
            focus.Focus();
        }
        Visuals spectrum = new Visuals();
        TAG_INFO TI = new TAG_INFO();
        private string position;
        private string length;
        private int stream;
        private int n = 0;
        private int hSFX3;
        private int hSFX4;
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && n % 2 == 0)
            {
                n += 1;
                instructions.Visible = false;
                settingBtn.Show();
                if (Bass.BASS_ChannelIsActive(stream) != BASSActive.BASS_ACTIVE_STOPPED)
                {
                    player.Show();
                }
                else
                {
                    playBtn.Show();
                }
            }
            else
            {
                n += 1;
                playBtn.Hide();
                settingBtn.Hide();
                settings.Hide();
                player.Hide();
                if (Bass.BASS_ChannelIsActive(stream) != BASSActive.BASS_ACTIVE_STOPPED)
                {
                    instructions.Visible = false;
                }
                else
                {
                    instructions.Visible = true;
                }
            }
            focus.Focus();
        }
        private string fileName;
        private int m = 0;
        private void Open_Click(object sender, EventArgs e)
        {
            m += 1;
            pauseSong_Click(sender, e);
            DialogResult result;
            this.openFileDialog1.Filter = "Music Formats|" +
                "*.mp3;*.ram;*.rm;*.wma;*.mid|" +
                "mp3 (*.mp3)|*.mp3|ram (*.ram)|*.ram|rm (*.rm)|*.rm|" +
                "wav (*.wav)|*.wav|wma (*.wma)|*.wma|mid (*mid)|*.mid";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.FileName = "";
            this.openFileDialog1.Title = "Choose Your Song!";
            this.openFileDialog1.CheckFileExists = true;
            this.openFileDialog1.CheckPathExists = true;
            this.openFileDialog1.Multiselect = false;
            result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                if (fileName != null)
                {
                    playSong_Click(sender, e);
                }
            }
            focus.Focus();
        }
        private void addItems()
        {
            spectrumDesign.Items.Add("Lines");
            spectrumDesign.Items.Add("Wave");
            spectrumDesign.Items.Add("Bar");
            spectrumDesign.Items.Add("Peak Bar");
            spectrumDesign.Items.Add("Dot");
            spectrumDesign.Items.Add("Bean");
            spectrumDesign.Items.Add("Eclipse");
            spectrumDesign.Items.Add("WaveForm");
            spectrumDesign.Items.Add("SpectrumText");
            spectrumDesign.Items.Add("Graphics");
            spectrumDesign.Items.Add("Custom Plugin");
        }
        private void playSong_Click(object sender, EventArgs e)
        {
            if (Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_PAUSED)
            {
                playSong.Hide();
                playSong.Enabled = true;
                pauseSong.Show();
                Bass.BASS_ChannelPlay(stream, false);
                timer1.Start();
                timer2.Start();
            }
            else
            {
                stream = Bass.BASS_StreamCreateFile(fileName, 0, 0, BASSFlag.BASS_DEFAULT);
                Bass.BASS_ChannelPlay(stream, false);

                song.Maximum = (int)Bass.BASS_ChannelGetLength(stream);

                Bass.BASS_SetVolume((float)0.32);

                playSong.Enabled = false;
                playSong.Hide();
                pauseSong.Show();

                BASS_CHANNELINFO channelinf = Bass.BASS_ChannelGetInfo(stream);
                string songFile = channelinf.filename;
                if (songFile.Length > 70)
                {
                    int length = songFile.Length;
                    songFile = songFile.Substring(0, 70) + ".... ";
                }
                SongName.Text = Path.GetFileName(songFile);

                addItems();

                timer1.Start();
                timer2.Start();
            }
            focus.Focus();
        }

        private void pauseSong_Click(object sender, EventArgs e)
        {
            if (Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {
                timer1.Stop();
                Bass.BASS_ChannelPause(stream);
                pauseSong.Hide();
                playSong.Enabled = true;
                playSong.Show();
                streamBox.Image = null;
            }
            focus.Focus();
        }

        private void focus_KeyDown(object sender, KeyEventArgs e)
        {
            if (Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {
                if (e.KeyCode == Keys.Right)
                {
                    if (song.Value < song.Maximum)
                    {
                        song.Value += 1000000;
                        song_Scroll(sender, e);
                    }
                }
                else if (e.KeyCode == Keys.Left)
                {
                    if (song.Value >= 1000000)
                    {
                        song.Value -= 1000000;
                        song_Scroll(sender, e);
                    }
                }
                else if (e.KeyCode == Keys.Up)
                {
                    if (volume.Value < 10)
                    {
                        volume.Value += 1;
                        volume_Scroll(sender, e);
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (volume.Value > 0)
                    {
                        volume.Value -= 1;
                        volume_Scroll(sender, e);
                    }
                }
                else if (e.KeyCode == Keys.M)
                {
                    volume.Value = 0;
                    volume_Scroll(sender, e);
                }
                else if (e.KeyCode == Keys.Space)
                {
                     pauseSong_Click(sender, e);
                }
            }
            else if (Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_PAUSED)
            {
                if (e.KeyCode == Keys.Space)
                {
                    playSong_Click(sender, e);
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                this.Text = "Audio Visualizer";
                WindowState = FormWindowState.Normal;
                this.Size = new Size(1000, 650);
            }
            if (e.KeyCode == Keys.Enter)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
        }

        private void song_Scroll(object sender, EventArgs e)
        {
            if (Bass.BASS_ChannelIsActive(stream) != BASSActive.BASS_ACTIVE_STOPPED)
            {
                Bass.BASS_ChannelSetPosition(stream, song.Value);
            }
            focus.Focus();
        }

        private void volume_Scroll(object sender, EventArgs e)
        {
            if (Bass.BASS_ChannelIsActive(stream) != BASSActive.BASS_ACTIVE_STOPPED)
            {
                Bass.BASS_SetVolume((float)volume.Value / 10);
                
            }
            focus.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            song.Enabled = true;
            volume.Enabled = true;
            song.Value = (int)Bass.BASS_ChannelGetPosition(stream);
            double len = Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetLength(stream));
            double pos = Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetPosition(stream));
            length = string.Format(" {0:#0.00}", Utils.FixTimespan(len, "MMSS"));
            position = string.Format(" {0:#0.00}", Utils.FixTimespan(pos, "MMSS"));
            songTime.Text = position + "/" + length;
            if (song.Value == song.Maximum)
            {
                pauseSong.Hide();
                playSong.Show();
                playSong.Enabled = true;
                songTime.Text = "00:00/00:00";
                timer1.Stop();
                song.Value = 0;
                song.Enabled = false;
                volume.Enabled = false;
            }
        }

        private void playBtn_MouseEnter(object sender, EventArgs e)
        {
            playBtn.Size = new Size(55, 50);
            playBtn.Location = new Point(playBtn.Location.X - 2, playBtn.Location.Y - 2);
        }

        private void playBtn_MouseLeave(object sender, EventArgs e)
        {
            playBtn.Size = new Size(50, 45);
            playBtn.Location = new Point(playBtn.Location.X + 2, playBtn.Location.Y + 2);
        }

        private void settingBtn_MouseEnter(object sender, EventArgs e)
        {
            settingBtn.Size = new Size(55, 50);
            settingBtn.Location = new Point(settingBtn.Location.X - 2, settingBtn.Location.Y - 2);
        }

        private void settingBtn_MouseLeave(object sender, EventArgs e)
        {
            settingBtn.Size = new Size(50, 45);
            settingBtn.Location = new Point(settingBtn.Location.X + 2, settingBtn.Location.Y + 2);
        }

        private void mediaPlayer_Load(object sender, EventArgs e)
        {
            song.Enabled = false;
            volume.Enabled = false;
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
            BassSfx.BASS_SFX_Init(System.Diagnostics.Process.GetCurrentProcess().Handle, this.Handle);
            focus.Focus();
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {   
            if (Bass.BASS_ChannelIsActive(stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {

                if (spectrumDesign.SelectedIndex == 0)
                    streamBox.Image = spectrum.CreateSpectrum(stream, streamBox.Width, streamBox.Height, clr1, clr2, clr3, false, false, true);
                else if (spectrumDesign.SelectedIndex == 1)
                    streamBox.Image = spectrum.CreateSpectrumWave(stream, streamBox.Width, streamBox.Height, clr1, clr2, clr3, 3, false, false, true);
                else if (spectrumDesign.SelectedIndex == 2)
                    streamBox.Image = spectrum.CreateSpectrumLine(stream, streamBox.Width, streamBox.Height, clr1, clr2, clr3, 11, 2, false, false, true);
                else if (spectrumDesign.SelectedIndex == 3)
                    streamBox.Image = spectrum.CreateSpectrumLinePeak(stream, streamBox.Width, streamBox.Height, clr1, clr2, clr2, clr3, 11, 1, 2, 50, false, false, true);
                else if (spectrumDesign.SelectedIndex == 4)
                    streamBox.Image = spectrum.CreateSpectrumDot(stream, streamBox.Width, streamBox.Height, clr1, clr2, clr3, 8, 5, false, false, true);
                else if (spectrumDesign.SelectedIndex == 5)
                    streamBox.Image = spectrum.CreateSpectrumBean(stream, streamBox.Width, streamBox.Height, clr1, clr2, clr3, 3, false, false, true);
                else if (spectrumDesign.SelectedIndex == 6)
                    streamBox.Image = spectrum.CreateSpectrumEllipse(stream, streamBox.Width, streamBox.Height, clr1, clr2, clr3, 8, 5, false, false, true);
                else if (spectrumDesign.SelectedIndex == 7)
                    streamBox.Image = spectrum.CreateWaveForm(stream, streamBox.Width, streamBox.Height, clr1, clr2, clr3, clr3, 3, false, false, true);
                else if (spectrumDesign.SelectedIndex == 8)
                    streamBox.Image = spectrum.CreateSpectrumText(stream, streamBox.Width, streamBox.Height, clr1, clr2, clr3, "Fiverr Project", false, false, true);
                else if (spectrumDesign.SelectedIndex == 9)
                {
                    if (hSFX3 != 0)
                    {
                        Graphics g = Graphics.FromHwnd(streamBox.Handle);
                        BassSfx.BASS_SFX_PluginRender(hSFX3, stream, g.GetHdc());
                        g.Dispose();
                    }
                }
                else if (spectrumDesign.SelectedIndex == 10)
                {
                    if (hSFX4 != 0)
                    {
                        Graphics g = Graphics.FromHwnd(streamBox.Handle);
                        BassSfx.BASS_SFX_PluginRender(hSFX4, stream, g.GetHdc());
                        g.Dispose();
                    }
                }   
                else
                    streamBox.Image = null;
            }
        }
        Color clr1 = Color.LawnGreen;
        Color clr2 = Color.Red;
        Color clr3 = Color.Empty;
        private void changeBack_Click_1(object sender, EventArgs e)
        {
            ColorDialog cPicker = new ColorDialog();
            if (cPicker.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cPicker.Color;
                streamBox.BackColor = cPicker.Color;
            }
            focus.Focus();
        }

        private void color1_Click(object sender, EventArgs e)
        {
            ColorDialog cPicker = new ColorDialog();
            if (cPicker.ShowDialog() == DialogResult.OK)
            {
                clr1 = cPicker.Color;
            }
            focus.Focus();
        }

        private void color2_Click(object sender, EventArgs e)
        {
            ColorDialog cPicker = new ColorDialog();
            if (cPicker.ShowDialog() == DialogResult.OK)
            {
                clr2 = cPicker.Color;
            }
            focus.Focus();
        }

        private void spectrumDesign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (spectrumDesign.SelectedIndex > -1 && spectrumDesign.SelectedIndex < 9)
            {
                color1.Enabled = true;
                color2.Enabled = true;
            }
            else if (spectrumDesign.SelectedIndex == 9)
            {
                try
                {
                    BassSfx.BASS_SFX_PluginStop(hSFX3);
                    BassSfx.BASS_SFX_PluginStop(hSFX4);
                }
                catch
                {

                }
                hSFX3 = BassSfx.BASS_SFX_PluginCreate("0AA02E8D-F851-4CB0-9F64-BBA9BE7A983D", streamBox.Handle, streamBox.Width, streamBox.Height, BASSSFXFlag.BASS_SFX_DEFAULT);
                BassSfx.BASS_SFX_PluginSetStream(hSFX3, stream);
                BassSfx.BASS_SFX_PluginStart(hSFX3);
            }
            else if (spectrumDesign.SelectedIndex == 10)
            {
                try
                {
                    BassSfx.BASS_SFX_PluginStop(hSFX3);
                    BassSfx.BASS_SFX_PluginStop(hSFX4);
                }
                catch
                {

                }
                DialogResult resultP;
                this.openFileDialog2.RestoreDirectory = true;
                this.openFileDialog2.FileName = "";
                this.openFileDialog2.Filter = "Plugins(.svp,.dll)|*.svp;*.dll|All Files|*.*";
                this.openFileDialog2.Title = "Choose Plugin!";
                this.openFileDialog2.CheckFileExists = true;
                this.openFileDialog2.CheckPathExists = true;
                this.openFileDialog2.Multiselect = false;
                resultP = openFileDialog2.ShowDialog();
                if (resultP == DialogResult.OK)
                {
                    hSFX4 = BassSfx.BASS_SFX_PluginCreate(openFileDialog2.FileName, streamBox.Handle, streamBox.Width, streamBox.Height, BASSSFXFlag.BASS_SFX_DEFAULT);
                    BassSfx.BASS_SFX_PluginSetStream(hSFX4, stream);
                    BassSfx.BASS_SFX_PluginStart(hSFX4);
                }
            }
            else
            {
                color1.Enabled = false;
                color2.Enabled = false;
            }
            focus.Focus();
        }

        private void streamBox_Click(object sender, EventArgs e)
        {
            focus.Focus();
        }
    }
}
