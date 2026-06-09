using SneakTrack___POS___Inventory_System.UIControls;
using System;
using System.Data;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System
{
    public partial class UserManager : UserControl
    {
        private MainSystem sys;
        private UserAuth ua;
        private Validator v;
        private UserController uc;

        private UserAuth.User selected;
        private string search;

        public UserManager()
        {
            InitializeComponent();
        }

        public void initialize(MainSystem system)
        {
            this.sys = system;
            this.ua = sys.UA;
            this.v = sys.VAL;
            this.uc = sys.UC;

            uc.loadDataGrid(dtgridUserFields);
        }

        private void dtgridUserFields_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridViewRow row = dtgridUserFields.CurrentRow;
            selected = (UserAuth.User)row.DataBoundItem;

            txbxSelectedUser.Text =
                $"{selected.Name} - {selected.Role}\r\n" + 
                $"Username: {selected.Username}\r\n" + 
                $"Account Created: {selected.DateCreated}";
        }

        private void btnArchiveAcc_Click(object sender, EventArgs e)
        {
            if (selected == null)
            {
                MessageBox.Show("No selected user.");
                return;
            }

            //TODO: prevent archive of current user or logoout if able to also prevent no admin and 1 user

            ConfirmationPrompt confirm = new ConfirmationPrompt();
            confirm.Header = "Archive Account";
            confirm.Prompt = $"Are you sure you want to archive the user \"{selected.Username}\"?";

            DialogResult results = confirm.ShowDialog();

            if (results == DialogResult.OK)
            {
                uc.archiveAccount(selected);
                reloadUser();
            }
        }

        private void reloadUser()
        {
            uc.reloadGrid(dtgridUserFields);
        }

        private void reloadUser(string query)
        {
            uc.reloadGrid(dtgridUserFields, query);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            search = null;
            reloadUser();
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            AddUserForm addForm = new AddUserForm(sys);
            DialogResult result = addForm.ShowDialog(this);

            if (result == DialogResult.OK) reloadUser();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (search == null) reloadUser();
            else reloadUser(search);
        }

        private void btnEditAcc_Click(object sender, EventArgs e)
        {
            EditUserForm editForm = new EditUserForm(sys, selected);
            DialogResult result = editForm.ShowDialog(this);

            if (result == DialogResult.OK) reloadUser();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string textbox = txbxSearch.Texts;

            if (textbox == null) return;
            search = textbox;
            reloadUser(v.readString(textbox));
        }
    }
}

