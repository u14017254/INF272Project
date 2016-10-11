namespace PharmPlus
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.mStrip = new System.Windows.Forms.MenuStrip();
            this.menuItem1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.drugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMainMenu = new System.Windows.Forms.DataGridView();
            this.byNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byClientIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // mStrip
            // 
            this.mStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem1ToolStripMenuItem,
            this.drugsToolStripMenuItem});
            this.mStrip.Location = new System.Drawing.Point(0, 0);
            this.mStrip.Name = "mStrip";
            this.mStrip.Size = new System.Drawing.Size(1017, 24);
            this.mStrip.TabIndex = 0;
            this.mStrip.Text = "menuStrip1";
            // 
            // menuItem1ToolStripMenuItem
            // 
            this.menuItem1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.addToolStripMenuItem1,
            this.listAllToolStripMenuItem1});
            this.menuItem1ToolStripMenuItem.Name = "menuItem1ToolStripMenuItem";
            this.menuItem1ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.menuItem1ToolStripMenuItem.Text = "Clients";
            this.menuItem1ToolStripMenuItem.Click += new System.EventHandler(this.menuItem1ToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byNameToolStripMenuItem,
            this.byClientIDToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // listAllToolStripMenuItem1
            // 
            this.listAllToolStripMenuItem1.Name = "listAllToolStripMenuItem1";
            this.listAllToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.listAllToolStripMenuItem1.Text = "List All";
            this.listAllToolStripMenuItem1.Click += new System.EventHandler(this.listAllToolStripMenuItem1_Click);
            // 
            // drugsToolStripMenuItem
            // 
            this.drugsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem1,
            this.addToolStripMenuItem,
            this.listAllToolStripMenuItem});
            this.drugsToolStripMenuItem.Name = "drugsToolStripMenuItem";
            this.drugsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.drugsToolStripMenuItem.Text = "Medication";
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem1.Text = "Search";
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.searchToolStripMenuItem1_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem,
            this.medicationToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // medicationToolStripMenuItem
            // 
            this.medicationToolStripMenuItem.Name = "medicationToolStripMenuItem";
            this.medicationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.medicationToolStripMenuItem.Text = "Medication";
            this.medicationToolStripMenuItem.Click += new System.EventHandler(this.medicationToolStripMenuItem_Click);
            // 
            // listAllToolStripMenuItem
            // 
            this.listAllToolStripMenuItem.Name = "listAllToolStripMenuItem";
            this.listAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listAllToolStripMenuItem.Text = "List All";
            this.listAllToolStripMenuItem.Click += new System.EventHandler(this.listAllToolStripMenuItem_Click);
            // 
            // dgvMainMenu
            // 
            this.dgvMainMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMainMenu.Location = new System.Drawing.Point(0, 24);
            this.dgvMainMenu.Name = "dgvMainMenu";
            this.dgvMainMenu.Size = new System.Drawing.Size(1017, 457);
            this.dgvMainMenu.TabIndex = 1;
            // 
            // byNameToolStripMenuItem
            // 
            this.byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            this.byNameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.byNameToolStripMenuItem.Text = "By Name";
            this.byNameToolStripMenuItem.Click += new System.EventHandler(this.byNameToolStripMenuItem_Click);
            // 
            // byClientIDToolStripMenuItem
            // 
            this.byClientIDToolStripMenuItem.Name = "byClientIDToolStripMenuItem";
            this.byClientIDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.byClientIDToolStripMenuItem.Text = "By Client ID";
            this.byClientIDToolStripMenuItem.Click += new System.EventHandler(this.byClientIDToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 481);
            this.Controls.Add(this.dgvMainMenu);
            this.Controls.Add(this.mStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mStrip;
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mStrip.ResumeLayout(false);
            this.mStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItem1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem drugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAllToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvMainMenu;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byClientIDToolStripMenuItem;
    }
}