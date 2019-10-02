using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginApp.Entities;

namespace LoginApp.View
{
    public partial class NotiView : Form, INotiView
    {
        private Form _previous;
        private UserEnt _user;
        public Form form => this;

        public NotiView(Form previous, UserEnt user)
        {
            InitializeComponent();
            this._previous = previous;
            this._user = user;
            showNoti();
        }

        private void showNoti()
        {
            labelUsername.Text = _user.Username;
        }


        private void NotiView_Load(object sender, EventArgs e)
        {

        }

        private void NotiView_FormClosing(object sender, FormClosingEventArgs e)
        {
           // _previous.Show();
        }

        private void NotiView_FormClosed(object sender, FormClosedEventArgs e)
        {
            _previous.Show();
        }
    }
}
