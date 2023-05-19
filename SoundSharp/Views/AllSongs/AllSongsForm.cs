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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SoundSharp.Views.AllSongs
{
    public partial class AllSongsForm : Form
    {
        private WindowsMediaPlayer _player;
        private List<Song> _songs;
        private List<IWMPMedia> _songsToPlay;
        private bool _play;
        private double _position;
        private PictureBox _pictureBox;
        private MainWindow mainWindow;
        //Considerar eliminar los atributos de abajo.
        private IWMPMedia _songToEliminate;
        private int _indexOfSongToEliminate;
        private string Artist;

        public AllSongsForm(WindowsMediaPlayer player, List<IWMPMedia> songs, MainWindow main)
        {
            _player = player;
            _songs = Song.GetSongs();
            _songsToPlay = songs;
            _play = true;
            mainWindow = main;
            _position = 0;
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
                dataGridView1.Rows.Add(SoundSharp.Properties.Resources.pausaDataGrid, _songs[i].Name, formattedTime(_songs[i].Duration));
            }
        }

        public void renderized(int index)
        {
            try
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < _songs.Count; i++)
                {
                    if (i == index)
                    {
                        continue;
                    }
                    dataGridView1.Rows.Add(SoundSharp.Properties.Resources.pausaDataGrid, _songs[i].Name, formattedTime(_songs[i].Duration));
                }
            }
            catch (Exception) { }
            
        }

        public void renderizedPlay(int index)
        {
            dataGridView1.Rows.Insert(index,
                SoundSharp.Properties.Resources.pausaDataGrid, _songs[index].Name, formattedTime(_songs[index].Duration));
        }

        public void renderizedPause(int index)
        {
            try
            {
                dataGridView1.Rows.Insert(index,
                    SoundSharp.Properties.Resources.playDataGrid, _songs[index].Name, formattedTime(_songs[index].Duration));
            }
            catch (Exception) { }
           
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
            try
            {
                if (e.ColumnIndex == dataGridView1.Columns["ColumnPlayPause"].Index
                && e.RowIndex >= 0)
                {
                    List<Song> songs = Song.GetSongs();
                    List<Song> filteredSongs = songs.Skip(e.RowIndex).Concat(songs.Take(e.RowIndex)).ToList();
                    mainWindow.SetSongs(filteredSongs);

                    bool isPlaying = mainWindow.Player.playState == WMPPlayState.wmppsPlaying;
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    renderized(e.RowIndex);
                    if (isPlaying)
                    {
                        renderizedPlay(e.RowIndex);
                        changePlayPause(false);
                    }
                    else
                    {
                        renderizedPause(e.RowIndex);
                        changePlayPause(true);
                    }

                }
            }
            catch (Exception) { }
            
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
        public void changePlayPause(bool option)
        {
            if (option)
            {
                _pictureBox.Image = SoundSharp.Properties.Resources.play;
            }
            else
            {
                _pictureBox.Image = SoundSharp.Properties.Resources.pausa;
            }
        }

        public void setPictureBox(ref PictureBox pictureBox)
        {
            _pictureBox = pictureBox;
        }
    }
}
