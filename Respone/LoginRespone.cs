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
    public class LoginRespone : IRespone<UserEnt>
    {
        ILoginView view;
        public LoginRespone(ILoginView view)
        {
            this.view = view;
        }

        public void OnSuccess(UserEnt data)
        {
            NotiView notiView = new NotiView(this.view.form, data);
            this.view.form.Hide();
            notiView.form.Show();
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
