using SneakTrack___POS___Inventory_System.UIControls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System
{
    public partial class AddUserForm : Form
    {

        private MainSystem sys;
        private Validator v;
        private DataHandler dh;

        private string username;
        private string password;

        public AddUserForm()
        {
            InitializeComponent();
        }

        public AddUserForm(MainSystem system)
        {
            InitializeComponent();

            this.sys = system;
            this.v = sys.VAL;
            this.dh = sys.DH;

            initialize();
        }

        private void initialize() 
        {
            cmbxRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!validateFields())
            {
                MessageBox.Show("Unexpected error occurred.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            username = v.readString(txbxUsername.Texts);
            password = v.readString(txbxPassword.Texts);

            UserAuth.User checkDuplicate = dh.checkUserAuth(username);
            if (!string.IsNullOrEmpty(checkDuplicate.UserID))
            {
                MessageBox.Show("Duplicate user found.", "User Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            confirmationAddUser();

        }

        private bool validateFields()
        {
            bool valid = true;

            pcbxRoleError.Visible = false;
            lbPasswordError.Visible = false;
            lbPasswordError.Visible = false;
            lbNameErr.Visible = false;

            if (cmbxRole.SelectedIndex == -1)
            {
                pcbxRoleError.Visible = true;
                valid = false;
            }

            string name = v.readString(txbxName.Texts);
            if (name == null)
            {
                lbNameErr.Visible = true;
                lbNameErr.Text = "The field cannot be blank";
                valid = false;
            }

            string username = v.readStringNoEnd(txbxUsername.Texts);
            if (username == null)
            {
                lbUsernameError.Visible = true;
                lbUsernameError.Text = "The field cannot be blank";
                valid = false;
            }

            else if (!v.validateCharacters(username))
            {
                lbUsernameError.Visible = true;
                lbUsernameError.Text = "Invalid characters";
                valid = false;
            }

            else if (username.Length < 5)
            {
                lbUsernameError.Visible = true;
                lbUsernameError.Text = "Minimum of 8 characters";
                valid = false;
            }

            string password = v.readStringNoEnd(txbxPassword.Texts);
            if (password == null)
            {
                lbPasswordError.Visible = true;
                lbPasswordError.Text = "The field cannot be blank";
                valid = false;
            }

            else if (!v.validateCharacters(password))
            {
                lbPasswordError.Visible = true;
                lbPasswordError.Text = "Invalid characters";
                valid = false;
            }

            else if (password.Length < 5)
            {
                lbPasswordError.Visible = true;
                lbPasswordError.Text = "Minimum of 8 characters";
                valid = false;
            }

            return valid;
        }

        private void confirmationAddUser()
        {   
            ConfirmationPrompt confirm = new ConfirmationPrompt();
            confirm.Header = "Create User Prompt";
            confirm.Prompt = $"Add new user \"{username}\"?";

            DialogResult results = confirm.ShowDialog();

            if (results == DialogResult.OK) { 
                this.DialogResult = results;
                loadUser();
                this.Close();
            }
        }

        private void loadUser()
        {
            string name = v.readString(txbxName.Texts);
            string role = cmbxRole.GetItemText(cmbxRole.SelectedItem);

            UserAuth.User user = new UserAuth.User(username, password, name, role, "", "");
            dh.toUserDB(user);
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            txbxPassword.PasswordChar = !txbxPassword.PasswordChar;
            btnHidePass.Image = txbxPassword.PasswordChar ? Properties.Resources.hideeye : Properties.Resources.openeye;
        }
    }
}
