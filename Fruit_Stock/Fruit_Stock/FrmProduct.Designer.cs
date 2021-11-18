
namespace Fruit_Stock
{
    partial class FrmProduct
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
            this.bdsPage = new System.Windows.Forms.BindingSource(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmuMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbPageNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbStockQuantity = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPage)).BeginInit();
            this.cmuMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(131, 666);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(336, 30);
            this.txtSearch.TabIndex = 13;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(1116, 668);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(70, 33);
            this.btnLast.TabIndex = 9;
            this.btnLast.Text = ">l";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1040, 668);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(70, 33);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(683, 667);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(70, 33);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(607, 665);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(70, 33);
            this.btnFirst.TabIndex = 7;
            this.btnFirst.Text = "l<";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(487, 659);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 45);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmuDelete
            // 
            this.cmuDelete.Name = "cmuDelete";
            this.cmuDelete.Size = new System.Drawing.Size(122, 24);
            this.cmuDelete.Text = "Delete";
            // 
            // cmuMenu
            // 
            this.cmuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmuDelete});
            this.cmuMenu.Name = "cmuC";
            this.cmuMenu.Size = new System.Drawing.Size(123, 28);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.ContextMenuStrip = this.cmuMenu;
            this.dgvData.Location = new System.Drawing.Point(12, 349);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1174, 304);
            this.dgvData.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(646, 225);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 45);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lbPageNum
            // 
            this.lbPageNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbPageNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPageNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPageNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPageNum.Location = new System.Drawing.Point(759, 668);
            this.lbPageNum.Name = "lbPageNum";
            this.lbPageNum.Size = new System.Drawing.Size(275, 32);
            this.lbPageNum.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "หน่วย";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อสินค้า";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 671);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Search";
            // 
            // txtProName
            // 
            this.txtProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProName.Location = new System.Drawing.Point(247, 91);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(360, 34);
            this.txtProName.TabIndex = 2;
            // 
            // txtProID
            // 
            this.txtProID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProID.Location = new System.Drawing.Point(247, 45);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(207, 34);
            this.txtProID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "รหัสสินค้า";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbUnit);
            this.groupBox1.Controls.Add(this.txtProPrice);
            this.groupBox1.Controls.Add(this.txtProName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbStockQuantity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtProID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1173, 333);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "ราคา";
            // 
            // txtProPrice
            // 
            this.txtProPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProPrice.Location = new System.Drawing.Point(247, 146);
            this.txtProPrice.Name = "txtProPrice";
            this.txtProPrice.Size = new System.Drawing.Size(219, 34);
            this.txtProPrice.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "จำนวนคงเหลือ";
            // 
            // lbStockQuantity
            // 
            this.lbStockQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbStockQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStockQuantity.Location = new System.Drawing.Point(242, 245);
            this.lbStockQuantity.Name = "lbStockQuantity";
            this.lbStockQuantity.Size = new System.Drawing.Size(236, 25);
            this.lbStockQuantity.TabIndex = 1;
            this.lbStockQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbUnit
            // 
            this.cmbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(247, 192);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(231, 37);
            this.cmbUnit.TabIndex = 4;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.ControlBox = false;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lbPageNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1980, 1080);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "FrmProduct";
            this.Text = "Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bdsPage)).EndInit();
            this.cmuMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsPage;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem cmuDelete;
        private System.Windows.Forms.ContextMenuStrip cmuMenu;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbPageNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbStockQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbUnit;
    }
}