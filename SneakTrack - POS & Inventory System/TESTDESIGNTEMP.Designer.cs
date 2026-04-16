namespace SneakTrack___POS___Inventory_System
{
    partial class TESTDESIGNTEMP
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
            this.tblpnSTMenu = new System.Windows.Forms.TableLayoutPanel();
            this.tblpnToolBarSplit = new System.Windows.Forms.TableLayoutPanel();
            this.pnToolbar = new System.Windows.Forms.Panel();
            this.pnPOS = new System.Windows.Forms.Panel();
            this.pnSidebar = new System.Windows.Forms.Panel();
            this.tblpnSTMenu.SuspendLayout();
            this.tblpnToolBarSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpnSTMenu
            // 
            this.tblpnSTMenu.ColumnCount = 2;
            this.tblpnSTMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tblpnSTMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.0424F));
            this.tblpnSTMenu.Controls.Add(this.tblpnToolBarSplit, 1, 0);
            this.tblpnSTMenu.Controls.Add(this.pnSidebar, 0, 0);
            this.tblpnSTMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnSTMenu.Location = new System.Drawing.Point(0, 0);
            this.tblpnSTMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnSTMenu.Name = "tblpnSTMenu";
            this.tblpnSTMenu.RowCount = 1;
            this.tblpnSTMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnSTMenu.Size = new System.Drawing.Size(790, 399);
            this.tblpnSTMenu.TabIndex = 1;
            // 
            // tblpnToolBarSplit
            // 
            this.tblpnToolBarSplit.ColumnCount = 1;
            this.tblpnToolBarSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnToolBarSplit.Controls.Add(this.pnToolbar, 0, 0);
            this.tblpnToolBarSplit.Controls.Add(this.pnPOS, 0, 1);
            this.tblpnToolBarSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnToolBarSplit.Location = new System.Drawing.Point(220, 0);
            this.tblpnToolBarSplit.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnToolBarSplit.Name = "tblpnToolBarSplit";
            this.tblpnToolBarSplit.RowCount = 2;
            this.tblpnToolBarSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblpnToolBarSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tblpnToolBarSplit.Size = new System.Drawing.Size(570, 399);
            this.tblpnToolBarSplit.TabIndex = 1;
            // 
            // pnToolbar
            // 
            this.pnToolbar.BackColor = System.Drawing.Color.Black;
            this.pnToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.pnToolbar.Name = "pnToolbar";
            this.pnToolbar.Size = new System.Drawing.Size(570, 55);
            this.pnToolbar.TabIndex = 2;
            // 
            // pnPOS
            // 
            this.pnPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(226)))), ((int)(((byte)(219)))));
            this.pnPOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPOS.Location = new System.Drawing.Point(0, 55);
            this.pnPOS.Margin = new System.Windows.Forms.Padding(0);
            this.pnPOS.Name = "pnPOS";
            this.pnPOS.Size = new System.Drawing.Size(570, 344);
            this.pnPOS.TabIndex = 1;
            // 
            // pnSidebar
            // 
            this.pnSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.pnSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.pnSidebar.Name = "pnSidebar";
            this.pnSidebar.Size = new System.Drawing.Size(220, 399);
            this.pnSidebar.TabIndex = 0;
            // 
            // TESTDESIGNTEMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 399);
            this.Controls.Add(this.tblpnSTMenu);
            this.Name = "TESTDESIGNTEMP";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TESTDESIGNTEMP_Load);
            this.tblpnSTMenu.ResumeLayout(false);
            this.tblpnToolBarSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpnSTMenu;
        private System.Windows.Forms.Panel pnSidebar;
        private System.Windows.Forms.Panel pnPOS;
        private System.Windows.Forms.TableLayoutPanel tblpnToolBarSplit;
        private System.Windows.Forms.Panel pnToolbar;
    }
}