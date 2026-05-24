using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SneakTrack___POS___Inventory_System.UserAuth;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SneakTrack___POS___Inventory_System
{
    public partial class AddAccount2 : Form
    {
        public AddAccount2()
        {
            InitializeComponent();
        }

        public string username;
        public string password;
        public string role;

        private void AddAccount2_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" ||
            txtPass.Text == "" ||
            cboRole.Text == "")
            {
            MessageBox.Show("Complete all fields!");
            return;
            }

            username = txtUser.Text;
            password = txtPass.Text;
            role = cboRole.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
