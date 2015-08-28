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
            this.btn_Slower = new System.Windows.Forms.Button();
            this.btn_Faster = new System.Windows.Forms.Button();
            this.sequencer1 = new Sanford.Multimedia.Midi.Sequencer();
            this.sequence1 = new Sanford.Multimedia.Midi.Sequence();
            this.timer1 = new Sanford.Multimedia.Timers.Timer(this.components);
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.sb_Duration = new System.Windows.Forms.HScrollBar();
            this.lb_Elapsed = new System.Windows.Forms.Label();
            this.lb_Time = new System.Windows.Forms.Label();
            this.midiInternalClock1 = new Sanford.Multimedia.Midi.MidiInternalClock(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
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
            this.ms_MainMenu.Size = new System.Drawing.Size(910, 24);
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
            this.flp_SongList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_SongList.Location = new System.Drawing.Point(12, 108);
            this.flp_SongList.Name = "flp_SongList";
            this.flp_SongList.Size = new System.Drawing.Size(436, 90);
            this.flp_SongList.TabIndex = 7;
            this.flp_SongList.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            // 
            // flp_PlayList
            // 
            this.flp_PlayList.AllowDrop = true;
            this.flp_PlayList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_PlayList.Location = new System.Drawing.Point(12, 204);
            this.flp_PlayList.Name = "flp_PlayList";
            this.flp_PlayList.Size = new System.Drawing.Size(436, 200);
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
            this.pdf_Lyrics.Location = new System.Drawing.Point(454, 27);
            this.pdf_Lyrics.Name = "pdf_Lyrics";
            this.pdf_Lyrics.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdf_Lyrics.OcxState")));
            this.pdf_Lyrics.Size = new System.Drawing.Size(444, 482);
            this.pdf_Lyrics.TabIndex = 9;
            // 
            // btn_Play
            // 
            this.btn_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.Image = global::MidiPlayer.Properties.Resources.button_play_small;
            this.btn_Play.Location = new System.Drawing.Point(12, 434);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(112, 75);
            this.btn_Play.TabIndex = 10;
            this.btn_Play.Text = " ";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Slower
            // 
            this.btn_Slower.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Slower.Image = global::MidiPlayer.Properties.Resources.button_slower_small;
            this.btn_Slower.Location = new System.Drawing.Point(292, 434);
            this.btn_Slower.Name = "btn_Slower";
            this.btn_Slower.Size = new System.Drawing.Size(75, 75);
            this.btn_Slower.TabIndex = 13;
            this.btn_Slower.Text = "+";
            this.btn_Slower.UseVisualStyleBackColor = true;
            this.btn_Slower.Click += new System.EventHandler(this.btn_Slower_Click);
            // 
            // btn_Faster
            // 
            this.btn_Faster.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Faster.Image = global::MidiPlayer.Properties.Resources.button_faster_small;
            this.btn_Faster.Location = new System.Drawing.Point(373, 434);
            this.btn_Faster.Name = "btn_Faster";
            this.btn_Faster.Size = new System.Drawing.Size(75, 75);
            this.btn_Faster.TabIndex = 14;
            this.btn_Faster.Text = "+";
            this.btn_Faster.UseVisualStyleBackColor = true;
            this.btn_Faster.Click += new System.EventHandler(this.btn_Faster_Click);
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
            // btn_Prev
            // 
            this.btn_Prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prev.Image = global::MidiPlayer.Properties.Resources.button_slower_small;
            this.btn_Prev.Location = new System.Drawing.Point(130, 434);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(75, 75);
            this.btn_Prev.TabIndex = 15;
            this.btn_Prev.Text = "+";
            this.btn_Prev.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Image = global::MidiPlayer.Properties.Resources.button_faster_small;
            this.btn_Next.Location = new System.Drawing.Point(211, 434);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 75);
            this.btn_Next.TabIndex = 16;
            this.btn_Next.Text = "+";
            this.btn_Next.UseVisualStyleBackColor = true;
            // 
            // sb_Duration
            // 
            this.sb_Duration.Location = new System.Drawing.Point(90, 407);
            this.sb_Duration.Name = "sb_Duration";
            this.sb_Duration.Size = new System.Drawing.Size(280, 24);
            this.sb_Duration.TabIndex = 17;
            // 
            // lb_Elapsed
            // 
            this.lb_Elapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Elapsed.Location = new System.Drawing.Point(12, 407);
            this.lb_Elapsed.Name = "lb_Elapsed";
            this.lb_Elapsed.Size = new System.Drawing.Size(75, 24);
            this.lb_Elapsed.TabIndex = 18;
            this.lb_Elapsed.Text = "00:00";
            this.lb_Elapsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Time
            // 
            this.lb_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Time.Location = new System.Drawing.Point(373, 407);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(75, 24);
            this.lb_Time.TabIndex = 19;
            this.lb_Time.Text = "00:00";
            this.lb_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // midiInternalClock1
            // 
            this.midiInternalClock1.Ppqn = 24;
            this.midiInternalClock1.Tempo = 500000;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.lb_Elapsed);
            this.Controls.Add(this.sb_Duration);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_Faster);
            this.Controls.Add(this.btn_Slower);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Button btn_Play;
        private Sanford.Multimedia.Midi.Sequencer sequencer1;
        private Sanford.Multimedia.Midi.Sequence sequence1;
        private Sanford.Multimedia.Timers.Timer timer1;
        private System.Windows.Forms.HScrollBar sb_Duration;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Label lb_Elapsed;
        private Sanford.Multimedia.Midi.MidiInternalClock midiInternalClock1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
    }
}

