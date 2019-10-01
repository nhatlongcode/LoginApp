using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using LoginApp.Entities;

namespace LoginApp
{
    public class Storage
    {
        static Storage instance;
        private string path = "User.txt";
        Dictionary<string, string> dict = new Dictionary<string, string>();

        private Storage()
        {
            loadData();
        }

        private void loadData()
        {
            if (!File.Exists(path))
            {
                //File.Create(path);
                return;
            }

            string[] dataFromFile = File.ReadAllLines(path);
            for (int i=0; i<dataFromFile.Length;i+=2)
            {
                dict.Add(dataFromFile[i], dataFromFile[i+1]);
            }
        }

        public UserEnt getUser(string username)
        {
            username = username.Trim().ToUpper();
            if (dict.ContainsKey(username))
            {
                UserEnt user = new UserEnt();
                user.Username = username;
                user.Password = dict[username];
                return user;
            }
            else return null;  
        }

        public bool addUser(UserEnt user)
        {
            string username = user.Username;
            string password = user.Password;

            username = username.Trim().ToUpper();
            password = MD5Hash(password);

            if (dict.ContainsKey(username)) return false;
            else
            {
                dict.Add(username, password);
                string[] temp = { username, password };
                File.AppendAllLines(path, temp);
            }
            return true;
        }

        public static Storage Instance // singleton
        {
            get
            {
                if (instance == null) instance = new Storage();
                return instance;
            }
        }

        public string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
