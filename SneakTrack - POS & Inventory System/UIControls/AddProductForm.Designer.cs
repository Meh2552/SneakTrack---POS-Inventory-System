namespace SneakTrack___POS___Inventory_System
{
    partial class AddProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.tblpnAddProduct = new System.Windows.Forms.TableLayoutPanel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pnBody = new System.Windows.Forms.Panel();
            this.lbSizeType = new System.Windows.Forms.Label();
            this.lbSetStock = new System.Windows.Forms.Label();
            this.dtgridSizeFields = new System.Windows.Forms.DataGridView();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbxSizeType = new SneakTrack___POS___Inventory_System.UIControls.RoundedTxBx();
            this.pnFields = new SneakTrack___POS___Inventory_System.UIControls.RoundedPanel();
            this.lbProductError = new System.Windows.Forms.Label();
            this.lbBrandError = new System.Windows.Forms.Label();
            this.lbColorError = new System.Windows.Forms.Label();
            this.lbPriceError = new System.Windows.Forms.Label();
            this.lbGenderError = new System.Windows.Forms.Label();
            this.pcbxImage = new System.Windows.Forms.PictureBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbGenders = new System.Windows.Forms.Label();
            this.roundedPanel2 = new SneakTrack___POS___Inventory_System.UIControls.RoundedPanel();
            this.chbxUnisex = new System.Windows.Forms.CheckBox();
            this.chbxFemale = new System.Windows.Forms.CheckBox();
            this.chbxMale = new System.Windows.Forms.CheckBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txbxPrice = new SneakTrack___POS___Inventory_System.UIControls.RoundedTxBx();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.txbxColor = new SneakTrack___POS___Inventory_System.UIControls.RoundedTxBx();
            this.lbBrand = new System.Windows.Forms.Label();
            this.txbxProductName = new SneakTrack___POS___Inventory_System.UIControls.RoundedTxBx();
            this.txbxBrand = new SneakTrack___POS___Inventory_System.UIControls.RoundedTxBx();
            this.tblpnAddProduct.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.pnBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridSizeFields)).BeginInit();
            this.pnFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImage)).BeginInit();
            this.roundedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHeader.Location = new System.Drawing.Point(25, 18);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(147, 28);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "Add Product";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.Location = new System.Drawing.Point(452, 447);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(431, 74);
            this.btnAddProduct.TabIndex = 13;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
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
            this.pnBody.Controls.Add(this.txbxSizeType);
            this.pnBody.Controls.Add(this.lbSizeType);
            this.pnBody.Controls.Add(this.lbSetStock);
            this.pnBody.Controls.Add(this.pnFields);
            this.pnBody.Controls.Add(this.btnAddProduct);
            this.pnBody.Controls.Add(this.dtgridSizeFields);
            this.pnBody.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 69);
            this.pnBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(883, 521);
            this.pnBody.TabIndex = 1;
            // 
            // lbSizeType
            // 
            this.lbSizeType.AutoSize = true;
            this.lbSizeType.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSizeType.ForeColor = System.Drawing.Color.Black;
            this.lbSizeType.Location = new System.Drawing.Point(697, 17);
            this.lbSizeType.Name = "lbSizeType";
            this.lbSizeType.Size = new System.Drawing.Size(81, 21);
            this.lbSizeType.TabIndex = 29;
            this.lbSizeType.Text = "Size Type: ";
            // 
            // lbSetStock
            // 
            this.lbSetStock.AutoSize = true;
            this.lbSetStock.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetStock.ForeColor = System.Drawing.Color.Black;
            this.lbSetStock.Location = new System.Drawing.Point(485, 13);
            this.lbSetStock.Name = "lbSetStock";
            this.lbSetStock.Size = new System.Drawing.Size(91, 25);
            this.lbSetStock.TabIndex = 28;
            this.lbSetStock.Text = "Set Stock";
            // 
            // dtgridSizeFields
            // 
            this.dtgridSizeFields.AllowUserToOrderColumns = true;
            this.dtgridSizeFields.AllowUserToResizeRows = false;
            this.dtgridSizeFields.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgridSizeFields.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgridSizeFields.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgridSizeFields.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3, 5, 0, 3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgridSizeFields.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgridSizeFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridSizeFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gender,
            this.Size,
            this.Quantity,
            this.Barcode});
            this.dtgridSizeFields.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtgridSizeFields.EnableHeadersVisualStyles = false;
            this.dtgridSizeFields.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgridSizeFields.Location = new System.Drawing.Point(475, 50);
            this.dtgridSizeFields.Margin = new System.Windows.Forms.Padding(0);
            this.dtgridSizeFields.Name = "dtgridSizeFields";
            this.dtgridSizeFields.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgridSizeFields.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgridSizeFields.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgridSizeFields.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgridSizeFields.Size = new System.Drawing.Size(398, 386);
            this.dtgridSizeFields.TabIndex = 16;
            this.dtgridSizeFields.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridSizeFields_CellEndEdit);
            // 
            // Gender
            // 
            this.Gender.FillWeight = 15F;
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.Width = 71;
            // 
            // Size
            // 
            this.Size.FillWeight = 15F;
            this.Size.HeaderText = "Size";
            this.Size.MaxInputLength = 6;
            this.Size.Name = "Size";
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
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.MaxInputLength = 13;
            this.Barcode.Name = "Barcode";
            // 
            // txbxSizeType
            // 
            this.txbxSizeType.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbxSizeType.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbxSizeType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txbxSizeType.BorderColor = System.Drawing.Color.Silver;
            this.txbxSizeType.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxSizeType.BorderRadius = 0;
            this.txbxSizeType.BorderSize = 2;
            this.txbxSizeType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxSizeType.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.txbxSizeType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxSizeType.Location = new System.Drawing.Point(776, 10);
            this.txbxSizeType.Margin = new System.Windows.Forms.Padding(4);
            this.txbxSizeType.MaxLength = 20;
            this.txbxSizeType.Multiline = false;
            this.txbxSizeType.Name = "txbxSizeType";
            this.txbxSizeType.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxSizeType.PasswordChar = false;
            this.txbxSizeType.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbxSizeType.PlaceholderText = "US";
            this.txbxSizeType.Size = new System.Drawing.Size(97, 32);
            this.txbxSizeType.TabIndex = 30;
            this.txbxSizeType.Texts = "";
            this.txbxSizeType.UnderlinedStyle = false;
            // 
            // pnFields
            // 
            this.pnFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.pnFields.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.pnFields.Controls.Add(this.lbProductError);
            this.pnFields.Controls.Add(this.lbBrandError);
            this.pnFields.Controls.Add(this.lbColorError);
            this.pnFields.Controls.Add(this.lbPriceError);
            this.pnFields.Controls.Add(this.lbGenderError);
            this.pnFields.Controls.Add(this.pcbxImage);
            this.pnFields.Controls.Add(this.btnAddImage);
            this.pnFields.Controls.Add(this.textBox1);
            this.pnFields.Controls.Add(this.lbDescription);
            this.pnFields.Controls.Add(this.lbGenders);
            this.pnFields.Controls.Add(this.roundedPanel2);
            this.pnFields.Controls.Add(this.lbPrice);
            this.pnFields.Controls.Add(this.txbxPrice);
            this.pnFields.Controls.Add(this.lbProductName);
            this.pnFields.Controls.Add(this.lbColor);
            this.pnFields.Controls.Add(this.txbxColor);
            this.pnFields.Controls.Add(this.lbBrand);
            this.pnFields.Controls.Add(this.txbxProductName);
            this.pnFields.Controls.Add(this.txbxBrand);
            this.pnFields.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnFields.ForeColor = System.Drawing.Color.Transparent;
            this.pnFields.Location = new System.Drawing.Point(-33, 0);
            this.pnFields.Margin = new System.Windows.Forms.Padding(0);
            this.pnFields.Name = "pnFields";
            this.pnFields.Radius = 50;
            this.pnFields.Size = new System.Drawing.Size(498, 533);
            this.pnFields.TabIndex = 15;
            this.pnFields.Thickness = 5F;
            // 
            // lbProductError
            // 
            this.lbProductError.AutoSize = true;
            this.lbProductError.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductError.ForeColor = System.Drawing.Color.Tomato;
            this.lbProductError.Location = new System.Drawing.Point(146, 21);
            this.lbProductError.Name = "lbProductError";
            this.lbProductError.Size = new System.Drawing.Size(140, 16);
            this.lbProductError.TabIndex = 32;
            this.lbProductError.Text = "The field cannot be blank";
            this.lbProductError.Visible = false;
            // 
            // lbBrandError
            // 
            this.lbBrandError.AutoSize = true;
            this.lbBrandError.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrandError.ForeColor = System.Drawing.Color.Tomato;
            this.lbBrandError.Location = new System.Drawing.Point(179, 98);
            this.lbBrandError.Name = "lbBrandError";
            this.lbBrandError.Size = new System.Drawing.Size(140, 16);
            this.lbBrandError.TabIndex = 31;
            this.lbBrandError.Text = "The field cannot be blank";
            this.lbBrandError.Visible = false;
            // 
            // lbColorError
            // 
            this.lbColorError.AutoSize = true;
            this.lbColorError.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColorError.ForeColor = System.Drawing.Color.Tomato;
            this.lbColorError.Location = new System.Drawing.Point(130, 172);
            this.lbColorError.Name = "lbColorError";
            this.lbColorError.Size = new System.Drawing.Size(140, 16);
            this.lbColorError.TabIndex = 30;
            this.lbColorError.Text = "The field cannot be blank";
            this.lbColorError.Visible = false;
            // 
            // lbPriceError
            // 
            this.lbPriceError.AutoSize = true;
            this.lbPriceError.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceError.ForeColor = System.Drawing.Color.Tomato;
            this.lbPriceError.Location = new System.Drawing.Point(361, 172);
            this.lbPriceError.Name = "lbPriceError";
            this.lbPriceError.Size = new System.Drawing.Size(71, 16);
            this.lbPriceError.TabIndex = 29;
            this.lbPriceError.Text = "Invalid price";
            this.lbPriceError.Visible = false;
            // 
            // lbGenderError
            // 
            this.lbGenderError.AutoSize = true;
            this.lbGenderError.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenderError.ForeColor = System.Drawing.Color.Tomato;
            this.lbGenderError.Location = new System.Drawing.Point(182, 247);
            this.lbGenderError.Name = "lbGenderError";
            this.lbGenderError.Size = new System.Drawing.Size(74, 16);
            this.lbGenderError.TabIndex = 28;
            this.lbGenderError.Text = "Shoe Gender";
            this.lbGenderError.Visible = false;
            // 
            // pcbxImage
            // 
            this.pcbxImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pcbxImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbxImage.Image = ((System.Drawing.Image)(resources.GetObject("pcbxImage.Image")));
            this.pcbxImage.Location = new System.Drawing.Point(73, 336);
            this.pcbxImage.Name = "pcbxImage";
            this.pcbxImage.Size = new System.Drawing.Size(132, 132);
            this.pcbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbxImage.TabIndex = 27;
            this.pcbxImage.TabStop = false;
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.Black;
            this.btnAddImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddImage.FlatAppearance.BorderSize = 0;
            this.btnAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImage.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImage.ForeColor = System.Drawing.Color.White;
            this.btnAddImage.Location = new System.Drawing.Point(73, 474);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(132, 24);
            this.btnAddImage.TabIndex = 26;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.textBox1.Location = new System.Drawing.Point(226, 386);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 100);
            this.textBox1.TabIndex = 25;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbDescription.Location = new System.Drawing.Point(225, 356);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(74, 17);
            this.lbDescription.TabIndex = 23;
            this.lbDescription.Text = "Description";
            // 
            // lbGenders
            // 
            this.lbGenders.AutoSize = true;
            this.lbGenders.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenders.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbGenders.Location = new System.Drawing.Point(76, 242);
            this.lbGenders.Name = "lbGenders";
            this.lbGenders.Size = new System.Drawing.Size(100, 21);
            this.lbGenders.TabIndex = 21;
            this.lbGenders.Text = "Shoe Gender";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderColor = System.Drawing.Color.White;
            this.roundedPanel2.Controls.Add(this.chbxUnisex);
            this.roundedPanel2.Controls.Add(this.chbxFemale);
            this.roundedPanel2.Controls.Add(this.chbxMale);
            this.roundedPanel2.Location = new System.Drawing.Point(73, 268);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Radius = 1;
            this.roundedPanel2.Size = new System.Drawing.Size(375, 53);
            this.roundedPanel2.TabIndex = 20;
            this.roundedPanel2.Thickness = 2F;
            // 
            // chbxUnisex
            // 
            this.chbxUnisex.AutoSize = true;
            this.chbxUnisex.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxUnisex.Location = new System.Drawing.Point(253, 17);
            this.chbxUnisex.Name = "chbxUnisex";
            this.chbxUnisex.Size = new System.Drawing.Size(69, 23);
            this.chbxUnisex.TabIndex = 2;
            this.chbxUnisex.Text = "Unisex";
            this.chbxUnisex.UseVisualStyleBackColor = true;
            // 
            // chbxFemale
            // 
            this.chbxFemale.AutoSize = true;
            this.chbxFemale.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxFemale.Location = new System.Drawing.Point(144, 17);
            this.chbxFemale.Name = "chbxFemale";
            this.chbxFemale.Size = new System.Drawing.Size(71, 23);
            this.chbxFemale.TabIndex = 1;
            this.chbxFemale.Text = "Female";
            this.chbxFemale.UseVisualStyleBackColor = true;
            // 
            // chbxMale
            // 
            this.chbxMale.AutoSize = true;
            this.chbxMale.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxMale.Location = new System.Drawing.Point(45, 17);
            this.chbxMale.Name = "chbxMale";
            this.chbxMale.Size = new System.Drawing.Size(58, 23);
            this.chbxMale.TabIndex = 0;
            this.chbxMale.Text = "Male";
            this.chbxMale.UseVisualStyleBackColor = true;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbPrice.Location = new System.Drawing.Point(312, 168);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(44, 21);
            this.lbPrice.TabIndex = 19;
            this.lbPrice.Text = "Price";
            // 
            // txbxPrice
            // 
            this.txbxPrice.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbxPrice.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txbxPrice.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbxPrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbxPrice.BorderRadius = 0;
            this.txbxPrice.BorderSize = 2;
            this.txbxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.txbxPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxPrice.Location = new System.Drawing.Point(307, 193);
            this.txbxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbxPrice.MaxLength = 20;
            this.txbxPrice.Multiline = false;
            this.txbxPrice.Name = "txbxPrice";
            this.txbxPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxPrice.PasswordChar = false;
            this.txbxPrice.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbxPrice.PlaceholderText = "0.00";
            this.txbxPrice.Size = new System.Drawing.Size(142, 32);
            this.txbxPrice.TabIndex = 3;
            this.txbxPrice.Texts = "";
            this.txbxPrice.UnderlinedStyle = false;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.ForeColor = System.Drawing.Color.White;
            this.lbProductName.Location = new System.Drawing.Point(76, 17);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(71, 21);
            this.lbProductName.TabIndex = 14;
            this.lbProductName.Text = "Product*";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbColor.Location = new System.Drawing.Point(76, 168);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(55, 21);
            this.lbColor.TabIndex = 17;
            this.lbColor.Text = "Color*";
            // 
            // txbxColor
            // 
            this.txbxColor.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbxColor.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbxColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txbxColor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbxColor.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbxColor.BorderRadius = 0;
            this.txbxColor.BorderSize = 2;
            this.txbxColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxColor.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.txbxColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxColor.Location = new System.Drawing.Point(73, 193);
            this.txbxColor.Margin = new System.Windows.Forms.Padding(4);
            this.txbxColor.MaxLength = 20;
            this.txbxColor.Multiline = false;
            this.txbxColor.Name = "txbxColor";
            this.txbxColor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxColor.PasswordChar = false;
            this.txbxColor.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbxColor.PlaceholderText = "Color";
            this.txbxColor.Size = new System.Drawing.Size(226, 32);
            this.txbxColor.TabIndex = 2;
            this.txbxColor.Texts = "";
            this.txbxColor.UnderlinedStyle = false;
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrand.ForeColor = System.Drawing.Color.White;
            this.lbBrand.Location = new System.Drawing.Point(76, 93);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(104, 21);
            this.lbBrand.TabIndex = 4;
            this.lbBrand.Text = "Brand Name*";
            // 
            // txbxProductName
            // 
            this.txbxProductName.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbxProductName.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbxProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txbxProductName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbxProductName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbxProductName.BorderRadius = 0;
            this.txbxProductName.BorderSize = 2;
            this.txbxProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxProductName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxProductName.Location = new System.Drawing.Point(73, 42);
            this.txbxProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txbxProductName.MaxLength = 50;
            this.txbxProductName.Multiline = false;
            this.txbxProductName.Name = "txbxProductName";
            this.txbxProductName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxProductName.PasswordChar = false;
            this.txbxProductName.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbxProductName.PlaceholderText = "Product Name";
            this.txbxProductName.Size = new System.Drawing.Size(375, 32);
            this.txbxProductName.TabIndex = 0;
            this.txbxProductName.Texts = "";
            this.txbxProductName.UnderlinedStyle = false;
            // 
            // txbxBrand
            // 
            this.txbxBrand.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txbxBrand.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbxBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.txbxBrand.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbxBrand.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbxBrand.BorderRadius = 0;
            this.txbxBrand.BorderSize = 2;
            this.txbxBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxBrand.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.txbxBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxBrand.Location = new System.Drawing.Point(73, 118);
            this.txbxBrand.Margin = new System.Windows.Forms.Padding(4);
            this.txbxBrand.MaxLength = 35;
            this.txbxBrand.Multiline = false;
            this.txbxBrand.Name = "txbxBrand";
            this.txbxBrand.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxBrand.PasswordChar = false;
            this.txbxBrand.PlaceholderColor = System.Drawing.Color.Gray;
            this.txbxBrand.PlaceholderText = "Brand";
            this.txbxBrand.Size = new System.Drawing.Size(375, 32);
            this.txbxBrand.TabIndex = 1;
            this.txbxBrand.Texts = "";
            this.txbxBrand.UnderlinedStyle = false;
            // 
            // AddProductForm
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
            this.Name = "AddProductForm";
            this.Text = "Student Registration";
            this.tblpnAddProduct.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridSizeFields)).EndInit();
            this.pnFields.ResumeLayout(false);
            this.pnFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImage)).EndInit();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Label lbBrand;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.TableLayoutPanel tblpnAddProduct;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnBody;
        private SneakTrack___POS___Inventory_System.UIControls.RoundedTxBx txbxBrand;
        private System.Windows.Forms.Label lbProductName;
        private SneakTrack___POS___Inventory_System.UIControls.RoundedTxBx txbxProductName;
        private System.Windows.Forms.Label lbColor;
        private SneakTrack___POS___Inventory_System.UIControls.RoundedTxBx txbxColor;
        private System.Windows.Forms.Label lbPrice;
        private SneakTrack___POS___Inventory_System.UIControls.RoundedTxBx txbxPrice;
        private SneakTrack___POS___Inventory_System.UIControls.RoundedPanel pnFields;
        private SneakTrack___POS___Inventory_System.UIControls.RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label lbGenders;
        private System.Windows.Forms.CheckBox chbxMale;
        private System.Windows.Forms.CheckBox chbxUnisex;
        private System.Windows.Forms.CheckBox chbxFemale;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.PictureBox pcbxImage;
        private System.Windows.Forms.DataGridView dtgridSizeFields;
        private System.Windows.Forms.Label lbSetStock;
        private System.Windows.Forms.Label lbGenderError;
        private System.Windows.Forms.Label lbPriceError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.Label lbSizeType;
        private UIControls.RoundedTxBx txbxSizeType;
        private System.Windows.Forms.Label lbProductError;
        private System.Windows.Forms.Label lbBrandError;
        private System.Windows.Forms.Label lbColorError;
    }
}

