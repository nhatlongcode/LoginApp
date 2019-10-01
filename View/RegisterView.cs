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

namespace LoginApp.View
{
    public partial class RegisterView : Form, IRegisterView
    {
        private Form _previous;

        public Form form => this;
        

        public RegisterView(Form previous)
        {
            InitializeComponent();
            this._previous = previous;
        }

        public string getUsername()
        {
            return txtRegUsername.Text;
        }

        public string getPassword()
        {
            return txtRegPassword.Text;
        }

        public string getConfirm()
        {
            return txtRegConfirm.Text;
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegisterPresenter presenter = new RegisterPresenter(this);
            presenter.DoRegister();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _previous.Show();
        }
    }
}
