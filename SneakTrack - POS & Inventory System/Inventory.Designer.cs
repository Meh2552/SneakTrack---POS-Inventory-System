namespace SneakTrack___POS___Inventory_System
{
    partial class Inventory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.tblpnHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.txbxSearch = new SneakTrack___POS___Inventory_System.UIControls.RoundedTxBx();
            this.tblpnSideInfo = new System.Windows.Forms.TableLayoutPanel();
            this.tblpnBottomBar = new System.Windows.Forms.TableLayoutPanel();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.tblpnBottom = new System.Windows.Forms.TableLayoutPanel();
            this.pnBottomButtons = new System.Windows.Forms.Panel();
            this.txbxBarcode = new SneakTrack___POS___Inventory_System.UIControls.RoundedTxBx();
            this.pnBarcodeControls = new System.Windows.Forms.Panel();
            this.chbxAutoAddInp = new System.Windows.Forms.CheckBox();
            this.pnBarcodeQuan = new System.Windows.Forms.Panel();
            this.txbxBarcodeQuan = new System.Windows.Forms.TextBox();
            this.btnBarcodeAdd = new System.Windows.Forms.Button();
            this.tblpnSelectionInv = new System.Windows.Forms.TableLayoutPanel();
            this.pnSelectionHeader = new System.Windows.Forms.Panel();
            this.lbTitleSH = new System.Windows.Forms.Label();
            this.tblpnTilesSH = new System.Windows.Forms.TableLayoutPanel();
            this.tblpnSideInfoLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnSideInfo = new System.Windows.Forms.Panel();
            this.txbxProductInfoSI = new System.Windows.Forms.TextBox();
            this.btnCloseSideInfo = new System.Windows.Forms.Button();
            this.lbCaptionSI = new System.Windows.Forms.Label();
            this.pnSideInfoButtons = new System.Windows.Forms.Panel();
            this.btnManageStock = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnHome = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.btnQuanIncrease = new System.Windows.Forms.Button();
            this.btnQuanDecrease = new System.Windows.Forms.Button();
            this.tlTotalStockSH = new SneakTrack___POS___Inventory_System.UIControls.Tile();
            this.tlProductListedSH = new SneakTrack___POS___Inventory_System.UIControls.Tile();
            this.tlTSVSH = new SneakTrack___POS___Inventory_System.UIControls.Tile();
            this.pcbxSideInfo = new System.Windows.Forms.PictureBox();
            this.tblpnHeader.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.tblpnSideInfo.SuspendLayout();
            this.tblpnBottomBar.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.tblpnBottom.SuspendLayout();
            this.pnBottomButtons.SuspendLayout();
            this.pnBarcodeControls.SuspendLayout();
            this.pnBarcodeQuan.SuspendLayout();
            this.tblpnSelectionInv.SuspendLayout();
            this.pnSelectionHeader.SuspendLayout();
            this.tblpnTilesSH.SuspendLayout();
            this.tblpnSideInfoLayout.SuspendLayout();
            this.pnSideInfo.SuspendLayout();
            this.pnSideInfoButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSideInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tblpnHeader
            // 
            this.tblpnHeader.ColumnCount = 1;
            this.tblpnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnHeader.Controls.Add(this.pnHeader, 0, 0);
            this.tblpnHeader.Controls.Add(this.tblpnSideInfo, 0, 1);
            this.tblpnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnHeader.Location = new System.Drawing.Point(0, 0);
            this.tblpnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnHeader.Name = "tblpnHeader";
            this.tblpnHeader.RowCount = 2;
            this.tblpnHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblpnHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnHeader.Size = new System.Drawing.Size(920, 675);
            this.tblpnHeader.TabIndex = 0;
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
            this.pnHeader.Size = new System.Drawing.Size(920, 60);
            this.pnHeader.TabIndex = 0;
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
            this.txbxSearch.Location = new System.Drawing.Point(106, 14);
            this.txbxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txbxSearch.MaxLength = 32767;
            this.txbxSearch.Multiline = false;
            this.txbxSearch.Name = "txbxSearch";
            this.txbxSearch.Padding = new System.Windows.Forms.Padding(20, 7, 10, 7);
            this.txbxSearch.PasswordChar = false;
            this.txbxSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbxSearch.PlaceholderText = "Search";
            this.txbxSearch.Size = new System.Drawing.Size(381, 31);
            this.txbxSearch.TabIndex = 0;
            this.txbxSearch.Texts = "";
            this.txbxSearch.UnderlinedStyle = true;
            // 
            // tblpnSideInfo
            // 
            this.tblpnSideInfo.ColumnCount = 2;
            this.tblpnSideInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.52174F));
            this.tblpnSideInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tblpnSideInfo.Controls.Add(this.tblpnBottomBar, 0, 0);
            this.tblpnSideInfo.Controls.Add(this.tblpnSideInfoLayout, 1, 0);
            this.tblpnSideInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnSideInfo.Location = new System.Drawing.Point(0, 60);
            this.tblpnSideInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnSideInfo.Name = "tblpnSideInfo";
            this.tblpnSideInfo.RowCount = 1;
            this.tblpnSideInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnSideInfo.Size = new System.Drawing.Size(920, 615);
            this.tblpnSideInfo.TabIndex = 1;
            // 
            // tblpnBottomBar
            // 
            this.tblpnBottomBar.ColumnCount = 1;
            this.tblpnBottomBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnBottomBar.Controls.Add(this.pnBottom, 0, 1);
            this.tblpnBottomBar.Controls.Add(this.tblpnSelectionInv, 0, 0);
            this.tblpnBottomBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnBottomBar.Location = new System.Drawing.Point(0, 0);
            this.tblpnBottomBar.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnBottomBar.Name = "tblpnBottomBar";
            this.tblpnBottomBar.RowCount = 2;
            this.tblpnBottomBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.0119F));
            this.tblpnBottomBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblpnBottomBar.Size = new System.Drawing.Size(670, 615);
            this.tblpnBottomBar.TabIndex = 2;
            // 
            // pnBottom
            // 
            this.pnBottom.BackColor = System.Drawing.Color.Black;
            this.pnBottom.Controls.Add(this.tblpnBottom);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBottom.Location = new System.Drawing.Point(0, 555);
            this.pnBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(670, 60);
            this.pnBottom.TabIndex = 2;
            // 
            // tblpnBottom
            // 
            this.tblpnBottom.ColumnCount = 4;
            this.tblpnBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tblpnBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tblpnBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblpnBottom.Controls.Add(this.pnBottomButtons, 0, 0);
            this.tblpnBottom.Controls.Add(this.txbxBarcode, 1, 0);
            this.tblpnBottom.Controls.Add(this.pnBarcodeControls, 2, 0);
            this.tblpnBottom.Controls.Add(this.btnBarcodeAdd, 3, 0);
            this.tblpnBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnBottom.Location = new System.Drawing.Point(0, 0);
            this.tblpnBottom.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnBottom.Name = "tblpnBottom";
            this.tblpnBottom.RowCount = 1;
            this.tblpnBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblpnBottom.Size = new System.Drawing.Size(670, 60);
            this.tblpnBottom.TabIndex = 1;
            // 
            // pnBottomButtons
            // 
            this.pnBottomButtons.Controls.Add(this.btnNewProduct);
            this.pnBottomButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBottomButtons.Location = new System.Drawing.Point(0, 0);
            this.pnBottomButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnBottomButtons.Name = "pnBottomButtons";
            this.pnBottomButtons.Size = new System.Drawing.Size(233, 60);
            this.pnBottomButtons.TabIndex = 8;
            // 
            // txbxBarcode
            // 
            this.txbxBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxBarcode.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbxBarcode.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbxBarcode.BackColor = System.Drawing.SystemColors.Window;
            this.txbxBarcode.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txbxBarcode.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbxBarcode.BorderRadius = 0;
            this.txbxBarcode.BorderSize = 2;
            this.txbxBarcode.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxBarcode.Location = new System.Drawing.Point(253, 13);
            this.txbxBarcode.Margin = new System.Windows.Forms.Padding(20, 4, 10, 4);
            this.txbxBarcode.MaxLength = 13;
            this.txbxBarcode.Multiline = false;
            this.txbxBarcode.Name = "txbxBarcode";
            this.txbxBarcode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxBarcode.PasswordChar = false;
            this.txbxBarcode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbxBarcode.PlaceholderText = "Barcode";
            this.txbxBarcode.Size = new System.Drawing.Size(179, 34);
            this.txbxBarcode.TabIndex = 6;
            this.txbxBarcode.Texts = "";
            this.txbxBarcode.UnderlinedStyle = false;
            this.txbxBarcode._TextChanged += new System.EventHandler(this.txbxBarcode__TextChanged);
            // 
            // pnBarcodeControls
            // 
            this.pnBarcodeControls.Controls.Add(this.chbxAutoAddInp);
            this.pnBarcodeControls.Controls.Add(this.pnBarcodeQuan);
            this.pnBarcodeControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBarcodeControls.Location = new System.Drawing.Point(442, 0);
            this.pnBarcodeControls.Margin = new System.Windows.Forms.Padding(0);
            this.pnBarcodeControls.Name = "pnBarcodeControls";
            this.pnBarcodeControls.Size = new System.Drawing.Size(108, 60);
            this.pnBarcodeControls.TabIndex = 9;
            // 
            // chbxAutoAddInp
            // 
            this.chbxAutoAddInp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chbxAutoAddInp.AutoSize = true;
            this.chbxAutoAddInp.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxAutoAddInp.ForeColor = System.Drawing.Color.White;
            this.chbxAutoAddInp.Location = new System.Drawing.Point(6, 42);
            this.chbxAutoAddInp.Margin = new System.Windows.Forms.Padding(0);
            this.chbxAutoAddInp.Name = "chbxAutoAddInp";
            this.chbxAutoAddInp.Size = new System.Drawing.Size(98, 18);
            this.chbxAutoAddInp.TabIndex = 1;
            this.chbxAutoAddInp.Text = "Auto-add Input";
            this.chbxAutoAddInp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbxAutoAddInp.UseVisualStyleBackColor = true;
            this.chbxAutoAddInp.CheckedChanged += new System.EventHandler(this.chbxAutoAddInp_CheckedChanged);
            // 
            // pnBarcodeQuan
            // 
            this.pnBarcodeQuan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnBarcodeQuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnBarcodeQuan.Controls.Add(this.txbxBarcodeQuan);
            this.pnBarcodeQuan.Controls.Add(this.btnQuanIncrease);
            this.pnBarcodeQuan.Controls.Add(this.btnQuanDecrease);
            this.pnBarcodeQuan.Location = new System.Drawing.Point(4, 10);
            this.pnBarcodeQuan.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pnBarcodeQuan.Name = "pnBarcodeQuan";
            this.pnBarcodeQuan.Size = new System.Drawing.Size(100, 27);
            this.pnBarcodeQuan.TabIndex = 1;
            // 
            // txbxBarcodeQuan
            // 
            this.txbxBarcodeQuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxBarcodeQuan.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxBarcodeQuan.Location = new System.Drawing.Point(30, 0);
            this.txbxBarcodeQuan.Margin = new System.Windows.Forms.Padding(0);
            this.txbxBarcodeQuan.MaxLength = 3;
            this.txbxBarcodeQuan.Name = "txbxBarcodeQuan";
            this.txbxBarcodeQuan.Size = new System.Drawing.Size(40, 28);
            this.txbxBarcodeQuan.TabIndex = 0;
            this.txbxBarcodeQuan.Text = "1";
            this.txbxBarcodeQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txbxBarcodeQuan, "Quantity to add on barcode input");
            this.txbxBarcodeQuan.TextChanged += new System.EventHandler(this.txbxBarcodeQuan_TextChanged);
            // 
            // btnBarcodeAdd
            // 
            this.btnBarcodeAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.btnBarcodeAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBarcodeAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBarcodeAdd.FlatAppearance.BorderSize = 0;
            this.btnBarcodeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarcodeAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarcodeAdd.ForeColor = System.Drawing.Color.Black;
            this.btnBarcodeAdd.Location = new System.Drawing.Point(550, 0);
            this.btnBarcodeAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnBarcodeAdd.Name = "btnBarcodeAdd";
            this.btnBarcodeAdd.Size = new System.Drawing.Size(120, 60);
            this.btnBarcodeAdd.TabIndex = 7;
            this.btnBarcodeAdd.Text = "Add Stock";
            this.toolTip1.SetToolTip(this.btnBarcodeAdd, "Add stock through barcode input");
            this.btnBarcodeAdd.UseVisualStyleBackColor = false;
            this.btnBarcodeAdd.Click += new System.EventHandler(this.btnBarcodeAdd_Click);
            // 
            // tblpnSelectionInv
            // 
            this.tblpnSelectionInv.AutoScroll = true;
            this.tblpnSelectionInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.tblpnSelectionInv.ColumnCount = 1;
            this.tblpnSelectionInv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnSelectionInv.Controls.Add(this.pnSelectionHeader, 0, 0);
            this.tblpnSelectionInv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnSelectionInv.Location = new System.Drawing.Point(0, 0);
            this.tblpnSelectionInv.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnSelectionInv.Name = "tblpnSelectionInv";
            this.tblpnSelectionInv.RowCount = 2;
            this.tblpnSelectionInv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tblpnSelectionInv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnSelectionInv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpnSelectionInv.Size = new System.Drawing.Size(670, 555);
            this.tblpnSelectionInv.TabIndex = 1;
            // 
            // pnSelectionHeader
            // 
            this.pnSelectionHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.pnSelectionHeader.Controls.Add(this.lbTitleSH);
            this.pnSelectionHeader.Controls.Add(this.tblpnTilesSH);
            this.pnSelectionHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSelectionHeader.Location = new System.Drawing.Point(0, 0);
            this.pnSelectionHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnSelectionHeader.Name = "pnSelectionHeader";
            this.pnSelectionHeader.Size = new System.Drawing.Size(670, 247);
            this.pnSelectionHeader.TabIndex = 0;
            // 
            // lbTitleSH
            // 
            this.lbTitleSH.AutoSize = true;
            this.lbTitleSH.BackColor = System.Drawing.Color.Transparent;
            this.lbTitleSH.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleSH.ForeColor = System.Drawing.Color.White;
            this.lbTitleSH.Location = new System.Drawing.Point(16, 13);
            this.lbTitleSH.Name = "lbTitleSH";
            this.lbTitleSH.Size = new System.Drawing.Size(271, 32);
            this.lbTitleSH.TabIndex = 0;
            this.lbTitleSH.Text = "Inventory Management";
            // 
            // tblpnTilesSH
            // 
            this.tblpnTilesSH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblpnTilesSH.ColumnCount = 5;
            this.tblpnTilesSH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpnTilesSH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblpnTilesSH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblpnTilesSH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblpnTilesSH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpnTilesSH.Controls.Add(this.tlTotalStockSH, 1, 0);
            this.tblpnTilesSH.Controls.Add(this.tlProductListedSH, 2, 0);
            this.tblpnTilesSH.Controls.Add(this.tlTSVSH, 3, 0);
            this.tblpnTilesSH.Location = new System.Drawing.Point(0, 53);
            this.tblpnTilesSH.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnTilesSH.Name = "tblpnTilesSH";
            this.tblpnTilesSH.RowCount = 1;
            this.tblpnTilesSH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnTilesSH.Size = new System.Drawing.Size(670, 194);
            this.tblpnTilesSH.TabIndex = 6;
            // 
            // tblpnSideInfoLayout
            // 
            this.tblpnSideInfoLayout.ColumnCount = 1;
            this.tblpnSideInfoLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnSideInfoLayout.Controls.Add(this.pnSideInfo, 0, 0);
            this.tblpnSideInfoLayout.Controls.Add(this.pnSideInfoButtons, 0, 1);
            this.tblpnSideInfoLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnSideInfoLayout.Location = new System.Drawing.Point(670, 0);
            this.tblpnSideInfoLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnSideInfoLayout.Name = "tblpnSideInfoLayout";
            this.tblpnSideInfoLayout.RowCount = 2;
            this.tblpnSideInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnSideInfoLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblpnSideInfoLayout.Size = new System.Drawing.Size(250, 615);
            this.tblpnSideInfoLayout.TabIndex = 3;
            // 
            // pnSideInfo
            // 
            this.pnSideInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.pnSideInfo.Controls.Add(this.txbxProductInfoSI);
            this.pnSideInfo.Controls.Add(this.btnCloseSideInfo);
            this.pnSideInfo.Controls.Add(this.lbCaptionSI);
            this.pnSideInfo.Controls.Add(this.pcbxSideInfo);
            this.pnSideInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSideInfo.Location = new System.Drawing.Point(0, 0);
            this.pnSideInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnSideInfo.Name = "pnSideInfo";
            this.pnSideInfo.Size = new System.Drawing.Size(250, 515);
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
            this.txbxProductInfoSI.Size = new System.Drawing.Size(231, 265);
            this.txbxProductInfoSI.TabIndex = 2;
            this.txbxProductInfoSI.Text = "Name: Shoe name model 123456789 - Real Color\r\nBrand: Brand name\r\nQuantity 29\r\nOth" +
    "er Infor: 213\r\nDescription: Description for a shoe made by brand name this is re" +
    "all long";
            // 
            // btnCloseSideInfo
            // 
            this.btnCloseSideInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseSideInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseSideInfo.FlatAppearance.BorderSize = 0;
            this.btnCloseSideInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSideInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSideInfo.ForeColor = System.Drawing.Color.White;
            this.btnCloseSideInfo.Location = new System.Drawing.Point(0, 0);
            this.btnCloseSideInfo.Name = "btnCloseSideInfo";
            this.btnCloseSideInfo.Size = new System.Drawing.Size(30, 34);
            this.btnCloseSideInfo.TabIndex = 4;
            this.btnCloseSideInfo.Text = "X";
            this.btnCloseSideInfo.UseVisualStyleBackColor = false;
            this.btnCloseSideInfo.Click += new System.EventHandler(this.btnCloseSideInfo_Click);
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
            // pnSideInfoButtons
            // 
            this.pnSideInfoButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.pnSideInfoButtons.Controls.Add(this.btnManageStock);
            this.pnSideInfoButtons.Controls.Add(this.btnDeleteProduct);
            this.pnSideInfoButtons.Controls.Add(this.btnEditProduct);
            this.pnSideInfoButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSideInfoButtons.Location = new System.Drawing.Point(0, 515);
            this.pnSideInfoButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pnSideInfoButtons.Name = "pnSideInfoButtons";
            this.pnSideInfoButtons.Size = new System.Drawing.Size(250, 100);
            this.pnSideInfoButtons.TabIndex = 4;
            // 
            // btnManageStock
            // 
            this.btnManageStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.btnManageStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageStock.FlatAppearance.BorderSize = 0;
            this.btnManageStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStock.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStock.ForeColor = System.Drawing.Color.Black;
            this.btnManageStock.Location = new System.Drawing.Point(19, 57);
            this.btnManageStock.Name = "btnManageStock";
            this.btnManageStock.Size = new System.Drawing.Size(216, 34);
            this.btnManageStock.TabIndex = 5;
            this.btnManageStock.Text = "Manage Stock";
            this.btnManageStock.UseVisualStyleBackColor = false;
            this.btnManageStock.Click += new System.EventHandler(this.btnManageStock_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteProduct.Location = new System.Drawing.Point(130, 14);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(105, 34);
            this.btnDeleteProduct.TabIndex = 4;
            this.btnDeleteProduct.Text = "Remove Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.btnEditProduct.Location = new System.Drawing.Point(19, 14);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(105, 34);
            this.btnEditProduct.TabIndex = 3;
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources.home_icon;
            this.btnHome.Location = new System.Drawing.Point(13, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(40, 57);
            this.btnHome.TabIndex = 6;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources.refresh;
            this.btnReload.Location = new System.Drawing.Point(59, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(40, 57);
            this.btnReload.TabIndex = 5;
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
            this.btnSearch.Location = new System.Drawing.Point(449, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 27);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.btnNewProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewProduct.FlatAppearance.BorderSize = 0;
            this.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProduct.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources.edit;
            this.btnNewProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProduct.Location = new System.Drawing.Point(22, 14);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNewProduct.Size = new System.Drawing.Size(138, 34);
            this.btnNewProduct.TabIndex = 5;
            this.btnNewProduct.Text = "      New Product";
            this.btnNewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProduct.UseVisualStyleBackColor = false;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // btnQuanIncrease
            // 
            this.btnQuanIncrease.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnQuanIncrease.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanIncrease.FlatAppearance.BorderSize = 0;
            this.btnQuanIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanIncrease.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources.arrow_circle_right;
            this.btnQuanIncrease.Location = new System.Drawing.Point(70, -5);
            this.btnQuanIncrease.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuanIncrease.Name = "btnQuanIncrease";
            this.btnQuanIncrease.Size = new System.Drawing.Size(30, 37);
            this.btnQuanIncrease.TabIndex = 1;
            this.btnQuanIncrease.UseVisualStyleBackColor = false;
            this.btnQuanIncrease.Click += new System.EventHandler(this.btnQuanIncrease_Click);
            // 
            // btnQuanDecrease
            // 
            this.btnQuanDecrease.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnQuanDecrease.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanDecrease.FlatAppearance.BorderSize = 0;
            this.btnQuanDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanDecrease.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources.arrow_circle_left;
            this.btnQuanDecrease.Location = new System.Drawing.Point(0, -5);
            this.btnQuanDecrease.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuanDecrease.Name = "btnQuanDecrease";
            this.btnQuanDecrease.Size = new System.Drawing.Size(30, 37);
            this.btnQuanDecrease.TabIndex = 0;
            this.btnQuanDecrease.UseVisualStyleBackColor = false;
            this.btnQuanDecrease.Click += new System.EventHandler(this.btnQuanDecrease_Click);
            // 
            // tlTotalStockSH
            // 
            this.tlTotalStockSH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlTotalStockSH.BackColor = System.Drawing.Color.Transparent;
            this.tlTotalStockSH.BackColors = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.tlTotalStockSH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.tlTotalStockSH.BottomText = "0";
            this.tlTotalStockSH.ForeColors = System.Drawing.Color.Black;
            this.tlTotalStockSH.ImageSize = new System.Drawing.Size(40, 40);
            this.tlTotalStockSH.Location = new System.Drawing.Point(23, 18);
            this.tlTotalStockSH.Name = "tlTotalStockSH";
            this.tlTotalStockSH.Radius = 20;
            this.tlTotalStockSH.RowPercent = 55F;
            this.tlTotalStockSH.Size = new System.Drawing.Size(204, 157);
            this.tlTotalStockSH.TabIndex = 0;
            this.tlTotalStockSH.Thickness = 2;
            this.tlTotalStockSH.TileImage = ((System.Drawing.Image)(resources.GetObject("tlTotalStockSH.TileImage")));
            this.tlTotalStockSH.TopText = "Total Stock";
            // 
            // tlProductListedSH
            // 
            this.tlProductListedSH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlProductListedSH.BackColor = System.Drawing.Color.Transparent;
            this.tlProductListedSH.BackColors = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.tlProductListedSH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.tlProductListedSH.BottomText = "0";
            this.tlProductListedSH.ForeColors = System.Drawing.Color.Black;
            this.tlProductListedSH.ImageSize = new System.Drawing.Size(40, 40);
            this.tlProductListedSH.Location = new System.Drawing.Point(233, 18);
            this.tlProductListedSH.Name = "tlProductListedSH";
            this.tlProductListedSH.Radius = 20;
            this.tlProductListedSH.RowPercent = 55F;
            this.tlProductListedSH.Size = new System.Drawing.Size(204, 157);
            this.tlProductListedSH.TabIndex = 1;
            this.tlProductListedSH.Thickness = 2;
            this.tlProductListedSH.TileImage = ((System.Drawing.Image)(resources.GetObject("tlProductListedSH.TileImage")));
            this.tlProductListedSH.TopText = "Products Types";
            // 
            // tlTSVSH
            // 
            this.tlTSVSH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlTSVSH.BackColor = System.Drawing.Color.Transparent;
            this.tlTSVSH.BackColors = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.tlTSVSH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.tlTSVSH.BottomText = "0";
            this.tlTSVSH.ForeColors = System.Drawing.Color.Black;
            this.tlTSVSH.ImageSize = new System.Drawing.Size(40, 40);
            this.tlTSVSH.Location = new System.Drawing.Point(443, 18);
            this.tlTSVSH.Name = "tlTSVSH";
            this.tlTSVSH.Radius = 20;
            this.tlTSVSH.RowPercent = 55F;
            this.tlTSVSH.Size = new System.Drawing.Size(204, 157);
            this.tlTSVSH.TabIndex = 2;
            this.tlTSVSH.Thickness = 2;
            this.tlTSVSH.TileImage = global::SneakTrack___POS___Inventory_System.Properties.Resources.wallet;
            this.tlTSVSH.TopText = "Total Stock Value";
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
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblpnHeader);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(920, 675);
            this.tblpnHeader.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.tblpnSideInfo.ResumeLayout(false);
            this.tblpnBottomBar.ResumeLayout(false);
            this.pnBottom.ResumeLayout(false);
            this.tblpnBottom.ResumeLayout(false);
            this.pnBottomButtons.ResumeLayout(false);
            this.pnBarcodeControls.ResumeLayout(false);
            this.pnBarcodeControls.PerformLayout();
            this.pnBarcodeQuan.ResumeLayout(false);
            this.pnBarcodeQuan.PerformLayout();
            this.tblpnSelectionInv.ResumeLayout(false);
            this.pnSelectionHeader.ResumeLayout(false);
            this.pnSelectionHeader.PerformLayout();
            this.tblpnTilesSH.ResumeLayout(false);
            this.tblpnSideInfoLayout.ResumeLayout(false);
            this.pnSideInfo.ResumeLayout(false);
            this.pnSideInfo.PerformLayout();
            this.pnSideInfoButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxSideInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpnHeader;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.TableLayoutPanel tblpnSelectionInv;
        private System.Windows.Forms.Panel pnSelectionHeader;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Label lbTitleSH;
        private System.Windows.Forms.TableLayoutPanel tblpnSideInfo;
        private System.Windows.Forms.Panel pnSideInfo;
        private System.Windows.Forms.TableLayoutPanel tblpnBottomBar;
        private System.Windows.Forms.TableLayoutPanel tblpnTilesSH;
        private UIControls.Tile tlTotalStockSH;
        private UIControls.Tile tlProductListedSH;
        private UIControls.Tile tlTSVSH;
        private System.Windows.Forms.TextBox txbxProductInfoSI;
        private System.Windows.Forms.Label lbCaptionSI;
        private System.Windows.Forms.PictureBox pcbxSideInfo;
        private System.Windows.Forms.TableLayoutPanel tblpnSideInfoLayout;
        private System.Windows.Forms.Panel pnSideInfoButtons;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private UIControls.RoundedTxBx txbxSearch;
        private System.Windows.Forms.Button btnNewProduct;
        private UIControls.RoundedTxBx txbxBarcode;
        private System.Windows.Forms.Button btnBarcodeAdd;
        private System.Windows.Forms.TableLayoutPanel tblpnBottom;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnBottomButtons;
        private System.Windows.Forms.Panel pnBarcodeControls;
        private System.Windows.Forms.Button btnManageStock;
        private System.Windows.Forms.TextBox txbxBarcodeQuan;
        private System.Windows.Forms.CheckBox chbxAutoAddInp;
        private System.Windows.Forms.Panel pnBarcodeQuan;
        private System.Windows.Forms.Button btnQuanDecrease;
        private System.Windows.Forms.Button btnQuanIncrease;
        private System.Windows.Forms.Button btnCloseSideInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnHome;
    }
}
