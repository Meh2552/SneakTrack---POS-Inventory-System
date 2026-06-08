namespace SneakTrack___POS___Inventory_System.UIControls
{
    partial class OrderCalculationPrompt
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
            this.pnHeader = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbHeader = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnCalculatorHeader = new System.Windows.Forms.Panel();
            this.pnPayment = new System.Windows.Forms.Panel();
            this.txbxPayment = new SneakTrack___POS___Inventory_System.UIControls.RoundedTxBx();
            this.lbPayment = new System.Windows.Forms.Label();
            this.lbAmountDue = new System.Windows.Forms.Label();
            this.pnBody = new System.Windows.Forms.Panel();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn1000 = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn000 = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbPaymentError = new System.Windows.Forms.Label();
            this.pnHeader.SuspendLayout();
            this.pnCalculatorHeader.SuspendLayout();
            this.pnPayment.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnHeader.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnHeader.Controls.Add(this.btnExit);
            this.pnHeader.Controls.Add(this.lbHeader);
            this.pnHeader.Location = new System.Drawing.Point(-4, -2);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(540, 63);
            this.pnHeader.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(486, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 63);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // lbHeader
            // 
            this.lbHeader.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.White;
            this.lbHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHeader.Location = new System.Drawing.Point(0, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(540, 63);
            this.lbHeader.TabIndex = 2;
            this.lbHeader.Text = "Input Payment";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbHeader_MouseDown);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(410, -2);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(130, 157);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(410, 447);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 106);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnCalculatorHeader
            // 
            this.pnCalculatorHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.pnCalculatorHeader.Controls.Add(this.pnPayment);
            this.pnCalculatorHeader.Controls.Add(this.lbAmountDue);
            this.pnCalculatorHeader.Location = new System.Drawing.Point(5, 0);
            this.pnCalculatorHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnCalculatorHeader.Name = "pnCalculatorHeader";
            this.pnCalculatorHeader.Size = new System.Drawing.Size(405, 160);
            this.pnCalculatorHeader.TabIndex = 10;
            // 
            // pnPayment
            // 
            this.pnPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnPayment.Controls.Add(this.lbPaymentError);
            this.pnPayment.Controls.Add(this.txbxPayment);
            this.pnPayment.Controls.Add(this.lbPayment);
            this.pnPayment.Location = new System.Drawing.Point(0, 80);
            this.pnPayment.Margin = new System.Windows.Forms.Padding(0);
            this.pnPayment.Name = "pnPayment";
            this.pnPayment.Size = new System.Drawing.Size(405, 77);
            this.pnPayment.TabIndex = 12;
            // 
            // txbxPayment
            // 
            this.txbxPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxPayment.AutocompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbxPayment.AutocompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbxPayment.BackColor = System.Drawing.Color.Gainsboro;
            this.txbxPayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxPayment.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txbxPayment.BorderRadius = 0;
            this.txbxPayment.BorderSize = 2;
            this.txbxPayment.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txbxPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbxPayment.Location = new System.Drawing.Point(109, 22);
            this.txbxPayment.Margin = new System.Windows.Forms.Padding(4);
            this.txbxPayment.MaxLength = 12;
            this.txbxPayment.Multiline = false;
            this.txbxPayment.Name = "txbxPayment";
            this.txbxPayment.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txbxPayment.PasswordChar = false;
            this.txbxPayment.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txbxPayment.PlaceholderText = "0.00";
            this.txbxPayment.Size = new System.Drawing.Size(276, 34);
            this.txbxPayment.TabIndex = 12;
            this.txbxPayment.Texts = "";
            this.txbxPayment.UnderlinedStyle = true;
            this.txbxPayment._TextChanged += new System.EventHandler(this.txbxPayment__TextChanged);
            // 
            // lbPayment
            // 
            this.lbPayment.AutoSize = true;
            this.lbPayment.BackColor = System.Drawing.Color.Transparent;
            this.lbPayment.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayment.ForeColor = System.Drawing.Color.Black;
            this.lbPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPayment.Location = new System.Drawing.Point(21, 25);
            this.lbPayment.Name = "lbPayment";
            this.lbPayment.Size = new System.Drawing.Size(81, 21);
            this.lbPayment.TabIndex = 13;
            this.lbPayment.Text = "Payment:";
            // 
            // lbAmountDue
            // 
            this.lbAmountDue.AutoSize = true;
            this.lbAmountDue.BackColor = System.Drawing.Color.Transparent;
            this.lbAmountDue.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmountDue.ForeColor = System.Drawing.Color.White;
            this.lbAmountDue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbAmountDue.Location = new System.Drawing.Point(30, 24);
            this.lbAmountDue.Name = "lbAmountDue";
            this.lbAmountDue.Size = new System.Drawing.Size(330, 28);
            this.lbAmountDue.TabIndex = 11;
            this.lbAmountDue.Text = "Amount Due: P 999999100.11";
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.pnBody.Controls.Add(this.btnBackspace);
            this.pnBody.Controls.Add(this.btn50);
            this.pnBody.Controls.Add(this.btn1000);
            this.pnBody.Controls.Add(this.btn500);
            this.pnBody.Controls.Add(this.btn100);
            this.pnBody.Controls.Add(this.btn000);
            this.pnBody.Controls.Add(this.btn00);
            this.pnBody.Controls.Add(this.btn0);
            this.pnBody.Controls.Add(this.btn9);
            this.pnBody.Controls.Add(this.btn8);
            this.pnBody.Controls.Add(this.btn7);
            this.pnBody.Controls.Add(this.btn6);
            this.pnBody.Controls.Add(this.btn5);
            this.pnBody.Controls.Add(this.btn4);
            this.pnBody.Controls.Add(this.btn3);
            this.pnBody.Controls.Add(this.btn2);
            this.pnBody.Controls.Add(this.btn1);
            this.pnBody.Controls.Add(this.btnClear);
            this.pnBody.Controls.Add(this.pnCalculatorHeader);
            this.pnBody.Controls.Add(this.btnCancel);
            this.pnBody.Controls.Add(this.btnConfirm);
            this.pnBody.Location = new System.Drawing.Point(-4, 61);
            this.pnBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(540, 553);
            this.pnBody.TabIndex = 13;
            // 
            // btnBackspace
            // 
            this.btnBackspace.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBackspace.BackColor = System.Drawing.Color.Gray;
            this.btnBackspace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackspace.FlatAppearance.BorderSize = 0;
            this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.ForeColor = System.Drawing.Color.White;
            this.btnBackspace.Location = new System.Drawing.Point(410, 155);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(130, 166);
            this.btnBackspace.TabIndex = 28;
            this.btnBackspace.Text = "Back";
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btn50
            // 
            this.btn50.BackColor = System.Drawing.Color.Black;
            this.btn50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn50.FlatAppearance.BorderSize = 0;
            this.btn50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn50.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn50.ForeColor = System.Drawing.Color.White;
            this.btn50.Location = new System.Drawing.Point(16, 450);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(89, 86);
            this.btn50.TabIndex = 27;
            this.btn50.Text = "+50";
            this.btn50.UseVisualStyleBackColor = false;
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
            // 
            // btn1000
            // 
            this.btn1000.BackColor = System.Drawing.Color.Black;
            this.btn1000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1000.FlatAppearance.BorderSize = 0;
            this.btn1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1000.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1000.ForeColor = System.Drawing.Color.White;
            this.btn1000.Location = new System.Drawing.Point(301, 450);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(89, 86);
            this.btn1000.TabIndex = 26;
            this.btn1000.Text = "+1000";
            this.btn1000.UseVisualStyleBackColor = false;
            this.btn1000.Click += new System.EventHandler(this.btn1000_Click);
            // 
            // btn500
            // 
            this.btn500.BackColor = System.Drawing.Color.Black;
            this.btn500.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn500.FlatAppearance.BorderSize = 0;
            this.btn500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn500.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn500.ForeColor = System.Drawing.Color.White;
            this.btn500.Location = new System.Drawing.Point(206, 450);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(89, 86);
            this.btn500.TabIndex = 25;
            this.btn500.Text = "+500";
            this.btn500.UseVisualStyleBackColor = false;
            this.btn500.Click += new System.EventHandler(this.btn500_Click);
            // 
            // btn100
            // 
            this.btn100.BackColor = System.Drawing.Color.Black;
            this.btn100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn100.FlatAppearance.BorderSize = 0;
            this.btn100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn100.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn100.ForeColor = System.Drawing.Color.White;
            this.btn100.Location = new System.Drawing.Point(111, 450);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(89, 86);
            this.btn100.TabIndex = 24;
            this.btn100.Text = "+100";
            this.btn100.UseVisualStyleBackColor = false;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn000
            // 
            this.btn000.BackColor = System.Drawing.Color.Black;
            this.btn000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn000.FlatAppearance.BorderSize = 0;
            this.btn000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn000.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn000.ForeColor = System.Drawing.Color.White;
            this.btn000.Location = new System.Drawing.Point(16, 358);
            this.btn000.Name = "btn000";
            this.btn000.Size = new System.Drawing.Size(89, 86);
            this.btn000.TabIndex = 23;
            this.btn000.Text = "000";
            this.btn000.UseVisualStyleBackColor = false;
            this.btn000.Click += new System.EventHandler(this.btn000_Click);
            // 
            // btn00
            // 
            this.btn00.BackColor = System.Drawing.Color.Black;
            this.btn00.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn00.FlatAppearance.BorderSize = 0;
            this.btn00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn00.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn00.ForeColor = System.Drawing.Color.White;
            this.btn00.Location = new System.Drawing.Point(16, 266);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(89, 86);
            this.btn00.TabIndex = 22;
            this.btn00.Text = "00";
            this.btn00.UseVisualStyleBackColor = false;
            this.btn00.Click += new System.EventHandler(this.btn00_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Black;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(16, 174);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(89, 86);
            this.btn0.TabIndex = 21;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Black;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(301, 358);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(89, 86);
            this.btn9.TabIndex = 20;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(206, 358);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(89, 86);
            this.btn8.TabIndex = 19;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Black;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(111, 358);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(89, 86);
            this.btn7.TabIndex = 18;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Black;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(301, 266);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(89, 86);
            this.btn6.TabIndex = 17;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Black;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(206, 266);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(89, 86);
            this.btn5.TabIndex = 16;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Black;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(111, 266);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(89, 86);
            this.btn4.TabIndex = 15;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(301, 174);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(89, 86);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(206, 174);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(89, 86);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(111, 174);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(89, 86);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(410, 321);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 128);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbPaymentError
            // 
            this.lbPaymentError.AutoSize = true;
            this.lbPaymentError.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaymentError.ForeColor = System.Drawing.Color.Tomato;
            this.lbPaymentError.Location = new System.Drawing.Point(108, 9);
            this.lbPaymentError.Name = "lbPaymentError";
            this.lbPaymentError.Size = new System.Drawing.Size(115, 16);
            this.lbPaymentError.TabIndex = 49;
            this.lbPaymentError.Text = "Insufficient Payment";
            this.lbPaymentError.Visible = false;
            // 
            // OrderCalculationPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(536, 617);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderCalculationPrompt";
            this.Text = "OrderCalculationPrompt";
            this.pnHeader.ResumeLayout(false);
            this.pnCalculatorHeader.ResumeLayout(false);
            this.pnCalculatorHeader.PerformLayout();
            this.pnPayment.ResumeLayout(false);
            this.pnPayment.PerformLayout();
            this.pnBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnCalculatorHeader;
        private RoundedTxBx txbxPayment;
        private System.Windows.Forms.Label lbAmountDue;
        private System.Windows.Forms.Panel pnPayment;
        private System.Windows.Forms.Label lbPayment;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn1000;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn000;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Label lbPaymentError;
    }
}