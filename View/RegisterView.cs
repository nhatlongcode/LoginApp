using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp.View
{
    public partial class RegisterView : Form, IRegisterView
    {
        private Form previous;

        public Form form => this;
        

        public RegisterView(Form previous)
        {
            InitializeComponent();
            this.previous = previous;
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
    }
}
