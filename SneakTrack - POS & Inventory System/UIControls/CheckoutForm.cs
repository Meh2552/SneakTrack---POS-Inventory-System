using SneakTrack___POS___Inventory_System.UIControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System
{
    public partial class CheckoutForm : Form
    {

        private MainSystem sys;
        private UserAuth ua;
        private Validator v;
        private DataHandler dh;
        private ProductController pc;

        private List<Variant> cart;
        private Product selected;
        private Variant selectedVariant;

        private decimal payment = 0;
        private bool succeeded = false;

        public bool Suceeded { get { return this.succeeded; } }

        public CheckoutForm()
        {
            InitializeComponent();
        }

        public CheckoutForm(MainSystem system, List<Variant> cart)
        {
            InitializeComponent();
            this.sys = system;
            this.ua = sys.UA;
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
                    $"{vari.Gender} - {vari.Size} ({vari.SizeType})",
                    vari.reservedQuan.ToString(),
                    $"₱ {vari.subtotal.ToString("0.00")}",
                    vari.SizeId.ToString()
                });

                item.BackColor = alternate ? Color.LightGray : Color.Gainsboro;
                alternate = !alternate;

                lsvCart.Items.Add(item);
            }

            lbCartItems.Text = $"Items: {cartTotal}/200";
            lbTotalPrice.Text = $"Total: ₱ {finalTotal.ToString("0.00")}";
            lbPriceNoTax.Text = $"(W/O Tax): ₱ {woTaxTotal.ToString("0.00")}";
        }

        private void lsvCart_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lsvCart.SelectedItems.Count == 0) return;

            int sizeId = v.readInt(lsvCart.SelectedItems[0].SubItems[4].Text);

            selection(sizeId);
        }

        private void selection(int sizeId)
        {
            if (sizeId < 0) return;

            int productId = v.idFromValue(dh.ProductMasterDT, "size_id", "product_id", sizeId.ToString());
            selected = v.productFromId(productId, dh.MasterToProductList);
            selectedVariant = selectionVariant(sizeId);

            pcbxSideInfo.BackColor = Color.White;
            pcbxSideInfo.Image = selected.Image;
            txbxProductInfoSI.Text = pc.toProdInfo(selected, selectedVariant);
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

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            OrderCalculationPrompt ordCal = new OrderCalculationPrompt(sys, finalTotal);
            DialogResult results = ordCal.ShowDialog();

            if (results == DialogResult.OK)
            {
                payment = ordCal.Payment;
                paymentSuccess();
                loadSale();
            }
        }

        private void paymentSuccess()
        {
            lbPayment.Text = $"Amount Paid: ₱ {payment.ToString("0.00")}";

            decimal change = payment - finalTotal;
            lbChange.Text = $"Change: ₱ {change.ToString("0.00")}";

            btnCancel.Visible = false;
            btnConfirmOrder.Visible = false;

            btnComplete.Visible = true;
            btnComplete.BringToFront();

            succeeded = true;
        }

        private void loadSale()
        {
            try
            {
                int saleId = dh.toSale(ua.CurrentUser.UserID, payment);
                if (saleId == 0) return;

                foreach (Variant vari in cart)
                {
                    dh.toSalesItem(vari, saleId, pc.productFromVariant(vari).ProdId);
                    pc.updateQuantity(vari, vari.Quantity - vari.reservedQuan);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the product.");
            }
        }

        private int cartTotal 
        {
            get
            {
                int output = 0;
                foreach (Variant vari in cart)
                {
                    output += vari.reservedQuan;
                }
                return output;
            }
        }

        public List<Variant> Cart { get { return cart; } }

        private void lsvCart_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lsvCart.Columns[e.ColumnIndex].Width;
        }

        private decimal finalTotal 
        {  
            get {
                decimal total = 0;

                foreach (Variant vari in Cart)
                {
                    total += vari.subtotal;
                }

                return total;
            }
        }

        private decimal woTaxTotal { get { return finalTotal * 0.88m; } }
    }   
}
