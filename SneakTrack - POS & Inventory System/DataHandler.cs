using System;
using System.Collections;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakTrack___POS___Inventory_System
{
    public class DataHandler
    {
        private MainSystem sys;
        private UserAuth ua;

        public DataHandler(MainSystem system)
        {
            this.sys = system;
            this.ua = system.UA;
        }

        public string selectQuery(string table, string column, string condition)
        {
            return $"SELECT {column} FROM [{table}] WHERE {condition}";
        }

        public string selectQuery(string table)
        {
            return $"SELECT * FROM [{table}]";
        }

        // idk sa database sya parang path nung server
        string conString = @"Data Source =.\SCHOOLSERVER; Initial Catalog = SneakTrackDB; Integrated Security = True;";

        // Returns an 3d ArrayList of data from the database
        public ArrayList getData(string query)
        {
            ArrayList data = new ArrayList();

            try
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ArrayList row = new ArrayList();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row.Add(reader[i]);
                    }

                    data.Add(row);
                }

                reader.Close();
                conn.Close();

            }

            catch (Exception e)
            {
                Debug.WriteLine($"Error: {e.Message}");
            }

            //test
            /*
            foreach (Object o in data)
            {
                Debug.WriteLine(o);
                foreach(var item in (ArrayList)o)
                {
                    Debug.WriteLine(item.ToString());
                }
            }
            */

            return data;
        }

        // Checks if user exists and credentials are correct
        public UserAuth.User checkUserAuth(string username)
        {
            string name = "", role = "", dateCreated = "", password = "";

            try
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE Username = @username", conn);
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    name = reader["name"].ToString();
                    role = reader["role"].ToString();
                    dateCreated = reader["date_created"].ToString();
                    password = reader["password"].ToString();
                }

                reader.Close();
                conn.Close();

            }

            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message); 
            }

            return new UserAuth.User(username, password, name, role, dateCreated);
        }

    }
}
