
namespace Fruit_Stock
{
    partial class FrmOrderHistory
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
            this.dgvAllOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllOrder
            // 
            this.dgvAllOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllOrder.Location = new System.Drawing.Point(319, 154);
            this.dgvAllOrder.Name = "dgvAllOrder";
            this.dgvAllOrder.RowHeadersWidth = 51;
            this.dgvAllOrder.RowTemplate.Height = 24;
            this.dgvAllOrder.Size = new System.Drawing.Size(240, 150);
            this.dgvAllOrder.TabIndex = 0;
            // 
            // FrmOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 606);
            this.Controls.Add(this.dgvAllOrder);
            this.Name = "FrmOrderHistory";
            this.Text = "FrmOrderHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllOrder;
    }
}