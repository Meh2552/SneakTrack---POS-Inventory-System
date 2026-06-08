using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;

namespace SneakTrack___POS___Inventory_System
{
    public class DataHandler
    {
        private MainSystem sys;
        private UserAuth ua;
        private FileHandler fh;
        private DataTable productMasterDT;
        private List<Product> masterToProductList;

        private List<string> colorList;
        private List<string> brandList;
        private List<double> sizeList;
        private List<string> sizeTypesList; 

        public DataHandler() { }

        public DataHandler(MainSystem system)
        {
            this.sys = system;
            this.ua = system.UA;
            this.fh = system.FH;
            
        }

        public void initialize() 
        {
            this.ua = sys.UA;
            this.fh = sys.FH;
            loadMasterList();
        }

        public string selectQuery(string table, string column, string condition, string join)
        {
            return $"SELECT {column} FROM [{table}] {join} WHERE {condition}";
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
                "INNER JOIN Size ON Product_Variants.variant_id = Size.variant_id " +
                "LEFT JOIN Brand ON Product.brand_id = Brand.brand_id " +
                "LEFT JOIN Color ON Product.color_id = Color.color_id ";
            return output;
        }

        public string insertQuery(string table, string columns, string values, bool returnId = false)
        {
            return $"INSERT INTO [{table}] ({columns}) VALUES ({values})" + (returnId ? "; SELECT SCOPE_IDENTITY();" : "");
        }

        public string updateQuery(string table, string setClause, string condition)
        {
            return $"UPDATE [{table}] SET {setClause} WHERE {condition}";
        }

        // idk sa database sya parang path nung server
        string conString = @"Data Source =.; Initial Catalog = SneakTrackDB; Integrated Security = True; Encrypt = False;";

        public DataTable ProductMasterDT { get { return this.productMasterDT; } }
        public List<Product> MasterToProductList { get { return this.masterToProductList; } }
        public List<string> ColorList { get { return this.colorList; } set { this.colorList = value; } }
        public List<string> BrandList { get { return this.brandList; } set { this.brandList = value; } }
        public List<double> SizeList { get { return this.sizeList; } set { this.sizeList = value; } }
        public List<string> SizeTypesList { get { return this.sizeTypesList; } set { this.sizeTypesList = value; } }

        public void loadMasterList()
        {
            string query = $"{String.Concat(selectQuery("Product"), joinAllQuery())} WHERE Product.archived = 0 ORDER BY Product.brand_id";
            this.productMasterDT = dtFromTable(query);
            this.masterToProductList = toProducts(this.productMasterDT);
            loadInfoLists();
        }

        private void loadInfoLists()
        {
            string query = selectQuery("Color", "color_name");
            DataTable dt = dtFromTable(query);
            List<string> colors = new List<string>();

            foreach (DataRow dr in dt.Rows)
            {
                colors.Add(dr["color_name"].ToString());
            }

            ColorList = colors;


            query = selectQuery("Brand", "brand_name");
            dt = dtFromTable(query);
            List<string> brands = new List<string>();

            foreach (DataRow dr in dt.Rows)
            {
                brands.Add(dr["brand_name"].ToString());
            }

            BrandList = brands;


            query = selectQuery("Size", "DISTINCT size");
            dt = dtFromTable(query);
            List<double> sizes = new List<double>();

            foreach (DataRow dr in dt.Rows)
            {
                sizes.Add(Convert.ToDouble(dr["size"]));
            }

            SizeList = sizes;

            query = selectQuery("Size", "DISTINCT size_type");
            dt = dtFromTable(query);
            List<string> sizeTypes = new List<string>();

            foreach (DataRow dr in dt.Rows)
            {
                sizeTypes.Add(dr["size_type"].ToString());
            }

            SizeTypesList = sizeTypes;
        }

        public string getValueFromTable(string query)
        {
            string output = "";
            try
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    output = reader[0].ToString();
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
            }
            return output;
        }

