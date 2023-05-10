using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundSharp.Models
{
    public class Album
    {
        private List<Song> _songs;
        private string _author;
        private string _name;
        private string _genre;

        public List<Song> Songs { get { return _songs; } }
        public string Author { get { return _author; } set { _author = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Genre { get { return _genre; } set { _genre = value; } }
    }
}
