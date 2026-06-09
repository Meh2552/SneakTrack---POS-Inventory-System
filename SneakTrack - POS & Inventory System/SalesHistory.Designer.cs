namespace SneakTrack___POS___Inventory_System
{
    partial class SalesHistory
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Test"}, -1, System.Drawing.Color.Black, System.Drawing.Color.LightGray, null);
            this.pnSalesCtrl = new System.Windows.Forms.Panel();
            this.lsvSales = new System.Windows.Forms.ListView();
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRevenue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbxSearch = new SneakTrack___POS___Inventory_System.UIControls.RoundedTxBx();
            this.tblpnSales = new System.Windows.Forms.TableLayoutPanel();
            this.pnSales = new System.Windows.Forms.Panel();
            this.tblpnSalesLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnSidePanel = new System.Windows.Forms.Panel();
            this.btnCloseRC = new System.Windows.Forms.Button();
            this.lbReciept = new System.Windows.Forms.Label();
            this.pnReciept = new SneakTrack___POS___Inventory_System.UIControls.RoundedPanel();
            this.lbCashierNameRC = new System.Windows.Forms.Label();
            this.lbOrderNoRC = new System.Windows.Forms.Label();
            this.lbDateRC = new System.Windows.Forms.Label();
            this.pnBottomRC = new System.Windows.Forms.Panel();
            this.pnRecieptSeparator = new System.Windows.Forms.Panel();
            this.lbSubtitleRC = new System.Windows.Forms.Label();
            this.lbRecieptHeader = new System.Windows.Forms.Label();
            this.lsvReciept = new System.Windows.Forms.ListView();
            this.pnHeader.SuspendLayout();
            this.tblpnSales.SuspendLayout();
            this.pnSales.SuspendLayout();
            this.tblpnSalesLayout.SuspendLayout();
            this.pnSidePanel.SuspendLayout();
            this.pnReciept.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSalesCtrl
            // 
            this.pnSalesCtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.pnSalesCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSalesCtrl.Location = new System.Drawing.Point(0, 571);
            this.pnSalesCtrl.Margin = new System.Windows.Forms.Padding(0);
            this.pnSalesCtrl.Name = "pnSalesCtrl";
            this.pnSalesCtrl.Size = new System.Drawing.Size(475, 104);
            this.pnSalesCtrl.TabIndex = 0;
            // 
            // lsvSales
            // 
            this.lsvSales.BackColor = System.Drawing.Color.Silver;
            this.lsvSales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmID,
            this.clmDate,
            this.clmRevenue});
            this.lsvSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvSales.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvSales.FullRowSelect = true;
            this.lsvSales.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvSales.HideSelection = false;
            this.lsvSales.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lsvSales.Location = new System.Drawing.Point(35, 100);
            this.lsvSales.Margin = new System.Windows.Forms.Padding(35);
            this.lsvSales.MultiSelect = false;
            this.lsvSales.Name = "lsvSales";
            this.lsvSales.ShowGroups = false;
            this.lsvSales.Size = new System.Drawing.Size(405, 436);
            this.lsvSales.TabIndex = 2;
            this.lsvSales.UseCompatibleStateImageBehavior = false;
            this.lsvSales.View = System.Windows.Forms.View.Details;
            this.lsvSales.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lsvSales_ItemSelectionChanged);
            // 
            // clmID
            // 
            this.clmID.Text = "Order ID";
            this.clmID.Width = 100;
            // 
            // clmDate
            // 
            this.clmDate.Text = "Date";
            this.clmDate.Width = 120;
            // 
            // clmRevenue
            // 
            this.clmRevenue.Text = "Revenue";
            this.clmRevenue.Width = 150;
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
            this.pnHeader.Size = new System.Drawing.Size(475, 65);
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
            this.btnHome.Location = new System.Drawing.Point(14, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(40, 65);
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
            this.btnReload.Location = new System.Drawing.Point(60, 0);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(40, 65);
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
            this.btnSearch.Location = new System.Drawing.Point(411, 19);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 27);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbxSearch
            // 
            this.txbxSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.txbxSearch.Location = new System.Drawing.Point(191, 17);
            this.txbxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txbxSearch.MaxLength = 32767;
            this.txbxSearch.Multiline = false;
            this.txbxSearch.Name = "txbxSearch";
            this.txbxSearch.Padding = new System.Windows.Forms.Padding(20, 7, 10, 7);
            this.txbxSearch.PasswordChar = false;
            this.txbxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbxSearch.PlaceholderText = "Search";
            this.txbxSearch.Size = new System.Drawing.Size(260, 31);
            this.txbxSearch.TabIndex = 7;
            this.txbxSearch.Texts = "";
            this.txbxSearch.UnderlinedStyle = true;
            // 
            // tblpnSales
            // 
            this.tblpnSales.ColumnCount = 2;
            this.tblpnSales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnSales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 445F));
            this.tblpnSales.Controls.Add(this.pnSales, 0, 0);
            this.tblpnSales.Controls.Add(this.pnSidePanel, 1, 0);
            this.tblpnSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnSales.Location = new System.Drawing.Point(0, 0);
            this.tblpnSales.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnSales.Name = "tblpnSales";
            this.tblpnSales.RowCount = 1;
            this.tblpnSales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnSales.Size = new System.Drawing.Size(920, 675);
            this.tblpnSales.TabIndex = 2;
            // 
            // pnSales
            // 
            this.pnSales.Controls.Add(this.tblpnSalesLayout);
            this.pnSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSales.Location = new System.Drawing.Point(0, 0);
            this.pnSales.Margin = new System.Windows.Forms.Padding(0);
            this.pnSales.Name = "pnSales";
            this.pnSales.Size = new System.Drawing.Size(475, 675);
            this.pnSales.TabIndex = 3;
            // 
            // tblpnSalesLayout
            // 
            this.tblpnSalesLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.tblpnSalesLayout.ColumnCount = 1;
            this.tblpnSalesLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnSalesLayout.Controls.Add(this.pnSalesCtrl, 0, 2);
            this.tblpnSalesLayout.Controls.Add(this.pnHeader, 0, 0);
            this.tblpnSalesLayout.Controls.Add(this.lsvSales, 0, 1);
            this.tblpnSalesLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnSalesLayout.Location = new System.Drawing.Point(0, 0);
            this.tblpnSalesLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnSalesLayout.Name = "tblpnSalesLayout";
            this.tblpnSalesLayout.RowCount = 3;
            this.tblpnSalesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tblpnSalesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnSalesLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tblpnSalesLayout.Size = new System.Drawing.Size(475, 675);
            this.tblpnSalesLayout.TabIndex = 0;
            // 
            // pnSidePanel
            // 
            this.pnSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.pnSidePanel.Controls.Add(this.btnCloseRC);
            this.pnSidePanel.Controls.Add(this.lbReciept);
            this.pnSidePanel.Controls.Add(this.pnReciept);
            this.pnSidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSidePanel.Location = new System.Drawing.Point(475, 0);
            this.pnSidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.pnSidePanel.Name = "pnSidePanel";
            this.pnSidePanel.Size = new System.Drawing.Size(445, 675);
            this.pnSidePanel.TabIndex = 2;
            // 
            // btnCloseRC
            // 
            this.btnCloseRC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.btnCloseRC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseRC.FlatAppearance.BorderSize = 0;
            this.btnCloseRC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.btnCloseRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseRC.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseRC.ForeColor = System.Drawing.Color.Black;
            this.btnCloseRC.Location = new System.Drawing.Point(0, -2);
            this.btnCloseRC.Name = "btnCloseRC";
            this.btnCloseRC.Size = new System.Drawing.Size(63, 67);
            this.btnCloseRC.TabIndex = 13;
            this.btnCloseRC.Text = "X";
            this.btnCloseRC.UseVisualStyleBackColor = false;
            this.btnCloseRC.Click += new System.EventHandler(this.btnCloseRC_Click);
            // 
            // lbReciept
            // 
            this.lbReciept.AutoSize = true;
            this.lbReciept.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold);
            this.lbReciept.Location = new System.Drawing.Point(108, 34);
            this.lbReciept.Name = "lbReciept";
            this.lbReciept.Size = new System.Drawing.Size(229, 42);
            this.lbReciept.TabIndex = 12;
            this.lbReciept.Text = "Sales Reciept";
            // 
            // pnReciept
            // 
            this.pnReciept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnReciept.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnReciept.Controls.Add(this.lbCashierNameRC);
            this.pnReciept.Controls.Add(this.lbOrderNoRC);
            this.pnReciept.Controls.Add(this.lbDateRC);
            this.pnReciept.Controls.Add(this.pnBottomRC);
            this.pnReciept.Controls.Add(this.pnRecieptSeparator);
            this.pnReciept.Controls.Add(this.lbSubtitleRC);
            this.pnReciept.Controls.Add(this.lbRecieptHeader);
            this.pnReciept.Controls.Add(this.lsvReciept);
            this.pnReciept.Location = new System.Drawing.Point(44, 95);
            this.pnReciept.Name = "pnReciept";
            this.pnReciept.Radius = 20;
            this.pnReciept.Size = new System.Drawing.Size(356, 550);
            this.pnReciept.TabIndex = 3;
            this.pnReciept.Thickness = 10F;
            // 
            // lbCashierNameRC
            // 
            this.lbCashierNameRC.AutoSize = true;
            this.lbCashierNameRC.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCashierNameRC.Location = new System.Drawing.Point(29, 141);
            this.lbCashierNameRC.Name = "lbCashierNameRC";
            this.lbCashierNameRC.Size = new System.Drawing.Size(130, 19);
            this.lbCashierNameRC.TabIndex = 19;
            this.lbCashierNameRC.Text = "Cashier: Nick Name";
            this.lbCashierNameRC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbOrderNoRC
            // 
            this.lbOrderNoRC.AutoSize = true;
            this.lbOrderNoRC.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderNoRC.Location = new System.Drawing.Point(29, 122);
            this.lbOrderNoRC.Name = "lbOrderNoRC";
            this.lbOrderNoRC.Size = new System.Drawing.Size(136, 19);
            this.lbOrderNoRC.TabIndex = 18;
            this.lbOrderNoRC.Text = "Order No: STP-0001";
            this.lbOrderNoRC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDateRC
            // 
            this.lbDateRC.AutoSize = true;
            this.lbDateRC.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateRC.Location = new System.Drawing.Point(234, 122);
            this.lbDateRC.Name = "lbDateRC";
            this.lbDateRC.Size = new System.Drawing.Size(89, 19);
            this.lbDateRC.TabIndex = 17;
            this.lbDateRC.Text = "Date: 0/0/12";
            this.lbDateRC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnBottomRC
            // 
            this.pnBottomRC.BackColor = System.Drawing.Color.Black;
            this.pnBottomRC.Location = new System.Drawing.Point(0, 459);
            this.pnBottomRC.Name = "pnBottomRC";
            this.pnBottomRC.Size = new System.Drawing.Size(356, 91);
            this.pnBottomRC.TabIndex = 16;
            // 
            // pnRecieptSeparator
            // 
            this.pnRecieptSeparator.BackColor = System.Drawing.Color.Black;
            this.pnRecieptSeparator.Location = new System.Drawing.Point(33, 113);
            this.pnRecieptSeparator.Margin = new System.Windows.Forms.Padding(0);
            this.pnRecieptSeparator.Name = "pnRecieptSeparator";
            this.pnRecieptSeparator.Size = new System.Drawing.Size(290, 3);
            this.pnRecieptSeparator.TabIndex = 15;
            // 
            // lbSubtitleRC
            // 
            this.lbSubtitleRC.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtitleRC.Location = new System.Drawing.Point(33, 66);
            this.lbSubtitleRC.Name = "lbSubtitleRC";
            this.lbSubtitleRC.Size = new System.Drawing.Size(290, 38);
            this.lbSubtitleRC.TabIndex = 14;
            this.lbSubtitleRC.Text = "POS and Inventory System for\r\nJAPORMS Shoe House";
            this.lbSubtitleRC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRecieptHeader
            // 
            this.lbRecieptHeader.AutoSize = true;
            this.lbRecieptHeader.Font = new System.Drawing.Font("Coolvetica Rg", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecieptHeader.Location = new System.Drawing.Point(109, 33);
            this.lbRecieptHeader.Name = "lbRecieptHeader";
            this.lbRecieptHeader.Size = new System.Drawing.Size(136, 29);
            this.lbRecieptHeader.TabIndex = 13;
            this.lbRecieptHeader.Text = "Sneak Track";
            // 
            // lsvReciept
            // 
            this.lsvReciept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lsvReciept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lsvReciept.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvReciept.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.lsvReciept.FullRowSelect = true;
            this.lsvReciept.HideSelection = false;
            this.lsvReciept.Location = new System.Drawing.Point(33, 168);
            this.lsvReciept.Name = "lsvReciept";
            this.lsvReciept.Size = new System.Drawing.Size(290, 282);
            this.lsvReciept.TabIndex = 3;
            this.lsvReciept.UseCompatibleStateImageBehavior = false;
            this.lsvReciept.View = System.Windows.Forms.View.List;
            // 
            // SalesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblpnSales);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SalesHistory";
            this.Size = new System.Drawing.Size(920, 675);
            this.pnHeader.ResumeLayout(false);
            this.tblpnSales.ResumeLayout(false);
            this.pnSales.ResumeLayout(false);
            this.tblpnSalesLayout.ResumeLayout(false);
            this.pnSidePanel.ResumeLayout(false);
            this.pnSidePanel.PerformLayout();
            this.pnReciept.ResumeLayout(false);
            this.pnReciept.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnSalesCtrl;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSearch;
        private UIControls.RoundedTxBx txbxSearch;
        private System.Windows.Forms.ListView lsvSales;
        private System.Windows.Forms.TableLayoutPanel tblpnSales;
        private System.Windows.Forms.Panel pnSidePanel;
        private System.Windows.Forms.Panel pnSales;
        private System.Windows.Forms.TableLayoutPanel tblpnSalesLayout;
        private UIControls.RoundedPanel pnReciept;
        private System.Windows.Forms.Label lbReciept;
        private System.Windows.Forms.Label lbRecieptHeader;
        private System.Windows.Forms.Panel pnRecieptSeparator;
        private System.Windows.Forms.Label lbSubtitleRC;
        private System.Windows.Forms.Label lbDateRC;
        private System.Windows.Forms.Panel pnBottomRC;
        private System.Windows.Forms.Label lbOrderNoRC;
        private System.Windows.Forms.Label lbCashierNameRC;
        private System.Windows.Forms.ColumnHeader clmID;
        private System.Windows.Forms.ColumnHeader clmDate;
        private System.Windows.Forms.ColumnHeader clmRevenue;
        private System.Windows.Forms.Button btnCloseRC;
        private System.Windows.Forms.ListView lsvReciept;
    }
}
