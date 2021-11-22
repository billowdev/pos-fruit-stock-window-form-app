
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTotalAfter = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(961, 689);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 41);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCheckBill
            // 
            this.btnCheckBill.Location = new System.Drawing.Point(817, 689);
            this.btnCheckBill.Name = "btnCheckBill";
            this.btnCheckBill.Size = new System.Drawing.Size(112, 41);
            this.btnCheckBill.TabIndex = 3;
            this.btnCheckBill.Text = "Check Bill";
            this.btnCheckBill.UseVisualStyleBackColor = true;
            this.btnCheckBill.Click += new System.EventHandler(this.btnCheckBill_Click);
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(788, 511);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(335, 34);
            this.txtCash.TabIndex = 1;
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            // 
            // lbChange
            // 
            this.lbChange.BackColor = System.Drawing.Color.White;
            this.lbChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChange.Location = new System.Drawing.Point(788, 623);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(335, 39);
            this.lbChange.TabIndex = 7;
            this.lbChange.Text = "Change";
            this.lbChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.Color.White;
            this.lbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(352, 511);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(335, 39);
            this.lbTotal.TabIndex = 8;
            this.lbTotal.Text = "Price Bill";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(725, 638);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Change";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(742, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cash";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(719, 568);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(788, 563);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(335, 34);
            this.txtDiscount.TabIndex = 2;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 568);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Discount";
            // 
            // lbDiscount
            // 
            this.lbDiscount.BackColor = System.Drawing.Color.White;
            this.lbDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.Location = new System.Drawing.Point(352, 563);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(335, 39);
            this.lbDiscount.TabIndex = 8;
            this.lbDiscount.Text = "Discount";
            this.lbDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 621);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total";
            // 
            // lbTotalAfter
            // 
            this.lbTotalAfter.BackColor = System.Drawing.Color.White;
            this.lbTotalAfter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotalAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAfter.Location = new System.Drawing.Point(352, 616);
            this.lbTotalAfter.Name = "lbTotalAfter";
            this.lbTotalAfter.Size = new System.Drawing.Size(335, 39);
            this.lbTotalAfter.TabIndex = 8;
            this.lbTotalAfter.Text = "Total";
            this.lbTotalAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(12, 12);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(1130, 473);
            this.dgvOrder.TabIndex = 15;
            // 
            // FrmCheckBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1176, 753);
            this.ControlBox = false;
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCheckBill);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.lbChange);
            this.Controls.Add(this.lbTotalAfter);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCheckBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCheckBill";
            this.Load += new System.EventHandler(this.FrmCheckBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTotalAfter;
        private System.Windows.Forms.DataGridView dgvOrder;
    }
}