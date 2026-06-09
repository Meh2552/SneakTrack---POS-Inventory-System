using SneakTrack___POS___Inventory_System.UIControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;

namespace SneakTrack___POS___Inventory_System
{//TODO: tile logic
    public partial class POS : UserControl
    {
        private MainSystem sys;
        private Validator v;
        private WindowHandler wh;
        private DataHandler dh;
        private ProductController pc;
        private Product selected;

        private List<Variant> cart;

        private int cartTotal { get { return cart?.Sum(v => v.reservedQuan) ?? 0; } }

        public POS()
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
            this.cart = new List<Variant>();
            loadSelection();
        }

        public void reloadPOS()
        {
            loadSelection();
            selected = null;
            tblpnSideInfo.ColumnStyles[1].Width = 0;
        }

        private void loadSelection()
        {
            dh.loadMasterList();

            List<Product> products = dh.MasterToProductList.Where(prod => prod.Archived == false && prod.ForSale == true).ToList();

            foreach(Product p in products)
            {
                foreach (Variant vari in cart)
                {
                    Variant incoming = p.fromSizeId(vari.SizeId);
                    if (incoming != null)
                    {
                       incoming.reservedQuan = vari.reservedQuan;
                    }
                }
            }

            List<ProductTile> ptlist = pc.loadProducts(tblpnSelectionInv, products, 1, false);
            foreach (ProductTile tile in ptlist)
            {
                tile.Click += new EventHandler(this.productTile_Click);
            }

            loadTiles();// TODO: change 
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
                MessageBox.Show("Error: Product not found;");
                return;
            }

            selected = p;
            loadSideInfo(selected);
        }

        private void txbxBarcodeQuan_TextChanged(object sender, EventArgs e)
        {
            double quan = v.readInt(txbxBarcodeQuan.Text); //TODO: limit for quantity

            if (quan == -1)
            {
                MessageBox.Show("Error: Invalid quantity input.");
                txbxBarcodeQuan.Text = "1";
            }

            else if (quan <= 0)
            {
                MessageBox.Show("Quantity cannot be negative or zero.");
                txbxBarcodeQuan.Text = "1";
            }

            else if (quan > 99)
            {
                MessageBox.Show("Quantity cannot exceed 99.");
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

        private void loadTiles()
        {
            tlProductListed.BottomText = pc.totalProductTypes().ToString();
            tlProductsInCart.BottomText = pc.totalStock().ToString();
            tlCartSubtotal.BottomText = "₱ " + pc.totalValue().ToString();
        }

        private void barcodeCheck()
        {
            string barcode = v.readString(txbxBarcode.Texts);
            if (string.IsNullOrEmpty(barcode)) return;

            Variant vari = pc.barcodeToVariant(barcode);
            if (pc.variantBarcodeToCart(vari, v.readInt(txbxBarcodeQuan.Text), cartTotal))
            {
                updateCart(vari);
                MessageBox.Show($"Successfully added product to cart.", "Add To Cart Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                reloadPOS();
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
            reloadPOS();
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

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cart == null || cart.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            CheckoutForm checkout = new CheckoutForm(sys, cart);
            DialogResult result = checkout.ShowDialog(this);

            if (checkout.Suceeded)
            {
                clearCart();
                reloadPOS();
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("\n==   Cart Contents   ==\n");
            foreach (Variant v in cart)
            {
                Debug.WriteLine(v.ToString());
            }

            if (cart == null || cart.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            CartListForm cartForm = new CartListForm(sys, cart);
            DialogResult result = cartForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                cart = cartForm.Cart;
                reloadPOS();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            AddToCartForm addForm = new AddToCartForm(sys, selected, cartTotal);
            DialogResult result = addForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                if (addForm.SelectedVariant != null) updateCart(addForm.SelectedVariant);
                reloadPOS();
            }
        }

        private void clearCart()
        {
            cart.Clear();
        }

        private void updateCart(Variant inVari)
        {
            foreach (Variant v in cart)
            {
                if (v.SizeId == inVari.SizeId)
                {
                    v.reservedQuan = inVari.reservedQuan;
                    return;
                }
            }

            cart.Add(inVari);
        }

    }

}
