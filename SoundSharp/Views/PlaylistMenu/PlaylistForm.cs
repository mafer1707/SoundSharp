﻿using Newtonsoft.Json;
using SoundSharp.Consts;
using SoundSharp.Models;
using SoundSharp.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;     

namespace SoundSharp
{
    public partial class PlaylistView : Form
    {
        //private Form activeForm = null;
        List<Playlist> MyPlayList = new List<Playlist>();
        private MainWindow miVentana;

        public PlaylistView(MainWindow main)
        {
            InitializeComponent();
            miVentana = main;
        }

        public PlaylistView()
        {
            InitializeComponent();
        }
        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            AddList add = new AddList();
            add.ShowDialog();
            dgPlaylist.Rows.Clear();
            MyPlayList = Playlist.GetPlaylists();
            ReloadDg(MyPlayList);
        }
        private void dgPlaylist_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // e.RowIndex != -1
            {
                ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();
                int position = dgPlaylist.HitTest(e.X, e.Y).RowIndex;
                if (position > -1)
                {
                    menu.Items.Add("Editar").Name = "Editar" + position;
                    menu.Items.Add("Eliminar").Name = "Eliminar" + position;
                }
                menu.Show(dgPlaylist, e.X, e.Y);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(munuClick);
            }
        }

        public void ReloadDg(List<Playlist> MyPlayList)
        {
            dgPlaylist.Rows.Clear();
            try
            {
                foreach (Playlist p in MyPlayList)
                {
                    dgPlaylist.Rows.Add(p.Name, p.Date);
                }
            }
            catch (Exception)
            {


            }
        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = SearchBox.Text.ToLower().Trim();
            List<Playlist> filtrado = MyPlayList.Where(i => i.Name.ToLower().StartsWith(pattern)).ToList();
            ReloadDg(filtrado);

        }


        private void PlaylistView_Load(object sender, EventArgs e)
        {
            GetPlaylist();
            MyPlayList = Playlist.GetPlaylists(); 
            ReloadDg(MyPlayList);
        }
        //revisar esto
        private void munuClick(object sender, ToolStripItemClickedEventArgs e)
        {
            string id = e.ClickedItem.Name.ToString();
            if (id.Contains("Editar"))
            {
                id = id.Replace("Editar", "");
                string nombre = dgPlaylist.Rows[int.Parse(id)].Cells[0].Value.ToString();
                int PosicionEnLista = GetPlayListByName(nombre);
                AddList add = new AddList(PosicionEnLista);
                add.ShowDialog();
                SearchBox.Text = "";
            }

            else if (id.Contains("Eliminar"))
            {
                id = id.Replace("Eliminar", "");
                DialogResult confirmar = MessageBox.Show("¿Está seguro que desea Eliminar?", "Eliminar", MessageBoxButtons.OKCancel);
                if (confirmar == DialogResult.OK)
                {
                    string name = dgPlaylist.Rows[int.Parse(id)].Cells[0].Value.ToString();
                    int PosicionEnLista = GetPlayListByName(name);
                    MyPlayList.RemoveAt(PosicionEnLista);
                    SetPlaylist();
                }
            }
            SearchBox.Clear();
            GetPlaylist();
            dgPlaylist.Rows.Clear();
            ReloadDg(MyPlayList);
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

        private void GetPlaylist()
        {
            string fileName = FileNames.Playlist;
            string jsonString = File.ReadAllText(fileName);
            try //adquirirfactura
            {
                MyPlayList = JsonConvert.DeserializeObject<List<Playlist>>(jsonString);

            }
            catch (Exception) //Capturar json vacio.
            {
                MessageBox.Show("No hay Playlist guardadas.");
            }
        }

        private void SetPlaylist()
        {
            string fileName = FileNames.Playlist;
            string jsonString = File.ReadAllText(fileName);
                
            jsonString = JsonConvert.SerializeObject(MyPlayList);
            MyPlayList = JsonConvert.DeserializeObject<List<Playlist>>(jsonString);
            File.WriteAllText(fileName, jsonString);
            jsonString = JsonConvert.SerializeObject(MyPlayList);
            File.WriteAllText(fileName, jsonString);
        }

        private void dgPlaylist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = dgPlaylist.Rows[e.RowIndex].Cells[0].Value.ToString();
            int PosicionEnLista = GetPlayListByName(name);
            var formpru = new PlaylistDetail(PosicionEnLista,miVentana);
            miVentana.OpenChildForm(formpru);

        }
    }
}
