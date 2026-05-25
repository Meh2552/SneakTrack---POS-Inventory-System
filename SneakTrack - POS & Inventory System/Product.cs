using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System
{
    public class Product
    {

        private int prodId;
        private string name;
        private string brand;
        private string color;
        private Image image = null;
        private string imagePath = null;
        private string description;
        private int brandId;
        private bool archived = false; //TODO: this
        private List<Variant> variants = new List<Variant>();

        private bool hasMale = false, hasFemale = false, hasUnisex = false;

        public Product(int prodId, string name, string brand, int brandId, string color,
                  string description, string imagePath)
        {
            this.prodId = prodId;
            this.name = name;
            this.brand = brand;
            this.color = color;
            this.image = setImagePath(imagePath);
            this.description = description;
            this.brandId = brandId;
        }

        public Product(string name, string brand, string color, string description, string imagePath = null)
        {
            this.prodId = -1;
            this.name = name;
            this.brand = brand;
            this.color = color;
            this.description = description;
            this.brandId = -1;
            this.image = imagePath == null ? null : setImagePath(imagePath);
            this.imagePath = imagePath;
        }

        public int ProdId { get { return prodId; } set { prodId = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
        public string Color { get { return color; } set { color = value; } }

        public Image Image
        {
            get 
            {
                if (this.image == null)
                {
                    return Properties.Resources.sport_shoe;
                }
                else
                {
                    return this.image;
                }
            }


        }

        public Image setImagePath(string imagePath)
        {
            try
            {
                Debug.WriteLine($"Loading image from path: {imagePath}");
                return Image.FromFile(imagePath);
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
                return null;
            }
        }

        public string newImageFileName(int productId)
        {
            string output = string.Format("PID_{0}-{1}{2}{3}",
                productId,
                Name?[0].ToString().ToUpper() ?? "N",
                Color?[0].ToString().ToUpper() ?? "C",
                Brand?[0].ToString().ToUpper() ?? "B"
            );
            return output;
        }

        public string Description { get { return description; } set { description = value; } }
        public int BrandId { get { return brandId; } set { brandId = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string ImagePath { get { return imagePath; } set { imagePath = value; } }
        public List<Variant> Variants { get { return variants; } }

        public int totalQuantity()
        {
            if (Variants != null)
            {
                int total = 0;
                foreach (var variant in Variants)
                {
                    total += variant.Quantity;
                }
                return total;
            }

            return 0;
        }

        public string DisplayName()
        {
            return $"{Name} - {Color}";
        }

        public string variantsString()
        {
            bool comma = false;
            string output = string.Empty;

            if (hasMale)
            {
                output += "M";
                comma = true;
            }

            if (hasFemale)
            {
                output += comma ? " ,F" : "F";
                comma = true;
            }

            if (hasUnisex)
            {
                output += comma ? " ,U" : "U";
                comma = true;
            }

            return output;
        }

        public void addVariant(Variant variant)
        {
            variants.Add(variant);
            checkVariantGender(variant);
        }

        public decimal displayPrice()
        {
            try
            {
                return Variants.First().Price;
            }

            catch (Exception e) {}

            return 0;
        }

        private void checkVariantGender(Variant v)
        {
            switch(v.Gender) {

                case 'M':
                this.hasMale = true;
                break;

                case 'F':
                this.hasFemale = true;
                break;

                case 'U':
                this.hasUnisex = true;
                break;

            }
        }

    }

    public class Variant
    {
        private int variantId;
        private int sizeId;
        private double size;
        private string sizeType;
        private int quantity;
        private string barcode;
        private char gender;
        private bool forSale;
        private decimal price;

        public Variant(double size, string sizeType, int quantity, string barcode, char gender, 
                       bool forSale, decimal price, int variant_id, int size_id)
        {
            this.size = size;
            this.sizeType = sizeType;
            this.quantity = quantity;
            this.barcode = barcode;
            this.gender = gender;
            this.forSale = forSale;
            this.price = price;
            this.variantId = variant_id;
            this.sizeId = size_id;
        }

        public Variant(double size, string sizeType, int quantity, string barcode, char gender, decimal price)
        {
            this.size = size;
            this.sizeType = sizeType;
            this.quantity = quantity;
            this.barcode = barcode;
            this.gender = gender;
            this.forSale = true;
            this.price = price;
            this.variantId = -1;
            this.sizeId = -1;
        }

        public double Size { get { return size; } set { size = value; } }
        public string SizeType { get { return sizeType; } set { sizeType = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public string Barcode { get { return barcode; } set { barcode = value; } }
        public char Gender { get { return gender; } set { gender = value; } }
        public bool ForSale { get { return forSale; } set { forSale = value; } }
        public decimal Price { get { return price; } set { price = value; } }
        public int VariantId { get { return variantId; } set { variantId = value; } }
        public int SizeId { get { return sizeId; } set { sizeId = value; } }
    }
}
