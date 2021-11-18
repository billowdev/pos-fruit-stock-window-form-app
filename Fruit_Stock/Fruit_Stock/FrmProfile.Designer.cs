
namespace Fruit_Stock
{
    partial class FrmProfile
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
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbEMPID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtEMPID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.dgvAllMember = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbOperating = new System.Windows.Forms.GroupBox();
            this.lbUserStatus = new System.Windows.Forms.Label();
            this.cmuMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMember)).BeginInit();
            this.gbOperating.SuspendLayout();
            this.cmuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(168, 288);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(233, 30);
            this.txtStatus.TabIndex = 1;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(87, 288);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(66, 25);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "สถานะ";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(46, 335);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(110, 25);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(168, 333);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(346, 30);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(168, 372);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(346, 30);
            this.txtPassword.TabIndex = 1;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(50, 372);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(106, 25);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password";
            // 
            // lbEMPID
            // 
            this.lbEMPID.AutoSize = true;
            this.lbEMPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEMPID.Location = new System.Drawing.Point(112, 31);
            this.lbEMPID.Name = "lbEMPID";
            this.lbEMPID.Size = new System.Drawing.Size(44, 25);
            this.lbEMPID.TabIndex = 2;
            this.lbEMPID.Text = "ไอดี";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(121, 74);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(34, 25);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "ชื่อ";
            // 
            // txtEMPID
            // 
            this.txtEMPID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.txtEMPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMPID.Location = new System.Drawing.Point(173, 34);
            this.txtEMPID.Name = "txtEMPID";
            this.txtEMPID.Size = new System.Drawing.Size(233, 30);
            this.txtEMPID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(173, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(346, 30);
            this.txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(173, 114);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(346, 30);
            this.txtLastName.TabIndex = 1;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.Location = new System.Drawing.Point(81, 111);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(78, 25);
            this.lbLastName.TabIndex = 2;
            this.lbLastName.Text = "นามสกุล";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(113, 160);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(43, 25);
            this.lbGender.TabIndex = 2;
            this.lbGender.Text = "เพศ";
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthDate.Location = new System.Drawing.Point(45, 207);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(118, 25);
            this.lbBirthDate.TabIndex = 2;
            this.lbBirthDate.Text = "วันเดือนปีเกิด";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(46, 248);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(117, 25);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "เบอร์โทรศัพท์";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.Location = new System.Drawing.Point(173, 210);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(308, 30);
            this.dtpBirthDate.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(173, 246);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(264, 30);
            this.txtPhone.TabIndex = 1;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.rdbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMale.Location = new System.Drawing.Point(173, 163);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(62, 29);
            this.rdbMale.TabIndex = 4;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "ชาย";
            this.rdbMale.UseVisualStyleBackColor = false;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.rdbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemale.Location = new System.Drawing.Point(273, 163);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(66, 29);
            this.rdbFemale.TabIndex = 4;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "หญิง";
            this.rdbFemale.UseVisualStyleBackColor = false;
            // 
            // dgvAllMember
            // 
            this.dgvAllMember.AllowUserToAddRows = false;
            this.dgvAllMember.AllowUserToDeleteRows = false;
            this.dgvAllMember.AllowUserToResizeColumns = false;
            this.dgvAllMember.AllowUserToResizeRows = false;
            this.dgvAllMember.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.dgvAllMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllMember.Location = new System.Drawing.Point(10, 9);
            this.dgvAllMember.Name = "dgvAllMember";
            this.dgvAllMember.ReadOnly = true;
            this.dgvAllMember.RowHeadersWidth = 51;
            this.dgvAllMember.RowTemplate.Height = 24;
            this.dgvAllMember.Size = new System.Drawing.Size(682, 514);
            this.dgvAllMember.TabIndex = 7;
            this.dgvAllMember.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAllMember_CellMouseUp);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(250)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(161, 422);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(81, 39);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "เพิ่ม";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(250)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(248, 422);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 39);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "แก้ไข";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(250)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(421, 422);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 39);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "ลบ";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(250)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(333, 422);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 39);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbOperating
            // 
            this.gbOperating.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOperating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.gbOperating.Controls.Add(this.lbUserStatus);
            this.gbOperating.Controls.Add(this.txtStatus);
            this.gbOperating.Controls.Add(this.lbUsername);
            this.gbOperating.Controls.Add(this.lbPassword);
            this.gbOperating.Controls.Add(this.txtUsername);
            this.gbOperating.Controls.Add(this.lbStatus);
            this.gbOperating.Controls.Add(this.txtPassword);
            this.gbOperating.Controls.Add(this.btnSave);
            this.gbOperating.Controls.Add(this.btnDelete);
            this.gbOperating.Controls.Add(this.btnEdit);
            this.gbOperating.Controls.Add(this.btnNew);
            this.gbOperating.Controls.Add(this.lbEMPID);
            this.gbOperating.Controls.Add(this.lbName);
            this.gbOperating.Controls.Add(this.lbLastName);
            this.gbOperating.Controls.Add(this.lbPhone);
            this.gbOperating.Controls.Add(this.rdbFemale);
            this.gbOperating.Controls.Add(this.lbGender);
            this.gbOperating.Controls.Add(this.txtPhone);
            this.gbOperating.Controls.Add(this.rdbMale);
            this.gbOperating.Controls.Add(this.dtpBirthDate);
            this.gbOperating.Controls.Add(this.lbBirthDate);
            this.gbOperating.Controls.Add(this.txtLastName);
            this.gbOperating.Controls.Add(this.txtName);
            this.gbOperating.Controls.Add(this.txtEMPID);
            this.gbOperating.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperating.Location = new System.Drawing.Point(698, 9);
            this.gbOperating.Name = "gbOperating";
            this.gbOperating.Size = new System.Drawing.Size(684, 514);
            this.gbOperating.TabIndex = 9;
            this.gbOperating.TabStop = false;
            // 
            // lbUserStatus
            // 
            this.lbUserStatus.AutoSize = true;
            this.lbUserStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserStatus.Location = new System.Drawing.Point(168, 288);
            this.lbUserStatus.Name = "lbUserStatus";
            this.lbUserStatus.Size = new System.Drawing.Size(109, 25);
            this.lbUserStatus.TabIndex = 0;
            this.lbUserStatus.Text = "labelStatus";
            // 
            // cmuMenu
            // 
            this.cmuMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuNew,
            this.mnuEdit,
            this.mnuDelete});
            this.cmuMenu.Name = "cmuMenu";
            this.cmuMenu.Size = new System.Drawing.Size(129, 124);
            // 
            // mnuBack
            // 
            this.mnuBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(128, 30);
            this.mnuBack.Text = "Back";
            // 
            // mnuNew
            // 
            this.mnuNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(128, 30);
            this.mnuNew.Text = "เพิ่ม";
            // 
            // mnuEdit
            // 
            this.mnuEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(128, 30);
            this.mnuEdit.Text = "แก้ไข";
            // 
            // mnuDelete
            // 
            this.mnuDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(128, 30);
            this.mnuDelete.Text = "ลบ";
            // 
            // FrmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(231)))), ((int)(((byte)(244)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1422, 653);
            this.Controls.Add(this.dgvAllMember);
            this.Controls.Add(this.gbOperating);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1440, 700);
            this.Name = "FrmProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Profile";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMember)).EndInit();
            this.gbOperating.ResumeLayout(false);
            this.gbOperating.PerformLayout();
            this.cmuMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbEMPID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtEMPID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.DataGridView dgvAllMember;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbOperating;
        private System.Windows.Forms.Label lbUserStatus;
        private System.Windows.Forms.ContextMenuStrip cmuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
    }
}