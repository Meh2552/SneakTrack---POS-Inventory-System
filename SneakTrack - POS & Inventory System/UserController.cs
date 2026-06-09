using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System
{
    public class UserController
    {
        private MainSystem sys;
        private Validator v;
        private DataHandler dh;

        private BindingList<UserAuth.User> userList;

        public UserController(MainSystem system) 
        { 
            this.sys = system;
            this.dh = this.sys.DH;
            this.v = this.sys.VAL;

            initialize();
        }

        private void initialize()
        {
            loadUserList();
        }

        public void reloadGrid(DataGridView grid)
        {
            loadUserList();
            loadDataGrid(grid);
        }

        public void reloadGrid(DataGridView grid, string query)
        {
            loadUserList(query);
            loadDataGrid(grid);
        }

        private void loadUserList()
        {
            BindingList<UserAuth.User> users = new BindingList<UserAuth.User>();
            string name, username, password, date, role, id;

            try { 
                DataTable table = dh.dtFromTable(dh.selectQuery("User","*","archived = 0"));

                foreach(DataRow dr in table.Rows)
                {
                    name = dr["name"].ToString();
                    username = dr["username"].ToString();
                    password = dr["password"].ToString();
                    date = dr["date_created"].ToString();
                    role = dr["role"].ToString();
                    id = dr["user_id"].ToString();

                    users.Add(new UserAuth.User(username, password, name, role, date, id));
                }
            }
            catch (Exception ex) { }

            this.userList = users;
        }

        private void loadUserList(string search)
        {
            BindingList<UserAuth.User> users = new BindingList<UserAuth.User>();
            DataTable table = dh.dtFromTable(dh.selectQuery("User", "*", "archived = 0"));
            string name, username, password, date, role, id;


            try
            { 
            table = table.AsEnumerable()
                .Where(row => row["name"].ToString().Contains(search) ||
                   row["username"].ToString().Contains(search) ||
                   row["role"].ToString().Contains(search) ||
                   row["date_created"].ToString().Contains(search))
                .CopyToDataTable();

                foreach (DataRow dr in table.Rows)
                {
                    name = dr["name"].ToString();
                    username = dr["username"].ToString();
                    password = dr["password"].ToString();
                    date = dr["date_created"].ToString();
                    role = dr["role"].ToString();
                    id = dr["user_id"].ToString();

                    users.Add(new UserAuth.User(username, password, name, role, date, id));
                }
            }
            catch (Exception ex) { }

            this.userList = users;
        }

        public void loadDataGrid(DataGridView grid)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
            grid.DataSource = userList;

            grid.Columns["Password"].Visible = false;
            grid.Columns["UserID"].Visible = false;
        }

        public void archiveAccount(UserAuth.User user)
        {
            dh.updateValueToTable(dh.updateQuery("User", "archived = 1", $"user_id = @user_id"), "@user_id", user.UserID);
        }
    }
}
