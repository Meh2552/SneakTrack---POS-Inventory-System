using SneakTrack___POS___Inventory_System.UIControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System
{
    public class WindowHandler
    {
        
        private Login login;
        private MainDashboard dash;

        // Accesors and Mutators
        public Login Login { get => login; set => login = value; }
        public MainDashboard Dash { get => dash; set => dash = value; }

        public WindowHandler() { }

        public WindowHandler(Login login, MainDashboard dash)
        {
            this.login = login;
            this.dash = dash;
        }

        public void switchControl(Control from, Control to)
        {
            if (from == null || from == to)
            {
                to.Visible = true;
                to.BringToFront();
            }

            else
            {
                to.SendToBack();
                to.Visible = true;
                from.Visible = false;
                to.BringToFront();
            }
        }

        public void changeLbTxt(Label label, string txt)
        {
            label.Visible = true;
            label.Text = txt;
        }


        /* 
         *    Removes the rows of a TableLayoutPanel after the specified index number in afterRow
         */

        public void clearRows(TableLayoutPanel tablePanel, int afterRow)
        {
            tablePanel.SuspendLayout();

            for (int i = tablePanel.Controls.Count - 1; i >= 0; i--)
            {
                Control control = tablePanel.Controls[i];
                if (tablePanel.GetRow(control) != afterRow)
                {
                    tablePanel.Controls.Remove(control);
                    control.Dispose();
                }
            }

            for (int i = tablePanel.RowCount - 1; i >= afterRow; i--)
            {
                if (i != afterRow) tablePanel.RowStyles.RemoveAt(i);
            }

            tablePanel.ResumeLayout(true);
        }

        /* 
         *    Returns a ProductTile object based on the product and variant parameters
        */

        public ProductTile toProductTile(Product product)
        {
            ProductTile tile = new ProductTile
            {
                ProductID = product.ProdId,
                TopText = product.Brand,
                BottomText = product.DisplayName(),
                Price = "₱ " + product.displayPrice(),
                TileImage = product.Image,
                Margin = new Padding(4, 7, 4, 7),
                Cursor = Cursors.Hand,
                ProductObj = product

            };

            return tile;
        }

        public string getImageFilePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;",
                Title = "Select an Image"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image.FromFile(openFileDialog.FileName);
                    return openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                    return null;
                }
            }
            return null;
        }

    }

    // Optional mabye remove nalang later on lmao
    /*
    public class Pallete
    {
        public static Color accent = Color.FromArgb(254, 182, 66);
        public static Color main = Color.FromArgb(238, 238, 238);
        public static Color black = Color.Black;
        public static Color white = Color.White;
    }
    */
}
