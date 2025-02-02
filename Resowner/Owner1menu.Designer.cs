namespace YumYard.Resowner
{
    partial class Owner1menu
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
            this.Menupanel = new System.Windows.Forms.Panel();
            this.btnmenurefresh = new System.Windows.Forms.Button();
            this.btnmenuupdate = new System.Windows.Forms.Button();
            this.btnmenudelete = new System.Windows.Forms.Button();
            this.btnmenuadd = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.Menupanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // Menupanel
            // 
            this.Menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Menupanel.Controls.Add(this.btnmenurefresh);
            this.Menupanel.Controls.Add(this.btnmenuupdate);
            this.Menupanel.Controls.Add(this.btnmenudelete);
            this.Menupanel.Controls.Add(this.btnmenuadd);
            this.Menupanel.Location = new System.Drawing.Point(6, 11);
            this.Menupanel.Name = "Menupanel";
            this.Menupanel.Size = new System.Drawing.Size(213, 574);
            this.Menupanel.TabIndex = 0;
            // 
            // btnmenurefresh
            // 
            this.btnmenurefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenurefresh.Location = new System.Drawing.Point(34, 314);
            this.btnmenurefresh.Name = "btnmenurefresh";
            this.btnmenurefresh.Size = new System.Drawing.Size(132, 43);
            this.btnmenurefresh.TabIndex = 3;
            this.btnmenurefresh.Text = "Refresh ";
            this.btnmenurefresh.UseVisualStyleBackColor = true;
            // 
            // btnmenuupdate
            // 
            this.btnmenuupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenuupdate.Location = new System.Drawing.Point(34, 238);
            this.btnmenuupdate.Name = "btnmenuupdate";
            this.btnmenuupdate.Size = new System.Drawing.Size(132, 43);
            this.btnmenuupdate.TabIndex = 2;
            this.btnmenuupdate.Text = "Update";
            this.btnmenuupdate.UseVisualStyleBackColor = true;
            // 
            // btnmenudelete
            // 
            this.btnmenudelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenudelete.Location = new System.Drawing.Point(34, 154);
            this.btnmenudelete.Name = "btnmenudelete";
            this.btnmenudelete.Size = new System.Drawing.Size(132, 43);
            this.btnmenudelete.TabIndex = 1;
            this.btnmenudelete.Text = "Delete";
            this.btnmenudelete.UseVisualStyleBackColor = true;
            // 
            // btnmenuadd
            // 
            this.btnmenuadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenuadd.Location = new System.Drawing.Point(34, 77);
            this.btnmenuadd.Name = "btnmenuadd";
            this.btnmenuadd.Size = new System.Drawing.Size(132, 43);
            this.btnmenuadd.TabIndex = 0;
            this.btnmenuadd.Text = "Add ";
            this.btnmenuadd.UseVisualStyleBackColor = true;
            this.btnmenuadd.Click += new System.EventHandler(this.btnmenuadd_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(240, 12);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(804, 570);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // Owner1menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 594);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.Menupanel);
            this.Name = "Owner1menu";
            this.Text = "Owner1menu";
            this.Menupanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menupanel;
        private System.Windows.Forms.Button btnmenurefresh;
        private System.Windows.Forms.Button btnmenuupdate;
        private System.Windows.Forms.Button btnmenudelete;
        private System.Windows.Forms.Button btnmenuadd;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}