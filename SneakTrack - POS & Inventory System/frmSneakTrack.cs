using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System
{
    public partial class frmSneakTrack : Form
    {
        // Mostly for ease of reference
        private MainSystem sys;
        private Validator v;
        private WindowHandler wh;
        private UserAuth auth;

        public frmSneakTrack(MainSystem system) // Makes sure same sys throughout
        {
            this.sys = system;
            InitializeComponent();
            userConLogin.initialize(sys);
            userConMainDash.initialize(sys);
        }

        private void frmSneakTrack_Load(object sender, EventArgs e)
        {
            
        }

    }

}