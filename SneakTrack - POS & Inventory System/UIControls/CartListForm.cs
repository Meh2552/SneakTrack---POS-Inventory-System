using SneakTrack___POS___Inventory_System.UIControls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Documents;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System
{
    public partial class CartListForm : Form
    {

        private MainSystem sys;
        private WindowHandler wh;
        private Validator v;
        private DataHandler dh;
        private ProductController pc;

        private List<Variant> cart;
        private Product selected;
        private Variant selectedVariant;

        public CartListForm()
        {
            InitializeComponent();
        }

        public CartListForm(MainSystem system, List<Variant> cart)
        {
            InitializeComponent();
            this.sys = system;
            this.wh = sys.WH;
            this.v = sys.VAL;
            this.dh = sys.DH;
            this.pc = sys.PC;
            this.cart = cart;

            initialize(cart);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void initialize(List<Variant> list)
        {
            lsvCart.Items.Clear();
            
            bool alternate = false;
            foreach (Variant vari in list)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    pc.productFromVariant(vari).DisplayName() ?? "Name",
                    vari.reservedQuan.ToString(),
                    vari.SizeId.ToString(),
                });

                item.BackColor = alternate ? Color.LightGray : Color.Gainsboro;
                alternate = !alternate;

                lsvCart.Items.Add(item);
            }

            lbCartItems.Text = $"Items: {cartTotal}/200";
            btnRemoveItem.Enabled = false;
        }

        private void lsvCart_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lsvCart.SelectedItems.Count == 0) return;

            int sizeId = v.readInt(lsvCart.SelectedItems[0].SubItems[2].Text);

            btnRemoveItem.Enabled = true;
            selection(sizeId);
        }

        bool firstSelect = true;

        private void selection(int sizeId)
        {
            if (sizeId < 0)
                return;

            int productId = v.idFromValue(dh.ProductMasterDT, "size_id", "product_id", sizeId.ToString());
            selected = v.productFromId(productId, dh.MasterToProductList);
            selectedVariant = selectionVariant(sizeId);

            pcbxSideInfo.BackColor = Color.White;
            pcbxSideInfo.Image = selected.Image;
            txbxProductInfoSI.Text = pc.toProdInfo(selected, selectedVariant);
            txbxQuantity.Texts = selectedVariant.reservedQuan.ToString();

            firstSelect = true;
        }

        private Variant selectionVariant(int sizeId)
        {
            foreach (Variant vari in cart)
            {
                if (vari.SizeId == sizeId)
                    return vari;
            }
            return null;
        }

        private void btnConfirmChanges_Click(object sender, EventArgs e)
        {
            ConfirmationPrompt confirm = new ConfirmationPrompt();
            confirm.Header = "Confirm Cart Changes";
            confirm.Prompt = "Confirm changes made to the cart items?";

            DialogResult results = confirm.ShowDialog();

            if (results == DialogResult.OK)
            {
                this.DialogResult = results;
                loadCart();
                this.Close();
            }
        }

        private void loadCart()
        {
            List<Variant> cartItems = new List<Variant>();

            try
            {
                foreach (ListViewItem item in lsvCart.Items)
                {
                    Variant vari = pc.variantFromId(v.readInt(item.SubItems[2].Text), cart);
                    int newQuan = v.readInt(item.SubItems[1].Text);
                    if (vari != null)
                    {
                        vari.reservedQuan = newQuan;
                        cartItems.Add(vari);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the product.");
            }

            cart = cartItems;
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            lsvCart.SelectedItems[0].Remove();
            lbCartItems.Text = $"Items: {cartTotal}/200";
        }

        private void btnDecQuantity_Click(object sender, EventArgs e)
        {
            txbxQuantity.Texts = (v.readInt(txbxQuantity.Texts) - 1).ToString();
            quantityCheck();
        }

        private void btnIncQuantity_Click(object sender, EventArgs e)
        {
            txbxQuantity.Texts = (v.readInt(txbxQuantity.Texts) + 1).ToString();
            quantityCheck();
        }

        private void txbxQuantity__TextChanged(object sender, EventArgs e)
        {
            if (firstSelect)
            {
                firstSelect = false;
                return;
            }
        }

        private bool quantityCheck()
        {
            int quan = v.readInt(txbxQuantity.Texts);

            if (quan == -1)
            {
                MessageBox.Show("Error: Invalid quantity input.");
                txbxQuantity.Texts = selectedVariant.reservedQuan.ToString();
                return false;
            }

            else if (quan <= 0)
            {
                MessageBox.Show("Quantity cannot be negative or zero.");
                txbxQuantity.Texts = "1";
                return false;
            }

            else if (quan > selectedVariant.Quantity)
            {
                MessageBox.Show($"Quantity cannot exceed the available stock. \n(Available: {selectedVariant.Quantity})");
                txbxQuantity.Texts = selectedVariant.Quantity.ToString();
                return false;
            }

            else if (cartTotal - selectedVariant.reservedQuan + quan > 200)
            {
                MessageBox.Show($"Total quantity in cart cannot exceed 200.");
                txbxQuantity.Texts = (200 - cartTotal + selectedVariant.reservedQuan).ToString();
                return false;
            }

            lsvCart.SelectedItems[0].SubItems[1].Text = txbxQuantity.Texts;
            lbCartItems.Text = $"Items: {cartTotal}/200";
            return true;
        }

        private int cartTotal 
        { 
            get {
                int count = 0;

                foreach (ListViewItem item in lsvCart.Items)
                {
                    int quan = v.readInt(item.SubItems[1].Text);
                    count += quan < 0 ? 0 : quan;
                }

                return count;
            }
        }
        public List<Variant> Cart { get { return cart; } }

        private void lsvCart_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lsvCart.Columns[e.ColumnIndex].Width;
        }
    }   
}
