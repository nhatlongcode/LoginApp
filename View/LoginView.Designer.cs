namespace LoginApp.View
{
    partial class LoginView
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.regButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Header.Controls.Add(this.txtPassword);
            this.Header.Controls.Add(this.txtUsername);
            this.Header.Controls.Add(this.bunifuImageButton3);
            this.Header.Controls.Add(this.bunifuImageButton2);
            this.Header.Controls.Add(this.closeButton);
            this.Header.Controls.Add(this.regButton);
            this.Header.Controls.Add(this.logButton);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(384, 261);
            this.Header.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(126, 99);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(156, 32);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.Location = new System.Drawing.Point(126, 44);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(156, 32);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.Text = "Username";
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuImageButton3.Image = global::LoginApp.Properties.Resources.icons8_lock_48px;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(78, 94);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(47, 40);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 6;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 0;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuImageButton2.Image = global::LoginApp.Properties.Resources.icons8_user_male_circle_64px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(75, 35);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(50, 51);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 5;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.closeButton.Image = global::LoginApp.Properties.Resources.icons8_delete_sign_64px;
            this.closeButton.ImageActive = global::LoginApp.Properties.Resources.icons8_delete_sign_64px;
            this.closeButton.Location = new System.Drawing.Point(347, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 27);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            this.closeButton.Zoom = 30;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // regButton
            // 
            this.regButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.regButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.regButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regButton.BorderRadius = 0;
            this.regButton.ButtonText = "REGISTER";
            this.regButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regButton.DisabledColor = System.Drawing.Color.Gray;
            this.regButton.Iconcolor = System.Drawing.Color.Transparent;
            this.regButton.Iconimage = null;
            this.regButton.Iconimage_right = null;
            this.regButton.Iconimage_right_Selected = null;
            this.regButton.Iconimage_Selected = null;
            this.regButton.IconMarginLeft = 0;
            this.regButton.IconMarginRight = 0;
            this.regButton.IconRightVisible = true;
            this.regButton.IconRightZoom = 0D;
            this.regButton.IconVisible = true;
            this.regButton.IconZoom = 64D;
            this.regButton.IsTab = false;
            this.regButton.Location = new System.Drawing.Point(204, 164);
            this.regButton.Margin = new System.Windows.Forms.Padding(4);
            this.regButton.Name = "regButton";
            this.regButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.regButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
            this.regButton.OnHoverTextColor = System.Drawing.Color.White;
            this.regButton.selected = false;
            this.regButton.Size = new System.Drawing.Size(134, 46);
            this.regButton.TabIndex = 1;
            this.regButton.Text = "REGISTER";
            this.regButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regButton.Textcolor = System.Drawing.Color.White;
            this.regButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // logButton
            // 
            this.logButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.logButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.logButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logButton.BorderRadius = 0;
            this.logButton.ButtonText = "LOGIN";
            this.logButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logButton.DisabledColor = System.Drawing.Color.Gray;
            this.logButton.Iconcolor = System.Drawing.Color.Transparent;
            this.logButton.Iconimage = null;
            this.logButton.Iconimage_right = null;
            this.logButton.Iconimage_right_Selected = null;
            this.logButton.Iconimage_Selected = null;
            this.logButton.IconMarginLeft = 0;
            this.logButton.IconMarginRight = 0;
            this.logButton.IconRightVisible = true;
            this.logButton.IconRightZoom = 0D;
            this.logButton.IconVisible = true;
            this.logButton.IconZoom = 64D;
            this.logButton.IsTab = false;
            this.logButton.Location = new System.Drawing.Point(38, 164);
            this.logButton.Margin = new System.Windows.Forms.Padding(4);
            this.logButton.Name = "logButton";
            this.logButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.logButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.logButton.OnHoverTextColor = System.Drawing.Color.White;
            this.logButton.selected = false;
            this.logButton.Size = new System.Drawing.Size(134, 46);
            this.logButton.TabIndex = 0;
            this.logButton.Text = "LOGIN";
            this.logButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logButton.Textcolor = System.Drawing.Color.White;
            this.logButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginView";
            this.Text = "Form1";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Header;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton logButton;
        private Bunifu.Framework.UI.BunifuFlatButton regButton;
        private Bunifu.Framework.UI.BunifuImageButton closeButton;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
    }
}

