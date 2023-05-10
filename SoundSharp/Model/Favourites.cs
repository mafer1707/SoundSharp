using SoundSharp.Model.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundSharp.Model
{
    public class Favourites
    {
        private List<Song> _listOfSongs;
        private AddingSongs _addinToN = new AddingSongs();
        private RemovingSongs _removingToN = new RemovingSongs();
        private NextSong _nextSong = new NextSong();
        private PreviousSong _previousSong = new PreviousSong();
        private LoopSong _loopSong = new LoopSong();
        private ShuffleSong _shuffleSong = new ShuffleSong();   

        public Favourites() { } //Creo el favourites
        
        public void addToFavorite() 
        { 
            _addinToN.addToFavourite();
        }
        public void removeToFavorites() 
        { 
            _removingToN.removeToFavourites();
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
    }
}
