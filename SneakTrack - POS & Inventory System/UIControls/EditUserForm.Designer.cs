namespace SneakTrack___POS___Inventory_System
{
    partial class EditUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.tblpnAddProduct = new System.Windows.Forms.TableLayoutPanel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnFields = new SneakTrack___POS___Inventory_System.UIControls.RoundedPanel();
            this.lbNameErr = new System.Windows.Forms.Label();
            this.txbxName = new SneakTrack___POS___Inventory_System.UIControls.RoundedTxBx();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPasswordError = new System.Windows.Forms.Label();
            this.lbUsernameError = new System.Windows.Forms.Label();
            this.btnHidePass = new System.Windows.Forms.Button();
            this.lbFieldHeader = new System.Windows.Forms.Label();
            this.txbxPassword = new SneakTrack___POS___Inventory_System.UIControls.RoundedTxBx();
            this.lbPassword = new System.Windows.Forms.Label();
            this.pcbxRoleError = new System.Windows.Forms.PictureBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.cmbxRole = new System.Windows.Forms.ComboBox();
            this.txbxUsername = new SneakTrack___POS___Inventory_System.UIControls.RoundedTxBx();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tblpnAddProduct.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.pnFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxRoleError)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHeader.Location = new System.Drawing.Point(22, 18);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(106, 28);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "Edit User";
            this.lbHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseForm.BackColor = System.Drawing.Color.Black;
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(376, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(62, 69);
            this.btnCloseForm.TabIndex = 14;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            // 
            // tblpnAddProduct
            // 
            this.tblpnAddProduct.ColumnCount = 1;
            this.tblpnAddProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnAddProduct.Controls.Add(this.pnHeader, 0, 0);
            this.tblpnAddProduct.Controls.Add(this.pnBody, 0, 1);
            this.tblpnAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnAddProduct.Location = new System.Drawing.Point(0, 0);
            this.tblpnAddProduct.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnAddProduct.Name = "tblpnAddProduct";
            this.tblpnAddProduct.RowCount = 2;
            this.tblpnAddProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tblpnAddProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.63612F));
            this.tblpnAddProduct.Size = new System.Drawing.Size(438, 551);
            this.tblpnAddProduct.TabIndex = 15;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Black;
            this.pnHeader.Controls.Add(this.lbHeader);
            this.pnHeader.Controls.Add(this.btnCloseForm);
            this.pnHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(438, 69);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.pnBody.Controls.Add(this.pnFields);
            this.pnBody.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 69);
            this.pnBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(438, 482);
            this.pnBody.TabIndex = 1;
            // 
            // pnFields
            // 
            this.pnFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnFields.BorderColor = System.Drawing.Color.White;
            this.pnFields.Controls.Add(this.lbNameErr);
            this.pnFields.Controls.Add(this.txbxName);
            this.pnFields.Controls.Add(this.lbName);
            this.pnFields.Controls.Add(this.lbPasswordError);
            this.pnFields.Controls.Add(this.lbUsernameError);
            this.pnFields.Controls.Add(this.btnHidePass);
            this.pnFields.Controls.Add(this.lbFieldHeader);
            this.pnFields.Controls.Add(this.txbxPassword);
            this.pnFields.Controls.Add(this.lbPassword);
            this.pnFields.Controls.Add(this.pcbxRoleError);
            this.pnFields.Controls.Add(this.lbRole);
            this.pnFields.Controls.Add(this.cmbxRole);
            this.pnFields.Controls.Add(this.txbxUsername);
            this.pnFields.Controls.Add(this.lbUsername);
            this.pnFields.Controls.Add(this.btnEditUser);
            this.pnFields.Location = new System.Drawing.Point(54, 25);
            this.pnFields.Name = "pnFields";
            this.pnFields.Radius = 20;
            this.pnFields.Size = new System.Drawing.Size(327, 435);
            this.pnFields.TabIndex = 14;
            this.pnFields.Thickness = 5F;
            // 
            // lbNameErr
            // 
            this.lbNameErr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbNameErr.AutoSize = true;
            this.lbNameErr.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameErr.ForeColor = System.Drawing.Color.Tomato;
            this.lbNameErr.Location = new System.Drawing.Point(135, 100);
            this.lbNameErr.Name = "lbNameErr";
            this.lbNameErr.Size = new System.Drawing.Size(140, 16);
            this.lbNameErr.TabIndex = 55;
            this.lbNameErr.Text = "The field cannot be blank";
            this.lbNameErr.Visible = false;
            // 
            // txbxName
            // 
            this.txbxName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbxName.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbxName.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbxName.BackColor = System.Drawing.Color.White;
            this.txbxName.BorderColor = System.Drawing.Color.Silver;
            this.txbxName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxName.BorderRadius = 5;
            this.txbxName.BorderSize = 2;
            this.txbxName.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxName.ForeColor = System.Drawing.Color.DimGray;
            this.txbxName.Location = new System.Drawing.Point(39, 120);
            this.txbxName.Margin = new System.Windows.Forms.Padding(10, 0, 10, 4);
            this.txbxName.MaxLength = 60;
            this.txbxName.Multiline = false;
            this.txbxName.Name = "txbxName";
            this.txbxName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxName.PasswordChar = false;
            this.txbxName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbxName.PlaceholderText = "Name";
            this.txbxName.Size = new System.Drawing.Size(250, 35);
            this.txbxName.TabIndex = 54;
            this.txbxName.Texts = "";
            this.txbxName.UnderlinedStyle = false;
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbName.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(45, 88);
            this.lbName.Margin = new System.Windows.Forms.Padding(10, 10, 0, 3);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(203, 29);
            this.lbName.TabIndex = 53;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbPasswordError
            // 
            this.lbPasswordError.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbPasswordError.AutoSize = true;
            this.lbPasswordError.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswordError.ForeColor = System.Drawing.Color.Tomato;
            this.lbPasswordError.Location = new System.Drawing.Point(135, 240);
            this.lbPasswordError.Name = "lbPasswordError";
            this.lbPasswordError.Size = new System.Drawing.Size(140, 16);
            this.lbPasswordError.TabIndex = 52;
            this.lbPasswordError.Text = "The field cannot be blank";
            this.lbPasswordError.Visible = false;
            // 
            // lbUsernameError
            // 
            this.lbUsernameError.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbUsernameError.AutoSize = true;
            this.lbUsernameError.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsernameError.ForeColor = System.Drawing.Color.Tomato;
            this.lbUsernameError.Location = new System.Drawing.Point(135, 168);
            this.lbUsernameError.Name = "lbUsernameError";
            this.lbUsernameError.Size = new System.Drawing.Size(140, 16);
            this.lbUsernameError.TabIndex = 51;
            this.lbUsernameError.Text = "The field cannot be blank";
            this.lbUsernameError.Visible = false;
            // 
            // btnHidePass
            // 
            this.btnHidePass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHidePass.BackColor = System.Drawing.Color.White;
            this.btnHidePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHidePass.FlatAppearance.BorderSize = 0;
            this.btnHidePass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHidePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHidePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePass.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources.hideeye;
            this.btnHidePass.Location = new System.Drawing.Point(249, 265);
            this.btnHidePass.Margin = new System.Windows.Forms.Padding(0);
            this.btnHidePass.Name = "btnHidePass";
            this.btnHidePass.Size = new System.Drawing.Size(30, 25);
            this.btnHidePass.TabIndex = 47;
            this.btnHidePass.UseVisualStyleBackColor = false;
            this.btnHidePass.Click += new System.EventHandler(this.btnHidePass_Click);
            // 
            // lbFieldHeader
            // 
            this.lbFieldHeader.AutoSize = true;
            this.lbFieldHeader.BackColor = System.Drawing.Color.Transparent;
            this.lbFieldHeader.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFieldHeader.ForeColor = System.Drawing.Color.Black;
            this.lbFieldHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbFieldHeader.Location = new System.Drawing.Point(111, 46);
            this.lbFieldHeader.Name = "lbFieldHeader";
            this.lbFieldHeader.Size = new System.Drawing.Size(111, 32);
            this.lbFieldHeader.TabIndex = 15;
            this.lbFieldHeader.Text = "Edit User";
            this.lbFieldHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbxPassword
            // 
            this.txbxPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbxPassword.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbxPassword.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbxPassword.BackColor = System.Drawing.Color.White;
            this.txbxPassword.BorderColor = System.Drawing.Color.Silver;
            this.txbxPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxPassword.BorderRadius = 5;
            this.txbxPassword.BorderSize = 2;
            this.txbxPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txbxPassword.Location = new System.Drawing.Point(39, 259);
            this.txbxPassword.Margin = new System.Windows.Forms.Padding(10, 0, 10, 4);
            this.txbxPassword.MaxLength = 20;
            this.txbxPassword.Multiline = false;
            this.txbxPassword.Name = "txbxPassword";
            this.txbxPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxPassword.PasswordChar = true;
            this.txbxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbxPassword.PlaceholderText = "Password";
            this.txbxPassword.Size = new System.Drawing.Size(250, 35);
            this.txbxPassword.TabIndex = 46;
            this.txbxPassword.Texts = "";
            this.txbxPassword.UnderlinedStyle = false;
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbPassword.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbPassword.ForeColor = System.Drawing.Color.Black;
            this.lbPassword.Location = new System.Drawing.Point(45, 228);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(10, 10, 0, 3);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(203, 29);
            this.lbPassword.TabIndex = 45;
            this.lbPassword.Text = "Password";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pcbxRoleError
            // 
            this.pcbxRoleError.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pcbxRoleError.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources.close;
            this.pcbxRoleError.Location = new System.Drawing.Point(228, 314);
            this.pcbxRoleError.Name = "pcbxRoleError";
            this.pcbxRoleError.Size = new System.Drawing.Size(23, 23);
            this.pcbxRoleError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbxRoleError.TabIndex = 43;
            this.pcbxRoleError.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbxRoleError, "Please fill in the field");
            this.pcbxRoleError.Visible = false;
            // 
            // lbRole
            // 
            this.lbRole.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.ForeColor = System.Drawing.Color.Black;
            this.lbRole.Location = new System.Drawing.Point(54, 313);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(39, 20);
            this.lbRole.TabIndex = 44;
            this.lbRole.Text = "Role";
            // 
            // cmbxRole
            // 
            this.cmbxRole.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbxRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxRole.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxRole.FormattingEnabled = true;
            this.cmbxRole.Items.AddRange(new object[] {
            "ADMIN",
            "STAFF"});
            this.cmbxRole.Location = new System.Drawing.Point(99, 312);
            this.cmbxRole.Name = "cmbxRole";
            this.cmbxRole.Size = new System.Drawing.Size(123, 25);
            this.cmbxRole.TabIndex = 43;
            // 
            // txbxUsername
            // 
            this.txbxUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbxUsername.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbxUsername.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbxUsername.BackColor = System.Drawing.Color.White;
            this.txbxUsername.BorderColor = System.Drawing.Color.Silver;
            this.txbxUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxUsername.BorderRadius = 5;
            this.txbxUsername.BorderSize = 2;
            this.txbxUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txbxUsername.Location = new System.Drawing.Point(39, 187);
            this.txbxUsername.Margin = new System.Windows.Forms.Padding(10, 0, 10, 4);
            this.txbxUsername.MaxLength = 20;
            this.txbxUsername.Multiline = false;
            this.txbxUsername.Name = "txbxUsername";
            this.txbxUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxUsername.PasswordChar = false;
            this.txbxUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbxUsername.PlaceholderText = "Username";
            this.txbxUsername.Size = new System.Drawing.Size(250, 35);
            this.txbxUsername.TabIndex = 16;
            this.txbxUsername.Texts = "";
            this.txbxUsername.UnderlinedStyle = false;
            // 
            // lbUsername
            // 
            this.lbUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbUsername.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbUsername.ForeColor = System.Drawing.Color.Black;
            this.lbUsername.Location = new System.Drawing.Point(45, 155);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(10, 10, 0, 3);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(203, 29);
            this.lbUsername.TabIndex = 15;
            this.lbUsername.Text = "Username";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditUser.BackColor = System.Drawing.Color.Black;
            this.btnEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.Color.White;
            this.btnEditUser.Location = new System.Drawing.Point(39, 363);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(250, 45);
            this.btnEditUser.TabIndex = 13;
            this.btnEditUser.Text = "Confirm Changes";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(438, 551);
            this.Controls.Add(this.tblpnAddProduct);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "EditUserForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Manage Stock";
            this.tblpnAddProduct.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnBody.ResumeLayout(false);
            this.pnFields.ResumeLayout(false);
            this.pnFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxRoleError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.TableLayoutPanel tblpnAddProduct;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.ComboBox cmbxRole;
        private System.Windows.Forms.PictureBox pcbxRoleError;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnBody;
        private UIControls.RoundedPanel pnFields;
        private UIControls.RoundedTxBx txbxPassword;
        private System.Windows.Forms.Label lbPassword;
        private UIControls.RoundedTxBx txbxUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbFieldHeader;
        private System.Windows.Forms.Button btnHidePass;
        private System.Windows.Forms.Label lbPasswordError;
        private System.Windows.Forms.Label lbUsernameError;
        private System.Windows.Forms.Label lbNameErr;
        private UIControls.RoundedTxBx txbxName;
        private System.Windows.Forms.Label lbName;
    }
}

