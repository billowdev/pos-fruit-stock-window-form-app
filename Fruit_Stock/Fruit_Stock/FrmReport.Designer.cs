﻿
namespace Fruit_Stock
{
    partial class FrmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReport));
            this.cryViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryViewer
            // 
            this.cryViewer.ActiveViewIndex = -1;
            this.cryViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryViewer.Location = new System.Drawing.Point(0, 0);
            this.cryViewer.Name = "cryViewer";
            this.cryViewer.Size = new System.Drawing.Size(1039, 667);
            this.cryViewer.TabIndex = 1;
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 667);
            this.Controls.Add(this.cryViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReport";
            this.Text = "FrmReportEmployee";
            this.Load += new System.EventHandler(this.FrmReportEmployee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryViewer;
    }
}