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

    public struct ProductVar
    {
        private int prodId;
        private int id;
        private decimal price;
        private int quantity;
        private string description;
        private string category;
        private int size;
        private char sizeType;
        private string barcode;

        public ProductVar(int prodId, int id, decimal price, int quantity,
                          string description, string category, int size,
                          char sizeType, string barcode)
        {
            this.prodId = prodId;
            this.id = id;
            this.price = price;
            this.quantity = quantity;
            this.description = description;
            this.category = category;
            this.size = size;
            this.sizeType = sizeType;
            this.barcode = barcode;
        }

        public int ProdId { get { return prodId; } set { prodId = value; } }
        public int Id { get { return id; } set { id = value; } }
        public decimal Price { get { return price; } set { price = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Category { get { return category; } set { category = value; } }
        public int Size { get { return size; } set { size = value; } }
        public char SizeType { get { return sizeType; } set { sizeType = value; } }
        public string Barcode { get { return barcode; } set { barcode = value; } }
    }

    public struct Product
    {
        private int id;
        private string name;
        private string brand;
        private bool forSale;

        public Product(int id, string name, string brand, bool forSale)
        {
            this.id = id;
            this.name = name;
            this.brand = brand;
            this.forSale = forSale;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Brand { get {  return brand; } set { brand = value; } }
        public bool ForSale { get { return forSale; } set { forSale = value; } }
    }
}
