
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
            this.btnExit = new System.Windows.Forms.Button();
            this.pbInvoice = new System.Windows.Forms.PictureBox();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.pbStock = new System.Windows.Forms.PictureBox();
            this.pbHistoryInvoice = new System.Windows.Forms.PictureBox();
            this.pbHelp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistoryInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Mali", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1203, 637);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 64);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbInvoice
            // 
            this.pbInvoice.BackColor = System.Drawing.Color.Transparent;
            this.pbInvoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbInvoice.BackgroundImage")));
            this.pbInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbInvoice.Location = new System.Drawing.Point(229, 82);
            this.pbInvoice.Name = "pbInvoice";
            this.pbInvoice.Size = new System.Drawing.Size(251, 254);
            this.pbInvoice.TabIndex = 6;
            this.pbInvoice.TabStop = false;
            // 
            // pbProfile
            // 
            this.pbProfile.BackColor = System.Drawing.Color.Transparent;
            this.pbProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbProfile.BackgroundImage")));
            this.pbProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbProfile.Location = new System.Drawing.Point(600, 82);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(251, 254);
            this.pbProfile.TabIndex = 6;
            this.pbProfile.TabStop = false;
            // 
            // pbStock
            // 
            this.pbStock.BackColor = System.Drawing.Color.Transparent;
            this.pbStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbStock.BackgroundImage")));
            this.pbStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbStock.Location = new System.Drawing.Point(229, 395);
            this.pbStock.Name = "pbStock";
            this.pbStock.Size = new System.Drawing.Size(251, 254);
            this.pbStock.TabIndex = 6;
            this.pbStock.TabStop = false;
            // 
            // pbHistoryInvoice
            // 
            this.pbHistoryInvoice.BackColor = System.Drawing.Color.Transparent;
            this.pbHistoryInvoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHistoryInvoice.BackgroundImage")));
            this.pbHistoryInvoice.Location = new System.Drawing.Point(600, 395);
            this.pbHistoryInvoice.Name = "pbHistoryInvoice";
            this.pbHistoryInvoice.Size = new System.Drawing.Size(251, 254);
            this.pbHistoryInvoice.TabIndex = 6;
            this.pbHistoryInvoice.TabStop = false;
            // 
            // pbHelp
            // 
            this.pbHelp.BackColor = System.Drawing.Color.Transparent;
            this.pbHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHelp.BackgroundImage")));
            this.pbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHelp.Location = new System.Drawing.Point(988, 264);
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.Size = new System.Drawing.Size(171, 169);
            this.pbHelp.TabIndex = 6;
            this.pbHelp.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.pbHistoryInvoice);
            this.Controls.Add(this.pbHelp);
            this.Controls.Add(this.pbProfile);
            this.Controls.Add(this.pbStock);
            this.Controls.Add(this.pbInvoice);
            this.Controls.Add(this.btnExit);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1980, 1080);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "FrmMain";
            this.Text = "Fruit Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHistoryInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbInvoice;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.PictureBox pbStock;
        private System.Windows.Forms.PictureBox pbHistoryInvoice;
        private System.Windows.Forms.PictureBox pbHelp;
    }
}

