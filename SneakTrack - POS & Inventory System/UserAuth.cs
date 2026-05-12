using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakTrack___POS___Inventory_System
{
    public class UserAuth
    {
        private MainSystem sys;
        private DataHandler dh;

        public UserAuth(MainSystem sys) { 
            this.sys = sys;
            this.dh = sys.DH;
        }

        public enum Role
        {
            ADMIN,
            EMPLOYEE,
        }

        public struct User
        {
            public User(string username, string password, string name, string role, string dateCreated)
            {
                this.username = username;
                this.password = password;
                this.name = name;
                Enum.TryParse<Role>(role, out Role parsedRole);
                this.role = parsedRole;
                this.dateCreated = dateCreated;
            }

            private string username;
            private string password;
            private Role role;
            private string name;
            private string dateCreated;

            public string Username { get { return this.username; } }
            public Enum Role { get { return this.role; } }
            public string Name { get { return this.name; } }
            public string DateCreated { get { return this.dateCreated; } }
            public string Password { get { return this.password; } }
        }

        // Checks if login is authorized
        public Boolean authLogin(string username, string password)
        {
            Boolean found = false;

            User account = dh.checkUserAuth(username);
            
            if (account.Password.Equals(password))
            {
                found = true;
            }

            return found;
        }
    }
}
