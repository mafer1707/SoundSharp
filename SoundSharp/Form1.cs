using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SoundSharp.Models;
using System.Drawing.Drawing2D;
using SoundSharp.Views;
using SoundSharp.Views.AllSongs;
using WMPLib;

namespace SoundSharp
{
    public partial class MainWindow : Form
    {
        private int contPlay;
        private int contShuffle;
        private int contLoop;
        private int contVolume;
        private int volumenActual;
        private Button currentButton;
        private double position = 0;
        private WMPLib.WindowsMediaPlayer player;
        private List<IWMPMedia> SongsForAllSongs;
        private AllSongsForm allSongs;
        bool menuExpand = true;
        private Form activeForm = null;

        //private Song randomSong = new Song(@"C:\Users\Yasmin\Documents\FERNANDA\Bad Bunny - Efecto (360Â° Visualizer) _ Un Verano Sin Ti(MP3_128K).mp3");
        //private Album[] randomAlbum = { new Album(@"C:\Users\58412\Desktop\SSHRP3\SoundSharp\SoundSharp\Database\Albums\1970 - Ladies Of The Canyon"),
        //    new Album(@"C:\Users\58412\Downloads\Jeff Buckley - Grace (2022) [FLAC 24-192]"),
        //    new Album(@"C:\Users\58412\Downloads\Mistki - Puberty 2 (2016)(FLAC)(CD)"),
        //    new Album(@"C:\Users\58412\Downloads\IC3PEAK-До_Свидания-WEB-2020")};

        public MainWindow()
        {
            player = new WMPLib.WindowsMediaPlayer();
            List<Song> songs = Song.GetSongs();
            SongsForAllSongs = new List<IWMPMedia>();
            SetSongs(songs, false);
            //player.currentMedia = randomSong.CurrentSong;
            //player.currentPlaylist = randomAlbum[0].CurrentAlbum;
            InitializeComponent();
            player.controls.stop();
            contPlay = 1;
            contShuffle = 1;
            contLoop = 1;
            contVolume = 1;
            slider.Height = 23;
            trackBar1.Value = 30;
            lblVolume.Text = trackBar1.Value.ToString() + "%";
            List<Playlist> playlists = Playlist.GetPlaylists();
        }

        public void SetSongs(List<Song> songs, bool automatedPlay = true)
        {
            bool isShuffleMode = player.settings.getMode("shuffle");
            player.settings.setMode("shuffle", false);
            WMPLib.IWMPPlaylist Playlist = player.newPlaylist("MyPlayList", "");
            foreach (Song song in songs)
            {
                IWMPMedia songToAdd = player.newMedia(song.Route);
                Playlist.appendItem(songToAdd);
                SongsForAllSongs.Add(songToAdd);
            }
            player.currentPlaylist = Playlist;
            if (automatedPlay) Play();
            if (isShuffleMode) player.settings.setMode("shuffle", true);
        }

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(childForm);
            PanelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void pbMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
            slider.Refresh();
        }

        private void pbPause_Click(object sender, EventArgs e)
        {

            try
            {
                switch (contPlay)
                {
                    case 1:
                        Play();
                        break;
                    case 2:
                        player.controls.pause();
                        position = player.controls.currentPosition;
                        btnPause.Image = SoundSharp.Properties.Resources.pausa;
                        contPlay = 1;
                        renderizedForAllSongs2();
                        break;
                }
            }
            catch (Exception)
            {

            }

        }

        public void Play()
        {
            player.controls.currentPosition = position;
            player.controls.play();
            btnPause.Image = Properties.Resources.play;
            contPlay = 2;
            renderizedForAllSongs();
        }

        private void pbShuffle_Click(object sender, EventArgs e)
        {
            switch (contShuffle)
            {
                case 1:
                    btnShuffle.Image = SoundSharp.Properties.Resources.shuffleRosado;
                    player.settings.setMode("autoRewind", false);
                    player.settings.setMode("shuffle", true);
                    contShuffle++;
                    break;
                case 2:
                    btnShuffle.Image = SoundSharp.Properties.Resources.shuffle;
                    player.settings.setMode("autoRewind", true);
                    player.settings.setMode("shuffle", false);
                    contShuffle = 1;
                    break;
            }
        }

