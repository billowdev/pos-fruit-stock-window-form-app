
namespace Fruit_Stock
{
    partial class FrmHistoryStockFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistoryStockFilter));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dgvAllHistoryStock = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllHistoryStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "From: ";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.dtpFromDate.CustomFormat = "";
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Location = new System.Drawing.Point(250, 34);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(308, 26);
            this.dtpFromDate.TabIndex = 45;
            // 
            // dgvAllHistoryStock
            // 
            this.dgvAllHistoryStock.AllowUserToAddRows = false;
            this.dgvAllHistoryStock.AllowUserToDeleteRows = false;
            this.dgvAllHistoryStock.AllowUserToResizeColumns = false;
            this.dgvAllHistoryStock.AllowUserToResizeRows = false;
            this.dgvAllHistoryStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(250)))));
            this.dgvAllHistoryStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllHistoryStock.Location = new System.Drawing.Point(12, 82);
            this.dgvAllHistoryStock.MaximumSize = new System.Drawing.Size(1398, 635);
            this.dgvAllHistoryStock.MinimumSize = new System.Drawing.Size(1398, 635);
            this.dgvAllHistoryStock.Name = "dgvAllHistoryStock";
            this.dgvAllHistoryStock.ReadOnly = true;
            this.dgvAllHistoryStock.RowHeadersVisible = false;
            this.dgvAllHistoryStock.RowHeadersWidth = 51;
            this.dgvAllHistoryStock.RowTemplate.Height = 24;
            this.dgvAllHistoryStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllHistoryStock.Size = new System.Drawing.Size(1398, 635);
            this.dgvAllHistoryStock.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(603, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "To:";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.dtpToDate.CustomFormat = "";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Location = new System.Drawing.Point(651, 34);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(308, 26);
            this.dtpToDate.TabIndex = 45;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1185, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(163, 64);
            this.btnPrint.TabIndex = 46;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(999, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(167, 64);
            this.btnLoad.TabIndex = 46;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // FrmHistoryStockFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 721);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.dgvAllHistoryStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 768);
            this.MinimizeBox = false;
            this.Name = "FrmHistoryStockFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHistoryStockReport";
            this.Load += new System.EventHandler(this.FrmHistoryStockReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllHistoryStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DataGridView dgvAllHistoryStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnLoad;
    }
}