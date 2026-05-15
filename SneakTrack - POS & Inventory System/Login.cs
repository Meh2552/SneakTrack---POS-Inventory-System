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
    public partial class Login : UserControl
    {
        // Mostly for ease of reference
        private MainSystem sys;
        private Validator v;
        private WindowHandler wh;
        private UserAuth auth;

        public Login()
        {
            InitializeComponent();
        }

        public void initialize(MainSystem system)
        {
            this.sys = system;
            v = sys.VAL;
            wh = sys.WH;
            auth = sys.UA;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(txbxUsername.Texts);
            string inuser = v.readStringNoEnd(txbxUsername.Texts), inpass = v.readStringNoEnd(txbxPassword.Texts);

            if (string.IsNullOrEmpty(inuser) || string.IsNullOrEmpty(inpass))
            {
                loginResult("Please fill in the fields above");
            }

            else if (!v.validateCharacters(inuser) || !v.validateCharacters(inpass))
            {
                loginResult("Invalid characters (Only letters, numbers, and certain symbols)");
            }

            else if (auth.authLogin(inuser, inpass))
            {
                await Task.Delay(300);
                wh.switchControl(tblpnUserAuthSplit, tblpnUATransition);
                await Task.Delay(4000);
                wh.Dash.start();
                wh.switchControl(this, wh.Dash);
            }

            else
            {
                loginResult("Invalid username or password");
            }
        }

        private void loginResult(string message)
        {
            wh.changeLbTxt(lbUserFormErr, message);
            txbxUsername.Focus();
        }

        // Changes the image based on the state of the hide button in the password and hides the inputted data and vice versa
        private void btnHidePass_Click(object sender, EventArgs e)
        { 
            txbxPassword.PasswordChar = !txbxPassword.PasswordChar;
            btnHidePass.Image = txbxPassword.PasswordChar ? Properties.Resources.hideeye : Properties.Resources.openeye;
        }

        // Disables copying the password
        private void txbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.X))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txbxPassword_Enter(object sender, EventArgs e)
        {
            btnHidePass.Visible = true;
        }

        private void txbxPassword_Leave(object sender, EventArgs e)
        {
            btnHidePass.Visible = false;
        }
    }
}
