using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System.UIControls
{

    public partial class Tile : UserControl
    {
        private Color backColor = Color.White;
        private Color foreColor = Color.Black;
        private Color borderColor = Color.Black;
        private Image image = null;
        private int radius = 2;
        private int thickness = 2;

        public Tile()
        {
            InitializeComponent();
        }
    }

    //TODO: gawin to idk
}
