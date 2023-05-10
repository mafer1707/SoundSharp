
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelReproduccion = new System.Windows.Forms.Panel();
            this.lblTimerFinal = new System.Windows.Forms.Label();
            this.lblTimerInicial = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.btnFav = new System.Windows.Forms.PictureBox();
            this.btnShuffle = new System.Windows.Forms.PictureBox();
            this.btnLoop = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelReproduccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.MenuVertical.Controls.Add(this.btnExit);
            this.MenuVertical.Controls.Add(this.btnFavorite);
            this.MenuVertical.Controls.Add(this.btnProfile);
            this.MenuVertical.Controls.Add(this.btnPlaylist);
            this.MenuVertical.Controls.Add(this.pbLogo);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(190, 458);
            this.MenuVertical.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(190, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 35);
            this.panel1.TabIndex = 1;
            // 
            // PanelReproduccion
            // 
            this.PanelReproduccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.PanelReproduccion.Controls.Add(this.btnAdd);
            this.PanelReproduccion.Controls.Add(this.btnFav);
            this.PanelReproduccion.Controls.Add(this.btnShuffle);
            this.PanelReproduccion.Controls.Add(this.btnLoop);
            this.PanelReproduccion.Controls.Add(this.btnBack);
            this.PanelReproduccion.Controls.Add(this.btnNext);
            this.PanelReproduccion.Controls.Add(this.btnPause);
            this.PanelReproduccion.Controls.Add(this.lblTimerFinal);
            this.PanelReproduccion.Controls.Add(this.lblTimerInicial);
            this.PanelReproduccion.Controls.Add(this.progressBar);
            this.PanelReproduccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelReproduccion.Location = new System.Drawing.Point(190, 358);
            this.PanelReproduccion.Name = "PanelReproduccion";
            this.PanelReproduccion.Size = new System.Drawing.Size(508, 100);
            this.PanelReproduccion.TabIndex = 2;
            // 
            // lblTimerFinal
            // 
            this.lblTimerFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimerFinal.AutoSize = true;
            this.lblTimerFinal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerFinal.ForeColor = System.Drawing.Color.White;
            this.lblTimerFinal.Location = new System.Drawing.Point(454, 65);
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
            this.lblTimerInicial.Location = new System.Drawing.Point(12, 65);
            this.lblTimerInicial.Name = "lblTimerInicial";
            this.lblTimerInicial.Size = new System.Drawing.Size(39, 15);
            this.lblTimerInicial.TabIndex = 0;
            this.lblTimerInicial.Text = "00:00";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(65, 70);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(375, 5);
            this.progressBar.TabIndex = 0;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(190, 35);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(508, 323);
            this.PanelContenedor.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = global::SoundSharp.Properties.Resources.anadir;
            this.btnAdd.Location = new System.Drawing.Point(67, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(29, 27);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 8;
            this.btnAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAdd, "Agregar a playlist");
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFav
            // 
            this.btnFav.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFav.Image = global::SoundSharp.Properties.Resources.favorito;
            this.btnFav.Location = new System.Drawing.Point(408, 17);
            this.btnFav.Name = "btnFav";
            this.btnFav.Size = new System.Drawing.Size(29, 27);
            this.btnFav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFav.TabIndex = 7;
            this.btnFav.TabStop = false;
            this.toolTip1.SetToolTip(this.btnFav, "Agregar a favoritos");
            this.btnFav.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffle.Image = global::SoundSharp.Properties.Resources.shuffle;
            this.btnShuffle.Location = new System.Drawing.Point(113, 17);
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
            this.btnLoop.Location = new System.Drawing.Point(361, 17);
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
            this.btnBack.Location = new System.Drawing.Point(193, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(24, 27);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 4;
            this.btnBack.TabStop = false;
            this.toolTip1.SetToolTip(this.btnBack, "Atrás");
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Image = global::SoundSharp.Properties.Resources.siguiente;
            this.btnNext.Location = new System.Drawing.Point(282, 17);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(24, 27);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNext.TabIndex = 3;
            this.btnNext.TabStop = false;
            this.toolTip1.SetToolTip(this.btnNext, "Siguiente");
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Image = global::SoundSharp.Properties.Resources.pausa;
            this.btnPause.Location = new System.Drawing.Point(238, 17);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(24, 27);
            this.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPause.TabIndex = 2;
            this.btnPause.TabStop = false;
            this.toolTip1.SetToolTip(this.btnPause, "Play/Pause");
            this.btnPause.Click += new System.EventHandler(this.pbPause_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::SoundSharp.Properties.Resources.lista;
            this.btnMenu.Location = new System.Drawing.Point(3, 0);
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
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(7)))), ((int)(((byte)(90)))));
            this.btnExit.Image = global::SoundSharp.Properties.Resources.salir;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.toolTip1.SetToolTip(this.btnExit, "Salir");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavorite.FlatAppearance.BorderSize = 0;
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorite.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavorite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(7)))), ((int)(((byte)(90)))));
            this.btnFavorite.Image = global::SoundSharp.Properties.Resources.favoritoRelleno1;
            this.btnFavorite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavorite.Location = new System.Drawing.Point(0, 258);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(190, 40);
            this.btnFavorite.TabIndex = 3;
            this.btnFavorite.Text = "   Favoritos";
            this.toolTip1.SetToolTip(this.btnFavorite, "Favoritos");
            this.btnFavorite.UseVisualStyleBackColor = true;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(7)))), ((int)(((byte)(90)))));
            this.btnProfile.Image = global::SoundSharp.Properties.Resources.perfil;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 191);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(190, 40);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Perfil";
            this.toolTip1.SetToolTip(this.btnProfile, "Perfil");
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
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
            this.btnPlaylist.Location = new System.Drawing.Point(0, 129);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(190, 40);
            this.btnPlaylist.TabIndex = 1;
            this.btnPlaylist.Text = " Playlist";
            this.toolTip1.SetToolTip(this.btnPlaylist, "Playlist");
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::SoundSharp.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(3, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(185, 56);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 458);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelReproduccion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuVertical);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoundSharp";
            this.MenuVertical.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanelReproduccion.ResumeLayout(false);
            this.PanelReproduccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel PanelReproduccion;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox btnPause;
        private System.Windows.Forms.Label lblTimerFinal;
        private System.Windows.Forms.Label lblTimerInicial;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox btnNext;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox btnLoop;
        private System.Windows.Forms.PictureBox btnShuffle;
        private System.Windows.Forms.PictureBox btnFav;
        private System.Windows.Forms.PictureBox btnAdd;
    }
}

