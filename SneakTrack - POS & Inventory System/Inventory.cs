using SneakTrack___POS___Inventory_System.UIControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;

namespace SneakTrack___POS___Inventory_System
{
    public partial class Inventory : UserControl
    {
        private MainSystem sys;
        private Validator v;
        private WindowHandler wh;
        private DataHandler dh;
        private Product selected;

        public Inventory()
        {
            InitializeComponent();
            tblpnSideInfo.ColumnStyles[1].Width = 0;
        }

        public void initialize(MainSystem system)
        {
            this.sys = system;
            this.v = sys.VAL;
            this.wh = sys.WH;
            this.dh = sys.DH;
            loadProducts();
        }
    
        public void loadProducts() // TODO: make method accesible to Products
        {

            List<Product> prodList = dh.toProducts(dh.ProductMasterList);
            wh.clearRows(tblpnSelectionInv, 0);

            int current = 0, count = 0;
            FlowLayoutPanel currentProd = new FlowLayoutPanel(); 
            foreach (Product prod in prodList)
            {
                if (prod.BrandId != current)
                {
                    current = prod.BrandId;
                    //Debug.WriteLine("Brand: " + prod.BrandId + ", " + prod.Brand); TODO: remove
                    tblpnSelectionInv.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
                    tblpnSelectionInv.Controls.Add(toLabel(prod.Brand));

                    currentProd = productContainer();
                    tblpnSelectionInv.RowStyles.Add(new RowStyle(SizeType.Absolute, 500F));
                    tblpnSelectionInv.Controls.Add(currentProd);
                }

                Variant v = prod.Variants.ElementAt(0);
                ProductTile pt = wh.toProductTile(prod, v);
                pt.DoubleClick += new System.EventHandler(this.productTile_DoubleClick);
                currentProd.Controls.Add(pt);
                
            }
        }

        private Label toLabel(string brandName)
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

        private FlowLayoutPanel productContainer()
        {
            FlowLayoutPanel flow = new FlowLayoutPanel
            {
                Anchor = AnchorStyles.Bottom | AnchorStyles.Top,
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 0)
            };

            return flow;
        }

        private void productTile_DoubleClick(object sender, EventArgs e)
        {
            ProductTile tile = sender as ProductTile;
            System.Windows.Forms.MessageBox.Show("works");
            Debug.WriteLine("wowie");
        }
    }

}
