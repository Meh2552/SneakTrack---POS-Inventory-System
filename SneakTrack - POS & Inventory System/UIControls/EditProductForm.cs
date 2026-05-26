using SneakTrack___POS___Inventory_System.UIControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System
{
    public partial class EditProductForm : Form
    {
        private MainSystem sys;
        private WindowHandler wh;
        private Validator v;
        private DataHandler dh;
        private ProductController pc;

        private string imagePath = null;
        private Product inProd;
        private Product outProd;
        private string genderRegex = null;

        public EditProductForm()
        {
            InitializeComponent();
        }

        public EditProductForm(MainSystem system, Product p)
        {
            InitializeComponent();
            this.sys = system;
            this.wh = sys.WH;
            this.v = sys.VAL;
            this.dh = sys.DH;
            this.pc = sys.PC;
            initialize(p);
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

        private void initialize(Product p) // TODO: add for size type
        {
            this.inProd = p;
            this.outProd = p;

            AutoCompleteStringCollection brandColl = new AutoCompleteStringCollection();
            brandColl.AddRange(dh.BrandList.ToArray());
            txbxBrand.AutoCompleteCustomSource = brandColl;

            AutoCompleteStringCollection colorColl = new AutoCompleteStringCollection();
            colorColl.AddRange(dh.ColorList.ToArray());
            txbxColor.AutoCompleteCustomSource = colorColl;
            
            txbxProductName.Texts = p.Name;
            txbxBrand.Texts = p.Brand;
            txbxColor.Texts = p.Color;
            txbxPrice.Texts = p.displayPrice().ToString("0.00");

            loadProductFields(p);

            chbxMale.Checked = p.HasMale;
            chbxFemale.Checked = p.HasFemale;
            chbxUnisex.Checked = p.HasUnisex;
            chbxForSale.Checked = p.ForSale;
        }

        private void loadProductFields(Product p)
        {

            foreach (Variant v in p.Variants)
            {
                string barcode = string.IsNullOrEmpty(v.Barcode) ? string.Empty : v.Barcode;
                dtgridSizeFields.Rows.Add(
                        v.Gender,
                        v.Size,
                        v.Quantity,
                        barcode,
                        v.SizeType,
                        v.SizeId
                    );
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e) // TODO: add image to file, resources.
        {
            string result = wh.getImageFilePath();
            if (result != null)
            {
                pcbxImage.Image = Image.FromFile(result);
                pcbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                imagePath = result;
            }

        }




        private void dtgridSizeFields_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {  
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;

            if (dtgridSizeFields.Rows[rowIndex].IsNewRow)
                return;

            DataGridViewRow row = dtgridSizeFields.Rows[rowIndex];
            DataGridViewCell cell = row.Cells[colIndex];

            validateCell(cell);
           
        }

        
        private bool validateCell(DataGridViewCell cell) // TODO: check for duplicate barcode mabye on upper method idk
        { 
            bool isValid = true;
            string columnName = dtgridSizeFields.Columns[cell.ColumnIndex].Name;
            string newValue = cell.FormattedValue.ToString();

            // Validate based on column
            switch (columnName)
            {
                case "Gender":
                    if (genderRegex == null)
                    {
                        isValid = v.validateCellValue(cell, false, "Select at least one checkbox");
                    }

                    else if (v.validateCellValue(cell, v.validateCharacters(newValue, genderRegex), "Invalid gender"))
                    {
                        cell.Value = cell.Value.ToString().ToUpper();
                    }

                    else
                    {
                        isValid = false;
                    }
                    break;

                case "Size":
                    bool hasValue = dtgridSizeFields.Rows.Cast<DataGridViewRow>()
                        .Where(row => !row.IsNewRow && row.Index != cell.RowIndex)
                        .Any(row => row.Cells["Size"].Value?.ToString() == cell.Value?.ToString()
                        && row.Cells["Gender"].Value?.ToString() ==
                        dtgridSizeFields.Rows[cell.RowIndex].Cells["Gender"].Value?.ToString());

                    if (hasValue)
                    {
                        isValid = v.validateCellValue(cell, false, "Duplicate size found");
                    }
                    else
                    {
                        isValid = v.validateCellValue(cell, v.readDouble(newValue) > 0, "Enter a valid size greater than 0");
                    }
                    break;

                case "Quantity":
                    isValid = v.validateCellValue(cell, v.readInt(newValue) >= 0, "Enter a valid quantity (0 or more)");
                    break;

                case "SizeType": //TODO: this
                    break;
            }
            return isValid;
        }


        private bool validateProductFields()
        {
            bool valid = true;
            lbGenderError.Visible = false;
            lbPriceError.Visible = false;
            lbBrandError.Visible = false;
            lbColorError.Visible = false;
            lbProductError.Visible = false;

            if (!chbxMale.Checked && !chbxFemale.Checked && !chbxUnisex.Checked)
            {
                wh.changeLbTxt(lbGenderError, "One must be selected");
                valid = false;
            }

            double price = v.readDouble((object)txbxPrice.Texts);
            if (price < 0 || price > 999999.99)
            {
                wh.changeLbTxt(lbPriceError, "Invalid price");
                valid = false;
            }
            else txbxPrice.Texts = v.readDecimal((object)txbxPrice.Texts).ToString("0.00");

            string brand = v.readString(txbxBrand.Texts);
            if (brand == null)
            {
                wh.changeLbTxt(lbBrandError, "The field cannot be blank");
                valid = false;
            }
            else txbxBrand.Texts = brand.ToUpper();

            string color = v.readString(txbxColor.Texts);
            if (color == null)
            {
                wh.changeLbTxt(lbColorError, "The field cannot be blank");
                valid = false;
            }
            else txbxColor.Texts = color.ToUpper();

            string productName = v.readString(txbxProductName.Texts);
            if (productName == null)
            {
                wh.changeLbTxt(lbProductError, "The field cannot be blank");
                valid = false;
            }
            else txbxProductName.Texts = productName;

            List<int> columnIndex = new List<int>() { 3, 4, 5};
            if (v.dataGridHasErrorsOrBlank(dtgridSizeFields, columnIndex))
            {
                valid = false;
            }

            return valid;

        }


        private void chbx_CheckedChanged(object sender, EventArgs e)
        {
            string gender = "^[";
            
            gender += chbxMale.Checked ? "mM" : "";
            gender += chbxFemale.Checked ? "fF" : "";
            gender += chbxUnisex.Checked ? "uU" : "";

            gender += "]$";

            if (gender != "^[]$") genderRegex = gender;
            else genderRegex = null;
        }

        private void btnConfirmChanges_Click(object sender, EventArgs e)
        {
            if (!validateProductFields() || dtgridSizeFields.Rows.Count == 1)
            {
                MessageBox.Show("Process has been cancelled due to unexpected errors.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = v.readString(txbxProductName.Texts);
            string brand = v.readString(txbxBrand.Texts);
            string color = v.readString(txbxColor.Texts);

            if (dh.hasDuplicateProduct(name, brand, color, inProd.ProdId.ToString()))
            {
                MessageBox.Show("Similar product is already listed in the system", "Duplicate Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           confirmationAddProd();
        }

        // TODO: remove size type txbx 
        private void confirmationAddProd()
        { 
            ConfirmationPrompt confirm = new ConfirmationPrompt();
            confirm.Header = "Confirm Product Changes";
            confirm.Prompt = "Save the product changes: \r\n" + txbxProductName.Texts + " - " + txbxColor.Texts;
            DialogResult results = confirm.ShowDialog();

            if (results == DialogResult.OK) { 
                this.DialogResult = results;
                loadProduct();
                this.Close();
            }
        }
        // TODO: check if barcode is duplicate


        private void loadProduct()
        {
            Product p = outProd;
            try
            {
                p.Name = v.readString(txbxProductName.Texts);
                p.Brand = v.readString(txbxBrand.Texts);
                p.Color = v.readString(txbxColor.Texts);
                p.Description = v.readString(txbxDescription.Text);
                p.ForSale = chbxForSale.Checked;
                p.ImagePath = this.imagePath;

                foreach (Variant vari in p.Variants) vari.Remove = true; // Those not found in the dataGridView are marked to be deleted

                foreach (DataGridViewRow row in dtgridSizeFields.Rows)
                {
                    if (row.IsNewRow) continue;

                    int sizeId = v.readInt(row.Cells[5].Value);

                    char gender = v.readString(row.Cells[0].Value.ToString())[0];
                    double size = v.readDouble(row.Cells[1].Value);
                    int quantity = v.readInt(row.Cells[2].Value);
                    string barcode = string.IsNullOrEmpty(row.Cells[3].Value?.ToString()) ? null : v.readString(row.Cells[3].Value.ToString());
                    string sizeType = v.readString(row.Cells[4].Value.ToString());
                    decimal price = v.readDecimal(txbxPrice.Texts);

                    // TODO: default values for datagridview
                    if (sizeId == 0) // There was no entry for size id in the dataGridView, meaning it was newly created
                    {
                        Variant variant = new Variant(size, sizeType, quantity, barcode, gender, price);
                        p.addVariant(variant);
                    }

                    else
                    {
                        Variant variant = p.fromSizeId(sizeId);

                        variant.Gender = gender;
                        variant.Size = size;
                        variant.Quantity = quantity;
                        variant.Barcode = barcode;
                        variant.SizeType = sizeType;
                        variant.Price = price;

                        variant.Remove = false;
                    }

                }

                p.recheckValues();
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the product.");
            }

            Debug.WriteLine("\n\n" + p.ToString());
            foreach (Variant v in p.Variants) Debug.WriteLine("\n" + v.ToString());
            // pc.addProduct(p);
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            imagePath = null;
            pcbxImage.Image = Properties.Resources.add_image;
            pcbxImage.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
}
