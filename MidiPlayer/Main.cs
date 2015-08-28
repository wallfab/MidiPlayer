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
using System.IO.Ports;

namespace MidiPlayer
{
    public partial class frm_Main : Form
    {
        private string library;
        private string groups;
        private string tracks;
        private string current_library;
        private Dictionary<string, Button> songs = new Dictionary<string, Button>();
        private List<Button> playlist = new List<Button>();
        private OutputDevice outputDevice;
        private int outputDeviceId;
        private bool playing;
        private bool pause;
        private int tempo = 500000;
        private int playlist_pos = 0;
        SerialPort ComPort = new SerialPort();
        DateTime lastInput;

        internal delegate void SerialDataReceivedEventHandlerDelegate(object sender, SerialDataReceivedEventArgs e);
        internal delegate void SerialPinChangedEventHandlerDelegate(object sender, SerialPinChangedEventArgs e);
        private SerialPinChangedEventHandler SerialPinChangedEventHandler1;
        delegate void SetTextCallback(string text);
        string InputData = String.Empty;

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
            this.groups = this.library + "\\Groups";
            this.tracks = this.library + "\\Tracks";
            this.current_library = this.tracks;
            this.playing = false;
            this.pause = false;
            this.playlist_pos = 0;

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
            if (Directory.Exists(this.tracks) && Directory.Exists(this.groups))
            {
                Debug.WriteLine("Folder exists.");
                fsw_LibraryWatcher.Path = this.current_library;
            }
            else
            {
                Debug.WriteLine("Folder does not exist.");
                setUpLibrary();
            }
    
            updateLibrary();

