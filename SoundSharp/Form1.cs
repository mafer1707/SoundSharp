﻿using System;
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

namespace SoundSharp
{
    public partial class MainWindow : Form
    {
        private int contPlay;
        private int contShuffle;
        private int contLoop;
        int contFavorite;
        private double position = 0;
        private WMPLib.WindowsMediaPlayer player;
        bool menuExpand;
        private Form activeForm = null;
        PlaylistDisplay playlistDisplay = new PlaylistDisplay();
        //private Song randomSong = new Song(@"C:\Users\58412\Downloads\Joni Mitchell - Full Discography\1970 - Ladies Of The Canyon\10 - Big Yellow Taxi.mp3");
        //private Album[] randomAlbum = { new Album(@"C:\Users\58412\Desktop\SSHRP3\SoundSharp\SoundSharp\Database\Albums\1970 - Ladies Of The Canyon"),
        //    new Album(@"C:\Users\58412\Downloads\Jeff Buckley - Grace (2022) [FLAC 24-192]"),
        //    new Album(@"C:\Users\58412\Downloads\Mistki - Puberty 2 (2016)(FLAC)(CD)"),
        //    new Album(@"C:\Users\58412\Downloads\IC3PEAK-До_Свидания-WEB-2020")};

        public MainWindow()
        {
            player = new WMPLib.WindowsMediaPlayer();
            //player.currentMedia = randomSong.CurrentSong;
            //player.currentPlaylist = randomAlbum[3].CurrentAlbum;
            InitializeComponent();
            player.controls.stop();
            contPlay = 1;
            contShuffle = 1;
            contLoop = 1;
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
            timerMenu.Start();
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
    }
}
