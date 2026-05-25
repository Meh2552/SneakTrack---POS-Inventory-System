using SneakTrack___POS___Inventory_System.UIControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SneakTrack___POS___Inventory_System
{
    public class ProductController
    {
        private MainSystem sys;
        private DataHandler dh;
        private WindowHandler wh;
        private Validator v;

        public ProductController(MainSystem system)
        {
            this.sys = system;
            this.dh = sys.DH;
            this.wh = sys.WH;
            this.v = sys.VAL;
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

        public bool hasDuplicateProduct(string productName, string brandName, string colorName)
        {
            return dh.ProductMasterList.AsEnumerable().Any(row =>
                string.Equals(row.Field<string>("product_name"), productName, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(row.Field<string>("brand_name"), brandName, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(row.Field<string>("color_name"), colorName, StringComparison.OrdinalIgnoreCase)
            );
        }


        public Label brandToLabel(string brandName)
        {
            Label label = new Label
            {
                Text = brandName.ToUpper(),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
                Margin = new Padding(30, 15, 0, 15),
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
                Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left,
                AutoSize = true,
                Margin = new Padding(35, 0, 0, 0)
            };

            return flow;
        }

        public List<ProductTile> loadProducts(TableLayoutPanel tablePanel, bool clearRowAfter0) // TODO: make method accesible to Products idk how coz of the event
        {

            List<Product> list = dh.toProducts(dh.ProductMasterList);
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
                    int labelRow = tablePanel.RowCount++;
                    current = prod.BrandId;
                    tablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
                    tablePanel.Controls.Add(brandToLabel(prod.Brand), 0, labelRow);

                    int flowRow = tablePanel.RowCount++;
                    currentProd = productContainer();
                    tablePanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    tablePanel.Controls.Add(currentProd, 0, flowRow);
                }

                ProductTile pt = wh.toProductTile(prod);
                currentProd.Controls.Add(pt);
                ptList.Add(pt);
            }

            return ptList;
        }

        // v.idFromValue(dh.ProductMasterList, "brand_name", "brand_id", p.Brand, true)  mabye useful
        public void addProduct(Product p)
        {

            int brandid = v.tableHasValue(dh.dataToTable(dh.selectQuery("Brand")), "brand_name", p.Brand, true) 
                ? v.readInt(dh.getValueFromTable(dh.selectQuery("Brand", "brand_id", $"brand_name = '{p.Brand}'")))
                : dh.toBrandDB(p);
            Debug.WriteLine($"Brand ID: {brandid}");

            int colorid = v.tableHasValue(dh.dataToTable(dh.selectQuery("Color")), "color_name", p.Color, true) 
                ? v.readInt(dh.getValueFromTable(dh.selectQuery("Color", "color_id", $"color_name = '{p.Color}'")))
                : dh.toColorDB(p);
            Debug.WriteLine($"Color ID: {colorid}");

            int prodid = dh.toProductDB(p, brandid, colorid); //TODO: yung price sa variant dapat iba for each gender.
            Debug.WriteLine($"Product ID: {prodid}");

            List<char> genders = new List<char>();
            List<int> variantIds = new List<int>();

            foreach (Variant v in p.Variants)
            {
                if (!genders.Contains(v.Gender)) 
                {
                    genders.Add(v.Gender);
                    variantIds.Add(dh.toVariantDB(v, prodid));
                }

                dh.toSizeDB(v, variantIds[genders.FindIndex(g => g == v.Gender)]);
            }
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

        public int totalQuantity(List<Product> list)
        {
            int total = 0;
            foreach (Product p in list)
            {
                total += p.totalQuantity();
            }
            return total;
        }

        public int totalProductTypes()
        {
            int total = dh.ProductMasterList.AsEnumerable()
                .Select(p => p.Field<int>("product_id"))
                .Distinct().Count();

            return total;
        }

        public int totalStock()
        {
            int total = dh.ProductMasterList.AsEnumerable()
                .Select(p => p.Field<int>("quantity")).Sum();

            return total;
        }

        public decimal totalValue()
        {
            decimal total = dh.ProductMasterList.AsEnumerable()
                .Select(p => p.Field<int>("quantity") * p.Field<decimal>("price")).Sum();

            return total;
        }
    }
}
