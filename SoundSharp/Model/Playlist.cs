using SoundSharp.Model.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundSharp.Model
{
    public class Playlist
    {
        private List<Song> _listOfSongs;
        private string _name;
        private AddingSongs _addinToN = new AddingSongs();
        private RemovingSongs _removingToN = new RemovingSongs();
        private NextSong _nextSong = new NextSong();
        private PreviousSong _previousSong = new PreviousSong();
        private LoopSong _loopSong = new LoopSong();
        private ShuffleSong _shuffleSong = new ShuffleSong();

        //Creo mi nueva playlist.
        public Playlist(string name) 
        { 
            _name = name;
        }

        public void addToPlaylist() 
        {
            _addinToN.addToPlaylist();
        }
        public void removeFromPlaylist() 
        {
            _removingToN.removeFromPlaylist();
        }
        public void nextSong() 
        {
            _nextSong.next();
        }
        public void previousSong() 
        {
            _previousSong.Previous();
        }
        public void loopMode() 
        {
            _loopSong.loop();
        }
        public void shuffleMode() 
        {
            _shuffleSong.shuffle();
        }

        public string Name { get { return _name; }  set { _name = value; } }
        ~Playlist() { } //Elimino mi playlist
    }
}
