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
        private string name;
        private string brand;
        private string color;
        private Image image;
        private string description;
        private int brand_id;
        private List<Variant> variants = new List<Variant>();

        public Product(int prodId, string name, string brand, int brand_id, string color,
                  string description, string imagePath)
        {
            this.prodId = prodId;
            this.name = name;
            this.brand = brand;
            this.color = color;
            this.image = setImagePath(imagePath);
            this.description = description;
            this.brand_id = brand_id;
        }

        public int ProdId { get { return prodId; } set { prodId = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
        public string Color { get { return color; } set { color = value; } }

        public Image Image {
            get { return image; }
        }

        public Image setImagePath(string imagePath)
        {
            try
            {
                return Image.FromFile(imagePath);
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
                return null;
            }
        }

        public string Description { get { return description; } set { description = value; } }
        public int BrandId { get { return brand_id; } set { brand_id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public List<Variant> Variants { get { return variants; } }

        public void addVariant(Variant variant)
        {
            variants.Add(variant);
        }

    }

    public class Variant
    {
        private double size;
        private string sizeType;
        private int quantity;
        private string barcode;
        private char gender;
        private bool forSale;
        private decimal price;

        public Variant(double size, string sizeType, int quantity, string barcode, char gender, bool forSale, decimal price)
        {
            this.size = size;
            this.sizeType = sizeType;
            this.quantity = quantity;
            this.barcode = barcode;
            this.gender = gender;
            this.forSale = forSale;
            this.price = price;
        }

        public double Size { get { return size; } set { size = value; } }
        public string SizeType { get { return sizeType; } set { sizeType = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public string Barcode { get { return barcode; } set { barcode = value; } }
        public char Gender { get { return gender; } set { gender = value; } }
        public bool ForSale { get { return forSale; } set { forSale = value; } }
        public decimal Price { get { return price; } set { price = value; } }
    }
}
