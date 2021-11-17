
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mnuFrmMain = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lbUsernameStatus = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timTime = new System.Windows.Forms.Timer(this.components);
            this.mnuFrmMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuFrmMain
            // 
            this.mnuFrmMain.AutoSize = false;
            this.mnuFrmMain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnuFrmMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuFrmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.mnuSale,
            this.mnuProfile,
            this.mnuInvoice,
            this.mnuStock,
            this.mnuHelp});
            this.mnuFrmMain.Location = new System.Drawing.Point(0, 0);
            this.mnuFrmMain.Name = "mnuFrmMain";
            this.mnuFrmMain.Size = new System.Drawing.Size(1920, 61);
            this.mnuFrmMain.TabIndex = 1;
            this.mnuFrmMain.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(56, 57);
            this.logOutToolStripMenuItem.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(129, 32);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuSale
            // 
            this.mnuSale.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnuSale.Name = "mnuSale";
            this.mnuSale.Size = new System.Drawing.Size(62, 57);
            this.mnuSale.Text = "Sale";
            this.mnuSale.Click += new System.EventHandler(this.mnuSale_Click);
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
            this.mnuInvoice.Click += new System.EventHandler(this.mnuInvoice_Click);
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
            this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
            // 
            // lbUsernameStatus
            // 
            this.lbUsernameStatus.BackColor = System.Drawing.Color.White;
            this.lbUsernameStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbUsernameStatus.Font = new System.Drawing.Font("Mali", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsernameStatus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbUsernameStatus.Image = ((System.Drawing.Image)(resources.GetObject("lbUsernameStatus.Image")));
            this.lbUsernameStatus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbUsernameStatus.Location = new System.Drawing.Point(519, 181);
            this.lbUsernameStatus.Name = "lbUsernameStatus";
            this.lbUsernameStatus.Size = new System.Drawing.Size(785, 594);
            this.lbUsernameStatus.TabIndex = 4;
            this.lbUsernameStatus.Text = "Username&Status";
            this.lbUsernameStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pbMain
            // 
            this.pbMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMain.BackgroundImage")));
            this.pbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMain.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMain.InitialImage")));
            this.pbMain.Location = new System.Drawing.Point(0, 53);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(1925, 1024);
            this.pbMain.TabIndex = 3;
            this.pbMain.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stsTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 977);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1920, 52);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(300, 46);
            this.toolStripStatusLabel1.Text = "โปรแกรมสต๊อกสินค้า ร้านผลไม้";
            // 
            // stsTime
            // 
            this.stsTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.stsTime.Name = "stsTime";
            this.stsTime.Size = new System.Drawing.Size(56, 46);
            this.stsTime.Text = "Time";
            // 
            // timTime
            // 
            this.timTime.Enabled = true;
            this.timTime.Tick += new System.EventHandler(this.timTime_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1029);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbUsernameStatus);
            this.Controls.Add(this.mnuFrmMain);
            this.Controls.Add(this.pbMain);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mnuFrmMain.ResumeLayout(false);
            this.mnuFrmMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFrmMain;
        private System.Windows.Forms.ToolStripMenuItem mnuProfile;
        private System.Windows.Forms.ToolStripMenuItem mnuInvoice;
        private System.Windows.Forms.ToolStripMenuItem mnuSale;
        private System.Windows.Forms.ToolStripMenuItem mnuStock;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Label lbUsernameStatus;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel stsTime;
        private System.Windows.Forms.Timer timTime;
    }
}