
namespace Fruit_Stock
{
    partial class FrmMain
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
            this.mnsTest = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsTest
            // 
            this.mnsTest.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.mnsTest.Location = new System.Drawing.Point(0, 0);
            this.mnsTest.Name = "mnsTest";
            this.mnsTest.Size = new System.Drawing.Size(1348, 28);
            this.mnsTest.TabIndex = 1;
            this.mnsTest.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.mnsTest);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsTest;
            this.MaximumSize = new System.Drawing.Size(1980, 1080);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "FrmMain";
            this.Text = "Fruit Stock";
            this.mnsTest.ResumeLayout(false);
            this.mnsTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsTest;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}

