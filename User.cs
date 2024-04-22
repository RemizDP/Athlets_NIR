﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class User
    {
        public int id { get; set; }
        private string login, password, email;
        
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public User() { }
        public User( string login, string password, string email)
        { 
            this.login = login;
            this.password = password;
            this.email = email;
        }

        public override string ToString()
        {
            return "Пользователь: " + Login + " " + Password + " " + Email;
        }
    }
}
