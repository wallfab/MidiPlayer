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
            this.rtb_Lyrics = new System.Windows.Forms.RichTextBox();
            this.fsw_LibraryWatcher = new System.IO.FileSystemWatcher();
            this.flp_SongList = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_PlayList = new System.Windows.Forms.FlowLayoutPanel();
            this.ms_MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_LibraryWatcher)).BeginInit();
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
            // rtb_Lyrics
            // 
            this.rtb_Lyrics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Lyrics.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtb_Lyrics.Location = new System.Drawing.Point(454, 24);
            this.rtb_Lyrics.Name = "rtb_Lyrics";
            this.rtb_Lyrics.Size = new System.Drawing.Size(436, 497);
            this.rtb_Lyrics.TabIndex = 6;
            this.rtb_Lyrics.Text = "";
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
            this.flp_SongList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flp_SongList.AutoScroll = true;
            this.flp_SongList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_SongList.Location = new System.Drawing.Point(12, 108);
            this.flp_SongList.Name = "flp_SongList";
            this.flp_SongList.Size = new System.Drawing.Size(424, 52);
            this.flp_SongList.TabIndex = 7;
            this.flp_SongList.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            // 
            // flp_PlayList
            // 
            this.flp_PlayList.AllowDrop = true;
            this.flp_PlayList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flp_PlayList.AutoScroll = true;
            this.flp_PlayList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_PlayList.Location = new System.Drawing.Point(12, 166);
            this.flp_PlayList.Name = "flp_PlayList";
            this.flp_PlayList.Size = new System.Drawing.Size(424, 343);
            this.flp_PlayList.TabIndex = 8;
            this.flp_PlayList.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel_DragDrop);
            this.flp_PlayList.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel_DragEnter);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 521);
            this.Controls.Add(this.flp_PlayList);
            this.Controls.Add(this.flp_SongList);
            this.Controls.Add(this.rtb_Lyrics);
            this.Controls.Add(this.btn_AddSong);
            this.Controls.Add(this.btn_Group);
            this.Controls.Add(this.btn_Alphabet);
            this.Controls.Add(this.ms_MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_MainMenu;
            this.Name = "frm_Main";
            this.Text = "MidiPlayer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.Resize += new System.EventHandler(this.frm_Main_Resize);
            this.ms_MainMenu.ResumeLayout(false);
            this.ms_MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fsw_LibraryWatcher)).EndInit();
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
        private System.Windows.Forms.RichTextBox rtb_Lyrics;
        private System.IO.FileSystemWatcher fsw_LibraryWatcher;
        private System.Windows.Forms.FlowLayoutPanel flp_SongList;
        private System.Windows.Forms.FlowLayoutPanel flp_PlayList;
    }
}

