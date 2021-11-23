
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
            this.lbPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btnCal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbCUSID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbCash = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCUSNAME = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1031, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 43);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCheckBill
            // 
            this.btnCheckBill.Location = new System.Drawing.Point(819, 704);
            this.btnCheckBill.Name = "btnCheckBill";
            this.btnCheckBill.Size = new System.Drawing.Size(323, 63);
            this.btnCheckBill.TabIndex = 3;
            this.btnCheckBill.Text = "Check Bill";
            this.btnCheckBill.UseVisualStyleBackColor = true;
            this.btnCheckBill.Click += new System.EventHandler(this.btnCheckBill_Click);
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(383, 551);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(335, 34);
            this.txtCash.TabIndex = 1;
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbChange
            // 
            this.lbChange.BackColor = System.Drawing.Color.White;
            this.lbChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChange.Location = new System.Drawing.Point(819, 638);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(323, 39);
            this.lbChange.TabIndex = 7;
            this.lbChange.Text = "Change";
            this.lbChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPrice
            // 
            this.lbPrice.BackColor = System.Drawing.Color.White;
            this.lbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(383, 487);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(335, 39);
            this.lbPrice.TabIndex = 8;
            this.lbPrice.Text = "Price Bill";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(756, 638);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Change";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cash";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 611);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(383, 606);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(335, 34);
            this.txtDiscount.TabIndex = 2;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(773, 538);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total";
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.Color.White;
            this.lbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(819, 527);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(323, 39);
            this.lbTotal.TabIndex = 8;
            this.lbTotal.Text = "Total";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(12, 57);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(1152, 400);
            this.dgvOrder.TabIndex = 15;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(402, 669);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(301, 64);
            this.btnCal.TabIndex = 16;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "สรุปรายการสั่งซื้อ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(231, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 31);
            this.label9.TabIndex = 17;
            this.label9.Text = "รหัสลูกค้า: ";
            // 
            // lbCUSID
            // 
            this.lbCUSID.AutoSize = true;
            this.lbCUSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCUSID.Location = new System.Drawing.Point(378, 12);
            this.lbCUSID.Name = "lbCUSID";
            this.lbCUSID.Size = new System.Drawing.Size(148, 29);
            this.lbCUSID.TabIndex = 17;
            this.lbCUSID.Text = "CUSXXXXX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(756, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Discount";
            // 
            // lbDiscount
            // 
            this.lbDiscount.BackColor = System.Drawing.Color.White;
            this.lbDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.Location = new System.Drawing.Point(819, 472);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(323, 39);
            this.lbDiscount.TabIndex = 7;
            this.lbDiscount.Text = "0";
            this.lbDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(756, 585);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cash";
            // 
            // lbCash
            // 
            this.lbCash.BackColor = System.Drawing.Color.White;
            this.lbCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCash.Location = new System.Drawing.Point(819, 585);
            this.lbCash.Name = "lbCash";
            this.lbCash.Size = new System.Drawing.Size(323, 39);
            this.lbCash.TabIndex = 7;
            this.lbCash.Text = "Cash";
            this.lbCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(607, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "ชื่อ: ";
            // 
            // lbCUSNAME
            // 
            this.lbCUSNAME.AutoSize = true;
            this.lbCUSNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCUSNAME.Location = new System.Drawing.Point(694, 12);
            this.lbCUSNAME.Name = "lbCUSNAME";
            this.lbCUSNAME.Size = new System.Drawing.Size(98, 29);
            this.lbCUSNAME.TabIndex = 17;
            this.lbCUSNAME.Text = "XXXXX";
            // 
            // FrmCheckBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1176, 800);
            this.ControlBox = false;
            this.Controls.Add(this.lbCUSNAME);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbCUSID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCheckBill);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbCash);
            this.Controls.Add(this.lbChange);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbCUSID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbCash;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCUSNAME;
    }
}