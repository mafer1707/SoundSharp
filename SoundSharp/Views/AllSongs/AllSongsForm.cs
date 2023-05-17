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
using WMPLib;

namespace SoundSharp.Views.AllSongs
{
    public partial class AllSongsForm : Form
    {
        private WindowsMediaPlayer _player;
        private List<IWMPMedia> _songs;
        private EverySong _allSongs;
        private bool _play;
        private double _position;
        private IWMPMedia _songToEliminate;
        private int _indexOfSongToEliminate;

        public AllSongsForm()
        {
            _player = new WindowsMediaPlayer();
            _songs = new List<IWMPMedia>();
            _play = true;
            _position = 0;
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeOpenFileDialog();
        }

        private void InitializeOpenFileDialog()
        {
            this.openFileDialogSongs.Filter =
                "Songs (*.mp3;*.flac;*.wma;*.wav;*.wave;*.m4a)|*.mp3;*.flac;*.wma;*.wav;*.wave;*.m4a|" +
                "All files (*.*)|*.*";
            this.openFileDialogSongs.Multiselect = true;
            this.openFileDialogSongs.Title = "My songs";
        }

         //Acá ira lo que brian haga
        private void buttonImport_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialogSongs.ShowDialog();
            if (dr == DialogResult.OK)
            {
                foreach (String song in openFileDialogSongs.FileNames)
                {
                    _songs.Add(_player.newMedia(song));
                }
            }
            renderized();
            initializePlaylist();
            _player.controls.stop();
        }

        private void buttonPausePlay_Click(object sender, EventArgs e)
        {
            playablePausable();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            _player.controls.next();
            if (_play == true)
            {
                _position = 0;
                _player.controls.playItem(_player.currentMedia);
                _play = !_play;
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            _player.controls.previous();
            if (_play == true)
            {
                _position = 0;
                _player.controls.playItem(_player.currentMedia);
                _play = !_play;
            }
        }

        private void renderized()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < _songs.Count; i++)
            {
                //Agregar Duration a song. 
                //dataGridView1.Rows.Add("Play/Pause", _songs[i].Name, formattedTime(_songs[i].Duration));
            }
        }

        private string formattedTime(TimeSpan time)
        {
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
                if (!_player.currentMedia.isIdentical[_songs[e.RowIndex]])
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
            _allSongs = new EverySong(_songs, "PlaylistOne");
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
                _songToEliminate = _songs[e.RowIndex];
                _indexOfSongToEliminate = e.RowIndex;
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EverySong.removeSong(_allSongs, _songToEliminate);
            _songs.Remove(_songs[_indexOfSongToEliminate]);
            renderized();
        }
    }
}
