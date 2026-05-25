using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System.UIControls
{
    public partial class ProductTile : UserControl
    {
        #region -> Fields
        private Image tileImage = null;
        private string topText = "BRAND";
        private string bottomText = "Product Name";
        private string price = "P 000,000.00";
        private Product productObj;
        private int prod_id; // mabye remove depending on changes

        private bool lowStock = false;
        #endregion

        public ProductTile()
        {
            InitializeComponent();

            loadControls();
        }

        public ProductTile(string brand, string name, string price, Image image, bool lowStock, int prod_id)
        {
            InitializeComponent();

            TopText = brand;
            BottomText = name;
            Price = price;
            TileImage = image;
            LowStock = lowStock;
            ProductID = prod_id;

            loadControls();
        }

        public ProductTile(Product pr)
        {
            InitializeComponent();

            TopText = pr.Brand;
            BottomText = pr.Name;
            Price = pr.Variants.First().Price.ToString();
            TileImage = pr.Image;
            LowStock = checkLowStock(pr);
            ProductID = pr.ProdId;

            loadControls();
        }

        public int ProductID
        {
            get { return prod_id; }
            set { prod_id = value; }
        }

        public Product ProductObj
        {
            get { return productObj; }
            set { productObj = value; }
        }

        public bool LowStock
        {
            get { return lowStock; }
            set 
            { 
                lowStock = value;
                setLowStock();
            }
        }

        private void forwardClicks(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                c.Click += (s, e) => this.OnClick(e);
                forwardClicks(c);
            }
        }

        private void loadControls()
        {
            forwardClicks(this);
            setLowStock();
        }

        #region -> Properties
        [Category("Appearance")]
        [Description("Gets or sets the text for the top label.")]
        public string TopText
        {
            get { return topText; }
            set
            {
                topText = value;
                lbTop.Text = value;
            }
        }

        [Category("Appearance")]
        [Description("Gets or sets the text for the bottom label.")]
        public string BottomText
        {
            get { return bottomText; }
            set
            {
                bottomText = value;
                lbBottom.Text = value;
            }
        }

        [Category("Appearance")]
        [Description("Gets or sets the text for the price label.")]
        public string Price
        {
            get { return price; }
            set
            {
                price = value;
                lbPrice.Text = value;
            }
        }

        [Category("Appearance")]
        [Description("Gets or sets the image for the picture box.")]
        public Image TileImage
        {
            get { return tileImage; }
            set 
            {
                this.tileImage = value;
                pictureBox1.Image = value;
            }
        }

        #endregion

        private void setLowStock()
        {
            pcbxLowStock.Visible = lowStock;
        }

        private bool checkLowStock(Product p)
        {
            if (p == null || p.Variants == null) return false;

            foreach (Variant v in p.Variants)
            {
                if (v.Quantity <= 3) return true;
            }

            return false;
        }
    }
}
