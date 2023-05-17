using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace SoundSharp.Models
{
    public class EverySong
    {
        private List<IWMPMedia> _songs;
        private WindowsMediaPlayer _aux;
        private WMPLib.IWMPPlaylist _currentPlaylist;

        public EverySong(List<IWMPMedia> songs, string playlistName)
        {
            _songs = songs;
            _aux = new WindowsMediaPlayer();
            _currentPlaylist = _aux.playlistCollection.newPlaylist(playlistName);
            foreach (IWMPMedia song in _songs)
            {
                _currentPlaylist.appendItem(song);
            }
        }

        public static void removeSong(EverySong playlist, IWMPMedia song)
        {
            playlist.CurrentPlaylist.removeItem(song);
        }

        public IWMPPlaylist CurrentPlaylist { get { return _currentPlaylist; } }
    }
}