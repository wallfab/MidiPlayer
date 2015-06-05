using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiPlayer
{
    public partial class AddSong : Form
    {
        string library;
        bool Song = false;
        bool Lyrics = false;
        public AddSong()
        {
            InitializeComponent();
        }

        public AddSong(String library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void btn_Song_Click(object sender, EventArgs e)
        {
            ofd_Song.ShowDialog();
        }

        private void ofd_Song_FileOk(object sender, CancelEventArgs e)
        {
            btn_Song.BackColor = Color.LightGreen;
            tb_Songname.Text = ofd_Song.SafeFileName.Remove(ofd_Song.SafeFileName.IndexOf('.'));
            this.Song = true;
        }

        private void ofd_Text_FileOk(object sender, CancelEventArgs e)
        {
            btn_Lyrics.BackColor = Color.LightGreen;
            this.Lyrics = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Saving song...");
            if(!this.Song)
            {
                Debug.WriteLine("No Song selected!");
                MessageBox.Show("Keine Midi Datei ausgewählt!", "Fehler");
                return;
            }
            String songFolder = library + "\\" + tb_Songname.Text;
            if (Directory.Exists(songFolder))
            {
                Debug.WriteLine("Song already exists!");
                MessageBox.Show("Dieses Lied existiert schon!", "Fehler");
                return;
            }
            else
            {
                try
                {
                    Directory.CreateDirectory(songFolder);
                    File.Copy(ofd_Song.FileName, Path.Combine(songFolder, tb_Songname.Text + ".mid"));
                    if(Lyrics)
                    {
                        File.Copy(ofd_Lyrics.FileName, Path.Combine(songFolder, tb_Songname.Text + ".doc"));
                    }   
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error while saving song: " + ex.ToString());
                }

            }
            Debug.WriteLine("Song saved!");
            this.Close();
        }

        private void btn_Lyrics_Click(object sender, EventArgs e)
        {
            ofd_Lyrics.ShowDialog();
        }

        private void AddSong_Load(object sender, EventArgs e)
        {

        }
    }
}
