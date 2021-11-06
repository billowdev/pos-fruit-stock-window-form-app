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
            //Fruit_Stock.static_classes.Db_connect.openConnection();
            

            //MessageBox.Show("Connection is " + Fruit_Stock.static_classes.Db_connect.conn.State.ToString(),
            //    "Test Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Fruit_Stock.static_classes.Db_connect.closeConnection();

            //MessageBox.Show("Connection is " + Fruit_Stock.static_classes.Db_connect.conn.State.ToString(),
            //    "Test Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

  

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // login
            if ( ( string.IsNullOrEmpty(this.txtUsername.Text.Trim() )) ||  
                 ( string.IsNullOrEmpty(this.txtPassword.Text.Trim() )) )
            {
                MessageBox.Show("Enter your username and password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (this.txtUsername.CanSelect)
                {
                    this.txtUsername.Select();
                }
                return;
            }
            
            Db_connect.sql = "SELECT * FROM tb_login WHERE Username = @us AND Password = @pa";

            Db_connect.cmd.Parameters.Clear();
            Db_connect.cmd.CommandType = CommandType.Text;
            Db_connect.cmd.CommandText = Db_connect.sql;

            Db_connect.cmd.Parameters.AddWithValue("@us", this.txtUsername.Text.Trim().ToString());
            Db_connect.cmd.Parameters.AddWithValue("@pa", this.txtPassword.Text.Trim().ToString());

            Db_connect.openConnection();

            Db_connect.rd = Db_connect.cmd.ExecuteReader(); 

            if (Db_connect.rd.HasRows)
            {
                while (Db_connect.rd.Read())
                {
                    Db_connect.currentUsername = Db_connect.rd[0].ToString();
                    Db_connect.currentStatus = Db_connect.rd[2].ToString();

                    MessageBox.Show("Welcome  " + Db_connect.currentUsername + "\n Your Status is ... " + Db_connect.currentStatus , "\n Login Successed :)",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                this.txtUsername.Text = string.Empty;
                this.txtPassword.Text = string.Empty;

                this.Hide();

                FrmMain f = new FrmMain();
                f.ShowDialog();
                f = null;

                this.Show();
            }
            else
            {
                MessageBox.Show("ผิดพลาด", "Invalid Username or Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (this.txtUsername.CanSelect)
                {
                    this.txtUsername.Select();
                }
            }

            Db_connect.rd.Close();
            Db_connect.closeConnection();

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
