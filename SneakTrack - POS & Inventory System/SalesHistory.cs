using SneakTrack___POS___Inventory_System.UIControls;
using System;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System
{
    public partial class SalesHistory : UserControl
    {
        private MainSystem sys;
        private UserAuth ua;
        private Validator v;
        private UserController uc;
        private SalesController sc;

        private Sale selectedSale;
        private string selectedText;
        private string search;

        public SalesHistory()
        {
            InitializeComponent();
        }

        public void initialize(MainSystem system)
        {
            this.sys = system;
            this.ua = sys.UA;
            this.v = sys.VAL;
            this.uc = sys.UC;
            this.sc = sys.SC;

            tblpnSales.ColumnStyles[1].Width = 0;
            loadSaleLV();
        }

        private void loadSaleLV()
        {
            lsvSales.Items.Clear();
            lsvSales.Columns[lsvSales.Columns.Count - 1].Width = -2;

            bool alternate = false;
            foreach (Sale sl in sc.Sales)
            {
                ListViewItem item = new ListViewItem(new string[] { //TODO: ibahin to
                    sl.orderID,
                    sl.Date,
                    sl.revenue.ToString(),
                    sl.SaleID.ToString()
                });

                item.BackColor = alternate ? Color.LightGray : Color.Gainsboro;
                alternate = !alternate;

                lsvSales.Items.Add(item);
            }
        }

        private void lsvSales_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lsvSales.SelectedItems.Count == 0) return;

            tblpnSales.ColumnStyles[1].Width = 445;
            int id = v.readInt(lsvSales.SelectedItems[0].SubItems[3].Text);
            lsSelectedSale(sc.saleFromID(id));
        }

        private void lsSelectedSale(Sale sale)
        {
            if (sale.SaleItems == null || sale.SaleItems.Count <= 0) return;

            lbOrderNoRC.Text = $"Order No.{sale.orderID}";
            lbDateRC.Text = sale.Date;
            lbCashierNameRC.Text = "";

            foreach (SaleItem si in sale.SaleItems)
            {
                ListViewItem item = new ListViewItem(new string[] { //TODO: ibahin to
                    //TODO: this
                });

                lsvReciept.Items.Add(item);
            }
        }

        private void btnArchiveAcc_Click(object sender, EventArgs e)
        {/*
            if (selected == null)
            {
                MessageBox.Show("No selected user.");
                return;
            }

            //TODO: prevent archive of current user or logoout if able to

            ConfirmationPrompt confirm = new ConfirmationPrompt();
            confirm.Header = "Archive Account";
            confirm.Prompt = $"Are you sure you want to archive the user \"{selected.Username}\"?";

            DialogResult results = confirm.ShowDialog();

            if (results == DialogResult.OK)
            {
                uc.archiveAccount(selected);
                reloadUser();
            }
            */
        }

        private void reloadUser()
        {
            // uc.reloadGrid(dtgridUserFields);
        }

        private void reloadUser(string query)
        {
            // uc.reloadGrid(dtgridUserFields, query);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            search = null;
            reloadUser();
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            /*
            AddUserForm addForm = new AddUserForm(sys);
            DialogResult result = addForm.ShowDialog(this);

            if (result == DialogResult.OK) reloadUser();
            */
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            /*
            if (search == null) reloadUser();
            else reloadUser(search); */
        }

        private void btnEditAcc_Click(object sender, EventArgs e)
        {
            /*
            EditUserForm editForm = new EditUserForm(sys, selected);
            DialogResult result = editForm.ShowDialog(this);

            if (result == DialogResult.OK) reloadUser();
            */
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {/*
            string textbox = txbxSearch.Texts;

            if (textbox == null) return;
            search = textbox;
            reloadUser(v.readString(textbox));
        */}

        private void btnCloseRC_Click(object sender, EventArgs e)
        {
            tblpnSales.ColumnStyles[1].Width = 0;
        }
    }
}

