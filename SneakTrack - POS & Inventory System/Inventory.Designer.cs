namespace SneakTrack___POS___Inventory_System
{
    partial class UserControl1
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
            this.tblpnHeaderSplit = new System.Windows.Forms.TableLayoutPanel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.tblpnSelectionInv = new System.Windows.Forms.TableLayoutPanel();
            this.pnSelectionHeader = new System.Windows.Forms.Panel();
            this.tblpnHeaderSplit.SuspendLayout();
            this.tblpnSelectionInv.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpnHeaderSplit
            // 
            this.tblpnHeaderSplit.ColumnCount = 1;
            this.tblpnHeaderSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnHeaderSplit.Controls.Add(this.pnHeader, 0, 0);
            this.tblpnHeaderSplit.Controls.Add(this.tblpnSelectionInv, 0, 1);
            this.tblpnHeaderSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnHeaderSplit.Location = new System.Drawing.Point(0, 0);
            this.tblpnHeaderSplit.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnHeaderSplit.Name = "tblpnHeaderSplit";
            this.tblpnHeaderSplit.RowCount = 2;
            this.tblpnHeaderSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblpnHeaderSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnHeaderSplit.Size = new System.Drawing.Size(920, 675);
            this.tblpnHeaderSplit.TabIndex = 0;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Black;
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(920, 60);
            this.pnHeader.TabIndex = 0;
            // 
            // tblpnSelectionInv
            // 
            this.tblpnSelectionInv.ColumnCount = 1;
            this.tblpnSelectionInv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 715F));
            this.tblpnSelectionInv.Controls.Add(this.pnSelectionHeader, 0, 0);
            this.tblpnSelectionInv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnSelectionInv.Location = new System.Drawing.Point(0, 60);
            this.tblpnSelectionInv.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnSelectionInv.Name = "tblpnSelectionInv";
            this.tblpnSelectionInv.RowCount = 2;
            this.tblpnSelectionInv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tblpnSelectionInv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnSelectionInv.Size = new System.Drawing.Size(920, 615);
            this.tblpnSelectionInv.TabIndex = 1;
            // 
            // pnSelectionHeader
            // 
            this.pnSelectionHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.pnSelectionHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSelectionHeader.Location = new System.Drawing.Point(0, 0);
            this.pnSelectionHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnSelectionHeader.Name = "pnSelectionHeader";
            this.pnSelectionHeader.Size = new System.Drawing.Size(920, 227);
            this.pnSelectionHeader.TabIndex = 0;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblpnHeaderSplit);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(920, 675);
            this.tblpnHeaderSplit.ResumeLayout(false);
            this.tblpnSelectionInv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpnHeaderSplit;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.TableLayoutPanel tblpnSelectionInv;
        private System.Windows.Forms.Panel pnSelectionHeader;
    }
}
