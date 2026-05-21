using SneakTrack___POS___Inventory_System.UIControls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System
{
    public class ProductController
    {
        private MainSystem sys;
        private DataHandler dh;
        private WindowHandler wh;

        public ProductController(MainSystem system)
        {
            this.sys = system;
            this.dh = sys.DH;
            this.wh = sys.WH;
        }

        /* remove if unecessary idk
        public Product prodFromID(int product_id)
        {
            Product output;

            foreach(Product p in ProdList)
            {
                if (p.ProdId == product_id) return p;
            }

            return null;
        }
        */

        public Label brandToLabel(string brandName)
        {
            Label label = new Label
            {
                Text = brandName.ToUpper(),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
                Margin = new Padding(30, 0, 0, 0),
                Font = new Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold),
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleLeft
            };

            return label;
        }

        public FlowLayoutPanel productContainer()
        {
            FlowLayoutPanel flow = new FlowLayoutPanel
            {
                Anchor = AnchorStyles.Bottom | AnchorStyles.Top,
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 0)
            };

            return flow;
        }

        public List<ProductTile> loadProducts(TableLayoutPanel tablePanel, bool clearRowAfter0) // TODO: make method accesible to Products idk how coz of the event
        {

            List <Product> list = dh.toProducts(dh.ProductMasterList);
            List<ProductTile> ptList = new List<ProductTile>();

            if (clearRowAfter0) wh.clearRows(tablePanel, 0);
            else
            {
                tablePanel.RowStyles.Clear();
                tablePanel.Controls.Clear();
            }

            int current = 0, count = 0; // TODO: limit for page length
            FlowLayoutPanel currentProd = new FlowLayoutPanel();
            foreach (Product prod in list)
            {
                if (prod.BrandId != current)
                {
                    current = prod.BrandId;
                    tablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
                    tablePanel.Controls.Add(brandToLabel(prod.Brand));

                    currentProd = productContainer();
                    tablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 500F)); // TODO: adjust values
                    tablePanel.Controls.Add(currentProd);
                }

                ProductTile pt = wh.toProductTile(prod);
                currentProd.Controls.Add(pt);
                ptList.Add(pt);
            }

            return ptList;
        }

        public string toProdInfo(Product p)
        {
            string output =
                $"Product Name: {p.DisplayName()}\r\n" +
                $"Color: {p.Color}\r\n" +
                $"Brand: {p.Brand}\r\n\r\n" +
                $"Variants: {p.variantsString()}\r\n" +
                $"Total Quantity: {p.totalQuantity()}\r\n\r\n" +
                $"{p.Description}";
                
            return output;
        }
    }
}