        private void pbLoop_Click(object sender, EventArgs e)
        {
            switch (contLoop)
            {
                case 1:
                    btnLoop.Image = SoundSharp.Properties.Resources.repetirRosado;
                    player.settings.setMode("autoRewind", false);
                    player.settings.setMode("loop", true);
                    contLoop++;
                    break;
                case 2:
                    btnLoop.Image = SoundSharp.Properties.Resources.repetir;
                    player.settings.setMode("autoRewind", true);
                    player.settings.setMode("loop", false);
                    contLoop = 1;
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel);

            if (confirmar == DialogResult.OK)
                this.Close();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, SoundSharp.Properties.Resources.playlistNegra);
            OpenChildForm(new PlaylistView(this));

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog Explorer = new OpenFileDialog();
            Explorer.Multiselect = true;
            Explorer.Filter = "Songs(*.mp3; *.flac; *.wma; *.wav; *.wave; *.m4a)| *.mp3; *.flac; *.wma; *.wav; *.wave; *.m4a";
            if (Explorer.ShowDialog() == DialogResult.OK)
            {
                List<string> paths = Explorer.FileNames.ToList();
                foreach (string path in paths)
                {
                    new AddSongs(path).ShowDialog();
                }
            }
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                MenuVertical.Width -= 10;
                slider.Refresh();
                if (MenuVertical.Width <= 62)
                {
                    menuExpand = false;
                    timerMenu.Stop();
                }

            }
            else
            {
                MenuVertical.Width += 10;
                slider.Refresh();
                if (MenuVertical.Width >= 190)
                {
                    menuExpand = true;
                    timerMenu.Stop();
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            player.controls.next();
            if (contPlay == 1)
            {
                position = 0;
                player.controls.playItem(player.currentMedia);
                contPlay++;
            }
            renderizedForAllSongs();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            player.controls.previous();
            if (contPlay == 1)
            {
                position = 0;
                player.controls.playItem(player.currentMedia);
                contPlay++;
            }
            renderizedForAllSongs();
        }

        // ---------- Barra de reproducción ---------

        float Default_value = 0.1f, Min = 0.0f, Max = 1.0f;
        bool mouse = false;
        private float Bar(float value)
        {
            return (slider.Width - 24) * (value - Min) / (float)(Max - Min);
        }
        private void Thumb(float value)
        {
            if (value < Min) value = Min;
            if (value > Max) value = Max;
            Default_value = value;
            slider.Refresh();
        }
        private float slider_width(int x)
        {
            return Min + (Max - Min) * x / (float)(slider.Width);
        }
        private void slider_Paint(object sender, PaintEventArgs e)
        {
            float bar_size = 0.45f;
            float x = Bar(Default_value);
            int y = (int)(slider.Height * bar_size);

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.FillRectangle(Brushes.DimGray, 0, y, slider.Width - 4, y / 2);
            e.Graphics.FillRectangle(Brushes.White, 0, y, x, slider.Height - 2 * y);

            using (Pen pen = new Pen(Color.White, 8))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 4, slider.Height / 2, slider.Height / 2);
                e.Graphics.FillEllipse(Brushes.White, x + 4, y - 4, slider.Height / 2, slider.Height / 2);
            }
        }
        private void slider_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (!mouse) return;
                Thumb(slider_width(e.X));
                player.controls.currentPosition = player.currentMedia.duration * e.X / slider.Width;
            }
            catch (Exception)
            {

            }
        }

        private void slider_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void slider_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                mouse = true;
                Thumb(slider_width(e.X));
                player.controls.currentPosition = player.currentMedia.duration * e.X / slider.Width;
            }
            catch (Exception)
            {

            }

        }

        private void timerSlider_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                Max = (int)player.controls.currentItem.duration;
                Default_value = (int)player.controls.currentPosition;
                slider.Invalidate();

                lblTimerInicial.Text = player.controls.currentPositionString;
                lblTimerFinal.Text = player.controls.currentItem.durationString;
            }
        }

        // ---------------- Control de volumen ------------
        private void btnVolume_Click(object sender, EventArgs e)
        {
            switch (contVolume)
            {
                case 1:
                    trackBar1.Value = 0;
                    player.settings.volume = trackBar1.Value;
                    lblVolume.Text = trackBar1.Value.ToString() + "%";
                    btnVolume.Image = SoundSharp.Properties.Resources.mute_img;
                    contVolume++;
                    break;
                case 2:
                    trackBar1.Value = volumenActual;
                    player.settings.volume = trackBar1.Value;
                    lblVolume.Text = trackBar1.Value.ToString() + "%";
                    if (volumenActual > 0 && volumenActual < 50)
                        btnVolume.Image = SoundSharp.Properties.Resources.mid_img;
                    else
                        btnVolume.Image = SoundSharp.Properties.Resources.high_img;
                    contVolume = 1;
                    break;
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value != 0) volumenActual = trackBar1.Value;
            else volumenActual = 30;

            player.settings.volume = trackBar1.Value;
            lblVolume.Text = trackBar1.Value.ToString() + "%";
            if (trackBar1.Value == 0)
                btnVolume.Image = SoundSharp.Properties.Resources.mute_img;
            else if (volumenActual > 0 && volumenActual < 50)
                btnVolume.Image = SoundSharp.Properties.Resources.mid_img;
            else
                btnVolume.Image = SoundSharp.Properties.Resources.high_img;

            contVolume = 1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            allSongs = new AllSongsForm(player, SongsForAllSongs);
            allSongs.setPictureBox(ref btnPause);
            ActiveButton(sender, SoundSharp.Properties.Resources.lupaNegra);
            OpenChildForm(allSongs);
        }

        private void ActiveButton(object senderBtn, Image imagen)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentButton = (Button)senderBtn;
                currentButton.BackColor = Color.FromArgb(239, 7, 90);
                currentButton.ForeColor = Color.Black;
                currentButton.Image = imagen;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                if (currentButton.Text == "Buscar")
                    currentButton.Image = SoundSharp.Properties.Resources.lupa;
                else
                    currentButton.Image = SoundSharp.Properties.Resources.playlist1;
                currentButton.BackColor = Color.FromArgb(11, 7, 17);
                currentButton.ForeColor = Color.FromArgb(239, 7, 90);
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                slider.Refresh();
        }

        private void renderizedForAllSongs()
        {
            if (allSongs != null)
            {
                int index = 0;
                int cont = 0;
                foreach (IWMPMedia song in SongsForAllSongs)
                {
                    if (player.currentMedia.isIdentical[song])
                    {
                        index = cont;
                        break;
                    }
                    cont++;
                }

                allSongs.renderized(index);
                allSongs.renderizedPause(index);
            }
        }

        private void renderizedForAllSongs2()
        {
            if (allSongs != null)
            {
                int index = 0;
                int cont = 0;
                foreach (IWMPMedia song in SongsForAllSongs)
                {
                    if (player.currentMedia.isIdentical[song])
                    {
                        index = cont;
                        break;
                    }
                    cont++;
                }

                allSongs.renderized(index);
                allSongs.renderizedPlay(index);
            }
        }

        //public PictureBox BtnPause { get { return btnPause; } set { btnPause = value; } }
    }
}
