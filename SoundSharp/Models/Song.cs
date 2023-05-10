using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoundSharp.Utils;
using SoundSharp.Consts;
using System.Text.Json.Serialization;

namespace SoundSharp.Models
{
    public class Song
    {
        //Colocar source de las canciones.
        private int _id;
        private string _author;
        private string _name;
        private string _route;
        private static DbHandler<Song> dbHandler = new DbHandler<Song>(FileNames.Songs, FileNames.SongsId);

        [JsonConstructor]
        public Song(int id, string author, string name, string route)
        {
            _id = id;
            Author = author;
            Name = name;
            Route = route;
        }

        public Song(string author, string name, string route)
        {
            int id = dbHandler.GetNewId();

            _id = id;
            Author = author;
            Name = name;
            Author = author;

            string destination = $"{FileNames.LoadedSongs}/{id}-{name}.mp3";

            File.Copy(route, destination);

            Route = destination;

            dbHandler.Add(this);
        }

        public int Id { get { return _id; } }
        public string Author { get { return _author; } set { _author = value; } }
        public string Name { get { return _name;} set { _name = value; } }
        public string Route { get { return _route;} set { _route = value; } }

        public static List<Song> GetSongs()
        {
            List<Song> songs = dbHandler.Get();
            return songs;
        }
    }
}
