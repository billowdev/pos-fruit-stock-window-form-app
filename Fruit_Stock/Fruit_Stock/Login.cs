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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("ออกจากโปรแกรมใช่หรือไม่", "Msg",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                try
                {
                    Application.Exit();
                }
                catch { }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
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

            oCenter.sql = "SELECT * FROM tb_login WHERE Username = @us AND Password = @pa";

            oCenter.cmd.Parameters.Clear();
            oCenter.cmd.CommandType = CommandType.Text;
            oCenter.cmd.CommandText = oCenter.sql;

            oCenter.cmd.Parameters.AddWithValue("@us", this.txtUsername.Text.Trim().ToString());
            oCenter.cmd.Parameters.AddWithValue("@pa", this.txtPassword.Text.Trim().ToString());

            oCenter.pusvOpenConnection();

            oCenter.rd = oCenter.cmd.ExecuteReader();

            if (oCenter.rd.HasRows)
            {
                while (oCenter.rd.Read())
                {
                    oCenter.currentUsername = oCenter.rd[1].ToString();
                    oCenter.currentStatus = oCenter.rd[3].ToString();

                    //MessageBox.Show("Welcome  " + oCenter.currentUsername + "\n Your Status is ... " + oCenter.currentStatus, "\n Login Successed :)",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.txtPassword.Text = string.Empty;
                this.txtUsername.Text = string.Empty;
                this.Hide();
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
                //MessageBox.Show(oCenter.currentUsername);

            }

            oCenter.rd.Close();
            oCenter.pusvCloseConnection();
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
