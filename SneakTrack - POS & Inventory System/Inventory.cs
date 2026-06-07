using SneakTrack___POS___Inventory_System.UIControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

        public void reloadInv()
        {
            loadSelection();
            selected = null;
            tblpnSideInfo.ColumnStyles[1].Width = 0;
        }

        private void loadSelection()
        {
            dh.loadMasterList();
            List<ProductTile> ptlist = pc.loadProducts(tblpnSelectionInv, dh.toProducts(dh.ProductMasterDT), 1);
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
            double quan = v.readInt(txbxBarcodeQuan.Text);

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
            txbxBarcodeQuan.Text = (v.readInt(txbxBarcodeQuan.Text) - 1).ToString();
        }

        private void btnQuanIncrease_Click(object sender, EventArgs e)
        {
            txbxBarcodeQuan.Text = (v.readInt(txbxBarcodeQuan.Text) + 1).ToString();
        }

        private void btnCloseSideInfo_Click(object sender, EventArgs e)
        {
            tblpnSideInfo.ColumnStyles[1].Width = 0;
        }

        private void txbxBarcode__TextChanged(object sender, EventArgs e)
        {
            if (!chbxAutoAddInp.Checked) return;

            if (txbxBarcode.Texts.Length >= 12) barcodeCheck();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addForm = new AddProductForm(sys);
            DialogResult result = addForm.ShowDialog(this);

            if (result == DialogResult.OK) reloadInv();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            EditProductForm editForm = new EditProductForm(sys, selected);
            DialogResult result = editForm.ShowDialog(this);

            if (result == DialogResult.OK) reloadInv();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnManageStock_Click(object sender, EventArgs e)
        {
            ManageStockForm addForm = new ManageStockForm(sys, selected);
            DialogResult result = addForm.ShowDialog(this);

            if (result == DialogResult.OK) reloadInv();
        }

        private void loadTiles()
        {
            tlProductListedSH.BottomText = pc.totalProductTypes().ToString();
            tlTotalStockSH.BottomText = pc.totalStock().ToString();
            tlTSVSH.BottomText = "₱ " + pc.totalValue().ToString();
        }

        private void barcodeCheck()
        {
            string barcode = v.readString(txbxBarcode.Texts);
            if (string.IsNullOrEmpty(barcode)) return;

            if (pc.addStockFromBarcode(pc.barcodeToVariant(barcode), v.readInt(txbxBarcodeQuan.Text)))
            {
                reloadInv();
                txbxBarcode.Texts = "";
                txbxBarcodeQuan.Text = "1";
            }

            txbxBarcode.Focus();
        }

        private void btnBarcodeAdd_Click(object sender, EventArgs e)
        {
            if (v.readString(txbxBarcode.Texts) == null)
            {
                MessageBox.Show("Please enter a barcode.");
                return;
            }
            barcodeCheck();
        }

        private void chbxAutoAddInp_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxAutoAddInp.Checked) barcodeCheck();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reloadInv();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = v.readString(txbxSearch.Texts);

            if (string.IsNullOrEmpty(search)) 
            {
                MessageBox.Show("Please enter a search term.");
                return; 
            }

            List<ProductTile> ptlist = pc.searchProducts(search, tblpnSelectionInv);
            if (ptlist == null || ptlist.Count == 0) return;

            foreach (ProductTile tile in ptlist)
            {
                tile.Click += new EventHandler(this.productTile_Click);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            loadSelection();
        }
    }

}
