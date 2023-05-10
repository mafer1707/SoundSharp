using SoundSharp.Model.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundSharp.Model
{
    public class Album
    {
        private List<Song> _listOfSongs;
        private string _name;
        private string _genre;
        private NextSong _nextSong = new NextSong(); 
        private PreviousSong _previousSong = new PreviousSong();    
        private LoopSong _loopSong = new LoopSong();
        private ShuffleSong _shuffleSong = new ShuffleSong();

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
    }
}
