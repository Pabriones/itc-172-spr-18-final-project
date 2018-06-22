using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Models
{
    public class Login
        {
            public Login() { }
            public Login(string user, string password)
            {
                UserName = user;
                PassWord = password;
            }
            public string UserName { set; get; }
            public string PassWord { set; get; }
        }
}