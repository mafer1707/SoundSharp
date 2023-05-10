
namespace SoundSharp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.EyeButton = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EyeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(7)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(59, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iniciar sesión";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(7)))), ((int)(((byte)(90)))));
            this.panel1.Location = new System.Drawing.Point(22, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(58, 212);
            this.txtUser.MaxLength = 100;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(199, 24);
            this.txtUser.TabIndex = 4;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(7)))), ((int)(((byte)(90)))));
            this.panel2.Location = new System.Drawing.Point(22, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(58, 295);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(179, 24);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // EyeButton
            // 
            this.EyeButton.Image = global::SoundSharp.Properties.Resources.EyeIcon;
            this.EyeButton.Location = new System.Drawing.Point(243, 289);
            this.EyeButton.Name = "EyeButton";
            this.EyeButton.Size = new System.Drawing.Size(30, 30);
            this.EyeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EyeButton.TabIndex = 7;
            this.EyeButton.TabStop = false;
            this.EyeButton.Click += new System.EventHandler(this.EyeButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SoundSharp.Properties.Resources.candado;
            this.pictureBox2.Location = new System.Drawing.Point(22, 289);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SoundSharp.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(22, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(7)))), ((int)(((byte)(90)))));
            this.btnAccept.Enabled = false;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(59, 353);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(168, 33);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Text = "Acceder";
            this.btnAccept.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(59, 403);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 33);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Header
            // 
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(292, 38);
            this.Header.TabIndex = 10;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::SoundSharp.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(23, 15);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(251, 115);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 11;
            this.pbLogo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(292, 448);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.EyeButton);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EyeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox EyeButton;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}