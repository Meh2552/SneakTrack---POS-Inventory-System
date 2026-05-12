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
    public partial class TESTDESIGNTEMP : Form
    {
        private MainSystem sys;
        private UserAuth ua;

        public TESTDESIGNTEMP(MainSystem system)
        {
            InitializeComponent();
            this.sys = system;
            this.ua = sys.UA;
        }

        private void TESTDESIGNTEMP_Load(object sender, EventArgs e)
        {

        }

        private void btnProdSB_Click(object sender, EventArgs e)
        {

        }

        private void btnInvSB_Click(object sender, EventArgs e)
        {

        }

        private void btnHistSB_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
