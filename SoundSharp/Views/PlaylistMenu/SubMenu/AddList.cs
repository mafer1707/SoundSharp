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
using SoundSharp.Models;
using static System.Net.Mime.MediaTypeNames;

namespace SoundSharp
{
    public partial class AddList : Form
    {
        List<Playlist> ListOfPlaylist = new List<Playlist>();
        List<Song> SongList = new List<Song>();
        List<Song> MySong = new List<Song>();
        bool ValidacionNombre = false;
        int contador = 0;
        private readonly int prueba;
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
                
                ValidarNombre(NameBox.Text);
                if (ValidacionNombre == false)
                {
                    if (_isEdit == true)
                    {
                        ListOfPlaylist[_posicion].Name = NameBox.Text;
                        ListOfPlaylist[_posicion].Songs = MySong;
                    }
                    else
                    {
                        Playlist MyPlaylist = new Playlist(NameBox.Text, MySong);
                        this.Close();
                    }
                }
            }

        }

        private void AddList_Load(object sender, EventArgs e)
        {

            List<Song> musica = new List<Song>();
            musica.Add(new Song(1,"yo","chainsaw", "../../Database/Songs/1-Chainsaw Op.mp3"));
            SongList.Add(new Song(1, "yo", "chainsaw", "../../Database/Songs/1-Chainsaw Op.mp3"));
            SongList.Add(new Song(1, "yo", "chainsaw", "../../Database/Songs/1-Chainsaw Op.mp3"));
            SongList.Add(new Song(1, "yo", "chainsaw", "../../Database/Songs/1-Chainsaw Op.mp3"));
            SongList.Add(new Song(1, "yo", "chainsaw", "../../Database/Songs/1-Chainsaw Op.mp3"));

            ListOfPlaylist.Add(new Playlist(1, "wenas", "01/01/01", musica));
            ListOfPlaylist.Add(new Playlist(1, "wenas", "01/01/01", musica));
            ListOfPlaylist.Add(new Playlist(1, "wenas1", "01/01/01", musica));
            ListOfPlaylist.Add(new Playlist(1, "wenas2", "01/01/01", musica));
            ListOfPlaylist.Add(new Playlist(1, "wenas3", "01/01/01", musica));
            ReFillItems();

            if (_isEdit == true)
            {
                MySong = ListOfPlaylist[_posicion].Songs;
                AddBtn.Text = "Modificar";
                NameBox.Text = ListOfPlaylist[_posicion].Name;
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
            foreach (var item in SongList)
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
            var search = from s in SongList
                         where s.Name.ToLower().Trim() == text.ToLower().Trim() || (s.Author + s.Name).ToLower().Trim() == text.ToLower().Trim()
                         select new { s.Id, s.Author, s.Name, s.Route };

            try
            {
                foreach (var item in search)
                {
                    MySong.Add(new Song(item.Id, item.Author, item.Name, item.Route));
                }

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ValidarNombre(string text)
        {
            var search = from s in ListOfPlaylist
                         where s.Name.ToLower().Trim() == text.ToLower().Trim()
                         select new { s.Name };

            try
            {
                if (search == null)
                {
                    ValidacionNombre = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
    
        }
    }
}
