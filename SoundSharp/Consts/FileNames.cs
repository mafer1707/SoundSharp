using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundSharp.Consts
{
    internal class FileNames
    {
        public static string Database = "../../Database";
        public static string ProgramDatabase = Database + "/Program"; 
        public static string LoadedSongs = Database + "/Songs";

        public static string Songs = ProgramDatabase + "/songs.json";
        public static string SongsId = ProgramDatabase + "/songsId.txt";

        public static string Playlist = ProgramDatabase + "/playlist.json";
        public static string PlaylistId = ProgramDatabase + "/playlistId.txt";
    }
}
