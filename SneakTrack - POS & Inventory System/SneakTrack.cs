using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System
{
    public partial class frmSneakTrack : Form
    {
        public frmSneakTrack()
        {
            InitializeComponent();
        }

        private void frmSneakTrack_Load(object sender, EventArgs e)
        {
            splitC_Sidebar.Width = 1;
        }
    }
}
