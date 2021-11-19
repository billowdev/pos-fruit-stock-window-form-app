
namespace Fruit_Stock
{
    partial class FrmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStock));
            this.txtProQuantity = new System.Windows.Forms.TextBox();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtProUnit = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.lbBarcode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProduct = new System.Windows.Forms.Button();
            this.dgvAllStock = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpProImport = new System.Windows.Forms.DateTimePicker();
            this.txtProIMID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bdsPage = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProQuantity
            // 
            this.txtProQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProQuantity.Location = new System.Drawing.Point(135, 184);
            this.txtProQuantity.Name = "txtProQuantity";
            this.txtProQuantity.Size = new System.Drawing.Size(301, 30);
            this.txtProQuantity.TabIndex = 2;
            this.txtProQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProID
            // 
            this.txtProID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.txtProID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProID.Location = new System.Drawing.Point(134, 23);
            this.txtProID.Name = "txtProID";
            this.txtProID.ReadOnly = true;
            this.txtProID.Size = new System.Drawing.Size(207, 30);
            this.txtProID.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(478, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 33);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProUnit
            // 
            this.txtProUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.txtProUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProUnit.Location = new System.Drawing.Point(135, 112);
            this.txtProUnit.Name = "txtProUnit";
            this.txtProUnit.ReadOnly = true;
            this.txtProUnit.Size = new System.Drawing.Size(244, 30);
            this.txtProUnit.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(472, 174);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 45);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtProName
            // 
            this.txtProName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.txtProName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProName.Location = new System.Drawing.Point(135, 66);
            this.txtProName.Name = "txtProName";
            this.txtProName.ReadOnly = true;
            this.txtProName.Size = new System.Drawing.Size(360, 30);
            this.txtProName.TabIndex = 2;
            // 
            // lbBarcode
            // 
            this.lbBarcode.AutoSize = true;
            this.lbBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarcode.Location = new System.Drawing.Point(16, 229);
            this.lbBarcode.Name = "lbBarcode";
            this.lbBarcode.Size = new System.Drawing.Size(112, 25);
            this.lbBarcode.TabIndex = 1;
            this.lbBarcode.Text = "Import Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Unit";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(11, 16);
            this.txtSearch.MinimumSize = new System.Drawing.Size(275, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(459, 34);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Location = new System.Drawing.Point(119, 516);
            this.groupBox2.MaximumSize = new System.Drawing.Size(680, 71);
            this.groupBox2.MinimumSize = new System.Drawing.Size(680, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 71);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product ID";
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(356, 18);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(99, 34);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // dgvAllStock
            // 
            this.dgvAllStock.AllowUserToAddRows = false;
            this.dgvAllStock.AllowUserToDeleteRows = false;
            this.dgvAllStock.AllowUserToResizeColumns = false;
            this.dgvAllStock.AllowUserToResizeRows = false;
            this.dgvAllStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(250)))));
            this.dgvAllStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllStock.Location = new System.Drawing.Point(119, 318);
            this.dgvAllStock.MaximumSize = new System.Drawing.Size(971, 230);
            this.dgvAllStock.MinimumSize = new System.Drawing.Size(687, 192);
            this.dgvAllStock.Name = "dgvAllStock";
            this.dgvAllStock.RowHeadersVisible = false;
            this.dgvAllStock.RowHeadersWidth = 51;
            this.dgvAllStock.RowTemplate.Height = 24;
            this.dgvAllStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllStock.Size = new System.Drawing.Size(687, 192);
            this.dgvAllStock.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.groupBox1.Controls.Add(this.dtpProImport);
            this.groupBox1.Controls.Add(this.txtProIMID);
            this.groupBox1.Controls.Add(this.txtProQuantity);
            this.groupBox1.Controls.Add(this.txtProUnit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtProName);
            this.groupBox1.Controls.Add(this.txtProID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbBarcode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnProduct);
            this.groupBox1.Location = new System.Drawing.Point(119, 12);
            this.groupBox1.MaximumSize = new System.Drawing.Size(687, 300);
            this.groupBox1.MinimumSize = new System.Drawing.Size(687, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 300);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // dtpProImport
            // 
            this.dtpProImport.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.dtpProImport.CustomFormat = "dd.MM.yyyy";
            this.dtpProImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpProImport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpProImport.Location = new System.Drawing.Point(134, 229);
            this.dtpProImport.Name = "dtpProImport";
            this.dtpProImport.Size = new System.Drawing.Size(308, 30);
            this.dtpProImport.TabIndex = 43;
            // 
            // txtProIMID
            // 
            this.txtProIMID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProIMID.Location = new System.Drawing.Point(135, 148);
            this.txtProIMID.Name = "txtProIMID";
            this.txtProIMID.Size = new System.Drawing.Size(228, 30);
            this.txtProIMID.TabIndex = 2;
            this.txtProIMID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Import ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Qty";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(812, 14);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(257, 242);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(257, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 242);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(573, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 33);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvAllStock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1980, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "FrmStock";
            this.Text = "FrmStock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStock_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProQuantity;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtProUnit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.Label lbBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.DataGridView dgvAllStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bdsPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtProIMID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpProImport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRefresh;
    }
}