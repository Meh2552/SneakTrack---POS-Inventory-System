namespace SneakTrack___POS___Inventory_System
{
    partial class AddToCartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToCartForm));
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.tblpnAddProduct = new System.Windows.Forms.TableLayoutPanel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pcbxQuantityError = new System.Windows.Forms.PictureBox();
            this.pcbxSizeError = new System.Windows.Forms.PictureBox();
            this.lbAvailableQ = new System.Windows.Forms.Label();
            this.txbxQuantity = new SneakTrack___POS___Inventory_System.UIControls.RoundedTxBx();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.cmbxSize = new System.Windows.Forms.ComboBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.cmbxGender = new System.Windows.Forms.ComboBox();
            this.pcbxGenderError = new System.Windows.Forms.PictureBox();
            this.pnTitleHeader = new System.Windows.Forms.Panel();
            this.lbProductInfo = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.pcbxProdImage = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbBrandTitle = new System.Windows.Forms.Label();
            this.lbBrand = new System.Windows.Forms.Label();
            this.lbColorTitle = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbGenderVariants = new System.Windows.Forms.Label();
            this.lbGenderText = new System.Windows.Forms.Label();
            this.lbPriceTitle = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tblpnAddProduct.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.pnBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxQuantityError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSizeError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxGenderError)).BeginInit();
            this.pnTitleHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxProdImage)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.lbHeader.Size = new System.Drawing.Size(147, 28);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "Add Product";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.Black;
            this.btnAddToCart.Location = new System.Drawing.Point(421, 300);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(172, 45);
            this.btnAddToCart.TabIndex = 13;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
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
            this.btnCloseForm.Location = new System.Drawing.Point(557, 0);
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
            this.tblpnAddProduct.Size = new System.Drawing.Size(619, 441);
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
            this.pnHeader.Size = new System.Drawing.Size(619, 69);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.pnBody.Controls.Add(this.pcbxQuantityError);
            this.pnBody.Controls.Add(this.pcbxSizeError);
            this.pnBody.Controls.Add(this.lbAvailableQ);
            this.pnBody.Controls.Add(this.txbxQuantity);
            this.pnBody.Controls.Add(this.lbQuantity);
            this.pnBody.Controls.Add(this.lbSize);
            this.pnBody.Controls.Add(this.cmbxSize);
            this.pnBody.Controls.Add(this.lbGender);
            this.pnBody.Controls.Add(this.cmbxGender);
            this.pnBody.Controls.Add(this.btnAddToCart);
            this.pnBody.Controls.Add(this.pcbxGenderError);
            this.pnBody.Controls.Add(this.pnTitleHeader);
            this.pnBody.Controls.Add(this.pcbxProdImage);
            this.pnBody.Controls.Add(this.flowLayoutPanel1);
            this.pnBody.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 69);
            this.pnBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(619, 372);
            this.pnBody.TabIndex = 1;
            // 
            // pcbxQuantityError
            // 
            this.pcbxQuantityError.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources.close;
            this.pcbxQuantityError.Location = new System.Drawing.Point(571, 244);
            this.pcbxQuantityError.Name = "pcbxQuantityError";
            this.pcbxQuantityError.Size = new System.Drawing.Size(23, 23);
            this.pcbxQuantityError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbxQuantityError.TabIndex = 51;
            this.pcbxQuantityError.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbxQuantityError, "Invalid Quantity");
            this.pcbxQuantityError.Visible = false;
            // 
            // pcbxSizeError
            // 
            this.pcbxSizeError.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources.close;
            this.pcbxSizeError.Location = new System.Drawing.Point(557, 141);
            this.pcbxSizeError.Name = "pcbxSizeError";
            this.pcbxSizeError.Size = new System.Drawing.Size(23, 23);
            this.pcbxSizeError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbxSizeError.TabIndex = 50;
            this.pcbxSizeError.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbxSizeError, "Please fill in the field");
            this.pcbxSizeError.Visible = false;
            // 
            // lbAvailableQ
            // 
            this.lbAvailableQ.AutoSize = true;
            this.lbAvailableQ.BackColor = System.Drawing.Color.Transparent;
            this.lbAvailableQ.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvailableQ.ForeColor = System.Drawing.Color.White;
            this.lbAvailableQ.Location = new System.Drawing.Point(491, 216);
            this.lbAvailableQ.Name = "lbAvailableQ";
            this.lbAvailableQ.Size = new System.Drawing.Size(103, 17);
            this.lbAvailableQ.TabIndex = 49;
            this.lbAvailableQ.Text = "(Available: 1000)";
            this.lbAvailableQ.Visible = false;
            // 
            // txbxQuantity
            // 
            this.txbxQuantity.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbxQuantity.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbxQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.txbxQuantity.BorderColor = System.Drawing.Color.Silver;
            this.txbxQuantity.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbxQuantity.BorderRadius = 0;
            this.txbxQuantity.BorderSize = 2;
            this.txbxQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbxQuantity.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txbxQuantity.ForeColor = System.Drawing.Color.White;
            this.txbxQuantity.Location = new System.Drawing.Point(421, 240);
            this.txbxQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txbxQuantity.MaxLength = 4;
            this.txbxQuantity.Multiline = false;
            this.txbxQuantity.Name = "txbxQuantity";
            this.txbxQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxQuantity.PasswordChar = false;
            this.txbxQuantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbxQuantity.PlaceholderText = "0";
            this.txbxQuantity.Size = new System.Drawing.Size(171, 32);
            this.txbxQuantity.TabIndex = 48;
            this.txbxQuantity.Texts = "";
            this.txbxQuantity.UnderlinedStyle = true;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.ForeColor = System.Drawing.Color.White;
            this.lbQuantity.Location = new System.Drawing.Point(417, 213);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(68, 20);
            this.lbQuantity.TabIndex = 47;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.White;
            this.lbSize.Location = new System.Drawing.Point(516, 143);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(36, 20);
            this.lbSize.TabIndex = 46;
            this.lbSize.Text = "Size";
            // 
            // cmbxSize
            // 
            this.cmbxSize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbxSize.Enabled = false;
            this.cmbxSize.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbxSize.FormattingEnabled = true;
            this.cmbxSize.Location = new System.Drawing.Point(520, 170);
            this.cmbxSize.Name = "cmbxSize";
            this.cmbxSize.Size = new System.Drawing.Size(73, 25);
            this.cmbxSize.TabIndex = 45;
            this.cmbxSize.SelectionChangeCommitted += new System.EventHandler(this.cmbxSize_SelectionChangeCommitted);
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.ForeColor = System.Drawing.Color.White;
            this.lbGender.Location = new System.Drawing.Point(417, 141);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(59, 20);
            this.lbGender.TabIndex = 44;
            this.lbGender.Text = "Gender";
            // 
            // cmbxGender
            // 
            this.cmbxGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxGender.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxGender.FormattingEnabled = true;
            this.cmbxGender.Location = new System.Drawing.Point(421, 170);
            this.cmbxGender.Name = "cmbxGender";
            this.cmbxGender.Size = new System.Drawing.Size(93, 25);
            this.cmbxGender.TabIndex = 43;
            this.cmbxGender.SelectionChangeCommitted += new System.EventHandler(this.cmbxGender_SelectionChangeCommitted);
            // 
            // pcbxGenderError
            // 
            this.pcbxGenderError.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources.close;
            this.pcbxGenderError.Location = new System.Drawing.Point(479, 141);
            this.pcbxGenderError.Name = "pcbxGenderError";
            this.pcbxGenderError.Size = new System.Drawing.Size(23, 23);
            this.pcbxGenderError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbxGenderError.TabIndex = 43;
            this.pcbxGenderError.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbxGenderError, "Please fill in the field");
            this.pcbxGenderError.Visible = false;
            // 
            // pnTitleHeader
            // 
            this.pnTitleHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.pnTitleHeader.Controls.Add(this.lbProductInfo);
            this.pnTitleHeader.Controls.Add(this.lbProductName);
            this.pnTitleHeader.Location = new System.Drawing.Point(0, -8);
            this.pnTitleHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnTitleHeader.Name = "pnTitleHeader";
            this.pnTitleHeader.Size = new System.Drawing.Size(622, 86);
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
            this.lbProductName.Size = new System.Drawing.Size(561, 44);
            this.lbProductName.TabIndex = 34;
            this.lbProductName.Text = "Air Force 1 OG High Name of Sneakers AAAAAAAAAAAAAAAAAAAAAAAAA";
            // 
            // pcbxProdImage
            // 
            this.pcbxProdImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pcbxProdImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.pcbxProdImage.Image = ((System.Drawing.Image)(resources.GetObject("pcbxProdImage.Image")));
            this.pcbxProdImage.Location = new System.Drawing.Point(27, 122);
            this.pcbxProdImage.Name = "pcbxProdImage";
            this.pcbxProdImage.Size = new System.Drawing.Size(130, 130);
            this.pcbxProdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxProdImage.TabIndex = 27;
            this.pcbxProdImage.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbBrandTitle);
            this.flowLayoutPanel1.Controls.Add(this.lbBrand);
            this.flowLayoutPanel1.Controls.Add(this.lbColorTitle);
            this.flowLayoutPanel1.Controls.Add(this.lbColor);
            this.flowLayoutPanel1.Controls.Add(this.lbGenderVariants);
            this.flowLayoutPanel1.Controls.Add(this.lbGenderText);
            this.flowLayoutPanel1.Controls.Add(this.lbPriceTitle);
            this.flowLayoutPanel1.Controls.Add(this.lbPrice);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(173, 122);
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
            this.lbBrand.ForeColor = System.Drawing.Color.White;
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
            this.lbColor.ForeColor = System.Drawing.Color.White;
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
            this.lbGenderText.ForeColor = System.Drawing.Color.White;
            this.lbGenderText.Location = new System.Drawing.Point(3, 114);
            this.lbGenderText.Name = "lbGenderText";
            this.lbGenderText.Size = new System.Drawing.Size(129, 17);
            this.lbGenderText.TabIndex = 39;
            this.lbGenderText.Text = "Male, Female, Unisex";
            // 
            // lbPriceTitle
            // 
            this.lbPriceTitle.AutoSize = true;
            this.lbPriceTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceTitle.ForeColor = System.Drawing.Color.White;
            this.lbPriceTitle.Location = new System.Drawing.Point(3, 131);
            this.lbPriceTitle.MinimumSize = new System.Drawing.Size(200, 0);
            this.lbPriceTitle.Name = "lbPriceTitle";
            this.lbPriceTitle.Size = new System.Drawing.Size(200, 21);
            this.lbPriceTitle.TabIndex = 41;
            this.lbPriceTitle.Text = "Price";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(3, 152);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(61, 17);
            this.lbPrice.TabIndex = 42;
            this.lbPrice.Text = "P 100000";
            // 
            // AddToCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(619, 441);
            this.Controls.Add(this.tblpnAddProduct);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AddToCartForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Manage Stock";
            this.tblpnAddProduct.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxQuantityError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSizeError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxGenderError)).EndInit();
            this.pnTitleHeader.ResumeLayout(false);
            this.pnTitleHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxProdImage)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.TableLayoutPanel tblpnAddProduct;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Label lbProductInfo;
        private System.Windows.Forms.PictureBox pcbxProdImage;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Panel pnTitleHeader;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label lbBrandTitle;
        private System.Windows.Forms.Label lbBrand;
        private System.Windows.Forms.Label lbColorTitle;
        private System.Windows.Forms.Label lbGenderVariants;
        private System.Windows.Forms.Label lbGenderText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbPriceTitle;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.ComboBox cmbxSize;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.ComboBox cmbxGender;
        private UIControls.RoundedTxBx txbxQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbAvailableQ;
        private System.Windows.Forms.PictureBox pcbxGenderError;
        private System.Windows.Forms.PictureBox pcbxQuantityError;
        private System.Windows.Forms.PictureBox pcbxSizeError;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

