using System.Drawing;
using System.Runtime.InteropServices;

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
            this.pnSTHub = new System.Windows.Forms.Panel();
            this.userConLogin = new SneakTrack___POS___Inventory_System.Login();
            this.userConMainDash = new SneakTrack___POS___Inventory_System.MainDashboard();
            this.pnSTHub.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSTHub
            // 
            this.pnSTHub.Controls.Add(this.userConLogin);
            this.pnSTHub.Controls.Add(this.userConMainDash);
            this.pnSTHub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSTHub.Location = new System.Drawing.Point(0, 0);
            this.pnSTHub.Margin = new System.Windows.Forms.Padding(0);
            this.pnSTHub.Name = "pnSTHub";
            this.pnSTHub.Size = new System.Drawing.Size(1184, 636);
            this.pnSTHub.TabIndex = 0;
            // 
            // userConLogin
            // 
            this.userConLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userConLogin.Location = new System.Drawing.Point(0, 0);
            this.userConLogin.Margin = new System.Windows.Forms.Padding(0);
            this.userConLogin.Name = "userConLogin";
            this.userConLogin.Size = new System.Drawing.Size(1184, 636);
            this.userConLogin.TabIndex = 0;
            // 
            // userConMainDash
            // 
            this.userConMainDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userConMainDash.Location = new System.Drawing.Point(0, 0);
            this.userConMainDash.Margin = new System.Windows.Forms.Padding(0);
            this.userConMainDash.Name = "userConMainDash";
            this.userConMainDash.Size = new System.Drawing.Size(1184, 636);
            this.userConMainDash.TabIndex = 1;
            this.userConMainDash.Visible = false;
            // 
            // frmSneakTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.pnSTHub);
            this.MinimumSize = new System.Drawing.Size(1200, 675);
            this.Name = "frmSneakTrack";
            this.Text = "SneakTrack";
            this.Load += new System.EventHandler(this.frmSneakTrack_Load);
            this.pnSTHub.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnSTHub;
        private Login userConLogin;
        private MainDashboard userConMainDash;
    }
}

