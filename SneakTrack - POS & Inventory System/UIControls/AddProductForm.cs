using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void initialize()
        {
            AutoCompleteStringCollection brandColl = new AutoCompleteStringCollection();
            brandColl.AddRange(dh.BrandList.ToArray());
            txbxBrand.AutoCompleteCustomSource = brandColl;

            AutoCompleteStringCollection colorColl = new AutoCompleteStringCollection();
            colorColl.AddRange(dh.ColorList.ToArray());
            txbxColor.AutoCompleteCustomSource = colorColl;
        }

        private void pnHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
            lbGenderError.Visible = false;
            lbPriceError.Visible = false;

            if (!chbxMale.Checked && !chbxFemale.Checked && !chbxUnisex.Checked)
            {
                wh.changeLbTxt(lbGenderError, "One must be selected");
            }

            if (v.readDouble((object)txbxPrice.Text) == -1)
            {
                wh.changeLbTxt(lbPriceError, "Invalid price");
            }

            bool isName = v.tableHasValue(dh.dataToTable(dh.selectQuery("Product")), "product_name", v.readString(txbxProductName.Text), true);
            bool isBrand = v.tableHasValue(dh.dataToTable(dh.selectQuery("Brand")), "brand_name", v.readString(txbxBrand.Text), true);
            bool isColor = v.tableHasValue(dh.dataToTable(dh.selectQuery("Color")), "color_name", v.readString(txbxColor.Text).ToUpper());

            bool isValidImage = false; //TODO: this only checks if image path is already in, so that duplicate file will not be created
            if (imagePath != null) isValidImage = v.tableHasValue(dh.dataToTable(dh.selectQuery("Product")), "image", imagePath);
        }

        // false if there are errors, true if all fields in the table are valid
        private bool validateTable()
        {
            DataTable dt = ((DataTable)dtgridSizeFields.DataSource).Copy();
            foreach (DataRow row in dt.Rows)
            {
                
            }
            return false;
        }
    }
}
