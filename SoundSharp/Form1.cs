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

namespace SoundSharp
{
    public partial class MainWindow : Form
    {
        int contPlay;
        int contShuffle;
        int contLoop;
        bool menuExpand;
        private Form activeForm = null;
        PlaylistDisplay playlistDisplay = new PlaylistDisplay();
        public MainWindow()
        {
            InitializeComponent();
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
                    btnPause.Image = SoundSharp.Properties.Resources.play;
                    contPlay++;
                    break;
                case 2:
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
                    contShuffle++;
                    break;
                case 2:
                    btnShuffle.Image = SoundSharp.Properties.Resources.shuffle;
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
                    contLoop++;
                    break;
                case 2:
                    btnLoop.Image = SoundSharp.Properties.Resources.repetir;
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
            OpenChildForm(new Playlist());
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
    }
}
