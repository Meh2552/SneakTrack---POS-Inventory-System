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
        private int prod_id;

        private bool lowStock = false;
        #endregion

        public ProductTile()
        {
            InitializeComponent();

            checkLowStock();
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

            checkLowStock();
            this.Click += (s, e) => Debug.WriteLine("TILE CLICKED"); // test
            forwardDoubleClicks(this);
        }

        public int ProductID
        {
            get { return prod_id; }
            set { prod_id = value; }
        }

        public bool LowStock
        {
            get { return lowStock; }
            set 
            { 
                lowStock = value;
                checkLowStock();
            }
        }

        private void forwardDoubleClicks(Control parent)
        {
            foreach (Control c in Controls)
            {
                c.DoubleClick += (s, e) => OnDoubleClick(e);
                forwardDoubleClicks(c);
            }
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
                if (value == null)
                {
                    tileImage = null;
                    pictureBox1.Image = Properties.Resources.sport_shoe;
                }
                else
                {
                    tileImage = value;
                    pictureBox1.Image = value;
                }
            }
        }

        #endregion

        private void checkLowStock()
        {
            pcbxLowStock.Visible = lowStock;
        }
    }
}
