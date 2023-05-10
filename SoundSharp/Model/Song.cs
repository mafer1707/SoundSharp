using SoundSharp.Model.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundSharp.Model
{
    public class Song
    {
        //Colocar source de las canciones.
        private string _interpreter;
        private string _name;  
        private PlaySong _playSong = new PlaySong();
        private StopSong _stopSong = new StopSong();
        private PauseSong _pauseSong = new PauseSong();
        private AddingSongs _addinToN = new AddingSongs();
        private RemovingSongs _removingToN = new RemovingSongs();
        public void play() 
        {
            _playSong.Play();
        }
        public void pause() 
        { 
            _pauseSong.Pause();
        }

        //Dejo
        public void stop() 
        { 
            _stopSong.Stop();
        }
        public void addToPlaylist() 
        { 
            _addinToN.addToPlaylist();
        }
        public void addToFavourite() 
        { 
            _addinToN.addToFavourite();
        }
        public void removeToFavourites() 
        { 
            _removingToN.removeToFavourites();
        }
    }
}
