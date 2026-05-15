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
            this.tblpnBorderSplit = new System.Windows.Forms.TableLayoutPanel();
            this.pn = new System.Windows.Forms.Panel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.tblpnSelectionInv = new System.Windows.Forms.TableLayoutPanel();
            this.pnSelectionHeader = new System.Windows.Forms.Panel();
            this.lbBarcode = new System.Windows.Forms.Label();
            this.lbHeaderTitle = new System.Windows.Forms.Label();
            this.tblpnBorderSplit.SuspendLayout();
            this.pn.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.tblpnSelectionInv.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpnBorderSplit
            // 
            this.tblpnBorderSplit.ColumnCount = 1;
            this.tblpnBorderSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnBorderSplit.Controls.Add(this.pn, 0, 2);
            this.tblpnBorderSplit.Controls.Add(this.pnHeader, 0, 0);
            this.tblpnBorderSplit.Controls.Add(this.tblpnSelectionInv, 0, 1);
            this.tblpnBorderSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnBorderSplit.Location = new System.Drawing.Point(0, 0);
            this.tblpnBorderSplit.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnBorderSplit.Name = "tblpnBorderSplit";
            this.tblpnBorderSplit.RowCount = 3;
            this.tblpnBorderSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblpnBorderSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnBorderSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tblpnBorderSplit.Size = new System.Drawing.Size(920, 675);
            this.tblpnBorderSplit.TabIndex = 0;
            // 
            // pn
            // 
            this.pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.pn.Controls.Add(this.lbBarcode);
            this.pn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn.Location = new System.Drawing.Point(0, 511);
            this.pn.Margin = new System.Windows.Forms.Padding(0);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(920, 164);
            this.pn.TabIndex = 2;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Black;
            this.pnHeader.Controls.Add(this.lbHeaderTitle);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(920, 60);
            this.pnHeader.TabIndex = 0;
            // 
            // tblpnSelectionInv
            // 
            this.tblpnSelectionInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.tblpnSelectionInv.ColumnCount = 1;
            this.tblpnSelectionInv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 715F));
            this.tblpnSelectionInv.Controls.Add(this.pnSelectionHeader, 0, 0);
            this.tblpnSelectionInv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnSelectionInv.Location = new System.Drawing.Point(0, 60);
            this.tblpnSelectionInv.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnSelectionInv.Name = "tblpnSelectionInv";
            this.tblpnSelectionInv.RowCount = 2;
            this.tblpnSelectionInv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tblpnSelectionInv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnSelectionInv.Size = new System.Drawing.Size(920, 451);
            this.tblpnSelectionInv.TabIndex = 1;
            // 
            // pnSelectionHeader
            // 
            this.pnSelectionHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.pnSelectionHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSelectionHeader.Location = new System.Drawing.Point(0, 0);
            this.pnSelectionHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnSelectionHeader.Name = "pnSelectionHeader";
            this.pnSelectionHeader.Size = new System.Drawing.Size(920, 163);
            this.pnSelectionHeader.TabIndex = 0;
            // 
            // lbBarcode
            // 
            this.lbBarcode.AutoSize = true;
            this.lbBarcode.BackColor = System.Drawing.Color.Transparent;
            this.lbBarcode.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarcode.ForeColor = System.Drawing.Color.Black;
            this.lbBarcode.Location = new System.Drawing.Point(19, 19);
            this.lbBarcode.Name = "lbBarcode";
            this.lbBarcode.Size = new System.Drawing.Size(82, 21);
            this.lbBarcode.TabIndex = 1;
            this.lbBarcode.Text = "Inventory";
            // 
            // lbHeaderTitle
            // 
            this.lbHeaderTitle.AutoSize = true;
            this.lbHeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbHeaderTitle.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lbHeaderTitle.Location = new System.Drawing.Point(17, 12);
            this.lbHeaderTitle.Name = "lbHeaderTitle";
            this.lbHeaderTitle.Size = new System.Drawing.Size(130, 35);
            this.lbHeaderTitle.TabIndex = 0;
            this.lbHeaderTitle.Text = "Inventory";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblpnBorderSplit);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(920, 675);
            this.tblpnBorderSplit.ResumeLayout(false);
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.tblpnSelectionInv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpnBorderSplit;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.TableLayoutPanel tblpnSelectionInv;
        private System.Windows.Forms.Panel pnSelectionHeader;
        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Label lbBarcode;
        private System.Windows.Forms.Label lbHeaderTitle;
    }
}
