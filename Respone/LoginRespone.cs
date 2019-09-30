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
    class LoginRespone : IRespone<UserEnt>
    {
        ILoginView view;
        LoginRespone(ILoginView view)
        {
            this.view = view;
        }

        public void OnSuccess(UserEnt data)
        {
            
        }

        public void OnFail(string msgs)
        {
            MessageBox.Show(
                msgs, 
                "Cannot login!", 
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        public void OnError(string msgs)
        {
            MessageBox.Show(
                "Something wrong!\n" + msgs,
                "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }
}
