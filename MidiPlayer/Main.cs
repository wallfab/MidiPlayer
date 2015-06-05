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
    public partial class frm_Main : Form
    {
        private string library;
        private Dictionary<string, Button> songs = new Dictionary<string, Button>();
        private List<Button> playlist = new List<Button>();

        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            //Load Program Defaults
            this.library = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\MidiPlayer";
            Debug.WriteLine(this.library);

            //Set up Program
            if(Directory.Exists(this.library))
            {
                Debug.WriteLine("Folder exists.");
                fsw_LibraryWatcher.Path = this.library;
            }
            else
            {
                Debug.WriteLine("Folder does not exist.");
                setUpLibrary();
            }

            flp_SongList.Width = this.Width / 2 - 30;
            flp_PlayList.Width = this.Width / 2 - 30;

            updateLibrary();

        }

        private void btn_AddSong_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Opening New Song Dialog...");
            AddSong frm_AddSong = new AddSong(this.library);
            frm_AddSong.Show();
        }

        private void updateLibrary()
        {
            flp_SongList.Controls.Clear();
            songs.Clear();
            Debug.WriteLine("Updating Library...");
            string[] directories = Directory.GetDirectories(this.library);
            foreach (string directory in directories)
            {
                string name = directory.Remove(0, this.library.Length + 1);
                Debug.WriteLine("Adding: " + name);
                songs[name] = new Button();
                songs[name].Text = name;
                songs[name].Tag = directory;
                songs[name].AutoSize = false;
                songs[name].Size = new Size((flp_SongList.Width - 25), 75);
                songs[name].Font = new Font(FontFamily.GenericSansSerif, 16);
                songs[name].Click += songButton_Click;
                songs[name].MouseDown += songButton_MouseDown;

                flp_SongList.Controls.Add(songs[name]);

            }
            Debug.WriteLine("Updated Library");
        }

        private void setUpLibrary()
        {
            Debug.WriteLine("Setting up Library...");
            try
            {
                Debug.WriteLine("Creating folder...");
                Directory.CreateDirectory(this.library);
                Debug.WriteLine("Folder successfully created!");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error while creating folder. " + ex.ToString());
                Debug.WriteLine("Exiting...");
                Application.Exit();
            }
            Debug.WriteLine("Successfully set up Library");
        }

        private void fsw_LibraryWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            Debug.WriteLine("The Library changed.");
            updateLibrary();
        }

        protected void songButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Debug.WriteLine("Clicked: " + button.Text);
        }

        protected void PlayListButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Debug.WriteLine("Clicked: " + button.Text);
        }

        protected void songButton_MouseDown(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.DoDragDrop(button, DragDropEffects.Copy);
        }

        private void frm_Main_Resize(object sender, EventArgs e)
        {
            flp_SongList.Width = this.Width / 2 - 30;
            flp_PlayList.Width = this.Width / 2 - 30;
            rtb_Lyrics.Width = this.Width / 2;
            foreach (KeyValuePair<string, Button> entry in songs)
            {
                entry.Value.Size = new Size((flp_SongList.Width - 25), 75);
            }
        }

        void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        void panel_DragDrop(object sender, DragEventArgs e)
        {
            Button button = (Button)e.Data.GetData(typeof(Button));

            Button playlist_button = new Button();
            playlist_button.Text = button.Text;
            playlist_button.Tag = button.Tag;
            playlist_button.AutoSize = false;
            playlist_button.Size = new Size((flp_PlayList.Width - 25), 75);
            playlist_button.Font = new Font(FontFamily.GenericSansSerif, 16);
            playlist_button.Click += PlayListButton_Click;

            this.playlist.Add(playlist_button);
            flp_PlayList.Controls.Add(playlist_button);
        }
    }
}
