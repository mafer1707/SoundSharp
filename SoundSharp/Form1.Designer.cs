
namespace SoundSharp
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.PanelReproduccion = new System.Windows.Forms.Panel();
            this.lblVolume = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnVolume = new System.Windows.Forms.PictureBox();
            this.slider = new System.Windows.Forms.PictureBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblSong = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.btnShuffle = new System.Windows.Forms.PictureBox();
            this.btnLoop = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.lblTimerFinal = new System.Windows.Forms.Label();
            this.lblTimerInicial = new System.Windows.Forms.Label();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.timerSlider = new System.Windows.Forms.Timer(this.components);
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.PanelReproduccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.MenuVertical.Controls.Add(this.lblMenu);
            this.MenuVertical.Controls.Add(this.btnMenu);
            this.MenuVertical.Controls.Add(this.btnExit);
            this.MenuVertical.Controls.Add(this.btnSearch);
            this.MenuVertical.Controls.Add(this.btnPlaylist);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(190, 473);
            this.MenuVertical.TabIndex = 0;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(7)))), ((int)(((byte)(90)))));
            this.lblMenu.Location = new System.Drawing.Point(72, 27);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(57, 23);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Menú";
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::SoundSharp.Properties.Resources.listaRosa;
            this.btnMenu.Location = new System.Drawing.Point(12, 21);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.toolTip1.SetToolTip(this.btnMenu, "Menú");
            this.btnMenu.Click += new System.EventHandler(this.pbMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(7)))), ((int)(((byte)(90)))));
            this.btnExit.Image = global::SoundSharp.Properties.Resources.salir;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 421);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(190, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.toolTip1.SetToolTip(this.btnExit, "Salir");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(7)))), ((int)(((byte)(90)))));
            this.btnSearch.Image = global::SoundSharp.Properties.Resources.lupa;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 129);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(190, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnSearch, "Buscar");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(7)))), ((int)(((byte)(90)))));
            this.btnPlaylist.Image = global::SoundSharp.Properties.Resources.playlist1;
            this.btnPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 191);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnPlaylist.Size = new System.Drawing.Size(190, 40);
            this.btnPlaylist.TabIndex = 1;
            this.btnPlaylist.Text = " Playlist";
            this.toolTip1.SetToolTip(this.btnPlaylist, "Playlist");
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // PanelReproduccion
            // 
            this.PanelReproduccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.PanelReproduccion.Controls.Add(this.lblVolume);
            this.PanelReproduccion.Controls.Add(this.trackBar1);
            this.PanelReproduccion.Controls.Add(this.btnVolume);
            this.PanelReproduccion.Controls.Add(this.slider);
            this.PanelReproduccion.Controls.Add(this.lblArtist);
            this.PanelReproduccion.Controls.Add(this.lblSong);
            this.PanelReproduccion.Controls.Add(this.btnAdd);
            this.PanelReproduccion.Controls.Add(this.btnShuffle);
            this.PanelReproduccion.Controls.Add(this.btnLoop);
            this.PanelReproduccion.Controls.Add(this.btnBack);
            this.PanelReproduccion.Controls.Add(this.btnNext);
            this.PanelReproduccion.Controls.Add(this.btnPause);
            this.PanelReproduccion.Controls.Add(this.lblTimerFinal);
            this.PanelReproduccion.Controls.Add(this.lblTimerInicial);
            this.PanelReproduccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelReproduccion.Location = new System.Drawing.Point(190, 356);
            this.PanelReproduccion.Name = "PanelReproduccion";
            this.PanelReproduccion.Size = new System.Drawing.Size(802, 117);
            this.PanelReproduccion.TabIndex = 2;
            // 
            // lblVolume
            // 
            this.lblVolume.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.White;
            this.lblVolume.Location = new System.Drawing.Point(754, 28);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(29, 16);
            this.lblVolume.TabIndex = 15;
            this.lblVolume.Text = "0%";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBar1.Location = new System.Drawing.Point(651, 25);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnVolume
            // 
            this.btnVolume.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVolume.Image = global::SoundSharp.Properties.Resources.mid_img;
            this.btnVolume.Location = new System.Drawing.Point(616, 23);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(29, 27);
            this.btnVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolume.TabIndex = 12;
            this.btnVolume.TabStop = false;
            this.toolTip1.SetToolTip(this.btnVolume, "Mute");
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // slider
            // 
            this.slider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.slider.Location = new System.Drawing.Point(251, 76);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(467, 23);
            this.slider.TabIndex = 11;
            this.slider.TabStop = false;
            this.slider.Paint += new System.Windows.Forms.PaintEventHandler(this.slider_Paint);
            this.slider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slider_MouseDown);
            this.slider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.slider_MouseMove);
            this.slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.slider_MouseUp);
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.ForeColor = System.Drawing.Color.White;
            this.lblArtist.Location = new System.Drawing.Point(28, 41);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(52, 16);
            this.lblArtist.TabIndex = 10;
            this.lblArtist.Text = "Artista";
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSong.ForeColor = System.Drawing.Color.White;
            this.lblSong.Location = new System.Drawing.Point(26, 18);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(64, 16);
            this.lblSong.TabIndex = 9;
            this.lblSong.Text = "Canción";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = global::SoundSharp.Properties.Resources.anadir;
            this.btnAdd.Location = new System.Drawing.Point(251, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(29, 27);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 8;
            this.btnAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAdd, "Agregar a playlist");
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffle.Image = global::SoundSharp.Properties.Resources.shuffle;
            this.btnShuffle.Location = new System.Drawing.Point(297, 23);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(29, 27);
            this.btnShuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnShuffle.TabIndex = 6;
            this.btnShuffle.TabStop = false;
            this.toolTip1.SetToolTip(this.btnShuffle, "Shuffle");
            this.btnShuffle.Click += new System.EventHandler(this.pbShuffle_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoop.Image = global::SoundSharp.Properties.Resources.repetir;
            this.btnLoop.Location = new System.Drawing.Point(563, 23);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(29, 27);
            this.btnLoop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLoop.TabIndex = 5;
            this.btnLoop.TabStop = false;
            this.toolTip1.SetToolTip(this.btnLoop, "Repetir");
            this.btnLoop.Click += new System.EventHandler(this.pbLoop_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::SoundSharp.Properties.Resources.atras;
            this.btnBack.Location = new System.Drawing.Point(384, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(24, 27);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 4;
            this.btnBack.TabStop = false;
            this.toolTip1.SetToolTip(this.btnBack, "Atrás");
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Image = global::SoundSharp.Properties.Resources.siguiente;
            this.btnNext.Location = new System.Drawing.Point(473, 23);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(24, 27);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNext.TabIndex = 3;
            this.btnNext.TabStop = false;
            this.toolTip1.SetToolTip(this.btnNext, "Siguiente");
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Image = global::SoundSharp.Properties.Resources.pausa;
            this.btnPause.Location = new System.Drawing.Point(429, 23);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(24, 27);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPause.TabIndex = 2;
            this.btnPause.TabStop = false;
            this.toolTip1.SetToolTip(this.btnPause, "Play/Pause");
            this.btnPause.Click += new System.EventHandler(this.pbPause_Click);
            // 
            // lblTimerFinal
            // 
            this.lblTimerFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerFinal.AutoSize = true;
            this.lblTimerFinal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerFinal.ForeColor = System.Drawing.Color.White;
            this.lblTimerFinal.Location = new System.Drawing.Point(740, 81);
            this.lblTimerFinal.Name = "lblTimerFinal";
            this.lblTimerFinal.Size = new System.Drawing.Size(39, 15);
            this.lblTimerFinal.TabIndex = 1;
            this.lblTimerFinal.Text = "00:00";
            // 
            // lblTimerInicial
            // 
            this.lblTimerInicial.AutoSize = true;
            this.lblTimerInicial.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerInicial.ForeColor = System.Drawing.Color.White;
            this.lblTimerInicial.Location = new System.Drawing.Point(194, 80);
            this.lblTimerInicial.Name = "lblTimerInicial";
            this.lblTimerInicial.Size = new System.Drawing.Size(39, 15);
            this.lblTimerInicial.TabIndex = 0;
            this.lblTimerInicial.Text = "00:00";
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(190, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(802, 356);
            this.PanelContenedor.TabIndex = 3;
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 15;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // timerSlider
            // 
            this.timerSlider.Enabled = true;
            this.timerSlider.Tick += new System.EventHandler(this.timerSlider_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 473);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelReproduccion);
            this.Controls.Add(this.MenuVertical);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoundSharp";
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.PanelReproduccion.ResumeLayout(false);
            this.PanelReproduccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel PanelReproduccion;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox btnPause;
        private System.Windows.Forms.Label lblTimerFinal;
        private System.Windows.Forms.Label lblTimerInicial;
        private System.Windows.Forms.PictureBox btnNext;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox btnLoop;
        private System.Windows.Forms.PictureBox btnShuffle;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.PictureBox slider;
        private System.Windows.Forms.Timer timerSlider;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox btnVolume;
        private System.Windows.Forms.Label lblVolume;
    }
}

