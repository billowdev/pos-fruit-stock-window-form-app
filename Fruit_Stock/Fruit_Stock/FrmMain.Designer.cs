
namespace Fruit_Stock
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mnuFrmMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHistoryInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnHistoryInvoice = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.mnuFrmMain.SuspendLayout();
            this.gbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuFrmMain
            // 
            this.mnuFrmMain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnuFrmMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuFrmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuProfile,
            this.mnuInvoice,
            this.mnuHistoryInvoice,
            this.mnuStock,
            this.mnuHelp});
            this.mnuFrmMain.Location = new System.Drawing.Point(0, 0);
            this.mnuFrmMain.Name = "mnuFrmMain";
            this.mnuFrmMain.Size = new System.Drawing.Size(1924, 36);
            this.mnuFrmMain.TabIndex = 1;
            this.mnuFrmMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHome,
            this.mnuLogout,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(56, 32);
            this.mnuFile.Text = "File";
            // 
            // mnuHome
            // 
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(166, 32);
            this.mnuHome.Text = "Home";
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(166, 32);
            this.mnuLogout.Text = "Log out";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(166, 32);
            this.mnuExit.Text = "Exit";
            // 
            // mnuProfile
            // 
            this.mnuProfile.Name = "mnuProfile";
            this.mnuProfile.Size = new System.Drawing.Size(82, 32);
            this.mnuProfile.Text = "Profile";
            this.mnuProfile.Click += new System.EventHandler(this.mnuProfile_Click);
            // 
            // mnuInvoice
            // 
            this.mnuInvoice.Name = "mnuInvoice";
            this.mnuInvoice.Size = new System.Drawing.Size(88, 32);
            this.mnuInvoice.Text = "Invoice";
            this.mnuInvoice.Click += new System.EventHandler(this.mnuInvoice_Click);
            // 
            // mnuHistoryInvoice
            // 
            this.mnuHistoryInvoice.Name = "mnuHistoryInvoice";
            this.mnuHistoryInvoice.Size = new System.Drawing.Size(156, 32);
            this.mnuHistoryInvoice.Text = "History Invoice";
            this.mnuHistoryInvoice.Click += new System.EventHandler(this.mnuHistoryInvoice_Click);
            // 
            // mnuStock
            // 
            this.mnuStock.Name = "mnuStock";
            this.mnuStock.Size = new System.Drawing.Size(74, 32);
            this.mnuStock.Text = "Stock";
            this.mnuStock.Click += new System.EventHandler(this.mnuStock_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(67, 32);
            this.mnuHelp.Text = "Help";
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.btnExit);
            this.gbMenu.Controls.Add(this.btnStock);
            this.gbMenu.Controls.Add(this.btnProfile);
            this.gbMenu.Controls.Add(this.btnInvoice);
            this.gbMenu.Controls.Add(this.btnHistoryInvoice);
            this.gbMenu.Controls.Add(this.btnHelp);
            this.gbMenu.Location = new System.Drawing.Point(0, 30);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(1920, 1001);
            this.gbMenu.TabIndex = 10;
            this.gbMenu.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Mali", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1668, 824);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 64);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.Transparent;
            this.btnStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStock.BackgroundImage")));
            this.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.Location = new System.Drawing.Point(154, 407);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(272, 285);
            this.btnStock.TabIndex = 8;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProfile.BackgroundImage")));
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Location = new System.Drawing.Point(475, 94);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(272, 285);
            this.btnProfile.TabIndex = 8;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.Transparent;
            this.btnInvoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInvoice.BackgroundImage")));
            this.btnInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvoice.Location = new System.Drawing.Point(154, 94);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(272, 285);
            this.btnInvoice.TabIndex = 8;
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnHistoryInvoice
            // 
            this.btnHistoryInvoice.BackColor = System.Drawing.Color.Transparent;
            this.btnHistoryInvoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHistoryInvoice.BackgroundImage")));
            this.btnHistoryInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistoryInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistoryInvoice.Location = new System.Drawing.Point(475, 407);
            this.btnHistoryInvoice.Name = "btnHistoryInvoice";
            this.btnHistoryInvoice.Size = new System.Drawing.Size(272, 285);
            this.btnHistoryInvoice.TabIndex = 8;
            this.btnHistoryInvoice.UseVisualStyleBackColor = false;
            this.btnHistoryInvoice.Click += new System.EventHandler(this.btnHistoryInvoice_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.ForeColor = System.Drawing.Color.Transparent;
            this.btnHelp.Location = new System.Drawing.Point(798, 247);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(272, 285);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.mnuFrmMain);
            this.Controls.Add(this.gbMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuFrmMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1980, 1080);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuFrmMain.ResumeLayout(false);
            this.mnuFrmMain.PerformLayout();
            this.gbMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFrmMain;
        private System.Windows.Forms.ToolStripMenuItem mnuProfile;
        private System.Windows.Forms.ToolStripMenuItem mnuInvoice;
        private System.Windows.Forms.ToolStripMenuItem mnuHistoryInvoice;
        private System.Windows.Forms.ToolStripMenuItem mnuStock;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnHistoryInvoice;
        private System.Windows.Forms.Button btnHelp;
    }
}