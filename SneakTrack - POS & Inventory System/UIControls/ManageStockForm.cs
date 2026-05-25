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
    public partial class ManageStockForm : Form
    {

        private MainSystem sys;
        private WindowHandler wh;
        private Validator v;
        private DataHandler dh;
        private ProductController pc;

        private Product inProd;

        public ManageStockForm()
        {
            InitializeComponent();
        }

        public ManageStockForm(MainSystem system, Product p)
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
            lbProductName.Text = p.Name;
            lbBrand.Text = p.Brand;
            lbColor.Text = p.Color;
            pcbxProdImage.Image = p.Image;
            txbxDescription.Text = p.Description;
            lbGenderText.Text = p.gendersStringFull();
            this.inProd = p;

            loadProductFields(p);
        }

        private void loadProductFields(Product p)
        {
            foreach (Variant v in p.Variants)
            {
                string barcode = string.IsNullOrEmpty(v.Barcode) ? string.Empty : v.Barcode;
                dtgridSizeFields.Rows.Add(
                        v.Gender.ToString(),
                        v.Size,
                        v.Quantity,
                        barcode,
                        v.Price,
                        v.SizeId
                    );
            }   
        }

        private void btnChangeStock_Click(object sender, EventArgs e)
        { 
            if (!validateProductFields() || dtgridSizeFields.Rows.Count == 1)
            {
                MessageBox.Show("Process has been cancelled due to unexpected errors.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            confirmationChangeStock();
            
        }

        private void dtgridSizeFields_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;

            if (dtgridSizeFields.Rows[rowIndex].IsNewRow)
                return;

            DataGridViewRow row = dtgridSizeFields.Rows[rowIndex];
            DataGridViewCell cell = row.Cells[colIndex];

            bool valid = v.validateCellValue(cell, v.readInt(cell.Value) >= 0, "Quantity must be greater than or equal to 0");
            if (valid && colIndex != 2 ) cell.Style.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
        }

        
        private bool validateProductFields()
        { 

            List<int> columnIndex = new List<int>() { 0,1,3,4,5 };
            if (v.dataGridHasErrorsOrBlank(dtgridSizeFields, columnIndex))
            {
                return false;
            }

            return true;
            
        }


        private void confirmationChangeStock()
        { 
            ConfirmationPrompt confirm = new ConfirmationPrompt();
            confirm.Header = "Confirm Stock Changes";
            confirm.Prompt = "Confirm the changes to the stock levels?";
            DialogResult results = confirm.ShowDialog();

            if (results == DialogResult.OK) { 
                this.DialogResult = results;
                loadProduct();
                this.Close();
            }
            
        }
       
        private void loadProduct()
        {
            Product p = inProd;
            try
            {

                foreach (DataGridViewRow row in dtgridSizeFields.Rows)
                {
                    if (row.IsNewRow) continue;

                    int currentId = Convert.ToInt32(row.Cells[5].Value);
                    Console.WriteLine("current id: " + currentId); //TODO: remove

                    foreach (Variant vari in p.Variants)
                    {
                        if (currentId == vari.SizeId)
                        {
                            vari.Quantity = v.readInt(row.Cells[2].Value);
                            Console.WriteLine($"Updated Variant ID {vari.SizeId} with Quantity {vari.Quantity}");
                            continue;
                        }
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the product.");
            }

            pc.updateQuantity(p);

        }
    }
}
