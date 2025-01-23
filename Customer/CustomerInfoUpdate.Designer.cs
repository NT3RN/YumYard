namespace YumYard.Customer
{
    partial class CustomerInfoUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInfoUpdate));
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.btnOrderInfo = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCurrentPass = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbCurrPass = new System.Windows.Forms.TextBox();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblWarnID = new System.Windows.Forms.Label();
            this.lblWarnUN = new System.Windows.Forms.Label();
            this.lblWarnEmail = new System.Windows.Forms.Label();
            this.lblWarnCPass = new System.Windows.Forms.Label();
            this.lblWarnNPass = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.btnHidePass = new System.Windows.Forms.Button();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCustomer.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelCustomer.Controls.Add(this.btnOrderInfo);
            this.panelCustomer.Controls.Add(this.btnUser);
            this.panelCustomer.Controls.Add(this.btnHome);
            this.panelCustomer.Controls.Add(this.panelLogo);
            this.panelCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCustomer.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCustomer.Location = new System.Drawing.Point(0, 0);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(200, 594);
            this.panelCustomer.TabIndex = 25;
            // 
            // btnOrderInfo
            // 
            this.btnOrderInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderInfo.FlatAppearance.BorderSize = 0;
            this.btnOrderInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderInfo.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderInfo.ForeColor = System.Drawing.SystemColors.Info;
            this.btnOrderInfo.Image = global::YumYard.Properties.Resources.icons8_shopping_cart_48;
            this.btnOrderInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderInfo.Location = new System.Drawing.Point(0, 224);
            this.btnOrderInfo.Name = "btnOrderInfo";
            this.btnOrderInfo.Size = new System.Drawing.Size(200, 62);
            this.btnOrderInfo.TabIndex = 2;
            this.btnOrderInfo.Text = "My Orders";
            this.btnOrderInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrderInfo.UseVisualStyleBackColor = true;
            this.btnOrderInfo.Click += new System.EventHandler(this.btnOrderInfo_Click);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.SystemColors.Info;
            this.btnUser.Image = global::YumYard.Properties.Resources.icons8_user_50;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 162);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(200, 62);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "User Info";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.Info;
            this.btnHome.Image = global::YumYard.Properties.Resources.icons8_home_50;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 100);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 62);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUserID.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(346, 105);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(84, 23);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "User ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(346, 164);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "User Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(346, 223);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(119, 23);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "User Email";
            // 
            // lblCurrentPass
            // 
            this.lblCurrentPass.AutoSize = true;
            this.lblCurrentPass.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPass.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPass.Location = new System.Drawing.Point(346, 341);
            this.lblCurrentPass.Name = "lblCurrentPass";
            this.lblCurrentPass.Size = new System.Drawing.Size(192, 23);
            this.lblCurrentPass.TabIndex = 4;
            this.lblCurrentPass.Text = "Current Password";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPass.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Location = new System.Drawing.Point(346, 400);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(157, 23);
            this.lblNewPass.TabIndex = 5;
            this.lblNewPass.Text = "New Password";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(346, 282);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(84, 23);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender";
            // 
            // tbUserID
            // 
            this.tbUserID.BackColor = System.Drawing.Color.Wheat;
            this.tbUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserID.Enabled = false;
            this.tbUserID.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserID.ForeColor = System.Drawing.Color.Black;
            this.tbUserID.Location = new System.Drawing.Point(572, 108);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.ReadOnly = true;
            this.tbUserID.Size = new System.Drawing.Size(183, 17);
            this.tbUserID.TabIndex = 7;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(572, 167);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(183, 20);
            this.tbUserName.TabIndex = 8;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(572, 226);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(183, 20);
            this.tbEmail.TabIndex = 9;
            // 
            // tbCurrPass
            // 
            this.tbCurrPass.Location = new System.Drawing.Point(572, 344);
            this.tbCurrPass.Name = "tbCurrPass";
            this.tbCurrPass.PasswordChar = '*';
            this.tbCurrPass.Size = new System.Drawing.Size(183, 20);
            this.tbCurrPass.TabIndex = 11;
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(572, 405);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PasswordChar = '*';
            this.tbNewPass.Size = new System.Drawing.Size(183, 20);
            this.tbNewPass.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SpringGreen;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(481, 466);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 35);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblWarnID
            // 
            this.lblWarnID.AutoSize = true;
            this.lblWarnID.BackColor = System.Drawing.Color.Transparent;
            this.lblWarnID.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarnID.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWarnID.Location = new System.Drawing.Point(569, 135);
            this.lblWarnID.Name = "lblWarnID";
            this.lblWarnID.Size = new System.Drawing.Size(39, 15);
            this.lblWarnID.TabIndex = 14;
            this.lblWarnID.Text = "label1";
            // 
            // lblWarnUN
            // 
            this.lblWarnUN.AutoSize = true;
            this.lblWarnUN.BackColor = System.Drawing.Color.Transparent;
            this.lblWarnUN.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarnUN.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWarnUN.Location = new System.Drawing.Point(569, 190);
            this.lblWarnUN.Name = "lblWarnUN";
            this.lblWarnUN.Size = new System.Drawing.Size(39, 15);
            this.lblWarnUN.TabIndex = 15;
            this.lblWarnUN.Text = "label1";
            // 
            // lblWarnEmail
            // 
            this.lblWarnEmail.AutoSize = true;
            this.lblWarnEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblWarnEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarnEmail.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWarnEmail.Location = new System.Drawing.Point(569, 249);
            this.lblWarnEmail.Name = "lblWarnEmail";
            this.lblWarnEmail.Size = new System.Drawing.Size(39, 15);
            this.lblWarnEmail.TabIndex = 16;
            this.lblWarnEmail.Text = "label1";
            // 
            // lblWarnCPass
            // 
            this.lblWarnCPass.AutoSize = true;
            this.lblWarnCPass.BackColor = System.Drawing.Color.Transparent;
            this.lblWarnCPass.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarnCPass.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWarnCPass.Location = new System.Drawing.Point(569, 367);
            this.lblWarnCPass.Name = "lblWarnCPass";
            this.lblWarnCPass.Size = new System.Drawing.Size(39, 15);
            this.lblWarnCPass.TabIndex = 18;
            this.lblWarnCPass.Text = "label1";
            // 
            // lblWarnNPass
            // 
            this.lblWarnNPass.AutoSize = true;
            this.lblWarnNPass.BackColor = System.Drawing.Color.Transparent;
            this.lblWarnNPass.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarnNPass.ForeColor = System.Drawing.Color.Firebrick;
            this.lblWarnNPass.Location = new System.Drawing.Point(569, 428);
            this.lblWarnNPass.Name = "lblWarnNPass";
            this.lblWarnNPass.Size = new System.Drawing.Size(39, 15);
            this.lblWarnNPass.TabIndex = 19;
            this.lblWarnNPass.Text = "label1";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.BackColor = System.Drawing.Color.Transparent;
            this.rbtnMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnMale.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.Location = new System.Drawing.Point(572, 282);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(60, 22);
            this.rbtnMale.TabIndex = 20;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = false;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.BackColor = System.Drawing.Color.Transparent;
            this.rbtnFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnFemale.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F);
            this.rbtnFemale.Location = new System.Drawing.Point(677, 282);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(78, 22);
            this.rbtnFemale.TabIndex = 21;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = false;
            // 
            // btnHidePass
            // 
            this.btnHidePass.BackColor = System.Drawing.SystemColors.Control;
            this.btnHidePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHidePass.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHidePass.Location = new System.Drawing.Point(787, 341);
            this.btnHidePass.Name = "btnHidePass";
            this.btnHidePass.Size = new System.Drawing.Size(75, 23);
            this.btnHidePass.TabIndex = 22;
            this.btnHidePass.Text = "Hide";
            this.btnHidePass.UseVisualStyleBackColor = false;
            this.btnHidePass.Click += new System.EventHandler(this.btnHidePass_Click);
            // 
            // btnShowPass
            // 
            this.btnShowPass.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPass.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPass.Location = new System.Drawing.Point(787, 341);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(75, 23);
            this.btnShowPass.TabIndex = 23;
            this.btnShowPass.Text = "Show";
            this.btnShowPass.UseVisualStyleBackColor = false;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(644, 466);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 35);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete Account";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "YUM YARD";
            // 
            // CustomerInfoUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1056, 594);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.btnHidePass);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.lblWarnNPass);
            this.Controls.Add(this.lblWarnCPass);
            this.Controls.Add(this.lblWarnEmail);
            this.Controls.Add(this.lblWarnUN);
            this.Controls.Add(this.lblWarnID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.tbCurrPass);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblCurrentPass);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUserID);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerInfoUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerInfoUpdate";
            this.panelCustomer.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnOrderInfo;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCurrentPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbCurrPass;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblWarnID;
        private System.Windows.Forms.Label lblWarnUN;
        private System.Windows.Forms.Label lblWarnEmail;
        private System.Windows.Forms.Label lblWarnCPass;
        private System.Windows.Forms.Label lblWarnNPass;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Button btnHidePass;
        private System.Windows.Forms.Button btnShowPass;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
    }
}