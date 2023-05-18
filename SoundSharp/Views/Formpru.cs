using Newtonsoft.Json;
using SoundSharp.Consts;
using SoundSharp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SoundSharp.Views
{
    public partial class Formpru : Form
    {
        List<Song> MySong = new List<Song>();
        List<Playlist> PlaylistRegister = new List<Playlist>();
        List<Song> SongsRegister = new List<Song>();
        List<Playlist> MyPlayList = new List<Playlist>();
        int contador = 0;
        private MainWindow miVentana;

        private readonly int _posicion;
        public Formpru(int id,MainWindow main)
        {
            InitializeComponent();
            _posicion = id;
            miVentana = main;
        }

        public Formpru(int id)
        {
            InitializeComponent();
            _posicion = id;
        }
        public Formpru()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            miVentana.OpenChildForm(new PlaylistView(miVentana));

            //PlaylistView back = new PlaylistView();
            //back.Show();
            //MainWindow.PanelContenedor.Controls.Add(back);
        }
        private void Formpru_Load(object sender, EventArgs e)
        {
            GetPlaylist();
            GetSongsRegister();
            MySong = PlaylistRegister[_posicion].Songs;
            foreach (var item in MySong)
            {
                dgvPlaylist.Rows.Add(Convert.ToString(item.Id), item.Name, item.Author, " ");
            }
        }
        private void GetPlaylist()
        {
            string fileName = FileNames.Playlist;
            string jsonString = File.ReadAllText(fileName);
            try
            {
                PlaylistRegister = JsonConvert.DeserializeObject<List<Playlist>>(jsonString);
            }
            catch (Exception)
            {
                MessageBox.Show("No hay Playlist guardadas.");
            }
        }
        private void GetSongsRegister()
        {
            string fileName = FileNames.Songs;
            string jsonString = File.ReadAllText(fileName);
            try
            {
                SongsRegister = JsonConvert.DeserializeObject<List<Song>>(jsonString);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void cualquiercosa()
        {
            string nombre = dgvPlaylist.Rows[_posicion].Cells[0].Value.ToString();
            int PosicionEnLista = GetPlayListByName(nombre);
            Formpru add = new Formpru(PosicionEnLista);
            add.ShowDialog();
        }
        private int GetPlayListByName(string nombre)
        {
            int id = -1;
            int i = 0;
            foreach (var item in MyPlayList)
            {
                if (item.Name == nombre)
                {
                    id = i;
                }
                i++;
            }
            return id;
        }
        private void dgvPlaylist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            try
            {
                i = dgvPlaylist.CurrentCell.RowIndex;
            }
            catch (NullReferenceException)
            {
                i = -1;

            }
            if (e.ColumnIndex == dgvPlaylist.Columns["dgvDelete"].Index && i != -1 && e.RowIndex != -1)
            {
                DialogResult confirmar = MessageBox.Show("¿Está seguro que desea Eliminar?", "Eliminar", MessageBoxButtons.OKCancel);
                if (confirmar == DialogResult.OK)
                {
                    string name = dgvPlaylist.Rows[_posicion].Cells[0].Value.ToString();
                    int PosicionEnLista = GetPlayListByName(name);
                    MyPlayList.RemoveAt(PosicionEnLista);
                    SetPlaylist();
                }
                //dgvPlaylist.Rows.Remove(dgvPlaylist.CurrentRow);
                //MySong.RemoveAt(i);
                //contador--;
            }
        }
        private void SetPlaylist()
        {
            string fileName = FileNames.Playlist;
            string jsonString = File.ReadAllText(fileName);
            //Crear y agregar primera dactura a la lista 
            jsonString = JsonConvert.SerializeObject(MyPlayList);
            MyPlayList = JsonConvert.DeserializeObject<List<Playlist>>(jsonString);
            File.WriteAllText(fileName, jsonString);
            jsonString = JsonConvert.SerializeObject(MyPlayList);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
