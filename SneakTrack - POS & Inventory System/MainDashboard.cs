using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private UserAuth ua;

        public MainDashboard()
        {
            InitializeComponent();
        }

        public void initialize(MainSystem system)
        {
            this.sys = system;
            this.ua = sys.UA;
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            
        }

        public void start()
        {
            checkRole();
        }

        // Checks the role of the user and enables/disables buttons accordingly
        private void checkRole()
        {
            lbUsersName.Text = ua.CurrentUser.Name;
            lbUserRole.Text = ua.CurrentUser.Role;

            if (ua.CurrentUser.Role == "ADMIN")
            {
                btnUsersSB.Visible = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        Color darken = Color.FromArgb(198, 148, 17);
        Color sbColor = Color.FromArgb(254, 182, 66);

        private void btnProdSB_Click(object sender, EventArgs e)
        {
            selectedColorBtn(btnProdSB);
        }

        private void btnInvSB_Click(object sender, EventArgs e)
        {
            selectedColorBtn(btnInvSB);
        }

        private void btnHistSB_Click(object sender, EventArgs e)
        {
            selectedColorBtn(btnHistSB);
        }

        private void btnUsersSB_Click(object sender, EventArgs e)
        {
            selectedColorBtn(btnUsersSB);
        }

        private void selectedColorBtn(Button selectedBtn)
        {
            btnProdSB.BackColor = sbColor;
            btnInvSB.BackColor = sbColor;
            btnHistSB.BackColor = sbColor;
            btnUsersSB.BackColor = sbColor;
            selectedBtn.BackColor = darken;
        }

    }
}
