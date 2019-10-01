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
    public class RegisterRespone : IRespone<UserEnt>
    {
        IRegisterView view;
        public RegisterRespone(IRegisterView view)
        {
            this.view = view;
        }

        public void OnSuccess(UserEnt data)
        {
            //INotiView notiView = new NotiView(this.view.form, data);
            this.view.form.Hide();
            //notiView.form.Show();
            new NotiView(Application.OpenForms[0], data).Show();
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
