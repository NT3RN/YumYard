namespace YumYard.Register___Login
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lblForgotPass = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(120, 202);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 23);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(120, 264);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(107, 23);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.Control;
            this.tbEmail.Location = new System.Drawing.Point(259, 205);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(260, 20);
            this.tbEmail.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(259, 264);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(260, 20);
            this.tbPass.TabIndex = 3;
            // 
            // lblForgotPass
            // 
            this.lblForgotPass.AutoSize = true;
            this.lblForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotPass.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPass.ForeColor = System.Drawing.Color.Red;
            this.lblForgotPass.Location = new System.Drawing.Point(255, 298);
            this.lblForgotPass.Name = "lblForgotPass";
            this.lblForgotPass.Size = new System.Drawing.Size(191, 23);
            this.lblForgotPass.TabIndex = 4;
            this.lblForgotPass.Text = "Forgot password?";
            this.lblForgotPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignIn.BackgroundImage")));
            this.btnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Location = new System.Drawing.Point(224, 354);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(142, 41);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.UseVisualStyleBackColor = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 594);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblForgotPass);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblEmail);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lblForgotPass;
        private System.Windows.Forms.Button btnSignIn;
    }
}