using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoundSharp.Models;
using System.Drawing.Drawing2D;

namespace SoundSharp
{
    public partial class MainWindow : Form
    {
        private int contPlay;
        private int contShuffle;
        private int contLoop;
        private int contVolume;
        private int volumenActual;
        private double position = 0;
        private WMPLib.WindowsMediaPlayer player;
        bool menuExpand;
        private Form activeForm = null;
        PlaylistDisplay playlistDisplay = new PlaylistDisplay();
        private Song randomSong = new Song(@"C:\Users\Yasmin\Documents\FERNANDA\Bad Bunny - Efecto (360Â° Visualizer) _ Un Verano Sin Ti(MP3_128K).mp3");
        //private Album[] randomAlbum = { new Album(@"C:\Users\58412\Desktop\SSHRP3\SoundSharp\SoundSharp\Database\Albums\1970 - Ladies Of The Canyon"),
        //    new Album(@"C:\Users\58412\Downloads\Jeff Buckley - Grace (2022) [FLAC 24-192]"),
        //    new Album(@"C:\Users\58412\Downloads\Mistki - Puberty 2 (2016)(FLAC)(CD)"),
        //    new Album(@"C:\Users\58412\Downloads\IC3PEAK-До_Свидания-WEB-2020")};

        public MainWindow()
        {
            player = new WMPLib.WindowsMediaPlayer();
            player.currentMedia = randomSong.CurrentSong;
            //player.currentPlaylist = randomAlbum[3].CurrentAlbum;
            InitializeComponent();
            player.controls.stop();
            contPlay = 1;
            contShuffle = 1;
            contLoop = 1;
            contVolume = 1;
            trackBar1.Value = 30;
            lblVolume.Text = trackBar1.Value.ToString() + "%";
        }

        private void OpenChildForm(Form childForm)
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
            if (MenuVertical.Width == 190)
                MenuVertical.Width = 59;

            else
                MenuVertical.Width = 190;
        }

        private void pbPause_Click(object sender, EventArgs e)
        {
            switch (contPlay)
            {
                case 1:
                    player.controls.currentPosition = position;
                    player.controls.play();
                    btnPause.Image = SoundSharp.Properties.Resources.play;
                    contPlay++;
                    break;
                case 2:
                    player.controls.pause();
                    position = player.controls.currentPosition;
                    btnPause.Image = SoundSharp.Properties.Resources.pausa;
                    contPlay = 1;
                    break;
            }
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
            OpenChildForm(new PlaylistView());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            playlistDisplay.Show();
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                MenuVertical.Width -= 10;
                if (MenuVertical.Width == MenuVertical.MinimumSize.Width)
                {
                    menuExpand = false;
                    timerMenu.Stop();
                }

            }
            else
            {
                MenuVertical.Width += 10;
                if (MenuVertical.Width == MenuVertical.MaximumSize.Width)
                {
                    menuExpand = true;
                    timerMenu.Stop();
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            player.controls.next();
            position = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            player.controls.previous();
            position = 0;
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
            e.Graphics.FillRectangle(Brushes.DimGray, 0, y, slider.Width, y / 2);
            e.Graphics.FillRectangle(Brushes.White, 0, y, x, slider.Height - 2 * y);

            using (Pen pen = new Pen(Color.White, 8))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 4, slider.Height / 2, slider.Height / 2);
                e.Graphics.FillEllipse(Brushes.White, x + 4, y - 4, slider.Height / 2, slider.Height / 2);
            }
        }

        private void slider_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouse) return;
            Thumb(slider_width(e.X));
            player.controls.currentPosition = player.currentMedia.duration * e.X / slider.Width;
        }  

        private void slider_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }


        private void slider_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            Thumb(slider_width(e.X));
            player.controls.currentPosition = player.currentMedia.duration * e.X / slider.Width;
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


    }
}
