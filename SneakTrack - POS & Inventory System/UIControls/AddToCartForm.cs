using SneakTrack___POS___Inventory_System.UIControls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System
{
    public partial class AddToCartForm : Form
    {

        private MainSystem sys;
        private WindowHandler wh;
        private Validator v;
        private DataHandler dh;
        private ProductController pc;

        private Product inProd;
        int totalCartCount = 0;

        private char selectedGender;
        private string selectedSizeType;
        private double selectedSize;
        private int selectedQuantity;
        private Variant selectedVariant;

        public Variant SelectedVariant { get => selectedVariant; }

        public AddToCartForm()
        {
            InitializeComponent();
        }

        public AddToCartForm(MainSystem system, Product p, int totalInCart)
        {
            InitializeComponent();
            this.sys = system;
            this.wh = sys.WH;
            this.v = sys.VAL;
            this.dh = sys.DH;
            this.pc = sys.PC;
            initialize(p, totalInCart);
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

        private void initialize(Product p, int totalInCart) // TODO: add for size type
        {
            lbProductName.Text = p.Name;
            lbBrand.Text = p.Brand;
            lbColor.Text = p.Color;
            lbPrice.Text = "₱ " + p.displayPrice().ToString("0.00");
            pcbxProdImage.Image = p.Image;
            lbGenderText.Text = p.gendersStringFull();
            this.inProd = p;
            this.totalCartCount = totalInCart;

            loadProductFields(p);
        }

        private void loadProductFields(Product p)
        {
            List<char> checkedGend = new List<char>();

            foreach (Variant v in p.Variants)
            {
                if (!checkedGend.Contains(v.Gender))
                {
                    string genderString = "";

                    switch (v.Gender)
                    {
                        case 'M':
                            genderString = "Male";
                            break;
                        case 'F':
                            genderString = "Female";
                            break;
                        case 'U':
                            genderString = "Unisex";
                            break;
                    }

                    if (genderString != null || string.IsNullOrEmpty(genderString)) cmbxGender.Items.Add(genderString);
                    checkedGend.Add(v.Gender);
                }
            }

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (!validateFields())
            {
                MessageBox.Show("Unexpected error occurred.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedQuantity > selectedVariant.Quantity - selectedVariant.reservedQuan)
            {
                pcbxQuantityError.Visible = true;
                MessageBox.Show("Not enough stock available.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if(selectedQuantity + totalCartCount > 200)
            {
                pcbxQuantityError.Visible = true;
                MessageBox.Show($"Maximum cart quantity exceeded.\nYou can only add up to {200 - totalCartCount} more items.", 
                    "Cart Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            confirmationChangeStock();
        }

        private bool validateFields()
        {
            bool valid = true;

            pcbxGenderError.Visible = false;
            pcbxSizeError.Visible = false;
            pcbxQuantityError.Visible = false;

            if (cmbxGender.SelectedIndex == -1)
            {
                pcbxGenderError.Visible = true;
                valid = false;
            }

            if (cmbxSize.SelectedIndex == -1)
            {
                pcbxSizeError.Visible = true;
                valid = false;
            }

            selectedQuantity = v.readInt(txbxQuantity.Texts);
            if (selectedQuantity <= 0)
            {
                pcbxQuantityError.Visible = true;
                valid = false;
            }

            return valid;
        }

        private void confirmationChangeStock()
        {   
            ConfirmationPrompt confirm = new ConfirmationPrompt();
            confirm.Header = "Confirm Add To Cart";
            confirm.Prompt = "Add the following product to cart?\n" +
                $"{inProd.DisplayName()} - Size: {selectedVariant.Size} ({selectedVariant.SizeType})\n Quantity: {selectedQuantity}";
            DialogResult results = confirm.ShowDialog();

            if (results == DialogResult.OK) { 
                this.DialogResult = results;
                selectedVariant.reservedQuan += selectedQuantity;
                Debug.WriteLine($"Added result vari: {selectedVariant?.ToString()}"); //TODO:remove
                this.Close();
            }
        }

        private void cmbxGender_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbxSize.Enabled = true;
            cmbxSize.Items.Clear();
            cmbxSize.Text = "";
            lbAvailableQ.Visible = false;

            char selectedGender = ' ';

            switch (v.readString(cmbxGender.SelectedItem.ToString()))
            { 

                case "Male":
                    selectedGender = 'M';
                    break;

                case "Female":
                    selectedGender = 'F';
                    break;

                case "Unisex":
                    selectedGender = 'U';
                    break;
            }

            foreach (Variant vari in inProd.Variants)
            {
                if (vari.Gender.Equals(selectedGender) && vari.Quantity > 0)
                {
                    cmbxSize.Items.Add(vari.Size.ToString() + " (" + vari.SizeType + ")");
                }
            }

            string selectedGenderString = v.readString(cmbxGender.SelectedItem.ToString());
            if (selectedGenderString != null && selectedGenderString.Length > 0) selectedGender = selectedGenderString[0];
        }

        private void cmbxSize_SelectionChangeCommitted(object sender, EventArgs e)
        {
            char genderText = 'U';
            string combobox = v.readString(cmbxGender.SelectedItem?.ToString());
            switch (combobox)
            {
                case "Male":
                    genderText = 'M';
                    break;
                case "Female":
                    genderText = 'F';
                    break;
                default:
                    genderText = 'U';
                    break;
            }

            selectedGender = genderText;

            string cleanText = v.readString(cmbxSize.SelectedItem?.ToString()).Replace("(", "")
                .Replace(")", "");

            string[] parts = cleanText.Split(' ');

            selectedSize = v.readDouble(parts[0]);
            selectedSizeType = parts[1];

            selectedVariant = findVariant(selectedSizeType, selectedSize, selectedGender);
            Debug.WriteLine($"Selected Variant: {selectedVariant?.ToString()}"); //TODO: remove
            loadQuantity();
        }

        private void loadQuantity()
        {
            if (selectedVariant == null) return;

            lbAvailableQ.Visible = true;
            lbAvailableQ.Text = $"(Available: {selectedVariant.Quantity - selectedVariant.reservedQuan})";
        }

        private Variant findVariant(string sizeType, double size, char gender)
        {
            Variant variatn = null;

            foreach(Variant vari in inProd.Variants)
            {
                if (vari.SizeType.Equals(sizeType) && vari.Gender == gender && vari.Size == size)
                {
                    return vari;
                }
            }

            return variatn;
        }
    }
}
