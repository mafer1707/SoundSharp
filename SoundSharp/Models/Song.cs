using System.Collections.Generic;
using System.IO;
using SoundSharp.Utils;
using SoundSharp.Consts;
using TagLib;
using System;

namespace SoundSharp.Models
{
    public class Song
    {
        //Colocar source de las canciones.
        private int _id;
        private string _author;
        private string _album;
        private string _name;
        private string _route;
        private TimeSpan _duration;
        private static DbHandler<Song> dbHandler = new DbHandler<Song>(FileNames.Songs, FileNames.SongsId);

        public Song(string author, string album, string name, string route)
        {
            int id = dbHandler.GetNewId();

            _id = id;
            Author = author;
            Album = album;
            Name = name;
            Author = author;

            string destination = $"{FileNames.LoadedSongs}/{id}-{name}.mp3";

            System.IO.File.Copy(route, destination);

            Route = Path.GetFullPath(destination);

            TagLib.File song = TagLib.File.Create(route);
            Duration = song.Properties.Duration;

            dbHandler.Add(this);
        }

        // This constructor is used by the JsonDeserializer, don't remove
        public Song()
        {

        }

        public int Id { get { return _id; } set { _id = value; } }
        public string Author { get { return _author; } set { _author = value; } }
        public string Album { get { return _album; } set { _album = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Route { get { return _route; } set { _route = value; } }
        public TimeSpan Duration { get { return _duration; } set { _duration = value; } }
        public static List<Song> GetSongs()
        {
            List<Song> songs = dbHandler.Get();
            return songs;
        }

    }
}

