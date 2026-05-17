using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakTrack___POS___Inventory_System
{
    public class Product
    {

        private int prodId;
        private string brand;
        private string color;
        private Image image;
        private string description;
        private List<Variant> variants= new List<Variant>();

        public Product(int prodId, int id, string brand, string color,
                  string description, Image image)
        {
            this.prodId = prodId;
            this.brand = brand;
            this.color = color;
            this.image = image;
            this.description = description;
        }

        public int ProdId { get { return prodId; } set { prodId = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
        public string Color { get { return color; } set { color = value; } }
        public Image Image { get { return image; } set { image = value; } }
        public string Description { get { return description; } set { description = value; } }

        public class Variant
        {
            private int size;
            private char sizeType;
            private int quantity;
            private string barcode;
            private char gender;
            private bool forSale;

            public Variant(int size, char sizeType, int quantity, string barcode, char gender, bool forSale)
            {
                this.size = size;
                this.sizeType = sizeType;
                this.quantity = quantity;
                this.barcode = barcode;
                this.gender = gender;
                this.forSale = forSale;
            }

            public int Size { get { return size; } set { size = value; } }
            public char SizeType { get { return sizeType; } set { sizeType = value; } }
            public int Quantity { get { return quantity; } set { quantity = value; } }
            public string Barcode { get { return barcode; } set { barcode = value; } }
            public char Gender { get { return gender; } set { gender = value; } }
            public bool ForSale { get { return forSale; } set { forSale = value; } }
        }
    }
}
