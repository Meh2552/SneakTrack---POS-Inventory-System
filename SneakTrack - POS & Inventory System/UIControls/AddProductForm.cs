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
    public partial class AddProductForm : Form
    {
        private MainSystem sys;
        private WindowHandler wh;
        private Validator v;
        private DataHandler dh;
        private Product outProd;

        private string imagePath = null;

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
            initialize();
        }

        public Product OutProd { get => outProd; set => outProd = value; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void initialize() // TODO: add for size type
        {
            AutoCompleteStringCollection brandColl = new AutoCompleteStringCollection();
            brandColl.AddRange(dh.BrandList.ToArray());
            txbxBrand.AutoCompleteCustomSource = brandColl;

            AutoCompleteStringCollection colorColl = new AutoCompleteStringCollection();
            colorColl.AddRange(dh.ColorList.ToArray());
            txbxColor.AutoCompleteCustomSource = colorColl;
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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!validateProductFields())
            {
                MessageBox.Show("Process has been cancelled due to unexpected errors.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isName = false;
            bool isBrand = false;
            bool isColor = false;

            try //TODO: reqrite, this doesnt check for duplicates
            {
                isName = v.tableHasValue(dh.dataToTable(dh.selectQuery("Product")), "product_name", v.readString(txbxProductName.Texts), true);
                isBrand = v.tableHasValue(dh.dataToTable(dh.selectQuery("Brand")), "brand_name", v.readString(txbxBrand.Texts), true);
                isColor = v.tableHasValue(dh.dataToTable(dh.selectQuery("Color")), "color_name", v.readString(txbxColor.Texts).ToUpper());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Process has been cancelled due to unexpected errors.", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine("exception " + ex.Message);
                return;
            }

            if (isName && isBrand && isColor)
            {
                MessageBox.Show("Product is already in the system.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isValidImage = false; //TODO: this only checks if image path is already in, so that duplicate file will not be created
            if (imagePath != null) isValidImage = v.tableHasValue(dh.dataToTable(dh.selectQuery("Product")), "image", imagePath);

            ConfirmationPrompt confirmationPrompt = new ConfirmationPrompt();
            DialogResult results = confirmationPrompt.ShowDialog();
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

            // Validate based on column
            switch (columnName)
            {
                case "Gender":
                    isValid = v.validateCellValue(cell, v.validateCharacters(newValue, "^[mMfFuU]$"), "Invalid gender (M/F/U)");
                    break;

                case "Size":
                    isValid = v.validateCellValue(cell, v.readDouble(newValue) > 0, "Enter a valid size greater than 0");
                    break;

                case "Quantity":
                    isValid = v.validateCellValue(cell, v.readInt(newValue) >= 0, "Enter a valid quantity (0 or more)");
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
            if (price < 0 || price   > 999999.99)
            {
                wh.changeLbTxt(lbPriceError, "Invalid price");
                valid = false;
            }

            if (v.readString(txbxBrand.Texts) == null)
            {
                wh.changeLbTxt(lbBrandError, "The field cannot be blank");
                valid = false;
            }

            if (v.readString(txbxColor.Texts) == null)
            {
                wh.changeLbTxt(lbColorError, "The field cannot be blank");
                valid = false;
            }

            if (v.readString(txbxProductName.Texts) == null)
            {
                wh.changeLbTxt(lbProductError, "The field cannot be blank");
                valid = false;
            }

            List<int> columnIndex = new List<int>() { 3 };
            if (v.dataGridHasErrorsOrBlank(dtgridSizeFields, columnIndex))
            {
                Debug.WriteLine("field on grid ");
                valid = false;
            }

            return valid;
        }
    }
}
