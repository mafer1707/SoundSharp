using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundSharp.Models
{
    public class Playlist
    {
        private string _name;
        private List<Song> _songs;

        //Creo mi nueva playlist.
        public Playlist(string name)
        {
            _name = name;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public List<Song> Songs { get { return _songs; } }
        ~Playlist() { } //Elimino mi playlist
    }
}
