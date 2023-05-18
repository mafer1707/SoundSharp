using Newtonsoft.Json;
using SoundSharp.Consts;
using SoundSharp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SoundSharp.Views
{
    public partial class Formpru : Form
    {
        Playlist playlist;
        private MainWindow miVentana;

        public Formpru(int id, MainWindow main)
        {
            InitializeComponent();
            playlist = Playlist.GetPlaylistById(id + 1);
            miVentana = main;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            miVentana.OpenChildForm(new PlaylistView(miVentana));
        }
        private void Formpru_Load(object sender, EventArgs e)
        {
            ReloadDg();
            lblTitle.Text = playlist.Name;
        }
        public void PlaySongs(List<Song> songs) 
        {
            miVentana.SetSongs(songs);
        }
        private void dgvPlaylist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            try
            {
                i = dgvPlaylist.CurrentCell.RowIndex;
            }
            catch (NullReferenceException)
            {
                i = -1;
            }
            if (e.ColumnIndex == dgvPlaylist.Columns["dgvDelete"].Index && i != -1 && e.RowIndex != -1)
            {

                DialogResult confirmar = MessageBox.Show("¿Está seguro que desea Eliminar?", "Eliminar", MessageBoxButtons.OKCancel);
                if (confirmar == DialogResult.OK)
                {
                    int id = Convert.ToInt32(dgvPlaylist.Rows[e.RowIndex].Cells[0].Value) -1;
                    playlist.RemoveSong(id);
                }
                dgvPlaylist.Rows.Clear();
                ReloadDg();
            }
        }
        private void dgvPlaylist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Song> playlistSongs = playlist.Songs;
            List<Song> songs = playlistSongs.Skip(e.RowIndex).Concat(playlistSongs.Take(e.RowIndex)).ToList();
            PlaySongs(songs); 
        }
        public void ReloadDg()
        {
            dgvPlaylist.Rows.Clear();
            try
            {
                List<Song> playlistSongs = playlist.Songs;
                for (int i = 0;i < playlistSongs.Count;i++)
                {
                    Song item = playlistSongs[i];
                    dgvPlaylist.Rows.Add(i+1, item.Name, item.Author, " ");
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
