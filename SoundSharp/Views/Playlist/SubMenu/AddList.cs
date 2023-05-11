using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundSharp.Views.Playlist.SubMenu
{
    public partial class AddList : Form
    {
        List<Playlist> List = new List<Playlist>(Playlist.getPlaylist());
        public AddList()
        {
            InitializeComponent();
        }

        private void Searchlbl_Click(object sender, EventArgs e)
        {

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