        public bool hasDuplicateProduct(string productName, string brandName, string colorName, string prodId = null)
        {
            bool output = false;
            try
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();

                bool allParams = prodId != null;
                string whereClause = allParams ?
                    $"(Product.product_name = @productName AND Brand.brand_name = @brandName AND Color.color_name = @colorName) AND " +
                    $"Product.product_id != @prodId" :
                    $"Product.product_name = @productName AND Brand.brand_name = @brandName AND Color.color_name = @colorName";

                string query = selectQuery("Product", "COUNT(*)",
                    whereClause, joinAllQuery());

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@productName", productName);
                cmd.Parameters.AddWithValue("@brandName", brandName);
                cmd.Parameters.AddWithValue("@colorName", colorName);

                if (allParams)
                {
                    cmd.Parameters.AddWithValue("@prodId", prodId);
                }

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                output = count > 0;
                conn.Close();

            }
            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);

            }
            return output;
        }

        public bool hasDuplicateUsername(string userID, string username, bool ignoreSelf = false)
        {
            bool output = false;
            try
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();

                string whereClause = ignoreSelf ? $"username = @username AND user_id != {userID}" :
                    "username = @username";

                string query = selectQuery("User", "*", whereClause);

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                Debug.WriteLine(cmd.CommandText);


                int count = Convert.ToInt32(cmd.ExecuteScalar());
                output = count > 0;
                conn.Close();
            }

            catch (Exception e)
            {
                Debug.WriteLine("hasDpUser Error: " + e.Message);

            }
            return output;
        }
        
        public bool updateValueToTable(string query, string parameterName, string parameterValue)
        {
            bool output = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(parameterName, parameterValue ?? (object)DBNull.Value);
                        Debug.WriteLine($"{parameterName} = {parameterValue}\n{cmd.CommandText}");
                        cmd.ExecuteNonQuery();
                        output = true;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
            }
            return output;
        }

        public bool deleteValueFromTable(string table, string condition)
        {
            bool output = false;
            string query = $"DELETE FROM [{table}] WHERE {condition}";
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        Debug.WriteLine($"{cmd.CommandText}");
                        cmd.ExecuteNonQuery();
                        output = true;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
            }
            return output;
        }

        // Returns a datatable of a table in the database.
        public DataTable dtFromTable(string query)
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

                return dt;
            }

            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
                return null;
            }
        }

        public DataTable searchTables(string search)
        {
            string query = $"{String.Concat(selectQuery("Product"), joinAllQuery())} " +
                $"WHERE Product.archived = 0 AND (Product.product_name LIKE @search " +
                $"OR Brand.brand_name LIKE @search OR Color.color_name LIKE @search" +
                $"OR Size.size_name LIKE @search OR Product_Variants.gender LIKE @search" +
                $"OR Product.description LIKE @search) ORDER BY Product.brand_id";

            DataTable output = new DataTable();

            try
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(output);
                conn.Close();
            }

            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
            }
            return output;
        }

        // Checks if user exists
        public UserAuth.User checkUserAuth(string username)
        {
            string name = "", role = "", dateCreated = "", password = "", id = "";

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
                    id = reader["user_id"].ToString();
                }

                reader.Close();
                conn.Close();

            }

            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
            }

            return new UserAuth.User(username, password, name, role, dateCreated, id);
        }

        // Used to get Products
        public List<Product> toProducts(DataTable table)
        {

            List<int> listed = new List<int>();
            List<Product> products = new List<Product>();

            foreach (DataRow dr in table.Rows)
            {

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
                dr["image"].ToString(),
                (bool)dr["for_sale"]
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
                (decimal)dr["price"],
                (int)dr["variant_id"],
                (int)dr["size_id"]
            );

            return v;
        }

        public int toBrandDB(Product p)
        {
            string query = insertQuery("Brand", "brand_name", "@brand_name", true);
            int brandId = 0;

            try
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@brand_name", p.Brand);
                Debug.Write(cmd.CommandText);
                brandId = Convert.ToInt32(cmd.ExecuteScalar());

                conn.Close();
            }

            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
            }

            return brandId;
        }

        public int toColorDB(Product p)
        {
            string query = insertQuery("Color", "color_name", "@color_name", true);
            int colorId = 0;
            try
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@color_name", p.Color);
                colorId = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
            }
            return colorId;
        }

        public int toProductDB(Product p, int brandId, int colorId)
        {
            bool hasDescription = !String.IsNullOrEmpty(p.Description);
            bool hasImage = !String.IsNullOrEmpty(p.ImagePath);

            string values = "@product_name, @brand_id, @color_id" +
                (hasDescription ? ", @description" : "") +
                (hasImage ? ", @image" : "");

            string columns = "product_name, brand_id, color_id" +
                (hasDescription ? ", description" : "") +
                (hasImage ? ", image" : "");

            string query = insertQuery("Product", columns, values, true);

            int productId = 0;
            try
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@product_name", p.Name);
                cmd.Parameters.AddWithValue("@brand_id", brandId);
                cmd.Parameters.AddWithValue("@color_id", colorId);
                if (hasDescription) cmd.Parameters.AddWithValue("@description", p.Description);
                if (hasImage) cmd.Parameters.AddWithValue("@image", p.ImagePath);

                productId = Convert.ToInt32(cmd.ExecuteScalar());
                Debug.WriteLine($"Product ID: {productId} = {cmd.CommandText}");

                if (hasImage) updateImage(p.ImagePath, productId, p.newImageFileName(productId));

                conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
            }

            return productId;
        }

        public void updateImage(string imagePath, int productId, string filename)
        {
            try
            {
                if (imagePath == null) return;

                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                SqlCommand updateCmd = new SqlCommand(updateQuery("Product", "image = @image", "product_id = @product_id"), conn);

                updateCmd.Parameters.AddWithValue("@image", fh.imagePathtoFile(imagePath, filename));
                updateCmd.Parameters.AddWithValue("@product_id", productId);
                updateCmd.ExecuteNonQuery();
               
                Debug.WriteLine(updateCmd.CommandText + " Updated");
                
                conn.Close();
            }

            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
            }
        }

        public int toVariantDB(Variant v, int productId)
        {
            string query = insertQuery("Product_Variants", "product_id, gender, price", "@product_id,  @gender, @price", true);
            int variantId = 0;
            try
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@product_id", productId);
                cmd.Parameters.AddWithValue("@gender", v.Gender);
                cmd.Parameters.AddWithValue("@price", v.Price);

                variantId = Convert.ToInt32(cmd.ExecuteScalar());

                conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
            }

            return variantId;
        }

        public int toSizeDB(Variant v, int variantId)
        {
            bool hasBarcode = !String.IsNullOrEmpty(v.Barcode);

            string values = "@variant_id, @size, @size_type, @quantity" + (hasBarcode ? ", @barcode" : "");
            string columns = "variant_id, size, size_type, quantity" + (hasBarcode ? ", barcode" : "");

            string query = insertQuery("Size", columns, values, true);
            int sizeId = 0;
            try
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@variant_id", variantId);
                cmd.Parameters.AddWithValue("@size", v.Size);
                cmd.Parameters.AddWithValue("@size_type", v.SizeType);
                cmd.Parameters.AddWithValue("@quantity", v.Quantity);
                if (hasBarcode) cmd.Parameters.AddWithValue("@barcode", v.Barcode);
                sizeId = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
            }
            return sizeId;
        }

        public int toUserDB(UserAuth.User user)
        {
            string query = insertQuery("User", "name, username, password, role", "@name, @username, @password, @role", true);
            int userId = 0;
            try
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@role", user.Role);

                userId = Convert.ToInt32(cmd.ExecuteScalar());

                conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error: " + e.Message);
            }

            return userId;
        }
    }
}
