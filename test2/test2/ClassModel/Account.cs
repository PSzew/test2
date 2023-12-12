using System;
using System.Collections.Generic;
using System.Text;

namespace test2.ClassModel
{
    internal class Account
    {
        public Account(string login, string password, UserClass c)
        {
            Login = login;
            Password = password;
            Class = c;
        }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserClass Class { get; set; }
    }
}
