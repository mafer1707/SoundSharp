using SoundSharp.Models;
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
using WMPLib;
using TagLib;

namespace SoundSharp.Views.AllSongs
{
    public partial class AllSongsForm : Form
    {
        private WindowsMediaPlayer _player;
        private List<Song> _songs;
        private List<IWMPMedia> _songsToPlay;
        private EverySong _allSongs;
        private bool _play;
        private double _position;
        private IWMPMedia _songToEliminate;
        private int _indexOfSongToEliminate;

        /*public AllSongsForm(List<string> paths)
        {
            _player = new WindowsMediaPlayer();
            _songs = new List<IWMPMedia>();
            _play = true;
            _position = 0;
            foreach (string path in paths)
            {
                _songs.Add(_player.newMedia(path));
            }
            InitializeComponent();
        }*/

        public AllSongsForm()
        {
            _player = new WindowsMediaPlayer();
            _songs = Song.GetSongs();
            _songsToPlay = new List<IWMPMedia>();
            _play = true;
            _position = 0;
            //foreach (Song song in _songs)
            //{
            //    string routeOfSong = song.Route.Replace("/", "\\");
            //    IWMPMedia songToAdd = _player.newMedia(routeOfSong);
            //    _songsToPlay.Add(songToAdd);
            //}
            InitializeComponent();
            renderized();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //InitializeOpenFileDialog();
        }

        private void renderized()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < _songs.Count; i++)
            {
                dataGridView1.Rows.Add(SoundSharp.Properties.Resources.playDataGrid, _songs[i].Name, formattedTime(_songs[i]));
            }
        }

        private string formattedTime (Song song)
        {
            TagLib.File file = TagLib.File.Create(song.Route);
            TimeSpan time = file.Properties.Duration;
            string minutes = time.Minutes < 10 ? "0" + time.Minutes : time.Minutes.ToString();
            string seconds = time.Seconds < 10 ? "0" + time.Seconds : time.Seconds.ToString();
            string timeFormatted = minutes + ":" + seconds;
            return timeFormatted;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["ColumnPlayPause"].Index
                && e.RowIndex >= 0)
            {
                if (!_player.currentMedia.isIdentical[_songsToPlay[e.RowIndex]])
                {
                    _player.controls.currentItem = _allSongs.CurrentPlaylist.Item[e.RowIndex];
                    _position = 0;
                    _play = true;
                }
                playablePausable();
            }
        }

        private void initializePlaylist()
        {
            _allSongs = new EverySong(_songsToPlay, "PlaylistOne");
            _player.currentPlaylist = _allSongs.CurrentPlaylist;
        }

        //Esto simula el play, pause y demás botones del principal.
        private void playablePausable()
        {
            if (_play)
            {
                play();
            }
            else
            {
                pause();
            }
            _play = !_play;
        }

        private void play()
        {
            _player.controls.currentPosition = _position;
            _player.controls.play();
        }

        private void pause()
        {
            _player.controls.pause();
            _position = _player.controls.currentPosition;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["ColumnSong"].Index
                && e.RowIndex >= 0
                && e.Button == MouseButtons.Right)
            {
                contextMenuStripSongs.Show(MousePosition.X, MousePosition.Y);
                _songToEliminate = _songsToPlay[e.RowIndex];
                _indexOfSongToEliminate = e.RowIndex;
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EverySong.removeSong(_allSongs, _songToEliminate);
            _songs.Remove(_songs[_indexOfSongToEliminate]);
            renderized();
        }

        public IWMPPlaylist getAllSongs()
        {
            return _allSongs.CurrentPlaylist;
        }
    }
}
