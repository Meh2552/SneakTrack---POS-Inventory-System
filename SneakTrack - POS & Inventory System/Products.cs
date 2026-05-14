using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakTrack___POS___Inventory_System
{
    public class Products : DataHandler
    {
        private MainSystem sys;

        public Products(MainSystem system) : base(system)
        {
            this.sys = system;
        }
    }

    public struct Product
    {
        private int prodId;
        private string name;
        private decimal price;
        private int quantity;
        private string description;
        private string category;
        private int size;
        private string sizeType;
        private string barcode;
        private bool forSale;

        public Product(int prodId, string name, decimal price, int quantity,
                       string description, string category, int size,
                       string sizeType, string barcode, bool forSale)
        {
            this.prodId = prodId;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.description = description;
            this.category = category;
            this.size = size;
            this.sizeType = sizeType;
            this.barcode = barcode;
            this.forSale = forSale;
        }

        public int ProdId { get { return prodId; } set { prodId = value; } }
        public string Name { get { return name; } set { name = value; } }
        public decimal Price { get { return price; } set { price = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Category { get { return category; } set { category = value; } }
        public int Size { get { return size; } set { size = value; } }
        public string SizeType { get { return sizeType; } set { sizeType = value; } }
        public string Barcode { get { return barcode; } set { barcode = value; } }
        public bool ForSale { get { return forSale; } set { forSale = value; } }
    }
}
