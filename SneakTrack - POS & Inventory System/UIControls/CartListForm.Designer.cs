namespace SneakTrack___POS___Inventory_System
{
    partial class CartListForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "TEst",
            "Test"}, -1, System.Drawing.Color.Black, System.Drawing.Color.LightGray, null);
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnConfirmChanges = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pnBody = new System.Windows.Forms.Panel();
            this.lbCartItems = new System.Windows.Forms.Label();
            this.lsvCart = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancel = new System.Windows.Forms.Button();
            this.tblpnSideInfoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnSideInfoButtons = new System.Windows.Forms.Panel();
            this.btnIncQuantity = new System.Windows.Forms.Button();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.btnDecQuantity = new System.Windows.Forms.Button();
            this.txbxQuantity = new SneakTrack___POS___Inventory_System.UIControls.RoundedTxBx();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.pnSideInfo = new System.Windows.Forms.Panel();
            this.txbxProductInfoSI = new System.Windows.Forms.TextBox();
            this.lbCaptionSI = new System.Windows.Forms.Label();
            this.pcbxSideInfo = new System.Windows.Forms.PictureBox();
            this.pnHeader.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.tblpnSideInfoLayout.SuspendLayout();
            this.pnSideInfoButtons.SuspendLayout();
            this.pnSideInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSideInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.BackColor = System.Drawing.Color.Transparent;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.Black;
            this.lbHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHeader.Location = new System.Drawing.Point(29, 20);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(96, 28);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "My Cart";
            // 
            // btnConfirmChanges
            // 
            this.btnConfirmChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.btnConfirmChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmChanges.FlatAppearance.BorderSize = 0;
            this.btnConfirmChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmChanges.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmChanges.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmChanges.Location = new System.Drawing.Point(215, 542);
            this.btnConfirmChanges.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirmChanges.Name = "btnConfirmChanges";
            this.btnConfirmChanges.Size = new System.Drawing.Size(245, 59);
            this.btnConfirmChanges.TabIndex = 13;
            this.btnConfirmChanges.Text = "Confirm Changes";
            this.btnConfirmChanges.UseVisualStyleBackColor = false;
            this.btnConfirmChanges.Click += new System.EventHandler(this.btnConfirmChanges_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.Black;
            this.btnCloseForm.Location = new System.Drawing.Point(648, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(62, 69);
            this.btnCloseForm.TabIndex = 14;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.pnHeader.Controls.Add(this.lbHeader);
            this.pnHeader.Controls.Add(this.btnCloseForm);
            this.pnHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(710, 69);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.lbCartItems);
            this.pnBody.Controls.Add(this.lsvCart);
            this.pnBody.Controls.Add(this.btnCancel);
            this.pnBody.Controls.Add(this.btnConfirmChanges);
            this.pnBody.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnBody.Location = new System.Drawing.Point(0, 69);
            this.pnBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(460, 601);
            this.pnBody.TabIndex = 1;
            // 
            // lbCartItems
            // 
            this.lbCartItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCartItems.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCartItems.ForeColor = System.Drawing.Color.Black;
            this.lbCartItems.Location = new System.Drawing.Point(289, 14);
            this.lbCartItems.Name = "lbCartItems";
            this.lbCartItems.Size = new System.Drawing.Size(150, 21);
            this.lbCartItems.TabIndex = 34;
            this.lbCartItems.Text = "Items: 0/200";
            this.lbCartItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lsvCart
            // 
            this.lsvCart.BackColor = System.Drawing.Color.Silver;
            this.lsvCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmQuantity});
            this.lsvCart.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvCart.FullRowSelect = true;
            this.lsvCart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvCart.HideSelection = false;
            this.lsvCart.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lsvCart.Location = new System.Drawing.Point(23, 45);
            this.lsvCart.Margin = new System.Windows.Forms.Padding(0);
            this.lsvCart.MultiSelect = false;
            this.lsvCart.Name = "lsvCart";
            this.lsvCart.ShowGroups = false;
            this.lsvCart.Size = new System.Drawing.Size(416, 473);
            this.lsvCart.TabIndex = 31;
            this.lsvCart.UseCompatibleStateImageBehavior = false;
            this.lsvCart.View = System.Windows.Forms.View.Details;
            this.lsvCart.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lsvCart_ColumnWidthChanging);
            this.lsvCart.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lsvCart_ItemSelectionChanged);
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 316;
            // 
            // clmQuantity
            // 
            this.clmQuantity.Text = "Quantity";
            this.clmQuantity.Width = 100;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(0, 542);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(215, 59);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // tblpnSideInfoLayout
            // 
            this.tblpnSideInfoLayout.ColumnCount = 1;
            this.tblpnSideInfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnSideInfoLayout.Controls.Add(this.pnSideInfoButtons, 0, 1);
            this.tblpnSideInfoLayout.Controls.Add(this.pnSideInfo, 0, 0);
            this.tblpnSideInfoLayout.Location = new System.Drawing.Point(460, 69);
            this.tblpnSideInfoLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnSideInfoLayout.Name = "tblpnSideInfoLayout";
            this.tblpnSideInfoLayout.RowCount = 2;
            this.tblpnSideInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnSideInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tblpnSideInfoLayout.Size = new System.Drawing.Size(251, 601);
            this.tblpnSideInfoLayout.TabIndex = 30;
            // 
            // pnSideInfoButtons
            // 
            this.pnSideInfoButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.pnSideInfoButtons.Controls.Add(this.btnIncQuantity);
            this.pnSideInfoButtons.Controls.Add(this.lbQuantity);
            this.pnSideInfoButtons.Controls.Add(this.btnDecQuantity);
            this.pnSideInfoButtons.Controls.Add(this.txbxQuantity);
            this.pnSideInfoButtons.Controls.Add(this.btnRemoveItem);
            this.pnSideInfoButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSideInfoButtons.Location = new System.Drawing.Point(0, 485);
            this.pnSideInfoButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnSideInfoButtons.Name = "pnSideInfoButtons";
            this.pnSideInfoButtons.Size = new System.Drawing.Size(251, 116);
            this.pnSideInfoButtons.TabIndex = 4;
            // 
            // btnIncQuantity
            // 
            this.btnIncQuantity.BackColor = System.Drawing.Color.White;
            this.btnIncQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btnIncQuantity.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources.arrow_circle_right;
            this.btnIncQuantity.Location = new System.Drawing.Point(188, 14);
            this.btnIncQuantity.Name = "btnIncQuantity";
            this.btnIncQuantity.Size = new System.Drawing.Size(26, 32);
            this.btnIncQuantity.TabIndex = 34;
            this.btnIncQuantity.UseVisualStyleBackColor = false;
            this.btnIncQuantity.Click += new System.EventHandler(this.btnIncQuantity_Click);
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.ForeColor = System.Drawing.Color.White;
            this.lbQuantity.Location = new System.Drawing.Point(23, 19);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(80, 21);
            this.lbQuantity.TabIndex = 33;
            this.lbQuantity.Text = "Quantity:";
            // 
            // btnDecQuantity
            // 
            this.btnDecQuantity.BackColor = System.Drawing.Color.White;
            this.btnDecQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.btnDecQuantity.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources.arrow_circle_left;
            this.btnDecQuantity.Location = new System.Drawing.Point(109, 14);
            this.btnDecQuantity.Name = "btnDecQuantity";
            this.btnDecQuantity.Size = new System.Drawing.Size(26, 32);
            this.btnDecQuantity.TabIndex = 31;
            this.btnDecQuantity.UseVisualStyleBackColor = false;
            this.btnDecQuantity.Click += new System.EventHandler(this.btnDecQuantity_Click);
            // 
            // txbxQuantity
            // 
            this.txbxQuantity.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbxQuantity.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbxQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txbxQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbxQuantity.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbxQuantity.BorderRadius = 0;
            this.txbxQuantity.BorderSize = 2;
            this.txbxQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxQuantity.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txbxQuantity.ForeColor = System.Drawing.Color.White;
            this.txbxQuantity.Location = new System.Drawing.Point(136, 14);
            this.txbxQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txbxQuantity.MaxLength = 4;
            this.txbxQuantity.Multiline = false;
            this.txbxQuantity.Name = "txbxQuantity";
            this.txbxQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxQuantity.PasswordChar = false;
            this.txbxQuantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbxQuantity.PlaceholderText = " 0";
            this.txbxQuantity.Size = new System.Drawing.Size(51, 32);
            this.txbxQuantity.TabIndex = 32;
            this.txbxQuantity.Texts = "";
            this.txbxQuantity.UnderlinedStyle = true;
            this.txbxQuantity._TextChanged += new System.EventHandler(this.txbxQuantity__TextChanged);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.Black;
            this.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.Tomato;
            this.btnRemoveItem.Location = new System.Drawing.Point(19, 57);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(215, 40);
            this.btnRemoveItem.TabIndex = 30;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // pnSideInfo
            // 
            this.pnSideInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.pnSideInfo.Controls.Add(this.txbxProductInfoSI);
            this.pnSideInfo.Controls.Add(this.lbCaptionSI);
            this.pnSideInfo.Controls.Add(this.pcbxSideInfo);
            this.pnSideInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSideInfo.Location = new System.Drawing.Point(0, 0);
            this.pnSideInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnSideInfo.Name = "pnSideInfo";
            this.pnSideInfo.Size = new System.Drawing.Size(251, 485);
            this.pnSideInfo.TabIndex = 3;
            // 
            // txbxProductInfoSI
            // 
            this.txbxProductInfoSI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txbxProductInfoSI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbxProductInfoSI.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txbxProductInfoSI.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxProductInfoSI.ForeColor = System.Drawing.Color.White;
            this.txbxProductInfoSI.Location = new System.Drawing.Point(19, 247);
            this.txbxProductInfoSI.Margin = new System.Windows.Forms.Padding(0);
            this.txbxProductInfoSI.Multiline = true;
            this.txbxProductInfoSI.Name = "txbxProductInfoSI";
            this.txbxProductInfoSI.ReadOnly = true;
            this.txbxProductInfoSI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbxProductInfoSI.ShortcutsEnabled = false;
            this.txbxProductInfoSI.Size = new System.Drawing.Size(231, 238);
            this.txbxProductInfoSI.TabIndex = 2;
            // 
            // lbCaptionSI
            // 
            this.lbCaptionSI.AutoSize = true;
            this.lbCaptionSI.Font = new System.Drawing.Font("Yu Gothic UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCaptionSI.ForeColor = System.Drawing.Color.White;
            this.lbCaptionSI.Location = new System.Drawing.Point(143, 10);
            this.lbCaptionSI.Name = "lbCaptionSI";
            this.lbCaptionSI.Size = new System.Drawing.Size(92, 15);
            this.lbCaptionSI.TabIndex = 1;
            this.lbCaptionSI.Text = "Selected Product";
            // 
            // pcbxSideInfo
            // 
            this.pcbxSideInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.pcbxSideInfo.Location = new System.Drawing.Point(0, 33);
            this.pcbxSideInfo.Name = "pcbxSideInfo";
            this.pcbxSideInfo.Size = new System.Drawing.Size(250, 214);
            this.pcbxSideInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxSideInfo.TabIndex = 0;
            this.pcbxSideInfo.TabStop = false;
            // 
            // CartListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(708, 670);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.tblpnSideInfoLayout);
            this.Controls.Add(this.pnBody);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "CartListForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Manage Stock";
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnBody.ResumeLayout(false);
            this.tblpnSideInfoLayout.ResumeLayout(false);
            this.pnSideInfoButtons.ResumeLayout(false);
            this.pnSideInfoButtons.PerformLayout();
            this.pnSideInfo.ResumeLayout(false);
            this.pnSideInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSideInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btnConfirmChanges;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tblpnSideInfoLayout;
        private System.Windows.Forms.Panel pnSideInfoButtons;
        private System.Windows.Forms.Panel pnSideInfo;
        private System.Windows.Forms.TextBox txbxProductInfoSI;
        private System.Windows.Forms.Label lbCaptionSI;
        private System.Windows.Forms.PictureBox pcbxSideInfo;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.ListView lsvCart;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmQuantity;
        private System.Windows.Forms.Button btnDecQuantity;
        private UIControls.RoundedTxBx txbxQuantity;
        private System.Windows.Forms.Button btnIncQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbCartItems;
    }
}

