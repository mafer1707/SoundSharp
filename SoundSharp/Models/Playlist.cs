using Newtonsoft.Json;
using SoundSharp.Consts;
using SoundSharp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SoundSharp.Models
{
    public class Playlist
    {
        private int _id;
        private string _name;
        private string _date;
        private List<Song> _songs;
        private static DbHandler<Playlist> dbHandler = new DbHandler<Playlist>(FileNames.Playlist, FileNames.PlaylistId);

        //Creo mi nueva playlist.
        [JsonConstructor]
        public Playlist(int id, string name, string date, List<Song> songs)
        {
            _id = id;
            _name = name;
            _date = date;
            _songs = songs;

        }

        public Playlist()
        {
            
        }

        public Playlist(string name, List<Song> songs)
        {
            int id = dbHandler.GetNewId();

            _id = id;
            _name = name;
            _date = DateTime.Now.ToString("dd/MM/yyyy.");
            _songs = songs;

           // dbHandler.Add(this);
        }

        public void AddSong(Song cancion)
        {
            Songs.Add(cancion);
        }

        public void RemoveSong(int index)
        {
            Songs.RemoveAt(index);
        }

        public string Name { get { return _name; } set { _name = value; } }
        public int Id { get { return _id; } set { _id = value; } }
        public string Date { get { return _date; } set { _date = value; } }
        public List<Song> Songs { get { return _songs; } set { _songs = value; } }


        public static List<Playlist> GetPlaylist()
        {
            List<Playlist> Playlists = dbHandler.Get();
            return Playlists;
        }

        

        ~Playlist() { } //Elimino mi playlist
    }
}
