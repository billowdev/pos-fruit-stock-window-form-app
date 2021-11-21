
namespace Fruit_Stock
{
    partial class FrmCheckBill
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCheckBill = new System.Windows.Forms.Button();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.lbChange = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cryReportBill = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(724, 620);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 60);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCheckBill
            // 
            this.btnCheckBill.Location = new System.Drawing.Point(580, 620);
            this.btnCheckBill.Name = "btnCheckBill";
            this.btnCheckBill.Size = new System.Drawing.Size(112, 60);
            this.btnCheckBill.TabIndex = 11;
            this.btnCheckBill.Text = "Check Bill";
            this.btnCheckBill.UseVisualStyleBackColor = true;
            this.btnCheckBill.Click += new System.EventHandler(this.btnCheckBill_Click);
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(560, 541);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(335, 34);
            this.txtCash.TabIndex = 9;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txtCash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCash_KeyDown);
            // 
            // lbChange
            // 
            this.lbChange.BackColor = System.Drawing.Color.White;
            this.lbChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChange.Location = new System.Drawing.Point(560, 578);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(335, 39);
            this.lbChange.TabIndex = 7;
            this.lbChange.Text = "Cost Bill";
            this.lbChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.Color.White;
            this.lbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(560, 499);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(335, 39);
            this.lbTotal.TabIndex = 8;
            this.lbTotal.Text = "Cost Bill";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Change";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cash";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cost Bill";
            // 
            // cryReportBill
            // 
            this.cryReportBill.ActiveViewIndex = -1;
            this.cryReportBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryReportBill.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryReportBill.Location = new System.Drawing.Point(1, 2);
            this.cryReportBill.Name = "cryReportBill";
            this.cryReportBill.Size = new System.Drawing.Size(894, 473);
            this.cryReportBill.TabIndex = 12;
            // 
            // FrmCheckBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(926, 707);
            this.ControlBox = false;
            this.Controls.Add(this.cryReportBill);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCheckBill);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.lbChange);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCheckBill";
            this.Text = "FrmCheckBill";
            this.Load += new System.EventHandler(this.FrmCheckBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCheckBill;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryReportBill;
    }
}