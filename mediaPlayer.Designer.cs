namespace AudioVisualizer1
{
    partial class mediaPlayer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mediaPlayer));
            this.player = new System.Windows.Forms.Panel();
            this.pauseSong = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.playSong = new System.Windows.Forms.Button();
            this.songTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.TrackBar();
            this.SongName = new System.Windows.Forms.Label();
            this.song = new System.Windows.Forms.TrackBar();
            this.settings = new System.Windows.Forms.Panel();
            this.color2 = new System.Windows.Forms.Button();
            this.color1 = new System.Windows.Forms.Button();
            this.changeBack = new System.Windows.Forms.Button();
            this.settingLabel = new System.Windows.Forms.Label();
            this.spectrumDesign = new System.Windows.Forms.ComboBox();
            this.design = new System.Windows.Forms.Label();
            this.instructions = new System.Windows.Forms.Label();
            this.focus = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playBtn = new System.Windows.Forms.Button();
            this.settingBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.streamBox = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.song)).BeginInit();
            this.settings.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.streamBox)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.player.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.player.Controls.Add(this.pauseSong);
            this.player.Controls.Add(this.Open);
            this.player.Controls.Add(this.playSong);
            this.player.Controls.Add(this.songTime);
            this.player.Controls.Add(this.label1);
            this.player.Controls.Add(this.volume);
            this.player.Controls.Add(this.SongName);
            this.player.Controls.Add(this.song);
            this.player.Location = new System.Drawing.Point(493, 27);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(504, 152);
            this.player.TabIndex = 4;
            // 
            // pauseSong
            // 
            this.pauseSong.AutoSize = true;
            this.pauseSong.BackColor = System.Drawing.Color.Transparent;
            this.pauseSong.BackgroundImage = global::AudioVisualizer1.Properties.Resources.icons8_pause_96;
            this.pauseSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pauseSong.FlatAppearance.BorderSize = 0;
            this.pauseSong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pauseSong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pauseSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseSong.Location = new System.Drawing.Point(43, 96);
            this.pauseSong.Name = "pauseSong";
            this.pauseSong.Size = new System.Drawing.Size(30, 30);
            this.pauseSong.TabIndex = 7;
            this.pauseSong.TabStop = false;
            this.pauseSong.UseVisualStyleBackColor = false;
            this.pauseSong.Click += new System.EventHandler(this.pauseSong_Click);
            // 
            // Open
            // 
            this.Open.AutoSize = true;
            this.Open.BackColor = System.Drawing.Color.Transparent;
            this.Open.BackgroundImage = global::AudioVisualizer1.Properties.Resources.icons8_folder_400__1_;
            this.Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Open.FlatAppearance.BorderSize = 0;
            this.Open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open.Location = new System.Drawing.Point(105, 96);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(30, 30);
            this.Open.TabIndex = 6;
            this.Open.TabStop = false;
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // playSong
            // 
            this.playSong.AutoSize = true;
            this.playSong.BackColor = System.Drawing.Color.Transparent;
            this.playSong.BackgroundImage = global::AudioVisualizer1.Properties.Resources.icons8_play_96;
            this.playSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playSong.Enabled = false;
            this.playSong.FlatAppearance.BorderSize = 0;
            this.playSong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playSong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playSong.Location = new System.Drawing.Point(43, 96);
            this.playSong.Name = "playSong";
            this.playSong.Size = new System.Drawing.Size(30, 30);
            this.playSong.TabIndex = 5;
            this.playSong.TabStop = false;
            this.playSong.UseVisualStyleBackColor = false;
            this.playSong.Click += new System.EventHandler(this.playSong_Click);
            // 
            // songTime
            // 
            this.songTime.AutoSize = true;
            this.songTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.songTime.Location = new System.Drawing.Point(397, 41);
            this.songTime.Name = "songTime";
            this.songTime.Size = new System.Drawing.Size(74, 16);
            this.songTime.TabIndex = 4;
            this.songTime.Text = "00:00/00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(395, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Volume";
            // 
            // volume
            // 
            this.volume.LargeChange = 0;
            this.volume.Location = new System.Drawing.Point(359, 96);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(120, 45);
            this.volume.TabIndex = 2;
            this.volume.TabStop = false;
            this.volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volume.Value = 5;
            this.volume.Scroll += new System.EventHandler(this.volume_Scroll);
            // 
            // SongName
            // 
            this.SongName.AutoSize = true;
            this.SongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SongName.Location = new System.Drawing.Point(22, 17);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(168, 18);
            this.SongName.TabIndex = 1;
            this.SongName.Text = "Select Any Song to Play!";
            // 
            // song
            // 
            this.song.Location = new System.Drawing.Point(12, 62);
            this.song.Maximum = 100;
            this.song.Name = "song";
            this.song.Size = new System.Drawing.Size(476, 45);
            this.song.TabIndex = 0;
            this.song.TabStop = false;
            this.song.TickStyle = System.Windows.Forms.TickStyle.None;
            this.song.Scroll += new System.EventHandler(this.song_Scroll);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.settings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settings.Controls.Add(this.color2);
            this.settings.Controls.Add(this.color1);
            this.settings.Controls.Add(this.changeBack);
            this.settings.Controls.Add(this.settingLabel);
            this.settings.Controls.Add(this.spectrumDesign);
            this.settings.Controls.Add(this.design);
            this.settings.Location = new System.Drawing.Point(3, 27);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(390, 301);
            this.settings.TabIndex = 5;
            // 
            // color2
            // 
            this.color2.Enabled = false;
            this.color2.Location = new System.Drawing.Point(229, 241);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(88, 27);
            this.color2.TabIndex = 6;
            this.color2.Text = "Peak Color";
            this.color2.UseVisualStyleBackColor = true;
            this.color2.Click += new System.EventHandler(this.color2_Click);
            // 
            // color1
            // 
            this.color1.Enabled = false;
            this.color1.Location = new System.Drawing.Point(67, 241);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(88, 27);
            this.color1.TabIndex = 5;
            this.color1.Text = "Base Color";
            this.color1.UseVisualStyleBackColor = true;
            this.color1.Click += new System.EventHandler(this.color1_Click);
            // 
            // changeBack
            // 
            this.changeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBack.Location = new System.Drawing.Point(91, 111);
            this.changeBack.Name = "changeBack";
            this.changeBack.Size = new System.Drawing.Size(194, 33);
            this.changeBack.TabIndex = 4;
            this.changeBack.Text = "Change Background Color";
            this.changeBack.UseVisualStyleBackColor = true;
            this.changeBack.Click += new System.EventHandler(this.changeBack_Click_1);
            // 
            // settingLabel
            // 
            this.settingLabel.AutoSize = true;
            this.settingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.settingLabel.Location = new System.Drawing.Point(135, 46);
            this.settingLabel.Name = "settingLabel";
            this.settingLabel.Size = new System.Drawing.Size(108, 29);
            this.settingLabel.TabIndex = 3;
            this.settingLabel.Text = "Settings";
            // 
            // spectrumDesign
            // 
            this.spectrumDesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spectrumDesign.FormattingEnabled = true;
            this.spectrumDesign.Location = new System.Drawing.Point(176, 184);
            this.spectrumDesign.Name = "spectrumDesign";
            this.spectrumDesign.Size = new System.Drawing.Size(156, 21);
            this.spectrumDesign.TabIndex = 2;
            this.spectrumDesign.SelectedIndexChanged += new System.EventHandler(this.spectrumDesign_SelectedIndexChanged);
            // 
            // design
            // 
            this.design.AutoSize = true;
            this.design.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.design.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.design.Location = new System.Drawing.Point(41, 185);
            this.design.Name = "design";
            this.design.Size = new System.Drawing.Size(114, 20);
            this.design.TabIndex = 1;
            this.design.Text = "Select Design";
            // 
            // instructions
            // 
            this.instructions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instructions.AutoSize = true;
            this.instructions.BackColor = System.Drawing.Color.Transparent;
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.instructions.Location = new System.Drawing.Point(412, 3);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(186, 24);
            this.instructions.TabIndex = 8;
            this.instructions.Text = "Right Click For Menu";
            // 
            // focus
            // 
            this.focus.BackColor = System.Drawing.SystemColors.InfoText;
            this.focus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.focus.Cursor = System.Windows.Forms.Cursors.Default;
            this.focus.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.focus.Location = new System.Drawing.Point(3, 3);
            this.focus.MaxLength = 32767000;
            this.focus.Name = "focus";
            this.focus.ReadOnly = true;
            this.focus.Size = new System.Drawing.Size(10, 3);
            this.focus.TabIndex = 9;
            this.focus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.focus_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 27;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playBtn
            // 
            this.playBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playBtn.AutoSize = true;
            this.playBtn.BackColor = System.Drawing.Color.Transparent;
            this.playBtn.BackgroundImage = global::AudioVisualizer1.Properties.Resources.icons8_play_100;
            this.playBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Location = new System.Drawing.Point(938, 12);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(50, 45);
            this.playBtn.TabIndex = 6;
            this.playBtn.TabStop = false;
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            this.playBtn.MouseEnter += new System.EventHandler(this.playBtn_MouseEnter);
            this.playBtn.MouseLeave += new System.EventHandler(this.playBtn_MouseLeave);
            // 
            // settingBtn
            // 
            this.settingBtn.AutoSize = true;
            this.settingBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingBtn.BackgroundImage = global::AudioVisualizer1.Properties.Resources.icons8_settings_100__1_;
            this.settingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingBtn.FlatAppearance.BorderSize = 0;
            this.settingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.settingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingBtn.Location = new System.Drawing.Point(5, 12);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(50, 45);
            this.settingBtn.TabIndex = 7;
            this.settingBtn.TabStop = false;
            this.settingBtn.UseVisualStyleBackColor = false;
            this.settingBtn.Click += new System.EventHandler(this.settingBtn_Click);
            this.settingBtn.MouseEnter += new System.EventHandler(this.settingBtn_MouseEnter);
            this.settingBtn.MouseLeave += new System.EventHandler(this.settingBtn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.instructions);
            this.panel1.Controls.Add(this.settings);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.playBtn);
            this.panel1.Controls.Add(this.settingBtn);
            this.panel1.Controls.Add(this.streamBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 600);
            this.panel1.TabIndex = 10;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // streamBox
            // 
            this.streamBox.BackColor = System.Drawing.Color.Transparent;
            this.streamBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streamBox.Enabled = false;
            this.streamBox.Location = new System.Drawing.Point(0, 0);
            this.streamBox.Name = "streamBox";
            this.streamBox.Size = new System.Drawing.Size(1000, 600);
            this.streamBox.TabIndex = 0;
            this.streamBox.TabStop = false;
            this.streamBox.Click += new System.EventHandler(this.streamBox_Click);
            this.streamBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // mediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.focus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "mediaPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.mediaPlayer_Load);
            this.player.ResumeLayout(false);
            this.player.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.song)).EndInit();
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.streamBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel player;
        private System.Windows.Forms.Button pauseSong;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button playSong;
        private System.Windows.Forms.Label songTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar volume;
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.TrackBar song;
        private System.Windows.Forms.Panel settings;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.TextBox focus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox streamBox;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label design;
        private System.Windows.Forms.ComboBox spectrumDesign;
        private System.Windows.Forms.Label settingLabel;
        private System.Windows.Forms.Button changeBack;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Button color2;
        private System.Windows.Forms.Button color1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}
