using SneakTrack___POS___Inventory_System.UIControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System
{
    public partial class AddProductForm : Form
    {
        private MainSystem sys;
        private WindowHandler wh;
        private Validator v;
        private DataHandler dh;
        private ProductController pc;

        private string imagePath = null;
        private string genderRegex = null;

        public AddProductForm()
        {
            InitializeComponent();
        }

        public AddProductForm(MainSystem system)
        {
            InitializeComponent();
            this.sys = system;
            this.wh = sys.WH;
            this.v = sys.VAL;
            this.dh = sys.DH;
            this.pc = sys.PC;
            initialize();
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

        private void initialize()
        {
            AutoCompleteStringCollection brandColl = new AutoCompleteStringCollection();
            brandColl.AddRange(dh.BrandList.ToArray());
            txbxBrand.AutoCompleteCustomSource = brandColl;

            AutoCompleteStringCollection colorColl = new AutoCompleteStringCollection();
            colorColl.AddRange(dh.ColorList.ToArray());
            txbxColor.AutoCompleteCustomSource = colorColl;

            AutoCompleteStringCollection sizeTypeColl = new AutoCompleteStringCollection();
            sizeTypeColl.AddRange(dh.SizeTypesList.ToArray());
            txbxSizeType.AutoCompleteCustomSource = sizeTypeColl;
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

        private bool validateCell(DataGridViewCell cell)
        {
            bool isValid = true;
            string columnName = dtgridSizeFields.Columns[cell.ColumnIndex].Name;
            string newValue = cell.FormattedValue.ToString();
            DataGridViewRow currentRow = dtgridSizeFields.Rows[cell.RowIndex];

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
                    v.validateCellValue(cell, v.readDouble(newValue) >= 0, "Enter a size (0 or more)");

                    bool hasValue = dtgridSizeFields.Rows
                        .Cast<DataGridViewRow>()
                        .Where(row => !row.IsNewRow && row.Index != currentRow.Index)
                        .Any(row =>
                            row.Cells["Size"].Value?.ToString() == currentRow.Cells["Size"].Value?.ToString() &&
                            row.Cells["Gender"].Value?.ToString() == currentRow.Cells["Gender"].Value?.ToString() &&
                            row.Cells["SizeType"].Value?.ToString() == currentRow.Cells["SizeType"].Value?.ToString());

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

                case "Barcode":
                    if (v.readString(newValue) == null)
                    {
                        v.toNormalCell(cell);
                        break;
                    }

                    if (v.validateCellValue(cell, !v.tableHasValue(dh.ProductMasterDT, "Barcode", v.readString(newValue)),
                        "Barcode already in the system")) {isValid = false; break; }

                    bool valueExists = dtgridSizeFields.Rows.Cast<DataGridViewRow>()
                            .Where(row => !row.IsNewRow && row.Index != cell.RowIndex)
                            .Any(row => row.Cells["Barcode"].Value?.ToString() == cell.Value?.ToString());

                    if (valueExists)
                    {
                        isValid = v.validateCellValue(cell, false, "Duplicate barcode found");
                    }
                    break;
            }

            return isValid;
        }

        private bool validateProductFields()
        {
            bool valid = true;
            lbGenderError.Visible = false;
            lbBrandError.Visible = false;
            lbColorError.Visible = false;
            lbProductError.Visible = false;

            if (!chbxMale.Checked && !chbxFemale.Checked && !chbxUnisex.Checked)
            {
                wh.changeLbTxt(lbGenderError, "Select One");
                valid = false;
            }

            if (!checkPrice(txbxMPrice, chbxMale)) valid = false;
            if (!checkPrice(txbxFPrice, chbxFemale)) valid = false;
            if (!checkPrice(txbxUPrice, chbxUnisex)) valid = false;

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

            string sizeType = v.readString(txbxSizeType.Texts);
            sizeType = txbxSizeType.Texts = sizeType?.ToUpper();
            foreach (DataGridViewRow dr in dtgridSizeFields.Rows)
            {
                if (dr.IsNewRow) continue;

                DataGridViewCell cell = dr.Cells[4];
                DataGridViewCell genCell = dr.Cells[0];

                if (sizeType != null && v.readString(cell.Value?.ToString()) == null)
                {
                    v.toNormalCell(cell);
                    cell.Value = sizeType;
                }

                else if (sizeType == null && v.readString(cell.Value?.ToString()) == null) continue;

                else v.toNormalCell(cell);

                v.validateCellValue(genCell, v.validateCharacters(v.readString(genCell.Value?.ToString()), genderRegex), "Invalid gender");

                bool hasDuplicate = dtgridSizeFields.Rows
                    .Cast<DataGridViewRow>()
                    .Where(row => !row.IsNewRow && row.Index != dr.Index)
                    .Any(row =>
                        row.Cells["Size"].Value?.ToString() == dr.Cells["Size"].Value?.ToString() &&
                        row.Cells["Gender"].Value?.ToString() == dr.Cells["Gender"].Value?.ToString() &&
                        row.Cells["SizeType"].Value?.ToString() == dr.Cells["SizeType"].Value?.ToString());

                if (hasDuplicate) v.validateCellValue(dr.Cells["Size"], false, "Duplicate size found");
                else v.toNormalCell(dr.Cells["Size"]);
            }


            List<int> columnIndex = new List<int>() { 3 };
            if (v.dataGridHasErrorsOrBlank(dtgridSizeFields, columnIndex))
            {
                valid = false;
            }

            return valid;
        }

        private bool checkPrice(RoundedTxBx textbox, CheckBox checkbox)
        {
            double price = v.readDouble(textbox.Texts);
            if (!checkbox.Checked) return true;

            else if (price < 0 || price > 999999.99)
            {
                wh.changeLbTxt(lbGenderError, "Invalid price");
                return false;
            }

            else
            {
                textbox.Texts = v.readDecimal((object)textbox.Texts).ToString("0.00");
                return true;
            }
        }

        private void chbx_CheckedChanged(object sender, EventArgs e)
        {
            checkCheckedGenderCheckCheckedCheck();
        }

        private void checkCheckedGenderCheckCheckedCheck()
        {
            string gender = "^[";

            bool hasMale = chbxMale.Checked, hasFemale = chbxFemale.Checked, hasUnisex = chbxUnisex.Checked;

            gender += hasMale ? "mM" : "";
            gender += hasFemale ? "fF" : "";
            gender += hasUnisex ? "uU" : "";

            gender += "]$";

            if (gender != "^[]$") genderRegex = gender;
            else genderRegex = null;

            if (!hasMale && !string.IsNullOrWhiteSpace(txbxMPrice.Texts)) txbxMPrice.Texts = "";
            if (!hasFemale && !string.IsNullOrWhiteSpace(txbxFPrice.Texts)) txbxFPrice.Texts = "";
            if (!hasUnisex && !string.IsNullOrWhiteSpace(txbxUPrice.Texts)) txbxUPrice.Texts = "";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!validateProductFields() || dtgridSizeFields.Rows.Count == 1)
            {
                MessageBox.Show("Process has been cancelled due to unexpected errors.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = v.readString(txbxProductName.Texts);
            string brand = v.readString(txbxBrand.Texts);
            string color = v.readString(txbxColor.Texts);

            if (dh.hasDuplicateProduct(name, brand, color))
            {
                MessageBox.Show("Similar product is already listed in the system", "Duplicate Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            confirmationAddProd();
        }

        private void confirmationAddProd()
        {
            ConfirmationPrompt confirm = new ConfirmationPrompt();
            confirm.Header = "Confirm Product Addition";
            confirm.Prompt = "Are you sure you want to add this product: \r\n" + txbxProductName.Texts + " - " + txbxColor.Texts;
            DialogResult results = confirm.ShowDialog();

            if (results == DialogResult.OK) { 
                this.DialogResult = results;
                loadProduct();
                this.Close();
            }
        }
       
        private void loadProduct()
        {
            Product p = null;
            try
            {
                string name = v.readString(txbxProductName.Texts);
                string brand = v.readString(txbxBrand.Texts);
                string color = v.readString(txbxColor.Texts);
                string sizeType = v.readString(txbxSizeType.Texts) ?? "US";
                string description = v.readString(txbxDescription.Text);

                p = new Product(name, brand, color, description, imagePath);

                foreach (DataGridViewRow row in dtgridSizeFields.Rows)
                {
                    if (row.IsNewRow) continue;

                    char gender = v.readString(row.Cells[0].Value.ToString())[0];
                    double size = v.readDouble(row.Cells[1].Value);
                    int quantity = v.readInt(row.Cells[2].Value);
                    string barcode = string.IsNullOrEmpty(row.Cells[3].Value?.ToString()) ? null : v.readString(row.Cells[3].Value.ToString());

                    decimal price = 0;
                    if (gender == 'M') price = v.readDecimal(txbxMPrice.Texts);
                    else if (gender == 'F') price = v.readDecimal(txbxFPrice.Texts);
                    else if (gender == 'U') price = v.readDecimal(txbxUPrice.Texts);

                    Variant variant = new Variant(size, sizeType, quantity, barcode, gender, price);
                    p.addVariant(variant);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the product.");
            }

            pc.addProduct(p);
            Debug.WriteLine(p.ToString());
            foreach (Variant varia in p.Variants) Debug.WriteLine(varia.ToString());

        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            imagePath = null;
            pcbxImage.Image = Properties.Resources.add_image;
            pcbxImage.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
}
