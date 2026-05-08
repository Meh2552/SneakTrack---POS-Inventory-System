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

        public frmSneakTrack()
        {
            InitializeComponent();

        }

        private WindowHandler wh = new WindowHandler();
        private UserAuth auth = new UserAuth();
        private Validator v = new Validator();

        private void frmSneakTrack_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string inuser = v.readString(txbxUsername.Text), inpass = v.readString(txbxPassword.Text);
            if (auth.authLogin(inuser, inpass))
            {
                await Task.Delay(300);
                wh.switchControl(tblpnUserAuthSplit, tblpnUATransition);
                await Task.Delay(4000);
                // wh.switchControl(tblpnUATransition);
            }

            else
            {
                wh.changeLbTxt(lbUserFormErr, "Invalid username or password.");
                txbxPassword.Clear();
                txbxUsername.Clear();
                txbxUsername.Focus();
            }
        }
    }

}
