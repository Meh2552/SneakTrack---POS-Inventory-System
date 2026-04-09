namespace SneakTrack___POS___Inventory_System
{
    partial class frmSneakTrack
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
            this.splitC_Sidebar = new System.Windows.Forms.SplitContainer();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.flpnSidebar = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitC_Sidebar)).BeginInit();
            this.splitC_Sidebar.Panel1.SuspendLayout();
            this.splitC_Sidebar.SuspendLayout();
            this.pnTitle.SuspendLayout();
            this.flpnSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitC_Sidebar
            // 
            this.splitC_Sidebar.BackColor = System.Drawing.Color.Transparent;
            this.splitC_Sidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitC_Sidebar.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitC_Sidebar.IsSplitterFixed = true;
            this.splitC_Sidebar.Location = new System.Drawing.Point(0, 0);
            this.splitC_Sidebar.Name = "splitC_Sidebar";
            // 
            // splitC_Sidebar.Panel1
            // 
            this.splitC_Sidebar.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(185)))), ((int)(((byte)(91)))));
            this.splitC_Sidebar.Panel1.Controls.Add(this.flpnSidebar);
            // 
            // splitC_Sidebar.Panel2
            // 
            this.splitC_Sidebar.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(226)))), ((int)(((byte)(219)))));
            this.splitC_Sidebar.Size = new System.Drawing.Size(784, 461);
            this.splitC_Sidebar.SplitterDistance = 202;
            this.splitC_Sidebar.TabIndex = 0;
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Location = new System.Drawing.Point(3, 3);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(196, 143);
            this.pnTitle.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Noto Sans JP DemiLight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(50)))), ((int)(((byte)(99)))));
            this.lbTitle.Location = new System.Drawing.Point(6, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(187, 74);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "SneakTrack";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpnSidebar
            // 
            this.flpnSidebar.Controls.Add(this.pnTitle);
            this.flpnSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnSidebar.Location = new System.Drawing.Point(0, 0);
            this.flpnSidebar.Name = "flpnSidebar";
            this.flpnSidebar.Size = new System.Drawing.Size(202, 461);
            this.flpnSidebar.TabIndex = 0;
            // 
            // frmSneakTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(226)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.splitC_Sidebar);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "frmSneakTrack";
            this.Text = "SneakTrack";
            this.Load += new System.EventHandler(this.frmSneakTrack_Load);
            this.splitC_Sidebar.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitC_Sidebar)).EndInit();
            this.splitC_Sidebar.ResumeLayout(false);
            this.pnTitle.ResumeLayout(false);
            this.flpnSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitC_Sidebar;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.FlowLayoutPanel flpnSidebar;
    }
}

