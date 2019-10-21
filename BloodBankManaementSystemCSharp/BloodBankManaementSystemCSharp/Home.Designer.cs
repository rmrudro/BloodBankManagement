namespace BloodBankManaementSystemCSharp
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCampToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDonorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDoctorToolStripMenuItem,
            this.addCampToolStripMenuItem,
            this.addDonorDetailsToolStripMenuItem,
            this.viewDoctorToolStripMenuItem,
            this.viewDonorToolStripMenuItem,
            this.viewStockToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1032, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addDoctorToolStripMenuItem
            // 
            this.addDoctorToolStripMenuItem.Name = "addDoctorToolStripMenuItem";
            this.addDoctorToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.addDoctorToolStripMenuItem.Text = "Add Doctor";
            this.addDoctorToolStripMenuItem.Click += new System.EventHandler(this.addDoctorToolStripMenuItem_Click);
            // 
            // addCampToolStripMenuItem
            // 
            this.addCampToolStripMenuItem.Name = "addCampToolStripMenuItem";
            this.addCampToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.addCampToolStripMenuItem.Text = "Add Camp";
            this.addCampToolStripMenuItem.Click += new System.EventHandler(this.addCampToolStripMenuItem_Click);
            // 
            // addDonorDetailsToolStripMenuItem
            // 
            this.addDonorDetailsToolStripMenuItem.Name = "addDonorDetailsToolStripMenuItem";
            this.addDonorDetailsToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.addDonorDetailsToolStripMenuItem.Text = "Add Donor Details";
            this.addDonorDetailsToolStripMenuItem.Click += new System.EventHandler(this.addDonorDetailsToolStripMenuItem_Click);
            // 
            // viewDoctorToolStripMenuItem
            // 
            this.viewDoctorToolStripMenuItem.Name = "viewDoctorToolStripMenuItem";
            this.viewDoctorToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.viewDoctorToolStripMenuItem.Text = "View Doctor";
            this.viewDoctorToolStripMenuItem.Click += new System.EventHandler(this.viewDoctorToolStripMenuItem_Click);
            // 
            // viewDonorToolStripMenuItem
            // 
            this.viewDonorToolStripMenuItem.Name = "viewDonorToolStripMenuItem";
            this.viewDonorToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.viewDonorToolStripMenuItem.Text = "View Donor";
            this.viewDonorToolStripMenuItem.Click += new System.EventHandler(this.viewDonorToolStripMenuItem_Click);
            // 
            // viewStockToolStripMenuItem
            // 
            this.viewStockToolStripMenuItem.Name = "viewStockToolStripMenuItem";
            this.viewStockToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.viewStockToolStripMenuItem.Text = "View Stock";
            this.viewStockToolStripMenuItem.Click += new System.EventHandler(this.viewStockToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 511);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCampToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDonorDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}