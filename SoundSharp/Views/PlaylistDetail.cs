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
    public partial class PlaylistDetail : Form
    {
        Playlist playlist;
        private MainWindow miVentana;

        public PlaylistDetail(int id, MainWindow main)
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
            TimeSpan timeSpan = new TimeSpan();
            foreach (Song song in playlist.Songs)
            {
                timeSpan += song.Duration;
            }
            lblTime.Text = formattedTime(timeSpan);
        }
        public void PlaySongs(List<Song> songs) 
        {
            miVentana.SetSongs(songs);
            miVentana.renderizedForAllSongs();
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
                    dgvPlaylist.Rows.Add(i+1, item.Name, item.Author, formattedTime(item.Duration));
                }
            }
            catch (Exception)
            {
            }
        }
        private string formattedTime(TimeSpan time)
        {
            string minutes = time.Minutes < 10 ? "0" + time.Minutes : time.Minutes.ToString();
            string seconds = time.Seconds < 10 ? "0" + time.Seconds : time.Seconds.ToString();
            string timeFormatted = minutes + ":" + seconds;
            return timeFormatted;
        }
    }
}
