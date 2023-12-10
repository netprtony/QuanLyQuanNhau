using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanNhau
{
    public class Account
    {
        public Account()
        {

        }
       
        public Account(string display, string user, string pass, bool role)
        {
            this.Display = display;
            this.Username = user;
            this.Password = pass;
            this.Role = role;
        }
        
        private string username;
        private string password;
        private string display;
        private bool role;
        
        public bool Role { get => role; set => role = value; }
        public string Display { get => display; set => display = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
    }
}
