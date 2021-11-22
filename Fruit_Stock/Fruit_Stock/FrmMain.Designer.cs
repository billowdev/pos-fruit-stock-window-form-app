
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
            this.mnuSale = new System.Windows.Forms.ToolStripMenuItem();
            this.cmuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHistoryStock = new System.Windows.Forms.ToolStripMenuItem();
            this.cmuHistoryOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExitProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsName = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsPageStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timTime = new System.Windows.Forms.Timer(this.components);
            this.lbWelcome = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.cmuFTSale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFrmMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuFrmMain
            // 
            this.mnuFrmMain.AutoSize = false;
            this.mnuFrmMain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnuFrmMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuFrmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSale,
            this.cmuCustomer,
            this.mnuStock,
            this.mnuProduct,
            this.mnuHistoryStock,
            this.cmuHistoryOrder,
            this.mnuProfile,
            this.mnuHelp,
            this.mnuExitProgram,
            this.cmuFTSale});
            this.mnuFrmMain.Location = new System.Drawing.Point(0, 0);
            this.mnuFrmMain.Name = "mnuFrmMain";
            this.mnuFrmMain.Size = new System.Drawing.Size(1920, 58);
            this.mnuFrmMain.TabIndex = 1;
            this.mnuFrmMain.Text = "menuStrip1";
            // 
            // mnuSale
            // 
            this.mnuSale.AutoSize = false;
            this.mnuSale.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnuSale.Image = ((System.Drawing.Image)(resources.GetObject("mnuSale.Image")));
            this.mnuSale.Name = "mnuSale";
            this.mnuSale.Size = new System.Drawing.Size(100, 54);
            this.mnuSale.Text = "Order";
            this.mnuSale.Click += new System.EventHandler(this.mnuSale_Click);
            // 
            // cmuCustomer
            // 
            this.cmuCustomer.Image = ((System.Drawing.Image)(resources.GetObject("cmuCustomer.Image")));
            this.cmuCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmuCustomer.Name = "cmuCustomer";
            this.cmuCustomer.Size = new System.Drawing.Size(130, 54);
            this.cmuCustomer.Text = "Customer";
            this.cmuCustomer.Click += new System.EventHandler(this.cmuCustomer_Click);
            // 
            // mnuStock
            // 
            this.mnuStock.AutoSize = false;
            this.mnuStock.Image = ((System.Drawing.Image)(resources.GetObject("mnuStock.Image")));
            this.mnuStock.Name = "mnuStock";
            this.mnuStock.Size = new System.Drawing.Size(100, 54);
            this.mnuStock.Text = "Stock";
            this.mnuStock.Click += new System.EventHandler(this.mnuStock_Click);
            // 
            // mnuProduct
            // 
            this.mnuProduct.AutoSize = false;
            this.mnuProduct.Image = ((System.Drawing.Image)(resources.GetObject("mnuProduct.Image")));
            this.mnuProduct.Name = "mnuProduct";
            this.mnuProduct.Size = new System.Drawing.Size(140, 54);
            this.mnuProduct.Text = "Product";
            this.mnuProduct.Click += new System.EventHandler(this.mnuProduct_Click);
            // 
            // mnuHistoryStock
            // 
            this.mnuHistoryStock.AutoSize = false;
            this.mnuHistoryStock.Image = ((System.Drawing.Image)(resources.GetObject("mnuHistoryStock.Image")));
            this.mnuHistoryStock.Name = "mnuHistoryStock";
            this.mnuHistoryStock.Size = new System.Drawing.Size(180, 54);
            this.mnuHistoryStock.Text = "History Stock";
            this.mnuHistoryStock.Click += new System.EventHandler(this.mnuHistoryStock_Click);
            // 
            // cmuHistoryOrder
            // 
            this.cmuHistoryOrder.Image = ((System.Drawing.Image)(resources.GetObject("cmuHistoryOrder.Image")));
            this.cmuHistoryOrder.Name = "cmuHistoryOrder";
            this.cmuHistoryOrder.Size = new System.Drawing.Size(165, 54);
            this.cmuHistoryOrder.Text = "History Order";
            this.cmuHistoryOrder.Click += new System.EventHandler(this.cmuHistoryOrder_Click);
            // 
            // mnuProfile
            // 
            this.mnuProfile.Image = ((System.Drawing.Image)(resources.GetObject("mnuProfile.Image")));
            this.mnuProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuProfile.Name = "mnuProfile";
            this.mnuProfile.Size = new System.Drawing.Size(132, 54);
            this.mnuProfile.Text = "Employee";
            this.mnuProfile.Click += new System.EventHandler(this.mnuProfile_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Image = ((System.Drawing.Image)(resources.GetObject("mnuHelp.Image")));
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(87, 54);
            this.mnuHelp.Text = "Help";
            this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
            // 
            // mnuExitProgram
            // 
            this.mnuExitProgram.AutoSize = false;
            this.mnuExitProgram.Image = ((System.Drawing.Image)(resources.GetObject("mnuExitProgram.Image")));
            this.mnuExitProgram.Name = "mnuExitProgram";
            this.mnuExitProgram.Size = new System.Drawing.Size(80, 54);
            this.mnuExitProgram.Text = "Exit";
            this.mnuExitProgram.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stsTime,
            this.stsName,
            this.stsPageStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 992);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1920, 37);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(300, 31);
            this.toolStripStatusLabel1.Text = "โปรแกรมสต๊อกสินค้า ร้านผลไม้";
            // 
            // stsTime
            // 
            this.stsTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.stsTime.Name = "stsTime";
            this.stsTime.Size = new System.Drawing.Size(56, 31);
            this.stsTime.Text = "Time";
            // 
            // stsName
            // 
            this.stsName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.stsName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.stsName.Name = "stsName";
            this.stsName.Size = new System.Drawing.Size(210, 31);
            this.stsName.Text = "Name + Lastname";
            // 
            // stsPageStatus
            // 
            this.stsPageStatus.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.stsPageStatus.Name = "stsPageStatus";
            this.stsPageStatus.Size = new System.Drawing.Size(69, 31);
            this.stsPageStatus.Text = "Main";
            this.stsPageStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timTime
            // 
            this.timTime.Enabled = true;
            this.timTime.Tick += new System.EventHandler(this.timTime_Tick);
            // 
            // lbWelcome
            // 
            this.lbWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbWelcome.Font = new System.Drawing.Font("Mali", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.White;
            this.lbWelcome.Image = ((System.Drawing.Image)(resources.GetObject("lbWelcome.Image")));
            this.lbWelcome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbWelcome.Location = new System.Drawing.Point(533, 168);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(895, 607);
            this.lbWelcome.TabIndex = 9;
            this.lbWelcome.Text = "Welcome";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            // cmuFTSale
            // 
            this.cmuFTSale.Name = "cmuFTSale";
            this.cmuFTSale.Size = new System.Drawing.Size(96, 54);
            this.cmuFTSale.Text = "FrmSale";
            this.cmuFTSale.Click += new System.EventHandler(this.cmuFTSale_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1029);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuFrmMain);
            this.Controls.Add(this.pbMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuFrmMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1980, 1080);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mnuFrmMain.ResumeLayout(false);
            this.mnuFrmMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFrmMain;
        private System.Windows.Forms.ToolStripMenuItem mnuProfile;
        private System.Windows.Forms.ToolStripMenuItem mnuStock;
        private System.Windows.Forms.ToolStripMenuItem mnuSale;
        private System.Windows.Forms.ToolStripMenuItem mnuProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel stsTime;
        private System.Windows.Forms.Timer timTime;
        private System.Windows.Forms.ToolStripStatusLabel stsName;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.ToolStripMenuItem mnuHistoryStock;
        private System.Windows.Forms.ToolStripMenuItem cmuCustomer;
        private System.Windows.Forms.ToolStripStatusLabel stsPageStatus;
        private System.Windows.Forms.ToolStripMenuItem cmuHistoryOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuExitProgram;
        private System.Windows.Forms.ToolStripMenuItem cmuFTSale;
    }
}