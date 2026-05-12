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

        public frmSneakTrack(MainSystem sys) // Makes sure same sys throughout
        {
            this.sys = sys;
            this.v = sys.VAL;
            this.auth = new UserAuth(sys);
            this.wh = sys.WH;
            InitializeComponent();
        }

        private void frmSneakTrack_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string inuser = v.readStringNoEnd(txbxUsername.Text), inpass = v.readStringNoEnd(txbxPassword.Text);

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
                // wh.switchControl(tblpnUATransition);
            }

            else
            {
                loginResult("Invalid username or password");
            }
        }

        private void loginResult(string message)
        {
            wh.changeLbTxt(lbUserFormErr, message);
            txbxUsername.Clear();
            txbxPassword.Clear();
            txbxUsername.Focus();
        }
    }

}
