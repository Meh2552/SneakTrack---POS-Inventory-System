using SneakTrack___POS___Inventory_System.UIControls;
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
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;

namespace SneakTrack___POS___Inventory_System
{
    public partial class Inventory : UserControl
    {
        private MainSystem sys;
        private Validator v;
        private WindowHandler wh;
        private DataHandler dh;
        private ProductController pc;
        private Product selected;

        public Inventory()
        {
            InitializeComponent();
            tblpnSideInfo.ColumnStyles[1].Width = 0;
        }

        public void initialize(MainSystem system)
        {
            this.sys = system;
            this.v = sys.VAL;
            this.wh = sys.WH;
            this.dh = sys.DH;
            this.pc = sys.PC;
            loadSelection();
        }
 
        private void loadSelection()
        {
            List<ProductTile> ptlist = pc.loadProducts(tblpnSelectionInv, true);
            foreach (ProductTile tile in ptlist)
            {
                tile.Click += new System.EventHandler(this.productTile_Click);
            }

            loadTiles();
        }

        private void loadSideInfo(Product product)
        {
            tblpnSideInfo.ColumnStyles[1].Width = 250;
            txbxProductInfoSI.Text = pc.toProdInfo(product);
            pcbxSideInfo.Image = product.Image;
            pcbxSideInfo.BackColor = System.Drawing.Color.White;
        }

        private void productTile_Click(object sender, EventArgs e)
        {
            ProductTile tile = sender as ProductTile;
            if (tile == null) return;

            Product p = tile.ProductObj;
            if (p == null) {
                System.Windows.Forms.MessageBox.Show("Error: Product not found;");
                return;
            }

            selected = p;
            loadSideInfo(selected);
        }

        private void txbxBarcodeQuan_TextChanged(object sender, EventArgs e)
        {
            double quan = v.readDouble((object)txbxBarcodeQuan.Text);

            if (quan == -1)
            {
                System.Windows.Forms.MessageBox.Show("Error: Invalid quantity input.");
                txbxBarcodeQuan.Text = "1";
            }

            else if (quan <= 0)
            {
                System.Windows.Forms.MessageBox.Show("Quantity cannot be negative or zero.");
                txbxBarcodeQuan.Text = "1";
            }

            else if (quan > 99)
            {
                System.Windows.Forms.MessageBox.Show("Quantity cannot exceed 99.");
                txbxBarcodeQuan.Text = "99";
            }
        }

        private void btnQuanDecrease_Click(object sender, EventArgs e)
        {
            txbxBarcodeQuan.Text = (v.readDouble((object)txbxBarcodeQuan.Text) - 1).ToString();
        }

        private void btnQuanIncrease_Click(object sender, EventArgs e)
        {
            txbxBarcodeQuan.Text = (v.readDouble((object)txbxBarcodeQuan.Text) + 1).ToString();
        }

        private void btnCloseSideInfo_Click(object sender, EventArgs e)
        {
            tblpnSideInfo.ColumnStyles[1].Width = 0;
        }

        private void txbxBarcode__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {

        }

        private void loadTiles()
        {
            tlProductListedSH.BottomText = pc.totalProductTypes().ToString();
            tlTotalStockSH.BottomText = pc.totalStock().ToString();
            tlTSVSH.BottomText = "₱ " + pc.totalValue().ToString();
        }
    }

}
