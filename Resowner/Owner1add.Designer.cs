namespace YumYard.Resowner
{
    partial class Owner1add
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnmenurefresh = new System.Windows.Forms.Button();
            this.btnmenuupdate = new System.Windows.Forms.Button();
            this.btnmenudelete = new System.Windows.Forms.Button();
            this.btnmenuadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnmenurefresh);
            this.panel1.Controls.Add(this.btnmenuupdate);
            this.panel1.Controls.Add(this.btnmenudelete);
            this.panel1.Controls.Add(this.btnmenuadd);
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 574);
            this.panel1.TabIndex = 0;
            // 
            // btnmenurefresh
            // 
            this.btnmenurefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenurefresh.Location = new System.Drawing.Point(37, 321);
            this.btnmenurefresh.Name = "btnmenurefresh";
            this.btnmenurefresh.Size = new System.Drawing.Size(123, 43);
            this.btnmenurefresh.TabIndex = 7;
            this.btnmenurefresh.Text = "Refresh ";
            this.btnmenurefresh.UseVisualStyleBackColor = true;
            // 
            // btnmenuupdate
            // 
            this.btnmenuupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenuupdate.Location = new System.Drawing.Point(37, 245);
            this.btnmenuupdate.Name = "btnmenuupdate";
            this.btnmenuupdate.Size = new System.Drawing.Size(123, 43);
            this.btnmenuupdate.TabIndex = 6;
            this.btnmenuupdate.Text = "Update";
            this.btnmenuupdate.UseVisualStyleBackColor = true;
            // 
            // btnmenudelete
            // 
            this.btnmenudelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenudelete.Location = new System.Drawing.Point(37, 161);
            this.btnmenudelete.Name = "btnmenudelete";
            this.btnmenudelete.Size = new System.Drawing.Size(123, 43);
            this.btnmenudelete.TabIndex = 5;
            this.btnmenudelete.Text = "Delete";
            this.btnmenudelete.UseVisualStyleBackColor = true;
            // 
            // btnmenuadd
            // 
            this.btnmenuadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenuadd.Location = new System.Drawing.Point(37, 84);
            this.btnmenuadd.Name = "btnmenuadd";
            this.btnmenuadd.Size = new System.Drawing.Size(123, 43);
            this.btnmenuadd.TabIndex = 4;
            this.btnmenuadd.Text = "Add ";
            this.btnmenuadd.UseVisualStyleBackColor = true;
            this.btnmenuadd.Click += new System.EventHandler(this.btnmenuadd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(250, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(783, 266);
            this.dataGridView1.TabIndex = 1;
            // 
            // Owner1add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 594);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Owner1add";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnmenurefresh;
        private System.Windows.Forms.Button btnmenuupdate;
        private System.Windows.Forms.Button btnmenudelete;
        private System.Windows.Forms.Button btnmenuadd;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}