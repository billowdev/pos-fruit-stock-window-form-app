
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
            this.mnuSale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFrmMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuFrmMain
            // 
            this.mnuFrmMain.AutoSize = false;
            this.mnuFrmMain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnuFrmMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuFrmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSale,
            this.mnuProfile,
            this.mnuInvoice,
            this.mnuStock,
            this.mnuHelp});
            this.mnuFrmMain.Location = new System.Drawing.Point(0, 0);
            this.mnuFrmMain.Name = "mnuFrmMain";
            this.mnuFrmMain.Size = new System.Drawing.Size(1924, 61);
            this.mnuFrmMain.TabIndex = 1;
            this.mnuFrmMain.Text = "menuStrip1";
            // 
            // mnuSale
            // 
            this.mnuSale.Name = "mnuSale";
            this.mnuSale.Size = new System.Drawing.Size(62, 57);
            this.mnuSale.Text = "Sale";
            // 
            // mnuProfile
            // 
            this.mnuProfile.Image = ((System.Drawing.Image)(resources.GetObject("mnuProfile.Image")));
            this.mnuProfile.Name = "mnuProfile";
            this.mnuProfile.Size = new System.Drawing.Size(102, 57);
            this.mnuProfile.Text = "Profile";
            this.mnuProfile.Click += new System.EventHandler(this.mnuProfile_Click);
            // 
            // mnuInvoice
            // 
            this.mnuInvoice.Image = ((System.Drawing.Image)(resources.GetObject("mnuInvoice.Image")));
            this.mnuInvoice.Name = "mnuInvoice";
            this.mnuInvoice.Size = new System.Drawing.Size(108, 57);
            this.mnuInvoice.Text = "Invoice";
            // 
            // mnuStock
            // 
            this.mnuStock.Image = ((System.Drawing.Image)(resources.GetObject("mnuStock.Image")));
            this.mnuStock.Name = "mnuStock";
            this.mnuStock.Size = new System.Drawing.Size(94, 57);
            this.mnuStock.Text = "Stock";
            // 
            // mnuHelp
            // 
            this.mnuHelp.Image = ((System.Drawing.Image)(resources.GetObject("mnuHelp.Image")));
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(87, 57);
            this.mnuHelp.Text = "Help";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.mnuFrmMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuFrmMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1980, 1080);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuFrmMain.ResumeLayout(false);
            this.mnuFrmMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFrmMain;
        private System.Windows.Forms.ToolStripMenuItem mnuProfile;
        private System.Windows.Forms.ToolStripMenuItem mnuInvoice;
        private System.Windows.Forms.ToolStripMenuItem mnuSale;
        private System.Windows.Forms.ToolStripMenuItem mnuStock;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
    }
}