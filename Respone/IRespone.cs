using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Respone
{
    public interface IRespone<T>
    {
        void OnSuccess(T data);

        void OnFail(string msgs);

        void OnError(string msgs);
    }
}
