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
        private bool lowStock;
        private List<Variant> variants = new List<Variant>();
        private bool forSale;

        private bool hasMale = false, hasFemale = false, hasUnisex = false;

        public Product(int prodId, string name, string brand, int brandId, string color,
                  string description, string imagePath, bool forSale)
        {
            this.prodId = prodId;
            this.name = name;
            this.brand = brand;
            this.color = color;
            this.image = setImagePath(imagePath);
            this.imagePath = imagePath;
            this.description = description;
            this.brandId = brandId;
            this.forSale = forSale;
        }

        public Product(string name, string brand, string color, string description, string imagePath = null, bool forSale = true)
        {
            this.prodId = -1;
            this.name = name;
            this.brand = brand.ToUpper();
            this.color = color.ToUpper();
            this.description = description;
            this.brandId = -1;
            this.image = imagePath == null ? null : setImagePath(imagePath);
            this.imagePath = imagePath;
            this.forSale = true;
        }

        public int ProdId { get { return prodId; } set { prodId = value; } }
        public string Brand { get { return brand; } set { brand = value.ToUpper(); } }
        public string Color { get { return color; } set { color = value.ToUpper(); } }
        public bool Archived { get { return archived; } set { archived = value; } }
        public bool HasMale { get { return hasMale; } }
        public bool HasFemale { get { return hasFemale; } }
        public bool HasUnisex { get { return hasUnisex; } }

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
            Image output = null;
            if (imagePath == null || string.IsNullOrWhiteSpace(imagePath)) return null;

            try
            {
                Debug.WriteLine($"Loading image from path: {imagePath}");
                output = Image.FromFile(imagePath);
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
                return null;
            }
            return output;
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
        public string ImagePath { get { return imagePath; }

            set { 
                imagePath = value;
                if (imagePath == null && string.IsNullOrWhiteSpace(imagePath))setImagePath(value);
            } 
        }
        public List<Variant> Variants { get { return variants; } }
        public bool LowStock { get { return lowStock; } set { lowStock = value; } }
        public bool ForSale { get { return forSale; } set { forSale = value; } }

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

        public string gendersString()
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

        public string gendersStringFull()
        {
            bool comma = false;
            string output = string.Empty;

            if (hasMale)
            {
                output += "Male";
                comma = true;
            }

            if (hasFemale)
            {
                output += comma ? " ,Female" : "Female";
                comma = true;
            }

            if (hasUnisex)
            {
                output += comma ? " ,Unisex" : "Unisex";
                comma = true;
            }

            return output;
        }

        public List<char> genderArray()
        {
            List<char> genders = new List<char>();

            if (hasMale)
                genders.Add('M');

            if (hasFemale)
                genders.Add('F');

            if (hasUnisex)
                genders.Add('U');

            return genders;
        }

        public Variant getMaleVariant()
        {
            Variant variant = null;

            foreach (Variant var in Variants)
            {
                if (var.Gender == 'M') return var;
            }

            return variant;
        }

        public Variant getFemaleVariant()
        {
            Variant variant = null;

            foreach (Variant var in Variants)
            {
                if (var.Gender == 'F') return var;
            }

            return variant;
        }

        public Variant getUnisexVariant()
        {
            Variant variant = null;

            foreach (Variant var in Variants)
            {
                if (var.Gender == 'U') return var;
            }

            return variant;
        }

        public Variant fromVariantId(int id)
        {
            Variant output = null;
            foreach (Variant variant in variants)
            {
                if (variant.VariantId == id) return variant;
            }
            return output;
        }

        public Variant fromSizeId(int id)
        {
            Variant output = null;
            foreach (Variant variant in variants)
            {
                if (variant.SizeId == id) return variant;
            }
            return output;
        }

        public void addVariant(Variant variant)
        {
            variants.Add(variant);
            checkVariantGender(variant);
            checkLowStock(variant);
        }

        public decimal displayPrice()
        {
            try
            {
                return Variants.First().Price;
            }

            catch (Exception e) { }

            return 0;
        }

        public decimal mPrice()
        {
            decimal price = 0;

            foreach (Variant var in Variants)
            {
                if (var.Gender == 'M') return var.Price;
            }

            return price;
        }
        public decimal fPrice()
        {
            decimal price = 0;

            foreach (Variant var in Variants)
            {
                if (var.Gender == 'F') return var.Price;
            }
            Debug.WriteLine(price);
            return price;
        }
        public decimal uPrice()
        {
            decimal price = 0;

            foreach (Variant var in Variants)
            {
                if (var.Gender == 'U') return var.Price;
            }

            return price;
        }

        private void checkVariantGender(Variant v)
        {
            if (v.Remove) return;
            switch (v.Gender)
            {

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

        public void recheckValues()
        {
            if (Variants.Count == 0) return;

            this.hasMale = false;
            this.hasFemale = false;
            this.hasUnisex= false;

            foreach (Variant vari in Variants)
            {
                checkVariantGender(vari);
                checkLowStock(vari);
            }
        }

        private void checkLowStock(Variant v)
        {
            this.lowStock = v.Quantity <= 3;
        }

        public override string ToString()
        {
            string output = $"Product: {prodId}\n" +
                $"{name} - {color} from {brand} BID: {brandId}\n" +
                $"Variants Loaded: {variants.Count} - M? {hasMale}, F? {hasFemale}, U? {hasUnisex}\n" +
                $"Low Stock - {lowStock} | For Sale: {forSale}\n" +
                $"Desc: {description} \nImPath: {imagePath}";
            return output;
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
        private decimal price;
        private bool remove = false;

        public Variant(double size, string sizeType, int quantity, string barcode, char gender, 
                       decimal price, int variant_id, int size_id)
        {
            this.size = size;
            this.sizeType = sizeType.ToUpper();
            this.quantity = quantity;
            this.barcode = barcode;
            this.gender = gender.ToString().ToUpper()[0];
            this.price = price;
            this.variantId = variant_id;
            this.sizeId = size_id;
        }

        public Variant(double size, string sizeType, int quantity, string barcode, char gender, decimal price)
        {
            this.size = size;
            this.sizeType = sizeType.ToUpper();
            this.quantity = quantity;
            this.barcode = barcode;
            this.gender = gender.ToString().ToUpper()[0];
            this.price = price;
            this.variantId = -1;
            this.sizeId = -1;
        }

        public double Size { get { return size; } set { size = value; } }
        public string SizeType { get { return sizeType; } set { sizeType = value.ToUpper(); } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public string Barcode { get { return barcode; } set { barcode = value; } }
        public char Gender { get { return gender; } set { gender = value.ToString().ToUpper()[0]; } }
        public decimal Price { get { return price; } set { price = value; } }
        public int VariantId { get { return variantId; } set { variantId = value; } }
        public int SizeId { get { return sizeId; } set { sizeId = value; } }
        public bool Remove { get { return remove; } set { remove = value; } }

        public override string ToString()
        {
            string output = $"Variant: {variantId} \n" +
                $"Size: {size} ({sizeType}, {gender}) - {quantity} items for {price} - {barcode}\n" + 
                $"SID: {sizeId} - Remove? {remove}";
            return output;
        }
    }
}
