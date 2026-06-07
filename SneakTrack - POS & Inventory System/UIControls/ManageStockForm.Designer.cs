namespace SneakTrack___POS___Inventory_System
{
    partial class ManageStockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStockForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.tblpnAddProduct = new System.Windows.Forms.TableLayoutPanel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pnBody = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbSetStock = new System.Windows.Forms.Label();
            this.pnFields = new SneakTrack___POS___Inventory_System.UIControls.RoundedPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbBrandTitle = new System.Windows.Forms.Label();
            this.lbBrand = new System.Windows.Forms.Label();
            this.lbColorTitle = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbGenderVariants = new System.Windows.Forms.Label();
            this.lbGenderText = new System.Windows.Forms.Label();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txbxDescription = new System.Windows.Forms.TextBox();
            this.pnTitleHeader = new System.Windows.Forms.Panel();
            this.lbProductInfo = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.pcbxProdImage = new System.Windows.Forms.PictureBox();
            this.dtgridSizeFields = new System.Windows.Forms.DataGridView();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbPriceText = new System.Windows.Forms.Label();
            this.tblpnAddProduct.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.pnFields.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnTitleHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxProdImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridSizeFields)).BeginInit();
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
            this.lbHeader.Size = new System.Drawing.Size(164, 28);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "Manage Stock";
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.btnAddStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStock.FlatAppearance.BorderSize = 0;
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.ForeColor = System.Drawing.Color.Black;
            this.btnAddStock.Location = new System.Drawing.Point(646, 452);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(218, 59);
            this.btnAddStock.TabIndex = 13;
            this.btnAddStock.Text = "Change Stock";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnChangeStock_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseForm.BackColor = System.Drawing.Color.DimGray;
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(821, 0);
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
            this.tblpnAddProduct.Size = new System.Drawing.Size(883, 590);
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
            this.pnHeader.Size = new System.Drawing.Size(883, 69);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.btnCancel);
            this.pnBody.Controls.Add(this.lbSetStock);
            this.pnBody.Controls.Add(this.pnFields);
            this.pnBody.Controls.Add(this.btnAddStock);
            this.pnBody.Controls.Add(this.dtgridSizeFields);
            this.pnBody.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 69);
            this.pnBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(883, 521);
            this.pnBody.TabIndex = 1;
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
            this.btnCancel.Location = new System.Drawing.Point(407, 453);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(228, 59);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lbSetStock
            // 
            this.lbSetStock.AutoSize = true;
            this.lbSetStock.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetStock.ForeColor = System.Drawing.Color.Black;
            this.lbSetStock.Location = new System.Drawing.Point(417, 17);
            this.lbSetStock.Name = "lbSetStock";
            this.lbSetStock.Size = new System.Drawing.Size(91, 25);
            this.lbSetStock.TabIndex = 28;
            this.lbSetStock.Text = "Set Stock";
            // 
            // pnFields
            // 
            this.pnFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.pnFields.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.pnFields.Controls.Add(this.flowLayoutPanel1);
            this.pnFields.Controls.Add(this.pnBottom);
            this.pnFields.Controls.Add(this.lbDescription);
            this.pnFields.Controls.Add(this.txbxDescription);
            this.pnFields.Controls.Add(this.pnTitleHeader);
            this.pnFields.Controls.Add(this.pcbxProdImage);
            this.pnFields.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnFields.ForeColor = System.Drawing.Color.Transparent;
            this.pnFields.Location = new System.Drawing.Point(-33, -8);
            this.pnFields.Margin = new System.Windows.Forms.Padding(0);
            this.pnFields.Name = "pnFields";
            this.pnFields.Radius = 50;
            this.pnFields.Size = new System.Drawing.Size(423, 536);
            this.pnFields.TabIndex = 15;
            this.pnFields.Thickness = 5F;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbBrandTitle);
            this.flowLayoutPanel1.Controls.Add(this.lbBrand);
            this.flowLayoutPanel1.Controls.Add(this.lbColorTitle);
            this.flowLayoutPanel1.Controls.Add(this.lbColor);
            this.flowLayoutPanel1.Controls.Add(this.lbGenderVariants);
            this.flowLayoutPanel1.Controls.Add(this.lbGenderText);
            this.flowLayoutPanel1.Controls.Add(this.lbPrice);
            this.flowLayoutPanel1.Controls.Add(this.lbPriceText);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(206, 128);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 206);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // lbBrandTitle
            // 
            this.lbBrandTitle.AutoSize = true;
            this.lbBrandTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrandTitle.ForeColor = System.Drawing.Color.White;
            this.lbBrandTitle.Location = new System.Drawing.Point(3, 0);
            this.lbBrandTitle.MinimumSize = new System.Drawing.Size(200, 0);
            this.lbBrandTitle.Name = "lbBrandTitle";
            this.lbBrandTitle.Size = new System.Drawing.Size(200, 21);
            this.lbBrandTitle.TabIndex = 38;
            this.lbBrandTitle.Text = "Brand";
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.BackColor = System.Drawing.Color.Transparent;
            this.lbBrand.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrand.Location = new System.Drawing.Point(3, 21);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(190, 34);
            this.lbBrand.TabIndex = 37;
            this.lbBrand.Text = "12345678901234567890123456789012345";
            // 
            // lbColorTitle
            // 
            this.lbColorTitle.AutoSize = true;
            this.lbColorTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColorTitle.ForeColor = System.Drawing.Color.White;
            this.lbColorTitle.Location = new System.Drawing.Point(3, 55);
            this.lbColorTitle.MinimumSize = new System.Drawing.Size(200, 0);
            this.lbColorTitle.Name = "lbColorTitle";
            this.lbColorTitle.Size = new System.Drawing.Size(200, 21);
            this.lbColorTitle.TabIndex = 36;
            this.lbColorTitle.Text = "Color";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.BackColor = System.Drawing.Color.Transparent;
            this.lbColor.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColor.Location = new System.Drawing.Point(3, 76);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(148, 17);
            this.lbColor.TabIndex = 35;
            this.lbColor.Text = "12345678901234567890";
            // 
            // lbGenderVariants
            // 
            this.lbGenderVariants.AutoSize = true;
            this.lbGenderVariants.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenderVariants.ForeColor = System.Drawing.Color.White;
            this.lbGenderVariants.Location = new System.Drawing.Point(3, 93);
            this.lbGenderVariants.MinimumSize = new System.Drawing.Size(200, 0);
            this.lbGenderVariants.Name = "lbGenderVariants";
            this.lbGenderVariants.Size = new System.Drawing.Size(200, 21);
            this.lbGenderVariants.TabIndex = 40;
            this.lbGenderVariants.Text = "Gender Variations";
            // 
            // lbGenderText
            // 
            this.lbGenderText.AutoSize = true;
            this.lbGenderText.BackColor = System.Drawing.Color.Transparent;
            this.lbGenderText.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenderText.Location = new System.Drawing.Point(3, 114);
            this.lbGenderText.Name = "lbGenderText";
            this.lbGenderText.Size = new System.Drawing.Size(129, 17);
            this.lbGenderText.TabIndex = 39;
            this.lbGenderText.Text = "Male, Female, Unisex";
            // 
            // pnBottom
            // 
            this.pnBottom.BackColor = System.Drawing.Color.Black;
            this.pnBottom.Location = new System.Drawing.Point(20, 477);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(417, 52);
            this.pnBottom.TabIndex = 41;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbDescription.Location = new System.Drawing.Point(82, 317);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(74, 17);
            this.lbDescription.TabIndex = 23;
            this.lbDescription.Text = "Description";
            // 
            // txbxDescription
            // 
            this.txbxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txbxDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.txbxDescription.Location = new System.Drawing.Point(66, 346);
            this.txbxDescription.MaxLength = 300;
            this.txbxDescription.Multiline = true;
            this.txbxDescription.Name = "txbxDescription";
            this.txbxDescription.ReadOnly = true;
            this.txbxDescription.Size = new System.Drawing.Size(320, 88);
            this.txbxDescription.TabIndex = 25;
            // 
            // pnTitleHeader
            // 
            this.pnTitleHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.pnTitleHeader.Controls.Add(this.lbProductInfo);
            this.pnTitleHeader.Controls.Add(this.lbProductName);
            this.pnTitleHeader.Location = new System.Drawing.Point(33, 8);
            this.pnTitleHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnTitleHeader.Name = "pnTitleHeader";
            this.pnTitleHeader.Size = new System.Drawing.Size(390, 93);
            this.pnTitleHeader.TabIndex = 35;
            // 
            // lbProductInfo
            // 
            this.lbProductInfo.AutoSize = true;
            this.lbProductInfo.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductInfo.ForeColor = System.Drawing.Color.White;
            this.lbProductInfo.Location = new System.Drawing.Point(32, 17);
            this.lbProductInfo.Name = "lbProductInfo";
            this.lbProductInfo.Size = new System.Drawing.Size(187, 25);
            this.lbProductInfo.TabIndex = 14;
            this.lbProductInfo.Text = "Product Information";
            // 
            // lbProductName
            // 
            this.lbProductName.BackColor = System.Drawing.Color.Transparent;
            this.lbProductName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.Location = new System.Drawing.Point(33, 42);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(314, 51);
            this.lbProductName.TabIndex = 34;
            this.lbProductName.Text = "Air Force 1 OG High Name of Sneakers AAAAAAAAAAAAAAAAAAAAAAAAA";
            // 
            // pcbxProdImage
            // 
            this.pcbxProdImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pcbxProdImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.pcbxProdImage.Image = ((System.Drawing.Image)(resources.GetObject("pcbxProdImage.Image")));
            this.pcbxProdImage.Location = new System.Drawing.Point(60, 128);
            this.pcbxProdImage.Name = "pcbxProdImage";
            this.pcbxProdImage.Size = new System.Drawing.Size(130, 130);
            this.pcbxProdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxProdImage.TabIndex = 27;
            this.pcbxProdImage.TabStop = false;
            // 
            // dtgridSizeFields
            // 
            this.dtgridSizeFields.AllowUserToAddRows = false;
            this.dtgridSizeFields.AllowUserToDeleteRows = false;
            this.dtgridSizeFields.AllowUserToOrderColumns = true;
            this.dtgridSizeFields.AllowUserToResizeRows = false;
            this.dtgridSizeFields.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgridSizeFields.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgridSizeFields.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgridSizeFields.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3, 5, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgridSizeFields.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgridSizeFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridSizeFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gender,
            this.Size,
            this.Quantity,
            this.Barcode,
            this.Price,
            this.sizeId});
            this.dtgridSizeFields.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtgridSizeFields.EnableHeadersVisualStyles = false;
            this.dtgridSizeFields.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgridSizeFields.Location = new System.Drawing.Point(407, 55);
            this.dtgridSizeFields.Margin = new System.Windows.Forms.Padding(0);
            this.dtgridSizeFields.Name = "dtgridSizeFields";
            this.dtgridSizeFields.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgridSizeFields.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgridSizeFields.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgridSizeFields.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgridSizeFields.Size = new System.Drawing.Size(457, 386);
            this.dtgridSizeFields.TabIndex = 16;
            this.dtgridSizeFields.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridSizeFields_CellEndEdit);
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Gender.DefaultCellStyle = dataGridViewCellStyle2;
            this.Gender.FillWeight = 45F;
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Size
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Size.DefaultCellStyle = dataGridViewCellStyle3;
            this.Size.FillWeight = 15F;
            this.Size.HeaderText = "Size";
            this.Size.MaxInputLength = 6;
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.ToolTipText = "Shoe size fields (Numeric or Decimal)";
            this.Size.Width = 54;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 20F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MaxInputLength = 4;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 77;
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Barcode.DefaultCellStyle = dataGridViewCellStyle4;
            this.Barcode.FillWeight = 80F;
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.MaxInputLength = 13;
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Price.DefaultCellStyle = dataGridViewCellStyle5;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // sizeId
            // 
            this.sizeId.HeaderText = "Column1";
            this.sizeId.Name = "sizeId";
            this.sizeId.Visible = false;
            this.sizeId.Width = 77;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(3, 131);
            this.lbPrice.MinimumSize = new System.Drawing.Size(200, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(200, 21);
            this.lbPrice.TabIndex = 41;
            this.lbPrice.Text = "Price";
            // 
            // lbPriceText
            // 
            this.lbPriceText.AutoSize = true;
            this.lbPriceText.BackColor = System.Drawing.Color.Transparent;
            this.lbPriceText.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceText.Location = new System.Drawing.Point(3, 152);
            this.lbPriceText.Name = "lbPriceText";
            this.lbPriceText.Size = new System.Drawing.Size(61, 17);
            this.lbPriceText.TabIndex = 42;
            this.lbPriceText.Text = "P 100000";
            // 
            // ManageStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(883, 590);
            this.Controls.Add(this.tblpnAddProduct);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ManageStockForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Manage Stock";
            this.tblpnAddProduct.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            this.pnFields.ResumeLayout(false);
            this.pnFields.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pnTitleHeader.ResumeLayout(false);
            this.pnTitleHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxProdImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridSizeFields)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.TableLayoutPanel tblpnAddProduct;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Label lbProductInfo;
        private SneakTrack___POS___Inventory_System.UIControls.RoundedPanel pnFields;
        private System.Windows.Forms.DataGridView dtgridSizeFields;
        private System.Windows.Forms.Label lbSetStock;
        private System.Windows.Forms.PictureBox pcbxProdImage;
        private System.Windows.Forms.TextBox txbxDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Panel pnTitleHeader;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label lbBrandTitle;
        private System.Windows.Forms.Label lbBrand;
        private System.Windows.Forms.Label lbColorTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbGenderVariants;
        private System.Windows.Forms.Label lbGenderText;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeId;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbPriceText;
    }
}

