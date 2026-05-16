namespace SneakTrack___POS___Inventory_System.UIControls
{
    partial class Tile
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
            this.roundedPanel3 = new SneakTrack___POS___Inventory_System.UIControls.RoundedPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTop = new System.Windows.Forms.Label();
            this.lbBottom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundedPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.White;
            this.roundedPanel3.BorderColor = System.Drawing.Color.White;
            this.roundedPanel3.Controls.Add(this.tableLayoutPanel1);
            this.roundedPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel3.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Radius = 20;
            this.roundedPanel3.Size = new System.Drawing.Size(173, 158);
            this.roundedPanel3.TabIndex = 4;
            this.roundedPanel3.Thickness = 5F;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbBottom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(173, 158);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lbTop
            // 
            this.lbTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTop.AutoSize = true;
            this.lbTop.BackColor = System.Drawing.Color.Transparent;
            this.lbTop.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTop.Location = new System.Drawing.Point(10, 21);
            this.lbTop.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lbTop.Name = "lbTop";
            this.lbTop.Size = new System.Drawing.Size(93, 19);
            this.lbTop.TabIndex = 0;
            this.lbTop.Text = "Total Stock";
            this.lbTop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBottom
            // 
            this.lbBottom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbBottom.AutoSize = true;
            this.lbBottom.BackColor = System.Drawing.Color.Transparent;
            this.lbBottom.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBottom.Location = new System.Drawing.Point(28, 99);
            this.lbBottom.Name = "lbBottom";
            this.lbBottom.Size = new System.Drawing.Size(117, 36);
            this.lbBottom.TabIndex = 1;
            this.lbBottom.Text = "999999";
            this.lbBottom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources.apps_add__1_;
            this.pictureBox1.Location = new System.Drawing.Point(70, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Tile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.roundedPanel3);
            this.Name = "Tile";
            this.Size = new System.Drawing.Size(173, 158);
            this.roundedPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbBottom;
        private System.Windows.Forms.Label lbTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
