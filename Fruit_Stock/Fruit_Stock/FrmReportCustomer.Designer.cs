
namespace Fruit_Stock
{
    partial class FrmReportCustomer
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
            this.cryCustomerViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryCustomerViewer
            // 
            this.cryCustomerViewer.ActiveViewIndex = -1;
            this.cryCustomerViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryCustomerViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryCustomerViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryCustomerViewer.Location = new System.Drawing.Point(0, 0);
            this.cryCustomerViewer.Name = "cryCustomerViewer";
            this.cryCustomerViewer.Size = new System.Drawing.Size(1039, 667);
            this.cryCustomerViewer.TabIndex = 0;
            // 
            // FrmReportCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 667);
            this.Controls.Add(this.cryCustomerViewer);
            this.Name = "FrmReportCustomer";
            this.Text = "FrmReportCustomer";
            this.Load += new System.EventHandler(this.FrmReportCustomer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryCustomerViewer;
    }
}