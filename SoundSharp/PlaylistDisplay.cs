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
    public partial class PlaylistDisplay : Form
    {
        private readonly string SearchPlaceHolder = "Buscar Playlist";
        public PlaylistDisplay()
        {
            InitializeComponent();
        }

        private void PlaylistDisplay_Load(object sender, EventArgs e)
        {
            txtSearch.Text = SearchPlaceHolder;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == SearchPlaceHolder)
                txtSearch.Text = "";
        }
    }
}
