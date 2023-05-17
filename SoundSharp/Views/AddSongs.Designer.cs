
namespace SoundSharp.Views
{
    partial class AddSongs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSongs));
            this.RouteInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.PlaylistInput = new System.Windows.Forms.TextBox();
            this.AlbumInput = new System.Windows.Forms.TextBox();
            this.RouteLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PlaylistLabel = new System.Windows.Forms.Label();
            this.AlbumLabel = new System.Windows.Forms.Label();
            this.AddSong = new System.Windows.Forms.Button();
            this.NameError = new System.Windows.Forms.Label();
            this.PlaylistError = new System.Windows.Forms.Label();
            this.AlbumError = new System.Windows.Forms.Label();
            this.AuthorError = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.Label();
            this.AuthorInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RouteInput
            // 
            this.RouteInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.RouteInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RouteInput.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.RouteInput.Location = new System.Drawing.Point(12, 35);
            this.RouteInput.Name = "RouteInput";
            this.RouteInput.ReadOnly = true;
            this.RouteInput.Size = new System.Drawing.Size(283, 24);
            this.RouteInput.TabIndex = 9;
            // 
            // NameInput
            // 
            this.NameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.NameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameInput.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.NameInput.Location = new System.Drawing.Point(12, 104);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(283, 24);
            this.NameInput.TabIndex = 0;
            this.NameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
            // 
            // PlaylistInput
            // 
            this.PlaylistInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.PlaylistInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlaylistInput.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaylistInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.PlaylistInput.Location = new System.Drawing.Point(12, 243);
            this.PlaylistInput.Name = "PlaylistInput";
            this.PlaylistInput.Size = new System.Drawing.Size(283, 24);
            this.PlaylistInput.TabIndex = 2;
            // 
            // AlbumInput
            // 
            this.AlbumInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.AlbumInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AlbumInput.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.AlbumInput.Location = new System.Drawing.Point(12, 314);
            this.AlbumInput.Name = "AlbumInput";
            this.AlbumInput.Size = new System.Drawing.Size(283, 24);
            this.AlbumInput.TabIndex = 3;
            // 
            // RouteLabel
            // 
            this.RouteLabel.AutoSize = true;
            this.RouteLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(7)))), ((int)(((byte)(90)))));
            this.RouteLabel.Location = new System.Drawing.Point(8, 9);
            this.RouteLabel.Name = "RouteLabel";
            this.RouteLabel.Size = new System.Drawing.Size(41, 19);
            this.RouteLabel.TabIndex = 13;
            this.RouteLabel.Text = "Ruta";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(7)))), ((int)(((byte)(90)))));
            this.NameLabel.Location = new System.Drawing.Point(8, 82);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(159, 19);
            this.NameLabel.TabIndex = 14;
            this.NameLabel.Text = "Nombre de la canción";
            // 
            // PlaylistLabel
            // 
            this.PlaylistLabel.AutoSize = true;
            this.PlaylistLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaylistLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(7)))), ((int)(((byte)(90)))));
            this.PlaylistLabel.Location = new System.Drawing.Point(8, 221);
            this.PlaylistLabel.Name = "PlaylistLabel";
            this.PlaylistLabel.Size = new System.Drawing.Size(58, 19);
            this.PlaylistLabel.TabIndex = 15;
            this.PlaylistLabel.Text = "Playlist";
            // 
            // AlbumLabel
            // 
            this.AlbumLabel.AutoSize = true;
            this.AlbumLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(7)))), ((int)(((byte)(90)))));
            this.AlbumLabel.Location = new System.Drawing.Point(8, 292);
            this.AlbumLabel.Name = "AlbumLabel";
            this.AlbumLabel.Size = new System.Drawing.Size(54, 19);
            this.AlbumLabel.TabIndex = 16;
            this.AlbumLabel.Text = "Álbum";
            // 
            // AddSong
            // 
            this.AddSong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.AddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSong.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold);
            this.AddSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(7)))), ((int)(((byte)(90)))));
            this.AddSong.Location = new System.Drawing.Point(12, 361);
            this.AddSong.Name = "AddSong";
            this.AddSong.Size = new System.Drawing.Size(283, 31);
            this.AddSong.TabIndex = 4;
            this.AddSong.Text = "Agregar";
            this.AddSong.UseVisualStyleBackColor = false;
            this.AddSong.Click += new System.EventHandler(this.AddSong_Click);
            // 
            // NameError
            // 
            this.NameError.AutoSize = true;
            this.NameError.ForeColor = System.Drawing.Color.Red;
            this.NameError.Location = new System.Drawing.Point(9, 131);
            this.NameError.Name = "NameError";
            this.NameError.Size = new System.Drawing.Size(0, 13);
            this.NameError.TabIndex = 18;
            // 
            // PlaylistError
            // 
            this.PlaylistError.AutoSize = true;
            this.PlaylistError.ForeColor = System.Drawing.Color.Red;
            this.PlaylistError.Location = new System.Drawing.Point(12, 273);
            this.PlaylistError.Name = "PlaylistError";
            this.PlaylistError.Size = new System.Drawing.Size(0, 13);
            this.PlaylistError.TabIndex = 19;
            // 
            // AlbumError
            // 
            this.AlbumError.AutoSize = true;
            this.AlbumError.ForeColor = System.Drawing.Color.Red;
            this.AlbumError.Location = new System.Drawing.Point(12, 341);
            this.AlbumError.Name = "AlbumError";
            this.AlbumError.Size = new System.Drawing.Size(0, 13);
            this.AlbumError.TabIndex = 20;
            // 
            // AuthorError
            // 
            this.AuthorError.AutoSize = true;
            this.AuthorError.ForeColor = System.Drawing.Color.Red;
            this.AuthorError.Location = new System.Drawing.Point(9, 201);
            this.AuthorError.Name = "AuthorError";
            this.AuthorError.Size = new System.Drawing.Size(0, 13);
            this.AuthorError.TabIndex = 23;
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(7)))), ((int)(((byte)(90)))));
            this.Autor.Location = new System.Drawing.Point(8, 152);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(49, 19);
            this.Autor.TabIndex = 22;
            this.Autor.Text = "Autor";
            // 
            // AuthorInput
            // 
            this.AuthorInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(56)))), ((int)(((byte)(82)))));
            this.AuthorInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorInput.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.AuthorInput.Location = new System.Drawing.Point(12, 174);
            this.AuthorInput.Name = "AuthorInput";
            this.AuthorInput.Size = new System.Drawing.Size(283, 24);
            this.AuthorInput.TabIndex = 1;
            this.AuthorInput.TextChanged += new System.EventHandler(this.AuthorInput_TextChanged);
            // 
            // AddSongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(307, 404);
            this.Controls.Add(this.AuthorError);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.AuthorInput);
            this.Controls.Add(this.AlbumError);
            this.Controls.Add(this.PlaylistError);
            this.Controls.Add(this.NameError);
            this.Controls.Add(this.AddSong);
            this.Controls.Add(this.AlbumLabel);
            this.Controls.Add(this.PlaylistLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.RouteLabel);
            this.Controls.Add(this.AlbumInput);
            this.Controls.Add(this.PlaylistInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.RouteInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddSongs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox RouteInput;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox PlaylistInput;
        private System.Windows.Forms.TextBox AlbumInput;
        private System.Windows.Forms.Label RouteLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PlaylistLabel;
        private System.Windows.Forms.Label AlbumLabel;
        private System.Windows.Forms.Button AddSong;
        private System.Windows.Forms.Label NameError;
        private System.Windows.Forms.Label PlaylistError;
        private System.Windows.Forms.Label AlbumError;
        private System.Windows.Forms.Label AuthorError;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.TextBox AuthorInput;
    }
}