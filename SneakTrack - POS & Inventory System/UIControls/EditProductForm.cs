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

        private void initialize(Product p)
        {
            this.inProd = p;

            this.outProd = new Product(p.ProdId, p.Name, p.Brand, p.BrandId, p.Color, p.Description, p.ImagePath, p.ForSale);
            foreach(Variant vari in p.Variants)
            {
                this.outProd.addVariant(new Variant(vari.Size, vari.SizeType, vari.Quantity, vari.Barcode, vari.Gender, vari.Price, vari.VariantId, vari.SizeId));
            }
            
            AutoCompleteStringCollection brandColl = new AutoCompleteStringCollection();
            brandColl.AddRange(dh.BrandList.ToArray());
            txbxBrand.AutoCompleteCustomSource = brandColl;

            AutoCompleteStringCollection colorColl = new AutoCompleteStringCollection();
            colorColl.AddRange(dh.ColorList.ToArray());
            txbxColor.AutoCompleteCustomSource = colorColl;

            AutoCompleteStringCollection sizeTypeColl = new AutoCompleteStringCollection();
            sizeTypeColl.AddRange(dh.SizeTypesList.ToArray());
            txbxSizeType.AutoCompleteCustomSource = sizeTypeColl;

            txbxProductName.Texts = p.Name;
            txbxBrand.Texts = p.Brand;
            txbxColor.Texts = p.Color;
            txbxDescription.Text = p.Description;

            pcbxImage.Image = p.Image;
            pcbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            imagePath = p.ImagePath;

            loadProductFields(p);

            chbxMale.Checked = p.HasMale;
            chbxFemale.Checked = p.HasFemale;
            chbxUnisex.Checked = p.HasUnisex;
            txbxMPrice.Texts = p.mPrice().ToString();
            txbxFPrice.Texts = p.fPrice().ToString();
            txbxUPrice.Texts = p.uPrice().ToString();

            chbxForSale.Checked = p.ForSale;
            checkCheckedGenderCheckCheckedCheck();
            
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

                    string sizeId = currentRow.Cells[5].Value?.ToString();
                    Debug.WriteLine(sizeId);
                    bool tableValueFound = sizeId != null ? v.tableHasValue(dh.ProductMasterDT, "Barcode", v.readString(newValue), "size_id", sizeId)
                        : v.tableHasValue(dh.ProductMasterDT, "Barcode", v.readString(newValue));

                    if (v.validateCellValue(cell, !tableValueFound, "Barcode already in the system")) { isValid = false; break; }

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

            List<int> columnIndex = new List<int>() { 3, 5};
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

                    decimal price = 0;
                    if (gender == 'M') price = v.readDecimal(txbxMPrice.Texts);
                    else if (gender == 'F') price = v.readDecimal(txbxFPrice.Texts);
                    else if (gender == 'U') price = v.readDecimal(txbxUPrice.Texts);

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
            pc.updateProd(p, inProd);
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            imagePath = null;
            pcbxImage.Image = Properties.Resources.add_image;
            pcbxImage.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
}
