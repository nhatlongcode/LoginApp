using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginApp.View;
using LoginApp.Model;
using LoginApp.Entities;
using LoginApp.Respone;

namespace LoginApp.Presenter
{
    class LoginPresenter : ILoginPresenter
    {
        ILoginView view;
        LoginPresenter(ILoginView view)
        {
            this.view = view;
        }
        public void DoLogin()
        {
            string username = view.getUsername();
            string password = view.getPassword();
            Model.Model.Login(username, password, new LoginRespone(view));
        }
    }
}
