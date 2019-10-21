namespace BloodBankManaementSystemCSharp
{
    partial class HomeD
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
            this.addDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBloodDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDonorToolStripMenuItem,
            this.addBloodDonorToolStripMenuItem,
            this.addStockToolStripMenuItem,
            this.viewDoctorToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(817, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addDonorToolStripMenuItem
            // 
            this.addDonorToolStripMenuItem.Name = "addDonorToolStripMenuItem";
            this.addDonorToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.addDonorToolStripMenuItem.Text = "Add Donor";
            this.addDonorToolStripMenuItem.Click += new System.EventHandler(this.addDonorToolStripMenuItem_Click);
            // 
            // addBloodDonorToolStripMenuItem
            // 
            this.addBloodDonorToolStripMenuItem.Name = "addBloodDonorToolStripMenuItem";
            this.addBloodDonorToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.addBloodDonorToolStripMenuItem.Text = "Add Blood Donor";
            this.addBloodDonorToolStripMenuItem.Click += new System.EventHandler(this.addBloodDonorToolStripMenuItem_Click);
            // 
            // addStockToolStripMenuItem
            // 
            this.addStockToolStripMenuItem.Name = "addStockToolStripMenuItem";
            this.addStockToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.addStockToolStripMenuItem.Text = "Add Stock";
            this.addStockToolStripMenuItem.Click += new System.EventHandler(this.addStockToolStripMenuItem_Click);
            // 
            // viewDoctorToolStripMenuItem
            // 
            this.viewDoctorToolStripMenuItem.Name = "viewDoctorToolStripMenuItem";
            this.viewDoctorToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.viewDoctorToolStripMenuItem.Text = "View Doctor";
            this.viewDoctorToolStripMenuItem.Click += new System.EventHandler(this.viewDoctorToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // HomeD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 514);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeD";
            this.Text = "HomeD";
            this.Load += new System.EventHandler(this.HomeD_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBloodDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}