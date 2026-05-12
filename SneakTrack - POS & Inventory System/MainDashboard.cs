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
    public partial class MainDashboard : UserControl
    {
        private MainSystem sys;

        public MainDashboard()
        {
            InitializeComponent();
        }
        public void initialize(MainSystem system)
        {
            this.sys = system;
        }
    }
}
