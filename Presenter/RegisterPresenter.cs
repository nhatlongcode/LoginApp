using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginApp.View;
using LoginApp.Model;
using LoginApp.Respone;

namespace LoginApp.Presenter
{
    class RegisterPresenter : IRegisterPresenter
    {
        IRegisterView view;

        public RegisterPresenter(IRegisterView view)
        {
            this.view = view;
        }
        public void DoRegister()
        {
            string username = view.getUsername();
            string password = view.getPassword();
            string confirm = view.getConfirm();
            Model.Model.Register(username, password, confirm, new RegisterRespone(this.view));
        }
    }
}
