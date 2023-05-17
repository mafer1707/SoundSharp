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
        List<Playlist> PlaylistRegister = new List<Playlist>();
        List<Song> SongsRegister = new List<Song>();
        List<Song> MySong = new List<Song>();
        bool ValidacionNombre = true;
        int contador = 0;
        private readonly bool _isEdit = false;
        private readonly int _posicion;

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
                if (_isEdit == true)
                {
                    PlaylistRegister[_posicion].Name = NameBox.Text;
                    PlaylistRegister[_posicion].Songs = MySong;
                    EditPlaylistToRegister();
                    this.Close();
                }
                else
                {
                    ValidarNombre(NameBox.Text);

                    if (ValidacionNombre == true)
                    {
                        Playlist NewPlaylist = new Playlist(NameBox.Text, MySong);
                        AddPlaylistToRegister(NewPlaylist);
                        this.Close();
                    }
                    else 
                    {
                        MessageBox.Show("El nombre que ingreso ya esta en uso.");
                    }
                }
            }
        }
        private void AddList_Load(object sender, EventArgs e)
        {
            List<Song> musica = new List<Song>();
            GetPlaylist();
            GetSongsRegister();
            ReFillItems();
            if (_isEdit == true)
            {
                MySong = PlaylistRegister[_posicion].Songs;
                AddBtn.Text = "Modificar";
                NameBox.Text = PlaylistRegister[_posicion].Name;
                foreach (var item in MySong)
                {
                    DgSongs.Rows.Add(item.Author, item.Name);
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
                    DgSongs.Rows.Add(MySong[contador].Author, MySong[contador].Name);
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
                MySong.RemoveAt(i);
                contador--;
            }
        }

        private void ReFillItems()
        {
            AutoCompleteStringCollection Canciones = new AutoCompleteStringCollection();

            //Añadir items de busqueda(canciones).
            foreach (var item in SongsRegister)
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
            var search = from s in SongsRegister
                         where s.Name.ToLower().Trim() == text.ToLower().Trim() || (s.Author + " " + s.Name).ToLower().Trim() == text.ToLower().Trim()
                         select new { s.Id, s.Author, s.Name, s.Route, s.Time};

            try
            {
                foreach (var item in search)
                {
                    MySong.Add(new Song(item.Id, item.Author, item.Name, item.Route, item.Time));
                }

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ValidarNombre(string text)
        {

            

            try
            {
                var search = from s in PlaylistRegister
                             where s.Name.ToLower().Trim() == text.ToLower().Trim()
                             select new { s.Name };
                if (search.Count() >= 1)
                {
                    ValidacionNombre = false;
                } else
                {
                    ValidacionNombre = true;
                }
            }
            catch (Exception)
            {
             
            }
    
        }

        private void AddPlaylistToRegister(Playlist PlaylistAdd)
        {
            string fileName = FileNames.Playlist;
            string jsonString = File.ReadAllText(fileName);

            try //adquirirfactura
            {
                PlaylistRegister = JsonConvert.DeserializeObject<List<Playlist>>(jsonString);
                PlaylistRegister.Add(PlaylistAdd);
            }
            catch (Exception) //Capturar json vacio.
            {
                //Crear y agregar primera dactura a la lista 
                PlaylistRegister = new List<Playlist>();
                PlaylistRegister.Add(PlaylistAdd);
                jsonString = JsonConvert.SerializeObject(PlaylistRegister);
                PlaylistRegister = JsonConvert.DeserializeObject<List<Playlist>>(jsonString);
                File.WriteAllText(fileName, jsonString);
            }

            //guardar Json actualizado.
            jsonString = JsonConvert.SerializeObject(PlaylistRegister);
            File.WriteAllText(fileName, jsonString);
        }

        private void GetSongsRegister() 
        {
            string fileName = FileNames.Songs;
            string jsonString = File.ReadAllText(fileName);

            try //adquirirfactura
            {
                SongsRegister = JsonConvert.DeserializeObject<List<Song>>(jsonString);
                
            }
            catch (Exception) //Capturar json vacio.
            {
                throw;
            }

            //guardar Json actualizado.
            
        }

        private void GetPlaylist()
        {
            string fileName = FileNames.Playlist;
            string jsonString = File.ReadAllText(fileName);


            try //adquirirfactura
            {
                PlaylistRegister = JsonConvert.DeserializeObject<List<Playlist>>(jsonString);

            }
            catch (Exception) //Capturar json vacio.
            {

                MessageBox.Show("No hay Playlist guardadas.");
            }
        }

        private void EditPlaylistToRegister()
        {
            string fileName = FileNames.Playlist;
   

            //guardar Json actualizado.
            string jsonString = JsonConvert.SerializeObject(PlaylistRegister);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
