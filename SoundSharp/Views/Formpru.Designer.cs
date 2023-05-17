namespace SoundSharp.Views
{
    partial class Formpru
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvPlaylist = new System.Windows.Forms.DataGridView();
            this.dgvLogo = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(7)))), ((int)(((byte)(90)))));
            this.lblTitle.Location = new System.Drawing.Point(276, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(226, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nombre de la Playlist";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.Silver;
            this.lblTime.Location = new System.Drawing.Point(278, 44);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(142, 17);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Duracion de la cancion";
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
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(125, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvPlaylist
            // 
            this.dgvPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlaylist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvPlaylist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlaylist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvLogo,
            this.dgvId,
            this.dtvName,
            this.dgvArtist,
            this.dtgTime,
            this.dgvDelete});
            this.dgvPlaylist.Location = new System.Drawing.Point(12, 111);
            this.dgvPlaylist.Name = "dgvPlaylist";
            this.dgvPlaylist.ReadOnly = true;
            this.dgvPlaylist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPlaylist.RowHeadersVisible = false;
            this.dgvPlaylist.Size = new System.Drawing.Size(762, 195);
            this.dgvPlaylist.TabIndex = 7;
            // 
            // dgvLogo
            // 
            this.dgvLogo.HeaderText = "Logo";
            this.dgvLogo.Name = "dgvLogo";
            this.dgvLogo.ReadOnly = true;
            this.dgvLogo.Width = 55;
            // 
            // dgvId
            // 
            this.dgvId.HeaderText = "Id";
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            this.dgvId.Width = 55;
            // 
            // dtvName
            // 
            this.dtvName.HeaderText = "Cancion";
            this.dtvName.Name = "dtvName";
            this.dtvName.ReadOnly = true;
            this.dtvName.Width = 250;
            // 
            // dgvArtist
            // 
            this.dgvArtist.HeaderText = "Cantante";
            this.dgvArtist.Name = "dgvArtist";
            this.dgvArtist.ReadOnly = true;
            this.dgvArtist.Width = 250;
            // 
            // dtgTime
            // 
            this.dtgTime.HeaderText = "Duracion";
            this.dtgTime.Name = "dtgTime";
            this.dtgTime.ReadOnly = true;
            this.dtgTime.Width = 50;
            // 
            // dgvDelete
            // 
            this.dgvDelete.HeaderText = "Eliminar";
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.ReadOnly = true;
            // 
            // Formpru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(786, 317);
            this.Controls.Add(this.dgvPlaylist);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTitle);
            this.Name = "Formpru";
            this.Text = "Formpru";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvPlaylist;
        private System.Windows.Forms.DataGridViewImageColumn dgvLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgTime;
        private System.Windows.Forms.DataGridViewButtonColumn dgvDelete;
    }
}