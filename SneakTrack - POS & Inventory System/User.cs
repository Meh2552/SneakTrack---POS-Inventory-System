using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SneakTrack___POS___Inventory_System
{
    public partial class User : UserControl
    {
        int id = 1;
        int selectedRow = -1;
        public User()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAccount2 frm = new AddAccount2();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                dgvUsers.Rows.Add(
                    id++,
                    frm.username,
                    frm.role,
                    "Active"
                );

                MessageBox.Show("Account Added!");
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            if (selectedRow >= 0)
            {
                dgvUsers.Rows[selectedRow]
                .Cells["colStatus"].Value = "Disabled";

                MessageBox.Show("Account Disabled!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedRow >= 0)
            {
                AddAccount2 frm = new AddAccount2();

                frm.txtUser.Text =
                    dgvUsers.Rows[selectedRow]
                    .Cells["colUsername"].Value.ToString();

                frm.cboRole.Text =
                    dgvUsers.Rows[selectedRow]
                    .Cells["colRole"].Value.ToString();

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dgvUsers.Rows[selectedRow]
                    .Cells["colUsername"].Value =
                    frm.username;

                    dgvUsers.Rows[selectedRow]
                    .Cells["colRole"].Value =
                    frm.role;

                    MessageBox.Show("Updated!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRow >= 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this account?",
                    "Delete Account",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dgvUsers.Rows.RemoveAt(selectedRow);

                    MessageBox.Show("Account Deleted!");

                    selectedRow = -1;
                }
            }
            else
            {
                MessageBox.Show("Select an account first!");
            }
        }
    }
}

