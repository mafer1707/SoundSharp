using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;
using SoundSharp.Consts;
using SoundSharp.Models;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace SoundSharp
{
    public partial class AddList : Form
    {
        List<Playlist> Playlists = new List<Playlist>();
        List<Song> Songs = new List<Song>();
        List<Song> PlaylistSongs = new List<Song>();
        bool ValidacionNombre = true;
        int contador = 0;
        private readonly bool _isEdit = false;
        private readonly int _posicion;

        private void AddList_Load(object sender, EventArgs e)
        {
            Playlists = Playlist.GetPlaylists();
            Songs = Song.GetSongs();

            ReFillItems();

            if (_isEdit == true)
            {
                PlaylistSongs = Playlists[_posicion].Songs;
                AddBtn.Text = "Modificar";
                contador = PlaylistSongs.Count();
                NameBox.Text = Playlists[_posicion].Name;
                foreach (var item in PlaylistSongs)
                {
                    DgSongs.Rows.Add(item.Author, item.Name);
                }
            }
        }

        public AddList(int id)
        {
            InitializeComponent();
            
            _posicion = id;
            _isEdit = true ;
        }
        public AddList()
        {
            InitializeComponent();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (NameBox.Text == string.Empty || DgSongs.Rows.Count == 0)
            {
                if (NameBox.Text == string.Empty)
                {
                    MessageBox.Show("Por favor ingrese un nombre para la playlist");
                }
                else
                {
                    MessageBox.Show("La lista de canciones esta vacia.");
                }
            }
            else
            {
                ValidarNombre(NameBox.Text);
                if (_isEdit == true)
                {
                    if (ValidacionNombre == true)
                    {
                        Playlists[_posicion].Name = NameBox.Text;
                        Playlists[_posicion].Songs = PlaylistSongs;
                        EditPlaylistToRegister();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El nombre que ingreso ya esta en uso.");
                        NameBox.Text = Playlists[_posicion].Name;
                    }
                }
                else
                {
                    if (ValidacionNombre == true)
                    {
                        new Playlist(NameBox.Text, PlaylistSongs);
                        this.Close();
                    }
                    else 
                    {
                        MessageBox.Show("El nombre que ingreso ya esta en uso.");
                        NameBox.Text = "";
                    }  
                }

                
            }

        }

        private void AddSong_Click(object sender, EventArgs e)
        {
            try
            {
                //campo de seleccion de cliente vacio.
                if (SearchBox.Text == string.Empty)
                {
                    MessageBox.Show("Por favor ingrese una cancion en la barra de busqueda");
                }
                else
                {
                    SetSong(SearchBox.Text);
                    DgSongs.Rows.Add(PlaylistSongs[contador].Author, PlaylistSongs[contador].Name);
                    contador++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("La cancion que introdujo no existe");
                throw;
            }
        }

        private void DgSongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            try
            {
                i = DgSongs.CurrentCell.RowIndex;
            }
            catch (NullReferenceException)
            {
                i = -1;

            }
            if (e.ColumnIndex == DgSongs.Columns["DeleteCell"].Index && i != -1 && e.RowIndex != -1)
            {
                DgSongs.Rows.Remove(DgSongs.CurrentRow);
                PlaylistSongs.RemoveAt(i);
                contador--;
            }
        }

        private void ReFillItems()
        {
            AutoCompleteStringCollection Canciones = new AutoCompleteStringCollection();

            //Añadir items de busqueda(canciones).
            foreach (var item in Songs)
            {
                Canciones.Add(item.Author + " " + item.Name);
                Canciones.Add(item.Name);
            }

            SearchBox.AutoCompleteCustomSource = Canciones;
            SearchBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            SearchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }

        private void SetSong(string text)
        {
            /*var search = from s in SongsRegister
                         where s.Name.ToLower().Trim() == text.ToLower().Trim() || (s.Author + " " + s.Name).ToLower().Trim() == text.ToLower().Trim()
                         select new { s.Id, s.Author, s.Name, s.Route };*/

           Song song = Songs.Find(element => element.Name.ToLower().Trim() == text.ToLower().Trim() || (element.Author + " " + element.Name).ToLower().Trim() == text.ToLower().Trim());

            try
            {
                
                    PlaylistSongs.Add(song);
                
            }
            catch (Exception)
            {  
            }
        }

        private void ValidarNombre(string text)
        {
            if (_isEdit == true)
            {
                try
                {
                    var search = from s in Playlists
                                 where (s.Name.ToLower().Trim() == text.ToLower().Trim()) && Playlists[_posicion].Name.ToLower().Trim() != text.ToLower().Trim()
                                 select new { s.Name };

                    if (search.Count() >= 1)
                    {
                        ValidacionNombre = false;
                    }
                    else
                    {
                        ValidacionNombre = true;
                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {
                try
                {
                    var search = from s in Playlists
                                 where s.Name.ToLower().Trim() == text.ToLower().Trim()
                                 select new { s.Name };
                    if (search.Count() >= 1)
                    {
                        ValidacionNombre = false;
                    }
                    else
                    {
                        ValidacionNombre = true;
                    }
                }
                catch (Exception)
                {

                }
            }
            
    
        }

        private void EditPlaylistToRegister()
        {
            string fileName = FileNames.Playlist;
   

            //guardar Json actualizado.
            string jsonString = JsonConvert.SerializeObject(Playlists);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
