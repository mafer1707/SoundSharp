using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoundSharp.Models;

namespace SoundSharp
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
