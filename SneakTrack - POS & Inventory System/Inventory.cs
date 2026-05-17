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

        string filter = "";
        string query = "SELECT * FROM Product " + 
            "INNER JOIN Product_Variants " +
            "ON Product.product_id = Product_Variants.product_id " +
            "LEFT JOIN Size ON Product_Variants.variant_id = Size.variant_id " +
            "LEFT JOIN Brand ON Product.brand_id = Brand.brand_id " +
            "LEFT JOIN Color ON Product.color_id = Color.color_id "+
            "ORDER BY Product.brand_id";

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
    
        public void loadProducts()
        {

            List<Product> prodList = dh.getProducts(query);
            tblpnSelection.Controls.Clear();
            tblpnSelection.RowStyles.Clear();

            int current = 0, count = 0;
            FlowLayoutPanel currentProd = new FlowLayoutPanel(); 
            foreach (Product prod in prodList)
            {
                if (prod.BrandId != current)
                {
                    current = prod.BrandId;
                    //Debug.WriteLine("Brand: " + prod.BrandId + ", " + prod.Brand); TODO: remove
                    tblpnSelection.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
                    tblpnSelection.Controls.Add(toLabel(prod.Brand));

                    currentProd = productContainer();
                    tblpnSelection.RowStyles.Add(new RowStyle(SizeType.Absolute, 500F));
                    tblpnSelection.Controls.Add(currentProd);
                }

                Variant v = prod.Variants.ElementAt(0);
                currentProd.Controls.Add(product(prod, v));

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

        private ProductTile product(Product product, Variant v)
        {
            ProductTile tile = new ProductTile
            {
                TopText = product.Brand,
                BottomText = product.Name,
                Price = "₱ " + v.Price,
                TileImage = product.Image,
                Margin = new Padding(4, 7, 4, 7),

            };

            return tile;
        }

    }

}
