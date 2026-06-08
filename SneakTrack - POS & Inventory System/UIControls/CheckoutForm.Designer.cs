namespace SneakTrack___POS___Inventory_System
{
    partial class CheckoutForm
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Test",
            "M - Test (TEST)",
            "Text",
            "P 100000.00"}, -1, System.Drawing.Color.Black, System.Drawing.Color.LightGray, null);
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pnBody = new System.Windows.Forms.Panel();
            this.lbCartItems = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSneakTrack = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lbPriceNoTax = new System.Windows.Forms.Label();
            this.lbOrderSummary = new System.Windows.Forms.Label();
            this.lsvCart = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGenSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancel = new System.Windows.Forms.Button();
            this.tblpnSideInfoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnSideInfoButtons = new System.Windows.Forms.Panel();
            this.pnSidebarBottom = new System.Windows.Forms.Panel();
            this.pnSideInfo = new System.Windows.Forms.Panel();
            this.txbxProductInfoSI = new System.Windows.Forms.TextBox();
            this.lbCaptionSI = new System.Windows.Forms.Label();
            this.pcbxSideInfo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPayment = new System.Windows.Forms.Label();
            this.lbChange = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.pnHeader.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tblpnSideInfoLayout.SuspendLayout();
            this.pnSideInfoButtons.SuspendLayout();
            this.pnSideInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSideInfo)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.lbHeader.Size = new System.Drawing.Size(113, 28);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "Checkout";
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirmOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.btnConfirmOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmOrder.FlatAppearance.BorderSize = 0;
            this.btnConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmOrder.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmOrder.Location = new System.Drawing.Point(215, 603);
            this.btnConfirmOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(452, 59);
            this.btnConfirmOrder.TabIndex = 13;
            this.btnConfirmOrder.Text = "Confirm Order (Proceed To Payment)";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
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
            this.btnCloseForm.Location = new System.Drawing.Point(856, 0);
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
            this.pnHeader.Size = new System.Drawing.Size(918, 69);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            // 
            // pnBody
            // 
            this.pnBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBody.Controls.Add(this.panel2);
            this.pnBody.Controls.Add(this.lbCartItems);
            this.pnBody.Controls.Add(this.panel1);
            this.pnBody.Controls.Add(this.lbOrderSummary);
            this.pnBody.Controls.Add(this.lsvCart);
            this.pnBody.Controls.Add(this.btnComplete);
            this.pnBody.Controls.Add(this.btnConfirmOrder);
            this.pnBody.Controls.Add(this.btnCancel);
            this.pnBody.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnBody.Location = new System.Drawing.Point(0, 69);
            this.pnBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(667, 662);
            this.pnBody.TabIndex = 1;
            // 
            // lbCartItems
            // 
            this.lbCartItems.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCartItems.ForeColor = System.Drawing.Color.Black;
            this.lbCartItems.Location = new System.Drawing.Point(444, 10);
            this.lbCartItems.Name = "lbCartItems";
            this.lbCartItems.Size = new System.Drawing.Size(199, 21);
            this.lbCartItems.TabIndex = 39;
            this.lbCartItems.Text = "Items: 0/200";
            this.lbCartItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbSneakTrack);
            this.panel1.Controls.Add(this.lbTotalPrice);
            this.panel1.Controls.Add(this.lbPriceNoTax);
            this.panel1.Location = new System.Drawing.Point(23, 436);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 91);
            this.panel1.TabIndex = 38;
            // 
            // lbSneakTrack
            // 
            this.lbSneakTrack.AutoSize = true;
            this.lbSneakTrack.BackColor = System.Drawing.Color.Transparent;
            this.lbSneakTrack.Font = new System.Drawing.Font("Coolvetica Rg", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSneakTrack.ForeColor = System.Drawing.Color.White;
            this.lbSneakTrack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbSneakTrack.Location = new System.Drawing.Point(33, 23);
            this.lbSneakTrack.Name = "lbSneakTrack";
            this.lbSneakTrack.Size = new System.Drawing.Size(198, 45);
            this.lbSneakTrack.TabIndex = 38;
            this.lbSneakTrack.Text = "SneakTrack";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lbTotalPrice.Location = new System.Drawing.Point(272, 15);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(322, 37);
            this.lbTotalPrice.TabIndex = 36;
            this.lbTotalPrice.Text = "Total Price: P 0.00";
            this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPriceNoTax
            // 
            this.lbPriceNoTax.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceNoTax.ForeColor = System.Drawing.Color.White;
            this.lbPriceNoTax.Location = new System.Drawing.Point(277, 52);
            this.lbPriceNoTax.Name = "lbPriceNoTax";
            this.lbPriceNoTax.Size = new System.Drawing.Size(317, 21);
            this.lbPriceNoTax.TabIndex = 37;
            this.lbPriceNoTax.Text = "(W/O VAT): 0.00";
            this.lbPriceNoTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbOrderSummary
            // 
            this.lbOrderSummary.AutoSize = true;
            this.lbOrderSummary.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderSummary.ForeColor = System.Drawing.Color.Black;
            this.lbOrderSummary.Location = new System.Drawing.Point(19, 10);
            this.lbOrderSummary.Name = "lbOrderSummary";
            this.lbOrderSummary.Size = new System.Drawing.Size(131, 21);
            this.lbOrderSummary.TabIndex = 35;
            this.lbOrderSummary.Text = "Order Summary";
            this.lbOrderSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lsvCart
            // 
            this.lsvCart.BackColor = System.Drawing.Color.Silver;
            this.lsvCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmGenSize,
            this.clmQuantity,
            this.clmSubtotal});
            this.lsvCart.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvCart.FullRowSelect = true;
            this.lsvCart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvCart.HideSelection = false;
            this.lsvCart.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.lsvCart.Location = new System.Drawing.Point(23, 45);
            this.lsvCart.Margin = new System.Windows.Forms.Padding(0);
            this.lsvCart.MultiSelect = false;
            this.lsvCart.Name = "lsvCart";
            this.lsvCart.ShowGroups = false;
            this.lsvCart.Size = new System.Drawing.Size(620, 391);
            this.lsvCart.TabIndex = 31;
            this.lsvCart.UseCompatibleStateImageBehavior = false;
            this.lsvCart.View = System.Windows.Forms.View.Details;
            this.lsvCart.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lsvCart_ColumnWidthChanging);
            this.lsvCart.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lsvCart_ItemSelectionChanged);
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 300;
            // 
            // clmGenSize
            // 
            this.clmGenSize.Text = "Gender/Size";
            this.clmGenSize.Width = 120;
            // 
            // clmQuantity
            // 
            this.clmQuantity.Text = "Quantity";
            this.clmQuantity.Width = 80;
            // 
            // clmSubtotal
            // 
            this.clmSubtotal.Width = 120;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(0, 603);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(215, 59);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // tblpnSideInfoLayout
            // 
            this.tblpnSideInfoLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tblpnSideInfoLayout.ColumnCount = 1;
            this.tblpnSideInfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnSideInfoLayout.Controls.Add(this.pnSideInfoButtons, 0, 1);
            this.tblpnSideInfoLayout.Controls.Add(this.pnSideInfo, 0, 0);
            this.tblpnSideInfoLayout.Location = new System.Drawing.Point(667, 69);
            this.tblpnSideInfoLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnSideInfoLayout.Name = "tblpnSideInfoLayout";
            this.tblpnSideInfoLayout.RowCount = 2;
            this.tblpnSideInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnSideInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tblpnSideInfoLayout.Size = new System.Drawing.Size(251, 662);
            this.tblpnSideInfoLayout.TabIndex = 30;
            // 
            // pnSideInfoButtons
            // 
            this.pnSideInfoButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.pnSideInfoButtons.Controls.Add(this.pnSidebarBottom);
            this.pnSideInfoButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSideInfoButtons.Location = new System.Drawing.Point(0, 604);
            this.pnSideInfoButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnSideInfoButtons.Name = "pnSideInfoButtons";
            this.pnSideInfoButtons.Size = new System.Drawing.Size(251, 58);
            this.pnSideInfoButtons.TabIndex = 4;
            // 
            // pnSidebarBottom
            // 
            this.pnSidebarBottom.BackColor = System.Drawing.Color.Black;
            this.pnSidebarBottom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnSidebarBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSidebarBottom.Location = new System.Drawing.Point(0, 0);
            this.pnSidebarBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnSidebarBottom.Name = "pnSidebarBottom";
            this.pnSidebarBottom.Size = new System.Drawing.Size(251, 58);
            this.pnSidebarBottom.TabIndex = 1;
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
            this.pnSideInfo.Size = new System.Drawing.Size(251, 604);
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
            this.txbxProductInfoSI.Size = new System.Drawing.Size(231, 357);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lbPayment);
            this.panel2.Controls.Add(this.lbChange);
            this.panel2.Location = new System.Drawing.Point(23, 530);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 60);
            this.panel2.TabIndex = 39;
            // 
            // lbPayment
            // 
            this.lbPayment.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayment.ForeColor = System.Drawing.Color.White;
            this.lbPayment.Location = new System.Drawing.Point(19, 13);
            this.lbPayment.Name = "lbPayment";
            this.lbPayment.Size = new System.Drawing.Size(322, 37);
            this.lbPayment.TabIndex = 36;
            this.lbPayment.Text = "Amount Paid: -";
            this.lbPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbChange
            // 
            this.lbChange.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChange.ForeColor = System.Drawing.Color.White;
            this.lbChange.Location = new System.Drawing.Point(283, 21);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(317, 21);
            this.lbChange.TabIndex = 37;
            this.lbChange.Text = "Change: -";
            this.lbChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.btnComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComplete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnComplete.FlatAppearance.BorderSize = 0;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.Color.Black;
            this.btnComplete.Location = new System.Drawing.Point(0, 603);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(0);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(667, 59);
            this.btnComplete.TabIndex = 40;
            this.btnComplete.Text = "Order Complete (Close Order)";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Visible = false;
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(918, 730);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.tblpnSideInfoLayout);
            this.Controls.Add(this.pnBody);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "CheckoutForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Manage Stock";
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tblpnSideInfoLayout.ResumeLayout(false);
            this.pnSideInfoButtons.ResumeLayout(false);
            this.pnSideInfo.ResumeLayout(false);
            this.pnSideInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSideInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btnConfirmOrder;
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
        private System.Windows.Forms.ListView lsvCart;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmQuantity;
        private System.Windows.Forms.Panel pnSidebarBottom;
        private System.Windows.Forms.Label lbOrderSummary;
        private System.Windows.Forms.ColumnHeader clmGenSize;
        private System.Windows.Forms.ColumnHeader clmSubtotal;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSneakTrack;
        private System.Windows.Forms.Label lbPriceNoTax;
        private System.Windows.Forms.Label lbCartItems;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbPayment;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.Button btnComplete;
    }
}

