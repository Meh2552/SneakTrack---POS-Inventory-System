using SneakTrack___POS___Inventory_System.UIControls;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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

        public bool readBarcode(string input, int quantity)
        {
            bool output = false;

            DataTable productsM = dh.ProductMasterDT;
            if (v.tableHasValue(productsM, "Barcode", input))
            {
                DataRow dr = productsM.Select($"Barcode = '{input}'").First();

                Product p = idsToProduct(v.readInt(dr["product_id"]));

                dh.updateValueToTable(dh.updateQuery("Size", "quantity += @quantity", $"size_id = {dr["size_id"]}"), "@quantity", quantity.ToString());
                MessageBox.Show("Product updated successfully.", "Stock Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            else
            {
                MessageBox.Show("Barcode not found in database.");
                return false;
            }
        } // TODO: stock limits for quantity

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

        public int brandToDB(Product p)
        {
            return v.tableHasValue(dh.dtFromTable(dh.selectQuery("Brand")), "brand_name", p.Brand, true)
                ? v.readInt(dh.getValueFromTable(dh.selectQuery("Brand", "brand_id", $"brand_name = '{p.Brand}'")))
                : dh.toBrandDB(p);
        }

        public int colorToDB(Product p)
        {
            return v.tableHasValue(dh.dtFromTable(dh.selectQuery("Color")), "color_name", p.Color, true)
                ? v.readInt(dh.getValueFromTable(dh.selectQuery("Color", "color_id", $"color_name = '{p.Color}'")))
                : dh.toColorDB(p);
        }

        public List<ProductTile> loadProducts(TableLayoutPanel tablePanel, List<Product> list, int clearFromRow = 1)
        {
            List<ProductTile> ptList = new List<ProductTile>();

            if (clearFromRow >= 1)
            {
                wh.clearRows(tablePanel, clearFromRow);
                TableLayoutRowStyleCollection style = tablePanel.RowStyles;
                tablePanel.RowCount = style.Count;
            }

            else
            {
                tablePanel.RowStyles.Clear();
                tablePanel.Controls.Clear();
            }

            tablePanel.SuspendLayout();

            if (list == null || list.Count == 0)
            {
                tablePanel.RowCount++;
                tablePanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                Debug.WriteLine("No products found., RC: " + tablePanel.RowCount);

                Label resultLabel = brandToLabel("No products found.");
                resultLabel.Font = new Font("Yu Gothic UI", 30F, FontStyle.Bold);
                resultLabel.Dock = DockStyle.Fill;
                resultLabel.AutoSize = true;
                resultLabel.TextAlign = ContentAlignment.MiddleCenter;
                Debug.WriteLine("Label added: " + resultLabel?.Text);

                FlowLayoutPanel flpanel = productContainer();
                flpanel.Padding = new Padding(0, 70, 0, 50);
                flpanel.Dock = DockStyle.None;
                flpanel.AutoSize = true;
                flpanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;

                tablePanel.Controls.Add(flpanel, 0, tablePanel.RowCount);
                flpanel.Controls.Add(resultLabel);

                tablePanel.ResumeLayout();
                return null;
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

            tablePanel.ResumeLayout();
            return ptList;
        }

        // v.idFromValue(dh.productMasterDT, "brand_name", "brand_id", p.Brand, true)  mabye useful
        public void addProduct(Product p)
        {
            int brandid = brandToDB(p);
            int colorid = colorToDB(p);

            int prodid = dh.toProductDB(p, brandid, colorid); //TODO: yung price sa variant dapat iba for each gender.

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

        public void updateProd(Product newProd, Product oldProd) 
        {
            int prodId = oldProd.ProdId;
            Debug.WriteLine(newProd.ToString());
            Debug.WriteLine(oldProd.ToString());
            
            if (newProd.Brand != oldProd.Brand)
            {
                int brandid = brandToDB(newProd);
                dh.updateValueToTable(dh.updateQuery("Product", "brand_id = @brand_id", $"product_id = {prodId}"), "@brand_id", brandid.ToString());
            }

            if (newProd.Color != oldProd.Color)
            {
                int colorid = colorToDB(newProd);
                dh.updateValueToTable(dh.updateQuery("Product", "color_id = @color_id", $"product_id = {prodId}"), "@color_id", colorid.ToString());
            }


            if (newProd.Name != oldProd.Name) 
                dh.updateValueToTable(dh.updateQuery("Product", "product_name = @product_name", $"product_id = {prodId}"), "@product_name", newProd.Name);

            if (newProd.Description != oldProd.Description)
                dh.updateValueToTable(dh.updateQuery("Product", "description = @description", $"product_id = {prodId}"), "@description", newProd.Description);

            if (newProd.ImagePath != oldProd.ImagePath)
                if (newProd.ImagePath != null )dh.updateImage(newProd.ImagePath, prodId, newProd.newImageFileName(prodId));
                else dh.updateValueToTable(dh.updateQuery("Product", "image = @image", $"product_id = {prodId}"), "@image", v.readString(newProd.ImagePath));

            if (newProd.Archived != oldProd.Archived)
                dh.updateValueToTable(dh.updateQuery("Product", "archived = @archived", $"product_id = {prodId}"), "@archived", newProd.Archived ? "1" : "0");

            if (newProd.ForSale != oldProd.ForSale)
                dh.updateValueToTable(dh.updateQuery("Product", "for_sale = @for_sale", $"product_id = {prodId}"), "@for_sale", newProd.ForSale ? "1" : "0");

            int mVariantId = oldProd.getMaleVariant()?.VariantId ?? 0;
            int fVariantId = oldProd.getFemaleVariant()?.VariantId ?? 0; //TODO: gender change
            int uVariantId = oldProd.getUnisexVariant()?.VariantId ?? 0;
            bool removeM = false, removeF = false, removeU = false;

            if (newProd.HasMale != oldProd.HasMale && newProd.HasMale) mVariantId = updateProductVariantsTable(newProd.ProdId, newProd.getMaleVariant());

            if (newProd.HasFemale != oldProd.HasFemale && newProd.HasFemale) fVariantId = updateProductVariantsTable(newProd.ProdId, newProd.getFemaleVariant());

            if (newProd.HasUnisex != oldProd.HasUnisex && newProd.HasUnisex) uVariantId = updateProductVariantsTable(newProd.ProdId, newProd.getUnisexVariant());

            if (newProd.HasMale && newProd.mPrice() != oldProd.mPrice())
                dh.updateValueToTable(dh.updateQuery("Product_Variants", "price = @price", $"variant_id = {mVariantId}"), "@price", newProd.mPrice().ToString());

            if (newProd.HasFemale && newProd.fPrice() != oldProd.fPrice())
                dh.updateValueToTable(dh.updateQuery("Product_Variants", "price = @price", $"variant_id = {fVariantId}"), "@price", newProd.fPrice().ToString());

            if (newProd.HasUnisex && newProd.uPrice() != oldProd.uPrice())
                dh.updateValueToTable(dh.updateQuery("Product_Variants", "price = @price", $"variant_id = {uVariantId}"), "@price", newProd.uPrice().ToString());

            Debug.WriteLine($"\nVariant Ids: m:{mVariantId}, f:{fVariantId}, u:{uVariantId}");

            foreach (Variant vari in newProd.Variants)
            {   
                int variantId = 0;
                switch (vari.Gender)
                {
                    case 'M':
                        variantId = mVariantId;
                        break;
                    case 'F':
                        variantId = fVariantId;
                        break;
                    case 'U':
                        variantId = uVariantId;
                        break;
                }

                if (vari.SizeId == -1)
                {
                    Debug.WriteLine("\nNew Variant:\n" + vari.ToString());
                    dh.toSizeDB(vari, variantId);
                }

                else if (vari.Remove)
                {
                    Debug.WriteLine("\nRemove Variant:\n" + vari.ToString());
                    dh.deleteValueFromTable("Size", $"size_id = {vari.SizeId}");
                }

                else if (vari.VariantId > 0)
                {
                    Debug.WriteLine("\nUpdate Variant:\n" + vari.ToString());
                    Debug.WriteLine("\nUpdate Old Prod:\n" + oldProd.fromSizeId(vari.SizeId)?.ToString());
                    updateSizeTable(vari, oldProd.fromSizeId(vari.SizeId) ,variantId);
                }
            }

            if (newProd.HasMale != oldProd.HasMale && !newProd.HasMale) deleteProductVariantsTable(mVariantId);
            if (newProd.HasFemale != oldProd.HasFemale && !newProd.HasFemale) deleteProductVariantsTable(fVariantId);
            if (newProd.HasUnisex != oldProd.HasUnisex && !newProd.HasUnisex) deleteProductVariantsTable(uVariantId);
        }

        private int updateProductVariantsTable(int product_id, Variant genVariant)
        {
            return dh.toVariantDB(genVariant, product_id);
        }

        private void deleteProductVariantsTable(int variantId)
        {
            dh.deleteValueFromTable("Size", $"variant_id = {variantId}");
            dh.deleteValueFromTable("Product_Variants", $"variant_id = {variantId}");
        }

        private void updateSizeTable(Variant newVari, Variant oldVari, int variant_id)
        {
            if (oldVari == null)
            {
                Debug.WriteLine("Variable 'oldVari' from method updateSizeTable() in ProductController is null");
                return;
            }

            if (variant_id != oldVari.VariantId)
                dh.updateValueToTable(dh.updateQuery("Size", "variant_id = @variant_id", $"size_id = {newVari.SizeId}"), "@variant_id", variant_id.ToString());

            if (newVari.Size != oldVari.Size)
                dh.updateValueToTable(dh.updateQuery("Size", "size = @size", $"size_id = {newVari.SizeId}"), "@size", newVari.Size.ToString());

            if (newVari.SizeType != oldVari.SizeType)
                dh.updateValueToTable(dh.updateQuery("Size", "size_type = @size_type", $"size_id = {newVari.SizeId}"), "@size_type", newVari.SizeType);

            if (newVari.Quantity != oldVari.Quantity)
                dh.updateValueToTable(dh.updateQuery("Size", "quantity = @quantity", $"size_id = {newVari.SizeId}"), "@quantity", newVari.Quantity.ToString());

            if (newVari.Barcode != oldVari.Barcode)
                dh.updateValueToTable(dh.updateQuery("Size", "barcode = @barcode", $"size_id = {newVari.SizeId}"), "@barcode", newVari.Barcode);
        }

        public void updateQuantity(Product P)
        {
            foreach (Variant v in P.Variants)
            {
                dh.updateValueToTable(dh.updateQuery("Size", "quantity = @quantity", $"size_id = {v.SizeId}"), "@quantity", v.Quantity.ToString());
            }

        }

        public List<ProductTile> searchProducts(string search, TableLayoutPanel tablePanel)
        {
            search = search.ToUpper();
            List<Product> searchResult = new List<Product>();

            foreach (Product product in dh.MasterToProductList)
            {
                if (product.Name.ToUpper().Contains(search) ||
                    product.Brand.ToUpper().Contains(search) ||
                    product.Color.ToUpper().Contains(search) ||
                    product.Description.ToUpper().Contains(search))
                {
                    searchResult.Add(product);
                    continue;
                }

                if (product.Variants != null)
                {
                    bool variantMatch = false;
                    foreach (Variant variant in product.Variants)
                    {
                        if (variant.Size.ToString().ToUpper().Contains(search) ||
                            variant.Price.ToString().ToUpper().Contains(search) ||
                            variant.Gender.ToString().ToUpper().Contains(search) ||
                            variant.SizeType.ToUpper().Contains(search) ||
                            variant.Barcode.ToUpper().Contains(search))
                        {
                            searchResult.Add(product);
                            variantMatch = true;
                            break;
                        }
                    }

                    if (variantMatch) continue;
                }
            }

            Debug.WriteLine($"Search for '{search}' found {searchResult.Count} results.");
            return loadProducts(tablePanel, searchResult, 1);
        }

        public Product idsToProduct(int prodId)
        {
            foreach(Product p in dh.MasterToProductList)
            {
                if (p.ProdId == prodId)
                    return p;
            }
            return null;
        }

        public string toProdInfo(Product p)
        {
            string listed = p.ForSale ? "Listed for sale" : "Unlisted";
            string output =
                "\r\n" +
                $"Product Name: {p.DisplayName()}\r\n" +
                $"Color: {p.Color}\r\n" +
                $"Brand: {p.Brand}\r\n\r\n" +
                $"Variants: {p.gendersString()}\r\n" +
                $"Total Quantity: {p.totalQuantity()}\r\n" +
                $"Status: {listed}\r\n\r\n" +
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
            int total = dh.ProductMasterDT.AsEnumerable()
                .Select(p => p.Field<int>("product_id"))
                .Distinct().Count();

            return total;
        }

        public int totalStock()
        {
            int total = dh.ProductMasterDT.AsEnumerable()
                .Select(p => p.Field<int>("quantity")).Sum();

            return total;
        }

        public decimal totalValue()
        {
            decimal total = dh.ProductMasterDT.AsEnumerable()
                .Select(p => p.Field<int>("quantity") * p.Field<decimal>("price")).Sum();

            return total;
        }
    }
}
