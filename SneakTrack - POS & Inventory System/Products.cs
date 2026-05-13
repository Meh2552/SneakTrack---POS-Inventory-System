using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakTrack___POS___Inventory_System
{
    public class Products
    {

        public int prodId { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public int size { get; set; }
        public string sizeType { get; set; }
        public string barcode { get; set; }

    }
}
