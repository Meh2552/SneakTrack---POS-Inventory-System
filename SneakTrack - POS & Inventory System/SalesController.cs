using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SneakTrack___POS___Inventory_System.UserAuth;

namespace SneakTrack___POS___Inventory_System
{
    public class SalesController
    {
        private MainSystem sys;
        private Validator v;
        private DataHandler dh;
        private UserAuth ua;

        private List<Sale> sales;
        private DataTable salesTable;

        public SalesController(MainSystem system)
        {
            this.sys = system;
            this.dh = this.sys.DH;
            this.v = this.sys.VAL;
            this.ua = this.sys.UA;

            initialize();
        }

        public List<Sale> Sales { get { return sales; } }

        private void initialize()
        {
            loadSaleLists();
        }

        private void loadSaleLists()
        {
            List<Sale> salesList = new List<Sale>();

            int saleID, userID;
            decimal total_amount;
            string date;

            try
            {
                salesTable = dh.dtFromTable(dh.selectQuery("Sales") + " ORDER BY sale_id");

                foreach (DataRow dr in salesTable.Rows)
                {
                    saleID = (int)dr["sale_id"];
                    userID = (int)dr["user_id"];
                    total_amount = (decimal)dr["total_amount"];
                    date = dr["date"].ToString();

                    DataTable nameTable = dh.dtFromTable(dh.selectQuery("User", "*", $"user_id = {userID}"));
                    string name = nameTable.Rows[0]["name"].ToString();
                    Sale sale = new Sale(saleID, userID, name, total_amount, date);

                    DataTable salesItems = dh.dtFromTable(dh.selectQuery("Sales_Item", "*", $"sale_id = {saleID}") + " ORDER BY sales_item_id");
                    foreach (DataRow dtrow in salesItems.Rows)
                    {
                        sale.addItem(toSaleItem(dtrow));
                    }

                    salesList.Add(sale);
                }
            }
            catch { }

            sales = salesList;
        }

        private SaleItem toSaleItem(DataRow dr)
        {
            int salesItemID, productID, quantity;
            double size;
            decimal price;
            string sizeType;
            char gender;

            try
            {
                salesItemID = (int)dr["sales_item_id"];
                productID = (int)dr["product_id"];
                size = (double)dr["size"];
                sizeType = dr["size_type"].ToString();
                quantity = (int)dr["quantity"];
                price = (decimal)dr["price"];
                gender = dr["gender"].ToString()[0];

                return new SaleItem(salesItemID, productID, size, sizeType, quantity, gender, price);
            }

            catch 
            { 
                return new SaleItem();
            }
        }

        public Sale saleFromID(int saleID)
        {
            Sale output = null;

            foreach(Sale sl in sales)
            {
                if (sl?.SaleID == saleID) return sl;
            }

            return output;
        }
    }

    public class Sale
    {
        private int saleID;
        private int userID;
        private decimal payment;
        private string date;

        private List<SaleItem> saleItems;

        public Sale(int saleID, int userID, string user, decimal payment, string date) 
        { 
            this.saleID = saleID;
            this.userID = userID;
            this.payment = payment;
            this.date = date;
        }

        public int SaleID { get { return saleID; } }
        public int UserID { get { return userID; } }
        public decimal Payment { get { return payment; } }

        public string Date
        {
            get
            {
                string[] dates = this.date.Split(' ');
                return dates[0];
            }
        }

        public List<SaleItem> SaleItems { get { return saleItems; } }
        public string orderID { get { return $"O-{saleID.ToString("0000")}"; } }
        public decimal revenue 
        { 
            get 
            {   
                decimal total = 0;
                foreach(SaleItem item in saleItems)
                {
                    total += item.Quantity * item.Price;
                }
                return total; 
            } 
        }

        public void addItem(SaleItem item) 
        { 
            if (saleItems == null) saleItems = new List<SaleItem>();
            saleItems.Add(item); 
        }
    }

    public struct SaleItem
    {
        private int saleItemID;
        private int productID;
        private double size;
        private string sizeType;
        private int quantity;
        private char gender;
        private decimal price;

        public SaleItem(int saleItemID, int productID, double size, string sizeType, int quantity, char gender, decimal price)
        {
            this.saleItemID = saleItemID;
            this.productID = productID;
            this.size = size;
            this.sizeType = sizeType.ToUpper();
            this.quantity = quantity;
            this.gender = gender.ToString().ToUpper()[0];
            this.price = price;
        }

        public int SaleItemID { get { return saleItemID; }}
        public int ProductID { get { return productID; }}
        public double Size { get { return size; }}
        public string SizeType { get { return sizeType; }}
        public int Quantity { get { return quantity; }}
        public char Gender { get { return gender; }}
        public decimal Price { get { return price; }}
    }
}
