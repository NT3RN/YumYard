namespace YumYard.Customer
{
    partial class ResturantPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResturantPicker));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msiHome = new System.Windows.Forms.ToolStripMenuItem();
            this.msiProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiHome,
            this.msiProfile,
            this.msiAboutUs});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msiHome
            // 
            this.msiHome.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msiHome.Name = "msiHome";
            this.msiHome.Size = new System.Drawing.Size(56, 20);
            this.msiHome.Text = "Home";
            // 
            // msiProfile
            // 
            this.msiProfile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msiProfile.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.msiProfile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.msiProfile.Name = "msiProfile";
            this.msiProfile.Size = new System.Drawing.Size(59, 20);
            this.msiProfile.Text = "Profile";
            this.msiProfile.Click += new System.EventHandler(this.msiProfile_Click);
            // 
            // msiAboutUs
            // 
            this.msiAboutUs.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.msiAboutUs.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F);
            this.msiAboutUs.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.msiAboutUs.Name = "msiAboutUs";
            this.msiAboutUs.Size = new System.Drawing.Size(76, 20);
            this.msiAboutUs.Text = "About us";
            // 
            // ResturantPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1056, 594);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ResturantPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resturants";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msiHome;
        private System.Windows.Forms.ToolStripMenuItem msiProfile;
        private System.Windows.Forms.ToolStripMenuItem msiAboutUs;
    }
}