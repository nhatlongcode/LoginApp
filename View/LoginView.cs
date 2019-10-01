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
        }

        public string getUsername()
        {
            return txtUsername.Text;
        }

        public string getPassword()
        {
            return txtPassword.Text;
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegisterPresenter regPresenter = new RegisterPresenter(this);
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
           LoginPresenter logPresenter = new LoginPresenter(this);
           logPresenter.DoLogin();
        }
    }
}
