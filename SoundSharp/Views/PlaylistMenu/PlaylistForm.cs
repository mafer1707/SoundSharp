using SoundSharp.Consts;
using SoundSharp.Models;
using SoundSharp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundSharp
{
    

    public partial class PlaylistView : Form
    {
        
       List<Playlist> List = new List<Playlist>(Playlist.getPlaylist());

        public PlaylistView()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddList add = new AddList();
            add.ShowDialog();
            ReloadDg();
        }
        
        public void ReloadDg()
        {
            foreach (Playlist p in List) 
            {
                int rowindex = dgPlaylist.Rows.Add();
                DataGridViewRow row = dgPlaylist.Rows[rowindex];
                row.Cells[0].Value = p.Name;
            }
            
        }

        

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void PlaylistView_Load(object sender, EventArgs e)
        {
            ReloadDg();
        }
    }
}
