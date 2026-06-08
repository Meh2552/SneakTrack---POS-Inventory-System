using System;

namespace SneakTrack___POS___Inventory_System
{
    public class UserAuth
    {
        private MainSystem sys;
        private DataHandler dh;
        private User currentUser;

        public UserAuth(MainSystem sys)
        {
            this.sys = sys;
            this.dh = sys.DH;
        }

        public class User
        {
            public User(string username, string password, string name, string role, string dateCreated, string userid)
            {
                this.username = username;
                this.password = password;
                this.name = name;
                this.role = role;
                this.dateCreated = dateCreated;
                this.userID = userid;
            }

            private string username;
            private string password;
            private string role;
            private string name;
            private string dateCreated;
            private string userID;

            public string UserID { get { return this.userID; } }
            public string Name { get { return this.name; } }
            public string Username { get { return this.username; } }
            public string Role { get { return this.role; } }

            public string DateCreated { 
                get 
                {
                    string[] date = this.dateCreated.Split(' ');
                    return date[0]; 
                } 
            }

            public string Password { get { return this.password; } }
        }

        // Used to set the current user after login
        public User CurrentUser { 
            get { return this.currentUser; } 
            set { this.currentUser = value; } 
        }

        // Checks if login is authorized
        public Boolean authLogin(string username, string password)
        {
            Boolean found = false;

            User account = dh.checkUserAuth(username);
            
            if (account.Password.Equals(password))
            {
                found = true;
                CurrentUser = account;
            }

            return found;
        }
    }
}
