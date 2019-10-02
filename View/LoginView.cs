using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginApp.Presenter;
using System.IO;

namespace LoginApp.View
{
    public partial class LoginView : Form, ILoginView
    {
        public Form form => this;


        public LoginView()
        {
            InitializeComponent();
            txtUsername.GotFocus += txtUsername_RemoveText;
            txtUsername.LostFocus += txtUsername_AddText;
            txtPassword.GotFocus += txtPassword_RemoveText;
            txtPassword.LostFocus += txtPassword_AddText;
        }

        public string getUsername()
        {
            return txtUsername.Text;
        }

        public string getPassword()
        {
            return txtPassword.Text;
        }


        private void logButtonClicked()
        {
            ILoginPresenter logPresenter = new LoginPresenter(this);
            logPresenter.DoLogin();
        }

        private void regButtonClicked()
        {
            this.Hide();
            new RegisterView(this).Show();
        }

        public void txtUsername_RemoveText(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = System.Drawing.Color.Black;
            }
        }

        public void txtUsername_AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {

                txtUsername.ForeColor = Color.FromArgb(64, 64, 64);
                txtUsername.Text = "Username";
            }
        }

        public void txtPassword_RemoveText(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = ""; 
                txtPassword.ForeColor = System.Drawing.Color.Black;
            }

        }

        public void txtPassword_AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {

                txtPassword.ForeColor = Color.FromArgb(64, 64, 64);
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
