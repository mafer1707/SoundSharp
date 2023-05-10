using SoundSharp.Views.Playlist.SubMenu;
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
    public partial class Playlist : Form
    {
        public Playlist()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddList add = new AddList();
            add.ShowDialog();
            ReloadDg();
        }
        
        public void ReloadDg(){ 
            
        }

        List<Playlist> Playlists = new List<Playlist>();
    }
}
