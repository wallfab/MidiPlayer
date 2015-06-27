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
using Sanford.Multimedia.Midi;
using Sanford.Multimedia.Midi.UI;

namespace MidiPlayer
{
    public partial class frm_Main : Form
    {
        private string library;
        private Dictionary<string, Button> songs = new Dictionary<string, Button>();
        private List<Button> playlist = new List<Button>();
        private OutputDevice outputDevice;
        private int outputDeviceId;

        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            if(OutputDevice.DeviceCount == 0)
            {
                MessageBox.Show("No MIDI output devices available.", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

                Close();
            }
            
            //Load Program Defaults
            this.library = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\MidiPlayer\\Library";
            Debug.WriteLine(this.library);

            try
            {
                if (Properties.Settings.Default["outputDeviceId"] != null)
                {
                    setOutDevice(Convert.ToInt32(Properties.Settings.Default["outputDeviceId"]));
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine("EXCEPTION: " + ex.ToString());
                setOutDevice(0);
            }

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
                songs[name].Size = new Size((flp_SongList.Width - 25), 50);
                songs[name].Font = new Font(FontFamily.GenericSansSerif, 16);
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

        protected void PlayListButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Debug.WriteLine("Clicked: " + button.Text);
        }

        protected void songButton_MouseDown(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Debug.WriteLine("Dragging Button...");
            button.DoDragDrop(button, DragDropEffects.Copy);
            
        }

        private void frm_Main_Resize(object sender, EventArgs e)
        {
            
            flp_SongList.Width = this.Width / 2 - 30;
            flp_PlayList.Width = this.Width / 2 - 30;
            pdf_Lyrics.Width = (this.Width / 2)-15;
            pdf_Lyrics.Location = new Point(flp_SongList.Width + flp_SongList.Location.X + 10, pdf_Lyrics.Location.Y);
            foreach (KeyValuePair<string, Button> entry in songs)
            {
                entry.Value.Size = new Size((flp_SongList.Width - 25), 50);
            }

            foreach (Button song in playlist)
            {
                song.Size = new Size((flp_PlayList.Width - 25), 30);
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
            playlist_button.Size = new Size((flp_PlayList.Width - 25), 30);
            playlist_button.Font = new Font(FontFamily.GenericSansSerif, 16);
            playlist_button.Click += PlayListButton_Click;

            this.playlist.Add(playlist_button);
            flp_PlayList.Controls.Add(playlist_button);
            Debug.WriteLine("Added " + button.Text);
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            playnext();
        }

        public void setOutDevice(int deviceId)
        {
            try
            {
                if (this.outputDevice != null)
                    this.outputDevice.Close();
                this.outputDevice = null;
                this.outputDevice = new OutputDevice(deviceId);
                this.outputDeviceId = deviceId;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Es ist ein Fehler beim Auswählen des Outputgeräts aufgetreten!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Debug.WriteLine("EXCEPTION: " + ex.ToString());
            }

        }

        private void tsmi_settings_Click(object sender, EventArgs e)
        {
            
            Debug.WriteLine("Opening New Song Dialog...");
            Settings frm_Settings = new Settings(this, outputDeviceId);
            frm_Settings.Show();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["outputDeviceId"] = this.outputDeviceId;
            Properties.Settings.Default.Save();
        }

        private void sequencer1_ChannelMessagePlayed(object sender, ChannelMessageEventArgs e)
        {
            this.outputDevice.Send(e.Message);
        }

        private void sequencer1_PlayingCompleted(object sender, EventArgs e)
        {
            sequencer1.Stop();
            sequence1.Clear();
            timer1.Stop();
            this.Invoke((MethodInvoker)delegate
            {
                flp_PlayList.Controls.Remove(playlist[0]);
                playlist.RemoveAt(0);// runs on UI thread
                playnext();
            });
            
        }

        private void playnext()
        {
            string pdfFilePath;
            string midiFilePath;
            Button song;
                song = playlist[0];
                pdfFilePath = Path.Combine(this.library + "\\" + song.Text + "\\", song.Text + ".pdf");
                midiFilePath = Path.Combine(this.library + "\\" + song.Text + "\\", song.Text + ".mid");
            Debug.WriteLine("Playing: " + song.Text);
            Debug.WriteLine("MidiFile: " + midiFilePath);
            Debug.WriteLine("PDFFile: " + pdfFilePath);

            this.Invoke((MethodInvoker)delegate
            {
                if (File.Exists(pdfFilePath))
                    pdf_Lyrics.src = pdfFilePath;

                else
                    pdf_Lyrics.src = "";
            });
             
            sequencer1.Stop();
            sequence1.Load(Path.Combine(this.library + "\\" + song.Text + "\\", song.Text + ".mid"));
            sequencer1.Start();
            timer1.Start();
        }

        private void timer1_Stopped(object sender, EventArgs e)
        {
            
        }

    }
}
