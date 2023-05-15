using Newtonsoft.Json.Linq;
using SoundSharp.Consts;
using SoundSharp.Models;
using SoundSharp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SoundSharp
{


    public partial class PlaylistView : Form
    {

        List<Playlist> MyPlayList = new List<Playlist>();


        public PlaylistView()
        {
            InitializeComponent();
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            AddList add = new AddList(-1);
            add.ShowDialog();
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
                    menu.Items.Add("Reproducir").Name = "Borrar" + position;
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
            foreach (Playlist p in MyPlayList)
            {
                dgPlaylist.Rows.Add(p.Name, p.Date);
            }
        }


        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = SearchBox.Text.ToLower().Trim();
            List<Playlist> filtrado = MyPlayList.Where(i => i.Name.ToLower().Contains(pattern)).ToList();
            ReloadDg(filtrado);

        }


        private void PlaylistView_Load(object sender, EventArgs e)
        {
            List<Song> musica = new List<Song>();
            
            musica.Add(new Song(1, "yo", "chainsaw", "../../Database/Songs/1-Chainsaw Op.mp3"));
            musica.Add(new Song(1, "yo", "chainsaw", "../../Database/Songs/1-Chainsaw Op.mp3"));
            musica.Add(new Song(1, "yo", "chainsaw", "../../Database/Songs/1-Chainsaw Op.mp3"));
            musica.Add(new Song(1, "yo", "chainsaw", "../../Database/Songs/1-Chainsaw Op.mp3"));

            MyPlayList.Add(new Playlist(1, "wenas", "01/01/01", musica));
            MyPlayList.Add(new Playlist(1, "wenas1", "01/01/01", musica));
            MyPlayList.Add(new Playlist(1, "wenas2", "01/01/01", musica));
            MyPlayList.Add(new Playlist(1, "wenas3", "01/01/01", musica));



            ReloadDg(MyPlayList);
        }
        private void munuClick(object sender, ToolStripItemClickedEventArgs e)
        {
            string id = e.ClickedItem.Name.ToString();
            if (id.Contains("Reproducir"))
            {
                id = id.Replace("Reproducir", "");



            }
            else if (id.Contains("Editar"))
            {
                id = id.Replace("Editar", "");

                string nombre = dgPlaylist.Rows[int.Parse(id)].Cells[0].Value.ToString();
                int PosicionEnLista = GetPlayListByName(nombre);
                AddList add = new AddList(PosicionEnLista);
                add.ShowDialog();
            }

            else if (id.Contains("Eliminar"))
            {
                id = id.Replace("Modificar", "");
            }

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

    }
}
