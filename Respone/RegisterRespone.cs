using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginApp.Entities;
using LoginApp.View;
using System.Windows.Forms;

namespace LoginApp.Respone
{
    class RegisterRespone : IRespone<UserEnt>
    {
        ILoginView view;
        RegisterRespone(ILoginView view)
        {
            this.view = view;
        }

        public void OnSuccess(UserEnt data)
        {

        }

        public void OnFail(string msgs)
        {
            MessageBox.Show(msgs, 
                "Cannot register!", 
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        public void OnError(string msgs)
        {
            MessageBox.Show("Something went wrong!\n" + msgs,
                "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }
}
