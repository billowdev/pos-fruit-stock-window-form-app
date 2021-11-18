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
        oCenter ocn = new oCenter();
        private void btnExit_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("ออกจากโปรแกรมใช่หรือไม่", "Msg",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                    Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Enter Username", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Enter Password", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            Check_login();
        }

        private void Check_login()
        {

            ocn.sql = "SELECT * FROM tb_login WHERE Username = @us AND Password = @pa";

            oCenter.cmd.Parameters.Clear();
            oCenter.cmd.CommandType = CommandType.Text;
            oCenter.cmd.CommandText = ocn.sql;

            oCenter.cmd.Parameters.AddWithValue("@us", this.txtUsername.Text.Trim().ToString());
            oCenter.cmd.Parameters.AddWithValue("@pa", this.txtPassword.Text.Trim().ToString());

            oCenter.pusvOpenConnection();

            oCenter.rd = oCenter.cmd.ExecuteReader();

            if (oCenter.rd.HasRows)
            {
                while (oCenter.rd.Read())
                {
                    oCenter.currentUsername = oCenter.rd[0].ToString();
                    oCenter.currentStatus = oCenter.rd[2].ToString();

                    //MessageBox.Show("Welcome  " + oCenter.currentUsername + "\n Your Status is ... " + oCenter.currentStatus, "\n Login Successed :)",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.txtPassword.Text = string.Empty;
                this.txtUsername.Text = string.Empty;
                FrmMain Frm = new FrmMain();
                Frm.Show();
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

                //this.txtPassword.Text = string.Empty;
                //this.txtUsername.Text = string.Empty;
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