            SerialPinChangedEventHandler1 = new SerialPinChangedEventHandler(PinChanged);
            ComPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_1);
            timer2.Start();

        }

        private void btn_AddSong_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Opening New Song Dialog...");
            AddSong frm_AddSong = new AddSong(this.current_library);
            frm_AddSong.Show();
        }

        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            lastInput = DateTime.Now;
        }

        internal void PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            SerialPinChange SerialPinChange1 = 0;
            bool signalState = false;

            SerialPinChange1 = e.EventType;
            switch (SerialPinChange1)
            {
                case SerialPinChange.Break:
                    
                    //MessageBox.Show("Break is Set");
                    break;
                case SerialPinChange.CDChanged:
                    signalState = ComPort.CDHolding;
                    //  MessageBox.Show("CD = " + signalState.ToString());
                    break;
                case SerialPinChange.CtsChanged:
                    signalState = ComPort.CtsHolding;
                    
                    //MessageBox.Show("CTS = " + signalState.ToString());
                    break;
                case SerialPinChange.DsrChanged:
                    signalState = ComPort.DsrHolding;
                    
                    // MessageBox.Show("DSR = " + signalState.ToString());
                    break;
                case SerialPinChange.Ring:
                    
                    //MessageBox.Show("Ring Detected");
                    break;
            }
        }

        private void updateLibrary()
        {
            flp_SongList.Controls.Clear();
            songs.Clear();
            Debug.WriteLine("Updating Library...");
            string[] directories = Directory.GetDirectories(this.current_library);
            foreach (string directory in directories)
            {
                string name = directory.Remove(0, this.current_library.Length + 1);
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
                Directory.CreateDirectory(this.tracks);
                Directory.CreateDirectory(this.groups);
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
            pdf_Lyrics.Height = this.Height - ms_MainMenu.Height - 46;
            pdf_Lyrics.Location = new Point(flp_SongList.Width + flp_SongList.Location.X + 10, pdf_Lyrics.Location.Y);
            foreach (KeyValuePair<string, Button> entry in songs)
            {
                entry.Value.Size = new Size((flp_SongList.Width - 25), 50);
            }

            foreach (Button song in playlist)
            {
                song.Size = new Size((flp_PlayList.Width - 25), 30);
            }

            btn_Play.Location = new Point(5, this.Height - btn_Play.Width - 5);
            btn_Prev.Location = new Point(btn_Play.Location.X + btn_Play.Width + 5, btn_Play.Location.Y);
            btn_Next.Location = new Point(btn_Prev.Location.X + btn_Prev.Width + 5, btn_Play.Location.Y);
            btn_Slower.Location = new Point(btn_Next.Location.X + btn_Next.Width + 5, btn_Play.Location.Y);
            btn_Faster.Location = new Point(btn_Slower.Location.X + btn_Slower.Width + 5, btn_Play.Location.Y);
            lb_Elapsed.Location = new Point(5, btn_Play.Location.Y - lb_Elapsed.Height - 5);
            lb_Time.Location = new Point(pdf_Lyrics.Location.X - 5 - lb_Time.Width, btn_Play.Location.Y - lb_Time.Height - 5);
            lb_Time.Height = lb_Elapsed.Height;
            sb_Duration.Height = lb_Elapsed.Height;
            sb_Duration.Location = new Point(lb_Elapsed.Location.X + lb_Elapsed.Width + 5, lb_Elapsed.Location.Y);
            sb_Duration.Width = lb_Time.Location.X - (lb_Elapsed.Location.X + lb_Elapsed.Width + 5) -5;
            flp_SongList.Height = ((lb_Time.Location.Y - btn_Alphabet.Location.Y - btn_Alphabet.Height - 15) / 3) * 2;
            flp_PlayList.Location = new Point(flp_PlayList.Location.X, flp_SongList.Location.Y + flp_SongList.Height + 5);
            flp_PlayList.Height = ((lb_Time.Location.Y - btn_Alphabet.Location.Y - btn_Alphabet.Height - 15) / 3);

           

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
            playlist_button.Size = new Size((flp_PlayList.Width - 25), 35);
            playlist_button.Font = new Font(FontFamily.GenericSansSerif, 16);
            playlist_button.Click += PlayListButton_Click;

            this.playlist.Add(playlist_button);
            flp_PlayList.Controls.Add(playlist_button);
            Debug.WriteLine("Added " + button.Text);
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            play();
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
            Debug.WriteLine("Playing Completed!");
            sequencer1.Stop();
            sequence1.Clear();
            timer1.Stop();
            
            this.Invoke((MethodInvoker)delegate
            {
                this.playlist_pos++;
                this.playing = false;
                this.pause = false;
                play();
                
            });
            
        }

        private void play()
        {
                           
                string pdfFilePath;
                string midiFilePath;
                Button song;
                song = playlist[this.playlist_pos];
                pdfFilePath = Path.Combine(this.current_library + "\\" + song.Text + "\\", song.Text + ".pdf");
                midiFilePath = Path.Combine(this.current_library + "\\" + song.Text + "\\", song.Text + ".mid");
                Debug.WriteLine("Playing: " + song.Text);
                Debug.WriteLine("MidiFile: " + midiFilePath);
                Debug.WriteLine("PDFFile: " + pdfFilePath);
                playlist[this.playlist_pos].BackColor = Color.Green;

                this.Invoke((MethodInvoker)delegate
                {
                    if (File.Exists(pdfFilePath))
                        pdf_Lyrics.src = pdfFilePath;

                    else
                        pdf_Lyrics.src = "";
                });

                sequencer1.Stop();
                sequence1.Load(Path.Combine(this.current_library + "\\" + song.Text + "\\", song.Text + ".mid"));

        }

        private void timer1_Stopped(object sender, EventArgs e)
        {
            
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {

        }

        private void btn_Slower_Click(object sender, EventArgs e)
        {
            tempo += 50000;
            sequencer1.changeTempo(tempo);
        }
        private void btn_Faster_Click(object sender, EventArgs e)
        {
            tempo -= 50000;
            sequencer1.changeTempo(tempo);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (lastInput > (DateTime.Now.AddMilliseconds(-500)))
            {
                if(!this.playing)
                {
                    sequencer1.Continue();
                    timer1.Start();
                    this.playing = true;
                    btn_Play.Image = new Bitmap(MidiPlayer.Properties.Resources.button_pause_small);
                }
            }
            else
            {
                this.playing = false;
                sequencer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComPort.PortName = "COM3";
            ComPort.BaudRate = 300;
            ComPort.DataBits = 7;
            ComPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
            ComPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), "None");
            ComPort.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
            ComPort.Open();

            SerialPinChangedEventHandler1 = new SerialPinChangedEventHandler(PinChanged);
            ComPort.PinChanged += SerialPinChangedEventHandler1;
            ComPort.RtsEnable = true;
            ComPort.DtrEnable = true;
        }

    }
}
