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
            this.tblpnUserAuthSplit = new System.Windows.Forms.TableLayoutPanel();
            this.tblpnUserAuth = new System.Windows.Forms.TableLayoutPanel();
            this.lbProjTitle = new System.Windows.Forms.Label();
            this.pnUserForm = new System.Windows.Forms.Panel();
            this.tblpnUserForm = new System.Windows.Forms.TableLayoutPanel();
            this.lbUserFormErr = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbxPassword = new System.Windows.Forms.TextBox();
            this.lbPassw = new System.Windows.Forms.Label();
            this.txbxUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.pcBxUALogo = new System.Windows.Forms.PictureBox();
            this.lbUALogo = new System.Windows.Forms.Label();
            this.pnUserAuthBackground = new System.Windows.Forms.Panel();
            this.pcBxUserAuthBackground = new System.Windows.Forms.PictureBox();
            this.tblpnUATransition = new System.Windows.Forms.TableLayoutPanel();
            this.lbTransition = new System.Windows.Forms.Label();
            this.pcbxLoading = new System.Windows.Forms.PictureBox();
            this.pnSTHub = new System.Windows.Forms.Panel();
            this.pnMain.SuspendLayout();
            this.pnUserAuth.SuspendLayout();
            this.tblpnUserAuthSplit.SuspendLayout();
            this.tblpnUserAuth.SuspendLayout();
            this.pnUserForm.SuspendLayout();
            this.tblpnUserForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxUALogo)).BeginInit();
            this.pnUserAuthBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxUserAuthBackground)).BeginInit();
            this.tblpnUATransition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLoading)).BeginInit();
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
            this.pnMain.Size = new System.Drawing.Size(1184, 636);
            this.pnMain.TabIndex = 3;
            // 
            // pnUserAuth
            // 
            this.pnUserAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.pnUserAuth.Controls.Add(this.tblpnUserAuthSplit);
            this.pnUserAuth.Controls.Add(this.tblpnUATransition);
            this.pnUserAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnUserAuth.Location = new System.Drawing.Point(0, 0);
            this.pnUserAuth.Name = "pnUserAuth";
            this.pnUserAuth.Size = new System.Drawing.Size(1184, 636);
            this.pnUserAuth.TabIndex = 1;
            // 
            // tblpnUserAuthSplit
            // 
            this.tblpnUserAuthSplit.ColumnCount = 2;
            this.tblpnUserAuthSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.65306F));
            this.tblpnUserAuthSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.34694F));
            this.tblpnUserAuthSplit.Controls.Add(this.tblpnUserAuth, 0, 0);
            this.tblpnUserAuthSplit.Controls.Add(this.pnUserAuthBackground, 1, 0);
            this.tblpnUserAuthSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnUserAuthSplit.Location = new System.Drawing.Point(0, 0);
            this.tblpnUserAuthSplit.Name = "tblpnUserAuthSplit";
            this.tblpnUserAuthSplit.RowCount = 1;
            this.tblpnUserAuthSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnUserAuthSplit.Size = new System.Drawing.Size(1184, 636);
            this.tblpnUserAuthSplit.TabIndex = 3;
            // 
            // tblpnUserAuth
            // 
            this.tblpnUserAuth.ColumnCount = 3;
            this.tblpnUserAuth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.16716F));
            this.tblpnUserAuth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.66569F));
            this.tblpnUserAuth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.16716F));
            this.tblpnUserAuth.Controls.Add(this.lbProjTitle, 1, 0);
            this.tblpnUserAuth.Controls.Add(this.pnUserForm, 1, 1);
            this.tblpnUserAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnUserAuth.Location = new System.Drawing.Point(0, 0);
            this.tblpnUserAuth.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnUserAuth.Name = "tblpnUserAuth";
            this.tblpnUserAuth.RowCount = 3;
            this.tblpnUserAuth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.78616F));
            this.tblpnUserAuth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.47799F));
            this.tblpnUserAuth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.57862F));
            this.tblpnUserAuth.Size = new System.Drawing.Size(682, 636);
            this.tblpnUserAuth.TabIndex = 2;
            // 
            // lbProjTitle
            // 
            this.lbProjTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProjTitle.Font = new System.Drawing.Font("Coolvetica Rg", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProjTitle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbProjTitle.Location = new System.Drawing.Point(161, 0);
            this.lbProjTitle.Name = "lbProjTitle";
            this.lbProjTitle.Size = new System.Drawing.Size(359, 164);
            this.lbProjTitle.TabIndex = 1;
            this.lbProjTitle.Text = "Sneak Track";
            this.lbProjTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnUserForm
            // 
            this.pnUserForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnUserForm.Controls.Add(this.tblpnUserForm);
            this.pnUserForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnUserForm.Location = new System.Drawing.Point(158, 164);
            this.pnUserForm.Margin = new System.Windows.Forms.Padding(0);
            this.pnUserForm.Name = "pnUserForm";
            this.pnUserForm.Size = new System.Drawing.Size(365, 391);
            this.pnUserForm.TabIndex = 4;
            // 
            // tblpnUserForm
            // 
            this.tblpnUserForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.tblpnUserForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnUserForm.Controls.Add(this.lbUserFormErr, 0, 6);
            this.tblpnUserForm.Controls.Add(this.btnLogin, 0, 7);
            this.tblpnUserForm.Controls.Add(this.txbxPassword, 0, 5);
            this.tblpnUserForm.Controls.Add(this.lbPassw, 0, 4);
            this.tblpnUserForm.Controls.Add(this.txbxUsername, 0, 3);
            this.tblpnUserForm.Controls.Add(this.lbUsername, 0, 2);
            this.tblpnUserForm.Controls.Add(this.pcBxUALogo, 0, 0);
            this.tblpnUserForm.Controls.Add(this.lbUALogo, 0, 1);
            this.tblpnUserForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnUserForm.Location = new System.Drawing.Point(0, 0);
            this.tblpnUserForm.Name = "tblpnUserForm";
            this.tblpnUserForm.RowCount = 8;
            this.tblpnUserForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.56589F));
            this.tblpnUserForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.05426F));
            this.tblpnUserForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.37984F));
            this.tblpnUserForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tblpnUserForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblpnUserForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblpnUserForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblpnUserForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tblpnUserForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblpnUserForm.Size = new System.Drawing.Size(365, 391);
            this.tblpnUserForm.TabIndex = 2;
            // 
            // lbUserFormErr
            // 
            this.lbUserFormErr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUserFormErr.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserFormErr.ForeColor = System.Drawing.Color.Red;
            this.lbUserFormErr.Location = new System.Drawing.Point(10, 310);
            this.lbUserFormErr.Margin = new System.Windows.Forms.Padding(10, 0, 0, 3);
            this.lbUserFormErr.Name = "lbUserFormErr";
            this.lbUserFormErr.Size = new System.Drawing.Size(355, 21);
            this.lbUserFormErr.TabIndex = 5;
            this.lbUserFormErr.Text = "Password";
            this.lbUserFormErr.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbUserFormErr.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(10, 339);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(345, 42);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbxPassword
            // 
            this.txbxPassword.BackColor = System.Drawing.Color.White;
            this.txbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxPassword.Location = new System.Drawing.Point(10, 275);
            this.txbxPassword.Margin = new System.Windows.Forms.Padding(10, 0, 10, 3);
            this.txbxPassword.MaxLength = 30;
            this.txbxPassword.Name = "txbxPassword";
            this.txbxPassword.PasswordChar = '*';
            this.txbxPassword.Size = new System.Drawing.Size(345, 26);
            this.txbxPassword.TabIndex = 2;
            // 
            // lbPassw
            // 
            this.lbPassw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPassw.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassw.Location = new System.Drawing.Point(10, 247);
            this.lbPassw.Margin = new System.Windows.Forms.Padding(10, 10, 0, 3);
            this.lbPassw.Name = "lbPassw";
            this.lbPassw.Size = new System.Drawing.Size(355, 25);
            this.lbPassw.TabIndex = 3;
            this.lbPassw.Text = "Password";
            this.lbPassw.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txbxUsername
            // 
            this.txbxUsername.BackColor = System.Drawing.Color.White;
            this.txbxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxUsername.ForeColor = System.Drawing.Color.Black;
            this.txbxUsername.Location = new System.Drawing.Point(10, 206);
            this.txbxUsername.Margin = new System.Windows.Forms.Padding(10, 0, 10, 3);
            this.txbxUsername.MaxLength = 30;
            this.txbxUsername.Name = "txbxUsername";
            this.txbxUsername.Size = new System.Drawing.Size(345, 26);
            this.txbxUsername.TabIndex = 1;
            // 
            // lbUsername
            // 
            this.lbUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(10, 176);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(10, 10, 0, 3);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(355, 27);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Username";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pcBxUALogo
            // 
            this.pcBxUALogo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pcBxUALogo.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources.logotransp;
            this.pcBxUALogo.Location = new System.Drawing.Point(122, 11);
            this.pcBxUALogo.Margin = new System.Windows.Forms.Padding(0);
            this.pcBxUALogo.MaximumSize = new System.Drawing.Size(120, 120);
            this.pcBxUALogo.Name = "pcBxUALogo";
            this.pcBxUALogo.Size = new System.Drawing.Size(120, 120);
            this.pcBxUALogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBxUALogo.TabIndex = 6;
            this.pcBxUALogo.TabStop = false;
            // 
            // lbUALogo
            // 
            this.lbUALogo.AutoSize = true;
            this.lbUALogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUALogo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUALogo.Location = new System.Drawing.Point(0, 136);
            this.lbUALogo.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lbUALogo.Name = "lbUALogo";
            this.lbUALogo.Size = new System.Drawing.Size(365, 30);
            this.lbUALogo.TabIndex = 7;
            this.lbUALogo.Text = "SneakTrack Login";
            this.lbUALogo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnUserAuthBackground
            // 
            this.pnUserAuthBackground.Controls.Add(this.pcBxUserAuthBackground);
            this.pnUserAuthBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnUserAuthBackground.Location = new System.Drawing.Point(682, 0);
            this.pnUserAuthBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pnUserAuthBackground.Name = "pnUserAuthBackground";
            this.pnUserAuthBackground.Size = new System.Drawing.Size(502, 636);
            this.pnUserAuthBackground.TabIndex = 5;
            // 
            // pcBxUserAuthBackground
            // 
            this.pcBxUserAuthBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcBxUserAuthBackground.BackColor = System.Drawing.Color.Black;
            this.pcBxUserAuthBackground.Image = global::SneakTrack___POS___Inventory_System.Properties.Resources._685014915_956013527344190_1734367649017491867_n;
            this.pcBxUserAuthBackground.Location = new System.Drawing.Point(-124, -24);
            this.pcBxUserAuthBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pcBxUserAuthBackground.Name = "pcBxUserAuthBackground";
            this.pcBxUserAuthBackground.Size = new System.Drawing.Size(806, 677);
            this.pcBxUserAuthBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBxUserAuthBackground.TabIndex = 0;
            this.pcBxUserAuthBackground.TabStop = false;
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
            this.tblpnUATransition.Size = new System.Drawing.Size(1184, 636);
            this.tblpnUATransition.TabIndex = 4;
            this.tblpnUATransition.Visible = false;
            // 
            // lbTransition
            // 
            this.lbTransition.AutoSize = true;
            this.lbTransition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTransition.Font = new System.Drawing.Font("Coolvetica Rg", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransition.ForeColor = System.Drawing.Color.Black;
            this.lbTransition.Location = new System.Drawing.Point(239, 127);
            this.lbTransition.Name = "lbTransition";
            this.lbTransition.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.lbTransition.Size = new System.Drawing.Size(704, 190);
            this.lbTransition.TabIndex = 0;
            this.lbTransition.Text = "Login Successful, now loading...";
            this.lbTransition.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pcbxLoading
            // 
            this.pcbxLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbxLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbxLoading.Image = ((System.Drawing.Image)(resources.GetObject("pcbxLoading.Image")));
            this.pcbxLoading.Location = new System.Drawing.Point(239, 320);
            this.pcbxLoading.Name = "pcbxLoading";
            this.pcbxLoading.Size = new System.Drawing.Size(704, 184);
            this.pcbxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxLoading.TabIndex = 1;
            this.pcbxLoading.TabStop = false;
            // 
            // pnSTHub
            // 
            this.pnSTHub.Controls.Add(this.pnMain);
            this.pnSTHub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSTHub.Location = new System.Drawing.Point(0, 0);
            this.pnSTHub.Name = "pnSTHub";
            this.pnSTHub.Size = new System.Drawing.Size(1184, 636);
            this.pnSTHub.TabIndex = 0;
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
            this.pnMain.ResumeLayout(false);
            this.pnUserAuth.ResumeLayout(false);
            this.tblpnUserAuthSplit.ResumeLayout(false);
            this.tblpnUserAuth.ResumeLayout(false);
            this.pnUserForm.ResumeLayout(false);
            this.tblpnUserForm.ResumeLayout(false);
            this.tblpnUserForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxUALogo)).EndInit();
            this.pnUserAuthBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcBxUserAuthBackground)).EndInit();
            this.tblpnUATransition.ResumeLayout(false);
            this.tblpnUATransition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLoading)).EndInit();
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
        private System.Windows.Forms.Panel pnUserForm;
        private System.Windows.Forms.PictureBox pcBxUALogo;
        private System.Windows.Forms.Label lbUALogo;
        private System.Windows.Forms.Panel pnUserAuthBackground;
    }
}

