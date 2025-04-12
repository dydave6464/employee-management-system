using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class UserReg
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public UserReg(string username, string password)
        {
            Username = username;
            Password = password;

        }
    }
}
