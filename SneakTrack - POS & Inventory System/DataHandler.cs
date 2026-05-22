using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System
{
    public class DataHandler
    {
        private MainSystem sys;
        private UserAuth ua;
        private DataTable productMasterList;
        private List<Product> masterToProductList;

        private List<string> colorList;
        private List<string> brandList;
        private List<double> sizeList;

        public DataHandler() { }

        public DataHandler(MainSystem system)
        {
            this.sys = system;
            this.ua = system.UA;
            loadMasterList();
        }

        public string selectQuery(string table, string column, string condition)
        {
            return $"SELECT {column} FROM [{table}] WHERE {condition}";
        }

        public string selectQuery(string table, string column)
        {
            return $"SELECT {column} FROM [{table}]";
        }

        public string selectQuery(string table)
        {
            return $"SELECT * FROM [{table}]";
        }

        private string joinAllQuery()
        {
            string output = "INNER JOIN Product_Variants " +
                "ON Product.product_id = Product_Variants.product_id " +
                "LEFT JOIN Size ON Product_Variants.variant_id = Size.variant_id " +
                "LEFT JOIN Brand ON Product.brand_id = Brand.brand_id " +
                "LEFT JOIN Color ON Product.color_id = Color.color_id ";
            return output;
        }

        // idk sa database sya parang path nung server
        string conString = @"Data Source =.; Initial Catalog = SneakTrackDB; Integrated Security = True; Encrypt = False;";

        public DataTable ProductMasterList { get { return this.productMasterList; } }
        public List<Product> MasterToProductList { get { return this.masterToProductList; } }
        public List<string> ColorList { get { return this.colorList; } set { this.colorList = value; } }
        public List<string> BrandList { get { return this.brandList; } set { this.brandList = value; } }
        public List<double> SizeList { get { return this.sizeList; } set { this.sizeList = value; } }

        private void loadMasterList()
        {
            string query = $"{String.Concat(selectQuery("Product"),joinAllQuery())} WHERE Product.archived = 0 ORDER BY Product.brand_id";
            this.productMasterList = dataToTable(query);
            this.masterToProductList = toProducts(this.productMasterList);
            loadInfoLists();
        }

        private void loadInfoLists()
        {
            string query = selectQuery("Color", "color_name");
            DataTable dt = dataToTable(query);
            List<string> colors = new List<string>();

            foreach (DataRow dr in dt.Rows)
            {
                colors.Add(dr["color_name"].ToString());
            }

            ColorList = colors;


            query = selectQuery("Brand", "brand_name");
            dt = dataToTable(query);
            List<string> brands = new List<string>();

            foreach (DataRow dr in dt.Rows)
            {
                brands.Add(dr["brand_name"].ToString());
            }

            BrandList = brands;


            query = selectQuery("Size", "DISTINCT size");
            dt = dataToTable(query);
            List<double> sizes = new List<double>();

            foreach (DataRow dr in dt.Rows)
            {
                sizes.Add(Convert.ToDouble(dr["size"]));
            }

            SizeList = sizes;
        }

        // Returns a datatable of a table in the database.
        public DataTable dataToTable(string query)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                

                /* For testing /
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        Debug.Write(row[col] + "\t");
                    }
                    Debug.WriteLine("");
                }
                */

                return dt;
            }

            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
                return null;
            }
        }

        // Checks if user exists and credentials are correct
        public UserAuth.User checkUserAuth(string username)
        {
            string name = "", role = "", dateCreated = "", password = "";

            try
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();

                SqlCommand cmd = new SqlCommand(selectQuery("User", "*", "Username = @username"), conn);
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

        // Used to get Products
        public List<Product> toProducts(DataTable table)
        {

            List<int> listed = new List<int>();
            List<Product> products = new List<Product>();

            foreach (DataRow dr in table.Rows) {

                int id = Convert.ToInt32(dr["product_id"]);
                if (!products.Count.Equals(0) && listed.Contains(id))
                {
                    products.ElementAt(listed.IndexOf(id)).addVariant
                    (
                        rowToVariant(dr)
                    );
                }

                else
                {
                    Product p = rowToProduct(dr);
                    p.addVariant(rowToVariant(dr));

                    listed.Add(id);
                    products.Add(p);
                }

                
            }

            return products;
        }

        public Product rowToProduct(DataRow dr)
        {
            Product p = new Product
            (
                (int)dr["product_id"],
                dr["product_name"].ToString(),
                dr["brand_name"].ToString(),
                (int)dr["brand_id"],
                dr["color_name"].ToString(),
                dr["description"].ToString(),
                dr["image"].ToString()
            );

            return p;
        }

        public Variant rowToVariant(DataRow dr)
        {
            Variant v = new Variant
            (
                (double)dr["size"],
                dr["size_type"].ToString(),
                (int)dr["quantity"],
                dr["barcode"].ToString(),
                (char)(dr["gender"].ToString()[0]),
                (bool)dr["for_sale"],
                (decimal)dr["price"],
                (int)dr["variant_id"],
                (int)dr["size_id"]
            );

            return v;
        }

    }
}
