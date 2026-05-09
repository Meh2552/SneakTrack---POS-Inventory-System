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

        public UserAuth(MainSystem sys) { 
            this.sys = sys;
        }

        // For testing
        string[] userList = { "user1", "user2", "user3" };
        string[] passList = { "pass1", "pass1", "pass1" };

        public struct User
        {
            User(string username, string password, string name)
            {
                this.username = username;
                this.password = password;
                this.name = name;
            }

            public string username;
            public string password;
            public string name;
        }

        // Checks if login is authorized
        public Boolean authLogin(string username, string password)
        {
            Boolean found = false;
            int index = -1;

            foreach (String userLN in userList)
            {
                index++;
                if (userLN.Equals(username)) {
                   if (passList[index].Equals(password)) return true;
                }
                else continue;
            }

            return found;
        }
    }
}
