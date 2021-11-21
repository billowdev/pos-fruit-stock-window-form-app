
namespace Fruit_Stock
{
    partial class FrmReportHistoryStock
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
            this.cryReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryReport
            // 
            this.cryReport.ActiveViewIndex = -1;
            this.cryReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryReport.Location = new System.Drawing.Point(0, 0);
            this.cryReport.Name = "cryReport";
            this.cryReport.Size = new System.Drawing.Size(1039, 667);
            this.cryReport.TabIndex = 0;
            // 
            // FrmReportHistoryStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 667);
            this.Controls.Add(this.cryReport);
            this.Name = "FrmReportHistoryStock";
            this.Text = "FrmReportHistoryStock";
            this.Load += new System.EventHandler(this.FrmReportHistoryStock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryReport;
    }
}