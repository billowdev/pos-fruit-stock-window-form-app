using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fruit_Stock.static_classes;

namespace Fruit_Stock
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                Check_login();
            }
            else
            {
                MessageBox.Show("กรุณากรอกรหัส", "Msg",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Check_login()
        {
            // login
            if ((string.IsNullOrEmpty(this.txtUsername.Text.Trim())) ||
                 (string.IsNullOrEmpty(this.txtPassword.Text.Trim())))
            {
                MessageBox.Show("Enter your username and password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (this.txtUsername.CanSelect)
                {
                    this.txtUsername.Select();
                }
                return;
            }

            AC.sql = "SELECT * FROM tb_login WHERE Username = @us AND Password = @pa";

            AC.cmd.Parameters.Clear();
            AC.cmd.CommandType = CommandType.Text;
            AC.cmd.CommandText = AC.sql;

            AC.cmd.Parameters.AddWithValue("@us", this.txtUsername.Text.Trim().ToString());
            AC.cmd.Parameters.AddWithValue("@pa", this.txtPassword.Text.Trim().ToString());

            AC.openConnection();

            AC.rd = AC.cmd.ExecuteReader();

            if (AC.rd.HasRows)
            {
                while (AC.rd.Read())
                {
                    AC.currentUsername = AC.rd[1].ToString();
                    AC.currentStatus = AC.rd[3].ToString();

                    //MessageBox.Show("Welcome  " + AC.currentUsername + "\n Your Status is ... " + AC.currentStatus, "\n Login Successed :)",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    FrmMain frm = new FrmMain();
                    frm.Show();

                }
                this.txtPassword.Text = string.Empty;
                this.txtUsername.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("ผิดพลาด", "Invalid Username or Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (this.txtUsername.CanSelect)
                {
                    this.txtUsername.Select();
                }

                this.txtPassword.Text = string.Empty;
                this.txtUsername.Text = string.Empty;
                //MessageBox.Show(AC.currentUsername);

            }

            AC.rd.Close();
            AC.closeConnection();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == true)
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }
    }
}
