
namespace Fruit_Stock
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pbShopkeeper = new System.Windows.Forms.PictureBox();
            this.pbFruitFrontShopkeeper = new System.Windows.Forms.PictureBox();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbShopkeeper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruitFrontShopkeeper)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Mali", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(171, 531);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(133, 53);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Mali", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(325, 531);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 53);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("TH Sarabun New", 16F, System.Drawing.FontStyle.Bold);
            this.txtUsername.Location = new System.Drawing.Point(148, 400);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(321, 43);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "akkarapon";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("TH Sarabun New", 16F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(148, 460);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(321, 43);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "akp1234";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbShopkeeper
            // 
            this.pbShopkeeper.BackColor = System.Drawing.Color.Transparent;
            this.pbShopkeeper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbShopkeeper.BackgroundImage")));
            this.pbShopkeeper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbShopkeeper.Location = new System.Drawing.Point(136, 57);
            this.pbShopkeeper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbShopkeeper.Name = "pbShopkeeper";
            this.pbShopkeeper.Size = new System.Drawing.Size(349, 326);
            this.pbShopkeeper.TabIndex = 6;
            this.pbShopkeeper.TabStop = false;
            // 
            // pbFruitFrontShopkeeper
            // 
            this.pbFruitFrontShopkeeper.BackColor = System.Drawing.Color.Transparent;
            this.pbFruitFrontShopkeeper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFruitFrontShopkeeper.BackgroundImage")));
            this.pbFruitFrontShopkeeper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFruitFrontShopkeeper.Location = new System.Drawing.Point(191, 241);
            this.pbFruitFrontShopkeeper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFruitFrontShopkeeper.Name = "pbFruitFrontShopkeeper";
            this.pbFruitFrontShopkeeper.Size = new System.Drawing.Size(100, 90);
            this.pbFruitFrontShopkeeper.TabIndex = 7;
            this.pbFruitFrontShopkeeper.TabStop = false;
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.cbShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPassword.ForeColor = System.Drawing.Color.White;
            this.cbShowPassword.Location = new System.Drawing.Point(478, 469);
            this.cbShowPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(151, 24);
            this.cbShowPassword.TabIndex = 5;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = false;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.pbFruitFrontShopkeeper);
            this.Controls.Add(this.pbShopkeeper);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fruit Shop Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.pbShopkeeper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruitFrontShopkeeper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pbShopkeeper;
        private System.Windows.Forms.PictureBox pbFruitFrontShopkeeper;
        private System.Windows.Forms.CheckBox cbShowPassword;
    }
}