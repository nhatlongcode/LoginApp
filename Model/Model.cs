using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginApp.Respone;
using LoginApp.Entities;
namespace LoginApp.Model
{
    public class Model
    {
        public static void Login(string username, string password,IRespone<UserEnt> respone)
        {
            username = username.Trim().ToUpper();
            try
            {
                UserEnt user = new UserEnt();
                user = Storage.Instance.getUser(username);
                if (user == null || Storage.Instance.MD5Hash(password) != user.Password)
                {
                    respone.OnFail("Login fail!");
                    return;
                }

                respone.OnSuccess(user);
            }
            catch (Exception e)
            {
                respone.OnError(e.ToString());
            }
        }

        public static void Register(string username, string password, string confirm, IRespone<UserEnt> respone)
        {
            username = username.Trim().ToUpper();
            UserEnt user = new UserEnt();
            user.Username = username;
            user.Password = password;
            try
            {
                if (user.Password != confirm)
                {
                    respone.OnFail("Please confirm again!");
                    return;
                }
                else if (!Storage.Instance.addUser(user))
                {
                    respone.OnFail("Username existed!");
                    return;
                }
                respone.OnSuccess(user);
            }
            catch (Exception e)
            {
                respone.OnError(e.ToString());
            }
        }
    }
}
