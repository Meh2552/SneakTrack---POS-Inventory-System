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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSneakTrack));
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnUserAuth = new System.Windows.Forms.Panel();
            this.tblpnUATransition = new System.Windows.Forms.TableLayoutPanel();
            this.lbTransition = new System.Windows.Forms.Label();
            this.pcbxLoading = new System.Windows.Forms.PictureBox();
            this.tblpnUserAuthSplit = new System.Windows.Forms.TableLayoutPanel();
            this.pcBxUserAuthBackground = new System.Windows.Forms.PictureBox();
            this.tblpnUserAuth = new System.Windows.Forms.TableLayoutPanel();
            this.tblpnUserForm = new System.Windows.Forms.TableLayoutPanel();
            this.lbUserFormErr = new System.Windows.Forms.Label();
            this.lbPassw = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txbxUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbxPassword = new System.Windows.Forms.TextBox();
            this.lbProjTitle = new System.Windows.Forms.Label();
            this.pnSTHub = new System.Windows.Forms.Panel();
            this.pnMain.SuspendLayout();
            this.pnUserAuth.SuspendLayout();
            this.tblpnUATransition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLoading)).BeginInit();
            this.tblpnUserAuthSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxUserAuthBackground)).BeginInit();
            this.tblpnUserAuth.SuspendLayout();
            this.tblpnUserForm.SuspendLayout();
            this.pnSTHub.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.Transparent;
            this.pnMain.Controls.Add(this.pnUserAuth);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(784, 411);
            this.pnMain.TabIndex = 3;
            // 
            // pnUserAuth
            // 
            this.pnUserAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.pnUserAuth.Controls.Add(this.tblpnUATransition);
            this.pnUserAuth.Controls.Add(this.tblpnUserAuthSplit);
            this.pnUserAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnUserAuth.Location = new System.Drawing.Point(0, 0);
            this.pnUserAuth.Name = "pnUserAuth";
            this.pnUserAuth.Size = new System.Drawing.Size(784, 411);
            this.pnUserAuth.TabIndex = 1;
            // 
            // tblpnUATransition
            // 
            this.tblpnUATransition.BackColor = System.Drawing.Color.White;
            this.tblpnUATransition.ColumnCount = 3;
            this.tblpnUATransition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnUATransition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblpnUATransition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnUATransition.Controls.Add(this.lbTransition, 1, 1);
            this.tblpnUATransition.Controls.Add(this.pcbxLoading, 1, 2);
            this.tblpnUATransition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnUATransition.Location = new System.Drawing.Point(0, 0);
            this.tblpnUATransition.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnUATransition.Name = "tblpnUATransition";
            this.tblpnUATransition.RowCount = 4;
            this.tblpnUATransition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnUATransition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblpnUATransition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblpnUATransition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnUATransition.Size = new System.Drawing.Size(784, 411);
            this.tblpnUATransition.TabIndex = 4;
            this.tblpnUATransition.Visible = false;
            // 
            // lbTransition
            // 
            this.lbTransition.AutoSize = true;
            this.lbTransition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTransition.Font = new System.Drawing.Font("Coolvetica Rg", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransition.ForeColor = System.Drawing.Color.Black;
            this.lbTransition.Location = new System.Drawing.Point(159, 82);
            this.lbTransition.Name = "lbTransition";
            this.lbTransition.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.lbTransition.Size = new System.Drawing.Size(464, 123);
            this.lbTransition.TabIndex = 0;
            this.lbTransition.Text = "Login Successful, now loading...";
            this.lbTransition.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pcbxLoading
            // 
            this.pcbxLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbxLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbxLoading.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources.discord_loading_sticker_discord_loading_loading_gif;
            this.pcbxLoading.Location = new System.Drawing.Point(159, 208);
            this.pcbxLoading.Name = "pcbxLoading";
            this.pcbxLoading.Size = new System.Drawing.Size(464, 117);
            this.pcbxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxLoading.TabIndex = 1;
            this.pcbxLoading.TabStop = false;
            // 
            // tblpnUserAuthSplit
            // 
            this.tblpnUserAuthSplit.ColumnCount = 2;
            this.tblpnUserAuthSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.65306F));
            this.tblpnUserAuthSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.34694F));
            this.tblpnUserAuthSplit.Controls.Add(this.pcBxUserAuthBackground, 1, 0);
            this.tblpnUserAuthSplit.Controls.Add(this.tblpnUserAuth, 0, 0);
            this.tblpnUserAuthSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnUserAuthSplit.Location = new System.Drawing.Point(0, 0);
            this.tblpnUserAuthSplit.Name = "tblpnUserAuthSplit";
            this.tblpnUserAuthSplit.RowCount = 1;
            this.tblpnUserAuthSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnUserAuthSplit.Size = new System.Drawing.Size(784, 411);
            this.tblpnUserAuthSplit.TabIndex = 3;
            // 
            // pcBxUserAuthBackground
            // 
            this.pcBxUserAuthBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcBxUserAuthBackground.BackgroundImage")));
            this.pcBxUserAuthBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcBxUserAuthBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcBxUserAuthBackground.Location = new System.Drawing.Point(452, 0);
            this.pcBxUserAuthBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pcBxUserAuthBackground.Name = "pcBxUserAuthBackground";
            this.pcBxUserAuthBackground.Size = new System.Drawing.Size(332, 411);
            this.pcBxUserAuthBackground.TabIndex = 0;
            this.pcBxUserAuthBackground.TabStop = false;
            // 
            // tblpnUserAuth
            // 
            this.tblpnUserAuth.ColumnCount = 3;
            this.tblpnUserAuth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.03882F));
            this.tblpnUserAuth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.43498F));
            this.tblpnUserAuth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.73094F));
            this.tblpnUserAuth.Controls.Add(this.tblpnUserForm, 1, 1);
            this.tblpnUserAuth.Controls.Add(this.lbProjTitle, 1, 0);
            this.tblpnUserAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnUserAuth.Location = new System.Drawing.Point(3, 3);
            this.tblpnUserAuth.Name = "tblpnUserAuth";
            this.tblpnUserAuth.RowCount = 3;
            this.tblpnUserAuth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.57724F));
            this.tblpnUserAuth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.tblpnUserAuth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.52846F));
            this.tblpnUserAuth.Size = new System.Drawing.Size(446, 405);
            this.tblpnUserAuth.TabIndex = 2;
            // 
            // tblpnUserForm
            // 
            this.tblpnUserForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.tblpnUserForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnUserForm.Controls.Add(this.lbUserFormErr, 0, 4);
            this.tblpnUserForm.Controls.Add(this.lbPassw, 0, 2);
            this.tblpnUserForm.Controls.Add(this.lbUsername, 0, 0);
            this.tblpnUserForm.Controls.Add(this.txbxUsername, 0, 1);
            this.tblpnUserForm.Controls.Add(this.btnLogin, 0, 5);
            this.tblpnUserForm.Controls.Add(this.txbxPassword, 0, 3);
            this.tblpnUserForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnUserForm.Location = new System.Drawing.Point(87, 82);
            this.tblpnUserForm.Name = "tblpnUserForm";
            this.tblpnUserForm.RowCount = 6;
            this.tblpnUserForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tblpnUserForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tblpnUserForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tblpnUserForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tblpnUserForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tblpnUserForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tblpnUserForm.Size = new System.Drawing.Size(267, 251);
            this.tblpnUserForm.TabIndex = 3;
            // 
            // lbUserFormErr
            // 
            this.lbUserFormErr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUserFormErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserFormErr.ForeColor = System.Drawing.Color.Red;
            this.lbUserFormErr.Location = new System.Drawing.Point(10, 172);
            this.lbUserFormErr.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbUserFormErr.Name = "lbUserFormErr";
            this.lbUserFormErr.Size = new System.Drawing.Size(237, 13);
            this.lbUserFormErr.TabIndex = 5;
            this.lbUserFormErr.Text = "Password";
            this.lbUserFormErr.Visible = false;
            // 
            // lbPassw
            // 
            this.lbPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassw.Location = new System.Drawing.Point(10, 68);
            this.lbPassw.Margin = new System.Windows.Forms.Padding(10, 10, 0, 3);
            this.lbPassw.Name = "lbPassw";
            this.lbPassw.Size = new System.Drawing.Size(107, 16);
            this.lbPassw.TabIndex = 3;
            this.lbPassw.Text = "Password";
            // 
            // lbUsername
            // 
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(10, 10);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(10, 10, 0, 3);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(107, 16);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Username";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txbxUsername
            // 
            this.txbxUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxUsername.Location = new System.Drawing.Point(10, 29);
            this.txbxUsername.Margin = new System.Windows.Forms.Padding(10, 0, 10, 3);
            this.txbxUsername.MaxLength = 30;
            this.txbxUsername.Name = "txbxUsername";
            this.txbxUsername.Size = new System.Drawing.Size(247, 26);
            this.txbxUsername.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(10, 207);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(247, 34);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbxPassword
            // 
            this.txbxPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxPassword.Location = new System.Drawing.Point(10, 92);
            this.txbxPassword.Margin = new System.Windows.Forms.Padding(10, 0, 10, 3);
            this.txbxPassword.MaxLength = 30;
            this.txbxPassword.Name = "txbxPassword";
            this.txbxPassword.Size = new System.Drawing.Size(247, 26);
            this.txbxPassword.TabIndex = 4;
            // 
            // lbProjTitle
            // 
            this.lbProjTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProjTitle.Font = new System.Drawing.Font("Coolvetica Rg", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProjTitle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbProjTitle.Location = new System.Drawing.Point(87, 0);
            this.lbProjTitle.Name = "lbProjTitle";
            this.lbProjTitle.Size = new System.Drawing.Size(267, 79);
            this.lbProjTitle.TabIndex = 1;
            this.lbProjTitle.Text = "Sneak Track";
            this.lbProjTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnSTHub
            // 
            this.pnSTHub.Controls.Add(this.pnMain);
            this.pnSTHub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSTHub.Location = new System.Drawing.Point(0, 0);
            this.pnSTHub.Name = "pnSTHub";
            this.pnSTHub.Size = new System.Drawing.Size(784, 411);
            this.pnSTHub.TabIndex = 0;
            // 
            // frmSneakTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(226)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.pnSTHub);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "frmSneakTrack";
            this.Text = "SneakTrack";
            this.Load += new System.EventHandler(this.frmSneakTrack_Load);
            this.pnMain.ResumeLayout(false);
            this.pnUserAuth.ResumeLayout(false);
            this.tblpnUATransition.ResumeLayout(false);
            this.tblpnUATransition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLoading)).EndInit();
            this.tblpnUserAuthSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcBxUserAuthBackground)).EndInit();
            this.tblpnUserAuth.ResumeLayout(false);
            this.tblpnUserForm.ResumeLayout(false);
            this.tblpnUserForm.PerformLayout();
            this.pnSTHub.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnUserAuth;
        private System.Windows.Forms.Label lbProjTitle;
        private System.Windows.Forms.PictureBox pcBxUserAuthBackground;
        private System.Windows.Forms.Panel pnSTHub;
        private System.Windows.Forms.TableLayoutPanel tblpnUserAuth;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox txbxUsername;
        private System.Windows.Forms.TableLayoutPanel tblpnUserAuthSplit;
        private System.Windows.Forms.TableLayoutPanel tblpnUserForm;
        private System.Windows.Forms.TextBox txbxPassword;
        private System.Windows.Forms.Label lbPassw;
        private System.Windows.Forms.Label lbUserFormErr;
        private System.Windows.Forms.TableLayoutPanel tblpnUATransition;
        private System.Windows.Forms.Label lbTransition;
        private System.Windows.Forms.PictureBox pcbxLoading;
    }
}

