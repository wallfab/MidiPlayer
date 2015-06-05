namespace MidiPlayer
{
    partial class AddSong
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
            this.btn_Song = new System.Windows.Forms.Button();
            this.btn_Lyrics = new System.Windows.Forms.Button();
            this.lbl_Songname = new System.Windows.Forms.Label();
            this.tb_Songname = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.ofd_Song = new System.Windows.Forms.OpenFileDialog();
            this.ofd_Lyrics = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_Song
            // 
            this.btn_Song.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Song.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Song.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Song.Location = new System.Drawing.Point(12, 12);
            this.btn_Song.Name = "btn_Song";
            this.btn_Song.Size = new System.Drawing.Size(260, 75);
            this.btn_Song.TabIndex = 0;
            this.btn_Song.Text = "1. Midi-Datei auswählen";
            this.btn_Song.UseVisualStyleBackColor = false;
            this.btn_Song.Click += new System.EventHandler(this.btn_Song_Click);
            // 
            // btn_Lyrics
            // 
            this.btn_Lyrics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Lyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lyrics.Location = new System.Drawing.Point(12, 93);
            this.btn_Lyrics.Name = "btn_Lyrics";
            this.btn_Lyrics.Size = new System.Drawing.Size(260, 75);
            this.btn_Lyrics.TabIndex = 1;
            this.btn_Lyrics.Text = "2. Text-Datei auswählen";
            this.btn_Lyrics.UseVisualStyleBackColor = true;
            this.btn_Lyrics.Click += new System.EventHandler(this.btn_Lyrics_Click);
            // 
            // lbl_Songname
            // 
            this.lbl_Songname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Songname.AutoSize = true;
            this.lbl_Songname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Songname.Location = new System.Drawing.Point(40, 171);
            this.lbl_Songname.Name = "lbl_Songname";
            this.lbl_Songname.Size = new System.Drawing.Size(207, 22);
            this.lbl_Songname.TabIndex = 2;
            this.lbl_Songname.Text = "3. Liedname eingeben";
            this.lbl_Songname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_Songname
            // 
            this.tb_Songname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Songname.Location = new System.Drawing.Point(12, 196);
            this.tb_Songname.Name = "tb_Songname";
            this.tb_Songname.Size = new System.Drawing.Size(260, 27);
            this.tb_Songname.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(12, 229);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(260, 75);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "4. Speichern";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // ofd_Song
            // 
            this.ofd_Song.Filter = "Midi Dateien|*.mid";
            this.ofd_Song.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_Song_FileOk);
            // 
            // ofd_Lyrics
            // 
            this.ofd_Lyrics.Filter = "Text Dateien|*.doc;*.pdf";
            this.ofd_Lyrics.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_Text_FileOk);
            // 
            // AddSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 313);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Songname);
            this.Controls.Add(this.lbl_Songname);
            this.Controls.Add(this.btn_Lyrics);
            this.Controls.Add(this.btn_Song);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddSong";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lied hinzufügen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddSong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Song;
        private System.Windows.Forms.Button btn_Lyrics;
        private System.Windows.Forms.Label lbl_Songname;
        private System.Windows.Forms.TextBox tb_Songname;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.OpenFileDialog ofd_Song;
        private System.Windows.Forms.OpenFileDialog ofd_Lyrics;
    }
}