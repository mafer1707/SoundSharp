using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SoundSharp.Utils;
using SoundSharp.Models;
using SoundSharp.Consts;

namespace SoundSharp.Views
{
    public partial class AddSongs : Form
    {
        private int NameInputMaxLength = 100;
        private int AuthorInputMaxLength = 100;

        private ErrorHandler NameErrorHandler;
        private ErrorHandler AuthorErrorHandler;

        public AddSongs(string route)
        {
            InitializeComponent();
            RouteInput.Text = route;

            NameErrorHandler = new ErrorHandler(NameError);
            AuthorErrorHandler = new ErrorHandler(AuthorError);

            List<Playlist> playlists = Playlist.GetPlaylists();
            List<Song> songs = Song.GetSongs();

            if (songs.Count() == 0) return;
            InputSuggestions.SetSuggestions(songs, AuthorInput, "Author");
            InputSuggestions.SetSuggestions(songs, AlbumInput, "Album");

            if (playlists.Count() == 0) return;
            InputSuggestions.SetSuggestions(playlists, PlaylistInput, "Name");
        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            InputValidators.LimitInput(NameInput, NameInputMaxLength);
            NameErrorHandler.HideError();
        }
        private void AuthorInput_TextChanged(object sender, EventArgs e)
        {
            InputValidators.LimitInput(AuthorInput, AuthorInputMaxLength);
            AuthorErrorHandler.HideError();
        }

        private void AddSong_Click(object sender, EventArgs e)
        {
            bool isValid = FormIsValid();
            if (!isValid) return;

            Song song = new Song(AuthorInput.Text, AlbumInput.Text, NameInput.Text, RouteInput.Text);
            Close();

            if (InputValidators.IsEmpty(PlaylistInput.Text)) return;
            Playlist playlist = GetPlaylist();
            if (playlist != null)
            {
                playlist.AddSong(song);
                return;
            };
            new Playlist(PlaylistInput.Text, new List<Song>() { song });
        }

        private bool NameExists()
        {
            List<Song> songs = Song.GetSongs();
            bool exists = InputValidators.Exists(NameInput.Text, "Name", songs);
            return exists;
        }
        private Playlist GetPlaylist()
        {
            List<Playlist> playlists = Playlist.GetPlaylists();
            Playlist playlist = playlists.FirstOrDefault(pl => pl.Name == PlaylistInput.Text);
            return playlist;
        }

        private bool FormIsValid()
        {
            bool nameIsEmpty = InputValidators.IsEmpty(NameInput.Text);
            bool nameAlreadyUsed = NameExists();
            bool authorIsEmpty = InputValidators.IsEmpty(AuthorInput.Text);

            if (nameAlreadyUsed) NameErrorHandler.ShowError(ErrorMessages.SongNameAlreadyUsed);
            if (nameIsEmpty) NameErrorHandler.ShowError(ErrorMessages.SongNameIsEmpty);
            if (authorIsEmpty) AuthorErrorHandler.ShowError(ErrorMessages.SongAuthorIsEmpty);

            return !nameIsEmpty && !authorIsEmpty && !nameAlreadyUsed;
        }
    }
}
