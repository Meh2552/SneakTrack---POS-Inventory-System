using SneakTrack___POS___Inventory_System.UIControls;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System
{
    public partial class EditUserForm : Form
    {

        private MainSystem sys;
        private Validator v;
        private DataHandler dh;

        UserAuth.User inUser;
        private string username;
        private string password;

        public EditUserForm()
        {
            InitializeComponent();
        }

        public EditUserForm(MainSystem system, UserAuth.User user)
        {
            InitializeComponent();

            this.sys = system;
            this.v = sys.VAL;
            this.dh = sys.DH;
            this.inUser = user;

            initialize();
        }

        private void initialize() 
        {
            cmbxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxRole.SelectedIndex = inUser.Role.Equals("STAFF") ? 1 : 0;

            txbxName.Texts = inUser.Name;
            txbxUsername.Texts = inUser.Username;
            txbxPassword.Texts = inUser.Password;
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

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (!validateFields())
            {
                MessageBox.Show("Unexpected error occurred.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            username = v.readString(txbxUsername.Texts);
            password = v.readString(txbxPassword.Texts);

            if (dh.hasDuplicateUsername(inUser.UserID, username, true))
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
            confirm.Header = "Edit User Prompt";
            confirm.Prompt = $"Confirm changes made?";

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

            if (inUser.Name != user.Name)
                dh.updateValueToTable(dh.updateQuery("User", "name = @name", $"user_id = {inUser.UserID}"), "@name", user.Name);

            if (inUser.Username != user.Username)
                dh.updateValueToTable(dh.updateQuery("User", "username = @username", $"user_id = {inUser.UserID}"), "@username", user.Username);

            if (inUser.Role != user.Role)
                dh.updateValueToTable(dh.updateQuery("User", "role = @role", $"user_id = {inUser.UserID}"), "@role", user.Role);

            if (inUser.Password != user.Password)
                dh.updateValueToTable(dh.updateQuery("User", "password = @password", $"user_id = {inUser.UserID}"), "@password", user.Password);
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            txbxPassword.PasswordChar = !txbxPassword.PasswordChar;
            btnHidePass.Image = txbxPassword.PasswordChar ? Properties.Resources.hideeye : Properties.Resources.openeye;
        }
    }
}
