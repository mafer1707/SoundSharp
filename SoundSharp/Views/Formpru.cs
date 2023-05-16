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
        List<Playlist> MyPlayList = new List<Playlist>();
        public Formpru()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            PlaylistView back = new PlaylistView();
            back.Show();
            //MainWindow.PanelContenedor.Controls.Add(back);
        }
    }
}
