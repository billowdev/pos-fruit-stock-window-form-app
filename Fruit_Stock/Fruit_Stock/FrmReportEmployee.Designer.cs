﻿
namespace Fruit_Stock
{
    partial class FrmReportEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportEmployee));
            this.cryReportEmployee = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryReportEmployee
            // 
            this.cryReportEmployee.ActiveViewIndex = -1;
            this.cryReportEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryReportEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryReportEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryReportEmployee.Location = new System.Drawing.Point(0, 0);
            this.cryReportEmployee.Name = "cryReportEmployee";
            this.cryReportEmployee.Size = new System.Drawing.Size(1039, 667);
            this.cryReportEmployee.TabIndex = 1;
            // 
            // FrmReportEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 667);
            this.Controls.Add(this.cryReportEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportEmployee";
            this.Text = "FrmReportEmployee";
            this.Load += new System.EventHandler(this.FrmReportEmployee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryReportEmployee;
    }
}