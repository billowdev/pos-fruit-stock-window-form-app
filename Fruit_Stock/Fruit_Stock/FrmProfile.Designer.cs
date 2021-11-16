﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfile));
            this.mnuProfile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvAllMember = new System.Windows.Forms.DataGridView();
            this.lbAllData = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbOperating = new System.Windows.Forms.GroupBox();
            this.lbUserStatus = new System.Windows.Forms.Label();
            this.tbloginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new Fruit_Stock.AppData();
            this.tb_loginTableAdapter = new Fruit_Stock.AppDataTableAdapters.tb_loginTableAdapter();
            this.mnuProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMember)).BeginInit();
            this.gbOperating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbloginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuProfile
            // 
            this.mnuProfile.BackColor = System.Drawing.Color.Transparent;
            this.mnuProfile.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuProfile.Font = new System.Drawing.Font("Mali", 12F);
            this.mnuProfile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.historyInvoiceToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuProfile.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mnuProfile.Location = new System.Drawing.Point(0, 0);
            this.mnuProfile.Name = "mnuProfile";
            this.mnuProfile.Size = new System.Drawing.Size(188, 1018);
            this.mnuProfile.TabIndex = 0;
            this.mnuProfile.Text = "menuStrip1";
            this.mnuProfile.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exportProfileToolStripMenuItem,
            this.homePageToolStripMenuItem,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(175, 46);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(245, 46);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exportProfileToolStripMenuItem
            // 
            this.exportProfileToolStripMenuItem.Name = "exportProfileToolStripMenuItem";
            this.exportProfileToolStripMenuItem.Size = new System.Drawing.Size(245, 46);
            this.exportProfileToolStripMenuItem.Text = "Export Profile";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(245, 46);
            this.homePageToolStripMenuItem.Text = "Home Page";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(245, 46);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(175, 46);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            this.invoiceToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // historyInvoiceToolStripMenuItem
            // 
            this.historyInvoiceToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.historyInvoiceToolStripMenuItem.Name = "historyInvoiceToolStripMenuItem";
            this.historyInvoiceToolStripMenuItem.Size = new System.Drawing.Size(175, 46);
            this.historyInvoiceToolStripMenuItem.Text = "History Invoice";
            this.historyInvoiceToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(175, 46);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(175, 46);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtStatus.Location = new System.Drawing.Point(153, 54);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(233, 35);
            this.txtStatus.TabIndex = 1;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(56, 54);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(84, 29);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "สถานะ";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(11, 108);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(133, 29);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(153, 103);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(346, 35);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(153, 158);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(346, 35);
            this.txtPassword.TabIndex = 1;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(11, 158);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(128, 29);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password";
            // 
            // lbEMPID
            // 
            this.lbEMPID.AutoSize = true;
            this.lbEMPID.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEMPID.Location = new System.Drawing.Point(80, 212);
            this.lbEMPID.Name = "lbEMPID";
            this.lbEMPID.Size = new System.Drawing.Size(58, 29);
            this.lbEMPID.TabIndex = 2;
            this.lbEMPID.Text = "ไอดี";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(92, 270);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(46, 29);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "ชื่อ";
            // 
            // txtEMPID
            // 
            this.txtEMPID.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEMPID.Location = new System.Drawing.Point(153, 212);
            this.txtEMPID.Name = "txtEMPID";
            this.txtEMPID.Size = new System.Drawing.Size(233, 35);
            this.txtEMPID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(153, 267);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(346, 35);
            this.txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(152, 331);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(346, 35);
            this.txtLastName.TabIndex = 1;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.Location = new System.Drawing.Point(44, 331);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(104, 29);
            this.lbLastName.TabIndex = 2;
            this.lbLastName.Text = "นามสกุล";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(79, 391);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(57, 29);
            this.lbGender.TabIndex = 2;
            this.lbGender.Text = "เพศ";
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthDate.Location = new System.Drawing.Point(29, 456);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(155, 29);
            this.lbBirthDate.TabIndex = 2;
            this.lbBirthDate.Text = "วันเดือนปีเกิด";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(26, 517);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(160, 29);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "เบอร์โทรศัพท์";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.Location = new System.Drawing.Point(190, 456);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(308, 35);
            this.dtpBirthDate.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(190, 512);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(264, 35);
            this.txtPhone.TabIndex = 1;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMale.Location = new System.Drawing.Point(200, 389);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(81, 33);
            this.rdbMale.TabIndex = 4;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "ชาย";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemale.Location = new System.Drawing.Point(351, 387);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(87, 33);
            this.rdbFemale.TabIndex = 4;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "หญิง";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // pbProfile
            // 
            this.pbProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbProfile.BackgroundImage")));
            this.pbProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbProfile.Location = new System.Drawing.Point(219, 5);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(152, 165);
            this.pbProfile.TabIndex = 6;
            this.pbProfile.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.Location = new System.Drawing.Point(30, 594);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 98);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvAllMember
            // 
            this.dgvAllMember.AllowUserToAddRows = false;
            this.dgvAllMember.AllowUserToDeleteRows = false;
            this.dgvAllMember.AllowUserToResizeColumns = false;
            this.dgvAllMember.AllowUserToResizeRows = false;
            this.dgvAllMember.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvAllMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllMember.Location = new System.Drawing.Point(219, 183);
            this.dgvAllMember.Name = "dgvAllMember";
            this.dgvAllMember.ReadOnly = true;
            this.dgvAllMember.RowHeadersWidth = 51;
            this.dgvAllMember.RowTemplate.Height = 24;
            this.dgvAllMember.Size = new System.Drawing.Size(520, 499);
            this.dgvAllMember.TabIndex = 7;
            this.dgvAllMember.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAllMember_CellMouseUp);
            // 
            // lbAllData
            // 
            this.lbAllData.AutoSize = true;
            this.lbAllData.BackColor = System.Drawing.Color.White;
            this.lbAllData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllData.Location = new System.Drawing.Point(409, 92);
            this.lbAllData.Name = "lbAllData";
            this.lbAllData.Size = new System.Drawing.Size(274, 39);
            this.lbAllData.TabIndex = 2;
            this.lbAllData.Text = "ข้อมูลสมาชิกทั้งหมด";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(176, 581);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(102, 39);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "เพิ่ม";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(308, 581);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 39);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "แก้ไข";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(439, 581);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 39);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(571, 581);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 39);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // gbOperating
            // 
            this.gbOperating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbOperating.Controls.Add(this.lbUserStatus);
            this.gbOperating.Controls.Add(this.btnSave);
            this.gbOperating.Controls.Add(this.btnCancel);
            this.gbOperating.Controls.Add(this.txtStatus);
            this.gbOperating.Controls.Add(this.btnEdit);
            this.gbOperating.Controls.Add(this.lbUsername);
            this.gbOperating.Controls.Add(this.btnNew);
            this.gbOperating.Controls.Add(this.lbPassword);
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
            this.gbOperating.Controls.Add(this.txtUsername);
            this.gbOperating.Controls.Add(this.lbStatus);
            this.gbOperating.Controls.Add(this.txtLastName);
            this.gbOperating.Controls.Add(this.txtPassword);
            this.gbOperating.Controls.Add(this.txtName);
            this.gbOperating.Controls.Add(this.txtEMPID);
            this.gbOperating.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperating.Location = new System.Drawing.Point(760, 81);
            this.gbOperating.Name = "gbOperating";
            this.gbOperating.Size = new System.Drawing.Size(713, 649);
            this.gbOperating.TabIndex = 9;
            this.gbOperating.TabStop = false;
            this.gbOperating.Text = "การดำเนินการ";
            // 
            // lbUserStatus
            // 
            this.lbUserStatus.AutoSize = true;
            this.lbUserStatus.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserStatus.Location = new System.Drawing.Point(157, 54);
            this.lbUserStatus.Name = "lbUserStatus";
            this.lbUserStatus.Size = new System.Drawing.Size(146, 29);
            this.lbUserStatus.TabIndex = 0;
            this.lbUserStatus.Text = "labelStatus";
            // 
            // tbloginBindingSource
            // 
            this.tbloginBindingSource.DataMember = "tb_login";
            this.tbloginBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_loginTableAdapter
            // 
            this.tb_loginTableAdapter.ClearBeforeFill = true;
            // 
            // FrmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1521, 1018);
            this.Controls.Add(this.pbProfile);
            this.Controls.Add(this.dgvAllMember);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbAllData);
            this.Controls.Add(this.mnuProfile);
            this.Controls.Add(this.gbOperating);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnuProfile;
            this.MaximumSize = new System.Drawing.Size(1980, 1080);
            this.MinimumSize = new System.Drawing.Size(1440, 1018);
            this.Name = "FrmProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProfile_Load);
            this.mnuProfile.ResumeLayout(false);
            this.mnuProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllMember)).EndInit();
            this.gbOperating.ResumeLayout(false);
            this.gbOperating.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbloginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuProfile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.DataGridView dgvAllMember;
        private System.Windows.Forms.Label lbAllData;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbOperating;
        private AppData appData;
        private System.Windows.Forms.BindingSource tbloginBindingSource;
        private AppDataTableAdapters.tb_loginTableAdapter tb_loginTableAdapter;
        private System.Windows.Forms.Label lbUserStatus;
    }
}