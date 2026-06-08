namespace SneakTrack___POS___Inventory_System
{
    partial class UserManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbHeaderTitle = new System.Windows.Forms.Label();
            this.tblpnUserLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dtgridUserFields = new System.Windows.Forms.DataGridView();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblpnHeaderLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbxSearch = new SneakTrack___POS___Inventory_System.UIControls.RoundedTxBx();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnControlPanel = new System.Windows.Forms.Panel();
            this.btnEditAcc = new System.Windows.Forms.Button();
            this.btnArchiveAcc = new System.Windows.Forms.Button();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.pnSelection = new System.Windows.Forms.Panel();
            this.lbSelected = new System.Windows.Forms.Label();
            this.txbxSelectedUser = new System.Windows.Forms.TextBox();
            this.tblpnUserLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridUserFields)).BeginInit();
            this.tblpnHeaderLayout.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnControlPanel.SuspendLayout();
            this.pnSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHeaderTitle
            // 
            this.lbHeaderTitle.AutoSize = true;
            this.lbHeaderTitle.BackColor = System.Drawing.Color.Black;
            this.lbHeaderTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeaderTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lbHeaderTitle.Location = new System.Drawing.Point(580, 0);
            this.lbHeaderTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbHeaderTitle.Name = "lbHeaderTitle";
            this.lbHeaderTitle.Size = new System.Drawing.Size(370, 68);
            this.lbHeaderTitle.TabIndex = 3;
            this.lbHeaderTitle.Text = "Sneak Track Admin Panel";
            this.lbHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblpnUserLayout
            // 
            this.tblpnUserLayout.ColumnCount = 1;
            this.tblpnUserLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnUserLayout.Controls.Add(this.dtgridUserFields, 0, 1);
            this.tblpnUserLayout.Controls.Add(this.tblpnHeaderLayout, 0, 0);
            this.tblpnUserLayout.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tblpnUserLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnUserLayout.Location = new System.Drawing.Point(0, 0);
            this.tblpnUserLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnUserLayout.Name = "tblpnUserLayout";
            this.tblpnUserLayout.RowCount = 3;
            this.tblpnUserLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tblpnUserLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnUserLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tblpnUserLayout.Size = new System.Drawing.Size(950, 615);
            this.tblpnUserLayout.TabIndex = 1;
            // 
            // dtgridUserFields
            // 
            this.dtgridUserFields.AllowUserToAddRows = false;
            this.dtgridUserFields.AllowUserToDeleteRows = false;
            this.dtgridUserFields.AllowUserToResizeRows = false;
            this.dtgridUserFields.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgridUserFields.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgridUserFields.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgridUserFields.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3, 5, 0, 3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgridUserFields.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgridUserFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridUserFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gender});
            this.dtgridUserFields.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtgridUserFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgridUserFields.EnableHeadersVisualStyles = false;
            this.dtgridUserFields.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgridUserFields.Location = new System.Drawing.Point(25, 93);
            this.dtgridUserFields.Margin = new System.Windows.Forms.Padding(25);
            this.dtgridUserFields.Name = "dtgridUserFields";
            this.dtgridUserFields.ReadOnly = true;
            this.dtgridUserFields.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgridUserFields.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgridUserFields.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgridUserFields.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgridUserFields.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgridUserFields.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgridUserFields.Size = new System.Drawing.Size(900, 381);
            this.dtgridUserFields.TabIndex = 17;
            this.dtgridUserFields.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dtgridUserFields_CellValidating);
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.FillWeight = 15F;
            this.Gender.HeaderText = "Name";
            this.Gender.MaxInputLength = 1;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tblpnHeaderLayout
            // 
            this.tblpnHeaderLayout.ColumnCount = 2;
            this.tblpnHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.15789F));
            this.tblpnHeaderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.84211F));
            this.tblpnHeaderLayout.Controls.Add(this.pnHeader, 0, 0);
            this.tblpnHeaderLayout.Controls.Add(this.lbHeaderTitle, 1, 0);
            this.tblpnHeaderLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnHeaderLayout.Location = new System.Drawing.Point(0, 0);
            this.tblpnHeaderLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnHeaderLayout.Name = "tblpnHeaderLayout";
            this.tblpnHeaderLayout.RowCount = 1;
            this.tblpnHeaderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnHeaderLayout.Size = new System.Drawing.Size(950, 68);
            this.tblpnHeaderLayout.TabIndex = 18;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Black;
            this.pnHeader.Controls.Add(this.btnHome);
            this.pnHeader.Controls.Add(this.btnReload);
            this.pnHeader.Controls.Add(this.btnSearch);
            this.pnHeader.Controls.Add(this.txbxSearch);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(580, 68);
            this.pnHeader.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources.home_icon;
            this.btnHome.Location = new System.Drawing.Point(14, 7);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(40, 57);
            this.btnHome.TabIndex = 10;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources.refresh;
            this.btnReload.Location = new System.Drawing.Point(60, 7);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(40, 57);
            this.btnReload.TabIndex = 8;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(448, 22);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 27);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbxSearch
            // 
            this.txbxSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbxSearch.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbxSearch.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbxSearch.BackColor = System.Drawing.Color.White;
            this.txbxSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbxSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbxSearch.BorderRadius = 15;
            this.txbxSearch.BorderSize = 2;
            this.txbxSearch.CausesValidation = false;
            this.txbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxSearch.Location = new System.Drawing.Point(107, 20);
            this.txbxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txbxSearch.MaxLength = 32767;
            this.txbxSearch.Multiline = false;
            this.txbxSearch.Name = "txbxSearch";
            this.txbxSearch.Padding = new System.Windows.Forms.Padding(20, 7, 10, 7);
            this.txbxSearch.PasswordChar = false;
            this.txbxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbxSearch.PlaceholderText = "Search";
            this.txbxSearch.Size = new System.Drawing.Size(381, 31);
            this.txbxSearch.TabIndex = 7;
            this.txbxSearch.Texts = "";
            this.txbxSearch.UnderlinedStyle = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.21053F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.78947F));
            this.tableLayoutPanel1.Controls.Add(this.pnControlPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnSelection, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 499);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 116);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // pnControlPanel
            // 
            this.pnControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.pnControlPanel.Controls.Add(this.btnEditAcc);
            this.pnControlPanel.Controls.Add(this.btnArchiveAcc);
            this.pnControlPanel.Controls.Add(this.btnAddAcc);
            this.pnControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControlPanel.Location = new System.Drawing.Point(0, 0);
            this.pnControlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.pnControlPanel.Name = "pnControlPanel";
            this.pnControlPanel.Size = new System.Drawing.Size(534, 116);
            this.pnControlPanel.TabIndex = 2;
            // 
            // btnEditAcc
            // 
            this.btnEditAcc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEditAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.btnEditAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditAcc.FlatAppearance.BorderSize = 0;
            this.btnEditAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAcc.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAcc.Location = new System.Drawing.Point(186, 31);
            this.btnEditAcc.Name = "btnEditAcc";
            this.btnEditAcc.Size = new System.Drawing.Size(141, 63);
            this.btnEditAcc.TabIndex = 8;
            this.btnEditAcc.Text = "Edit Selected";
            this.btnEditAcc.UseVisualStyleBackColor = false;
            this.btnEditAcc.Click += new System.EventHandler(this.btnEditAcc_Click);
            // 
            // btnArchiveAcc
            // 
            this.btnArchiveAcc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnArchiveAcc.BackColor = System.Drawing.Color.Black;
            this.btnArchiveAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchiveAcc.FlatAppearance.BorderSize = 0;
            this.btnArchiveAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchiveAcc.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveAcc.ForeColor = System.Drawing.Color.Tomato;
            this.btnArchiveAcc.Location = new System.Drawing.Point(39, 31);
            this.btnArchiveAcc.Name = "btnArchiveAcc";
            this.btnArchiveAcc.Size = new System.Drawing.Size(141, 63);
            this.btnArchiveAcc.TabIndex = 7;
            this.btnArchiveAcc.Text = "Archive Selected";
            this.btnArchiveAcc.UseVisualStyleBackColor = false;
            this.btnArchiveAcc.Click += new System.EventHandler(this.btnArchiveAcc_Click);
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.btnAddAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAcc.FlatAppearance.BorderSize = 0;
            this.btnAddAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAcc.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAcc.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources.circle_user;
            this.btnAddAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAcc.Location = new System.Drawing.Point(362, 31);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnAddAcc.Size = new System.Drawing.Size(151, 62);
            this.btnAddAcc.TabIndex = 6;
            this.btnAddAcc.Text = " New Account";
            this.btnAddAcc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAcc.UseVisualStyleBackColor = false;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // pnSelection
            // 
            this.pnSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.pnSelection.Controls.Add(this.lbSelected);
            this.pnSelection.Controls.Add(this.txbxSelectedUser);
            this.pnSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSelection.Location = new System.Drawing.Point(534, 0);
            this.pnSelection.Margin = new System.Windows.Forms.Padding(0);
            this.pnSelection.Name = "pnSelection";
            this.pnSelection.Size = new System.Drawing.Size(416, 116);
            this.pnSelection.TabIndex = 0;
            // 
            // lbSelected
            // 
            this.lbSelected.AutoSize = true;
            this.lbSelected.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelected.ForeColor = System.Drawing.Color.White;
            this.lbSelected.Location = new System.Drawing.Point(22, 9);
            this.lbSelected.Name = "lbSelected";
            this.lbSelected.Size = new System.Drawing.Size(111, 19);
            this.lbSelected.TabIndex = 9;
            this.lbSelected.Text = "Selected Account";
            // 
            // txbxSelectedUser
            // 
            this.txbxSelectedUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxSelectedUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txbxSelectedUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxSelectedUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxSelectedUser.ForeColor = System.Drawing.Color.White;
            this.txbxSelectedUser.Location = new System.Drawing.Point(14, 35);
            this.txbxSelectedUser.Multiline = true;
            this.txbxSelectedUser.Name = "txbxSelectedUser";
            this.txbxSelectedUser.ReadOnly = true;
            this.txbxSelectedUser.Size = new System.Drawing.Size(387, 68);
            this.txbxSelectedUser.TabIndex = 9;
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblpnUserLayout);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserManager";
            this.Size = new System.Drawing.Size(950, 615);
            this.tblpnUserLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridUserFields)).EndInit();
            this.tblpnHeaderLayout.ResumeLayout(false);
            this.tblpnHeaderLayout.PerformLayout();
            this.pnHeader.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnControlPanel.ResumeLayout(false);
            this.pnSelection.ResumeLayout(false);
            this.pnSelection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbHeaderTitle;
        private System.Windows.Forms.TableLayoutPanel tblpnUserLayout;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSearch;
        private UIControls.RoundedTxBx txbxSearch;
        private System.Windows.Forms.Button btnEditAcc;
        private System.Windows.Forms.Button btnArchiveAcc;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.Panel pnControlPanel;
        private System.Windows.Forms.TextBox txbxSelectedUser;
        private System.Windows.Forms.Label lbSelected;
        private System.Windows.Forms.DataGridView dtgridUserFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.TableLayoutPanel tblpnHeaderLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnSelection;
    }
}
