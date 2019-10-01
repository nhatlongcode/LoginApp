using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.View
{
    public interface IRegisterView : IBaseView
    {
        string getUsername();
        string getPassword();
        string getConfirm();
    }
}
