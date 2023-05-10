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
    public partial class LoginForm : Form
    {
        int mov;
        int movX;
        int movY;

        string usernamePlaceholder = "Usuario";
        string passwordPlaceholder = "Contraseña";
        char passwordMask = '*';
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUser.Text = usernamePlaceholder;
            txtPassword.Text = passwordPlaceholder;
        }
        private void VerifyInputs()
        {
            //Verificaciones de que los campos del usuario y clave no esten vacíos 
            //y asi activar el boton de acceso
            bool usernameInputIsInvalid = string.IsNullOrEmpty(txtUser.Text) || txtUser.Text == usernamePlaceholder;
            bool passwordInputIsInvalid = string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text == passwordPlaceholder;
            if (usernameInputIsInvalid || passwordInputIsInvalid)
            {
                btnAccept.Enabled = false;
                return;
            }
            btnAccept.Enabled = true;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            VerifyInputs();
        }
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == usernamePlaceholder)
            {
                txtUser.Text = "";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            VerifyInputs();
        }


        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == passwordPlaceholder)
            {
                txtPassword.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
                txtUser.Text = usernamePlaceholder;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
                txtPassword.Text = passwordPlaceholder;
        }

        private void EyeButton_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility();
        }

        private void TogglePasswordVisibility()
        {
            if (txtPassword.PasswordChar == passwordMask)
            {
                txtPassword.PasswordChar = '\0';
                return;
            }
            txtPassword.PasswordChar = passwordMask;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel);

            if (confirmar == DialogResult.OK)
                this.Close();
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
