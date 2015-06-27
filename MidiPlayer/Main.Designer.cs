namespace MidiPlayer
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.ms_MainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmi_file = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_help = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_about = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Alphabet = new System.Windows.Forms.Button();
            this.btn_Group = new System.Windows.Forms.Button();
            this.btn_AddSong = new System.Windows.Forms.Button();
            this.fsw_LibraryWatcher = new System.IO.FileSystemWatcher();
            this.flp_SongList = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_PlayList = new System.Windows.Forms.FlowLayoutPanel();
            this.pdf_Lyrics = new AxAcroPDFLib.AxAcroPDF();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Slower = new System.Windows.Forms.Button();
            this.btn_Faster = new System.Windows.Forms.Button();
            this.sequencer1 = new Sanford.Multimedia.Midi.Sequencer();
            this.sequence1 = new Sanford.Multimedia.Midi.Sequence();
            this.timer1 = new Sanford.Multimedia.Timers.Timer(this.components);
            this.ms_MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_LibraryWatcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdf_Lyrics)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_MainMenu
            // 
            this.ms_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_file,
            this.tsmi_help});
            this.ms_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.ms_MainMenu.Name = "ms_MainMenu";
            this.ms_MainMenu.Size = new System.Drawing.Size(890, 24);
            this.ms_MainMenu.TabIndex = 0;
            this.ms_MainMenu.Text = "menuStrip1";
            // 
            // tsmi_file
            // 
            this.tsmi_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_settings,
            this.tsmi_quit});
            this.tsmi_file.Name = "tsmi_file";
            this.tsmi_file.Size = new System.Drawing.Size(46, 20);
            this.tsmi_file.Text = "&Datei";
            // 
            // tsmi_settings
            // 
            this.tsmi_settings.Name = "tsmi_settings";
            this.tsmi_settings.Size = new System.Drawing.Size(145, 22);
            this.tsmi_settings.Text = "Einstellungen";
            this.tsmi_settings.Click += new System.EventHandler(this.tsmi_settings_Click);
            // 
            // tsmi_quit
            // 
            this.tsmi_quit.Name = "tsmi_quit";
            this.tsmi_quit.Size = new System.Drawing.Size(145, 22);
            this.tsmi_quit.Text = "Beenden";
            // 
            // tsmi_help
            // 
            this.tsmi_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_about});
            this.tsmi_help.Name = "tsmi_help";
            this.tsmi_help.Size = new System.Drawing.Size(44, 20);
            this.tsmi_help.Text = "&Hilfe";
            // 
            // tsmi_about
            // 
            this.tsmi_about.Name = "tsmi_about";
            this.tsmi_about.Size = new System.Drawing.Size(99, 22);
            this.tsmi_about.Text = "Über";
            // 
            // btn_Alphabet
            // 
            this.btn_Alphabet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alphabet.Location = new System.Drawing.Point(12, 27);
            this.btn_Alphabet.Name = "btn_Alphabet";
            this.btn_Alphabet.Size = new System.Drawing.Size(110, 75);
            this.btn_Alphabet.TabIndex = 1;
            this.btn_Alphabet.Text = "A - Z";
            this.btn_Alphabet.UseVisualStyleBackColor = true;
            // 
            // btn_Group
            // 
            this.btn_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Group.Location = new System.Drawing.Point(128, 27);
            this.btn_Group.Name = "btn_Group";
            this.btn_Group.Size = new System.Drawing.Size(110, 75);
            this.btn_Group.TabIndex = 2;
            this.btn_Group.Text = "Gruppe";
            this.btn_Group.UseVisualStyleBackColor = true;
            // 
            // btn_AddSong
            // 
            this.btn_AddSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddSong.Location = new System.Drawing.Point(244, 27);
            this.btn_AddSong.Name = "btn_AddSong";
            this.btn_AddSong.Size = new System.Drawing.Size(75, 75);
            this.btn_AddSong.TabIndex = 4;
            this.btn_AddSong.Text = "+";
            this.btn_AddSong.UseVisualStyleBackColor = true;
            this.btn_AddSong.Click += new System.EventHandler(this.btn_AddSong_Click);
            // 
            // fsw_LibraryWatcher
            // 
            this.fsw_LibraryWatcher.EnableRaisingEvents = true;
            this.fsw_LibraryWatcher.SynchronizingObject = this;
            this.fsw_LibraryWatcher.Changed += new System.IO.FileSystemEventHandler(this.fsw_LibraryWatcher_Changed);
            this.fsw_LibraryWatcher.Created += new System.IO.FileSystemEventHandler(this.fsw_LibraryWatcher_Changed);
            this.fsw_LibraryWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fsw_LibraryWatcher_Changed);
            // 
            // flp_SongList
            // 
            this.flp_SongList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_SongList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_SongList.Location = new System.Drawing.Point(12, 108);
            this.flp_SongList.Name = "flp_SongList";
            this.flp_SongList.Size = new System.Drawing.Size(424, 194);
            this.flp_SongList.TabIndex = 7;
            this.flp_SongList.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            // 
            // flp_PlayList
            // 
            this.flp_PlayList.AllowDrop = true;
            this.flp_PlayList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flp_PlayList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_PlayList.Location = new System.Drawing.Point(12, 308);
            this.flp_PlayList.Name = "flp_PlayList";
            this.flp_PlayList.Size = new System.Drawing.Size(424, 201);
            this.flp_PlayList.TabIndex = 8;
            this.flp_PlayList.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.flp_PlayList.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // pdf_Lyrics
            // 
            this.pdf_Lyrics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdf_Lyrics.Enabled = true;
            this.pdf_Lyrics.Location = new System.Drawing.Point(442, 27);
            this.pdf_Lyrics.Name = "pdf_Lyrics";
            this.pdf_Lyrics.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdf_Lyrics.OcxState")));
            this.pdf_Lyrics.Size = new System.Drawing.Size(436, 401);
            this.pdf_Lyrics.TabIndex = 9;
            // 
            // btn_Play
            // 
            this.btn_Play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.Image = global::MidiPlayer.Properties.Resources.button_play_small;
            this.btn_Play.Location = new System.Drawing.Point(442, 434);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(112, 75);
            this.btn_Play.TabIndex = 10;
            this.btn_Play.Text = " ";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pause.Image = global::MidiPlayer.Properties.Resources.button_pause_small;
            this.btn_Pause.Location = new System.Drawing.Point(560, 434);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(75, 75);
            this.btn_Pause.TabIndex = 11;
            this.btn_Pause.UseVisualStyleBackColor = true;
            // 
            // btn_Stop
            // 
            this.btn_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.Image = global::MidiPlayer.Properties.Resources.button_stop_small;
            this.btn_Stop.Location = new System.Drawing.Point(641, 434);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 75);
            this.btn_Stop.TabIndex = 12;
            this.btn_Stop.UseVisualStyleBackColor = true;
            // 
            // btn_Slower
            // 
            this.btn_Slower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Slower.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Slower.Image = global::MidiPlayer.Properties.Resources.button_slower_small;
            this.btn_Slower.Location = new System.Drawing.Point(722, 434);
            this.btn_Slower.Name = "btn_Slower";
            this.btn_Slower.Size = new System.Drawing.Size(75, 75);
            this.btn_Slower.TabIndex = 13;
            this.btn_Slower.Text = "+";
            this.btn_Slower.UseVisualStyleBackColor = true;
            // 
            // btn_Faster
            // 
            this.btn_Faster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Faster.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Faster.Image = global::MidiPlayer.Properties.Resources.button_faster_small;
            this.btn_Faster.Location = new System.Drawing.Point(803, 434);
            this.btn_Faster.Name = "btn_Faster";
            this.btn_Faster.Size = new System.Drawing.Size(75, 75);
            this.btn_Faster.TabIndex = 14;
            this.btn_Faster.Text = "+";
            this.btn_Faster.UseVisualStyleBackColor = true;
            // 
            // sequencer1
            // 
            this.sequencer1.Position = 0;
            this.sequencer1.Sequence = this.sequence1;
            this.sequencer1.PlayingCompleted += new System.EventHandler(this.sequencer1_PlayingCompleted);
            this.sequencer1.ChannelMessagePlayed += new System.EventHandler<Sanford.Multimedia.Midi.ChannelMessageEventArgs>(this.sequencer1_ChannelMessagePlayed);
            // 
            // sequence1
            // 
            this.sequence1.Format = 1;
            // 
            // timer1
            // 
            this.timer1.Mode = Sanford.Multimedia.Timers.TimerMode.Periodic;
            this.timer1.Period = 1;
            this.timer1.Resolution = 1;
            this.timer1.SynchronizingObject = null;
            this.timer1.Stopped += new System.EventHandler(this.timer1_Stopped);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 521);
            this.Controls.Add(this.btn_Faster);
            this.Controls.Add(this.btn_Slower);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.flp_PlayList);
            this.Controls.Add(this.flp_SongList);
            this.Controls.Add(this.pdf_Lyrics);
            this.Controls.Add(this.btn_AddSong);
            this.Controls.Add(this.btn_Group);
            this.Controls.Add(this.btn_Alphabet);
            this.Controls.Add(this.ms_MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_MainMenu;
            this.MinimumSize = new System.Drawing.Size(906, 560);
            this.Name = "frm_Main";
            this.Text = "MidiPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.Resize += new System.EventHandler(this.frm_Main_Resize);
            this.ms_MainMenu.ResumeLayout(false);
            this.ms_MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_LibraryWatcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdf_Lyrics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmi_help;
        private System.Windows.Forms.ToolStripMenuItem tsmi_about;
        private System.Windows.Forms.ToolStripMenuItem tsmi_file;
        private System.Windows.Forms.ToolStripMenuItem tsmi_settings;
        private System.Windows.Forms.ToolStripMenuItem tsmi_quit;
        private System.Windows.Forms.Button btn_Alphabet;
        private System.Windows.Forms.Button btn_Group;
        private System.Windows.Forms.Button btn_AddSong;
        private System.IO.FileSystemWatcher fsw_LibraryWatcher;
        private System.Windows.Forms.FlowLayoutPanel flp_SongList;
        private System.Windows.Forms.FlowLayoutPanel flp_PlayList;
        private AxAcroPDFLib.AxAcroPDF pdf_Lyrics;
        private System.Windows.Forms.Button btn_Faster;
        private System.Windows.Forms.Button btn_Slower;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Play;
        private Sanford.Multimedia.Midi.Sequencer sequencer1;
        private Sanford.Multimedia.Midi.Sequence sequence1;
        private Sanford.Multimedia.Timers.Timer timer1;
    }
}

