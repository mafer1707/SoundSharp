using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoundSharp.Consts;
using WMPLib;

namespace SoundSharp.Models
{
    public class Album
    {
        private List<Song> _songs;
        private string _author;
        private string _name;
        private string _genre;
        private string _route;
        private WMPLib.WindowsMediaPlayer _aux;
        private WMPLib.IWMPPlaylist _currentAlbum;
        public Album(string route)
        {
            FileInfo[] songs;
            DirectoryInfo dir;
            _route = route;
            _aux = new WMPLib.WindowsMediaPlayer();
            _currentAlbum = _aux.playlistCollection.newPlaylist(_route);
            dir = new DirectoryInfo(_route);
            songs = dir.GetFiles();

            foreach (FileInfo song in songs)
            {
                WMPLib.IWMPMedia media;
                media = _aux.newMedia(song.FullName);
                _currentAlbum.appendItem(media);
            }
        }

        public List<Song> Songs { get { return _songs; } }
        public string Author { get { return _author; } set { _author = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Genre { get { return _genre; } set { _genre = value; } }

        public WMPLib.IWMPPlaylist CurrentAlbum { get { return _currentAlbum; } }
    }
}
