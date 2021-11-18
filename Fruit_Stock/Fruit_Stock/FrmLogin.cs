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
using System.Data.OleDb;

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
                    oCenter.currentUsername = oCenter.rd[0].ToString();
                    oCenter.currentStatus = oCenter.rd[2].ToString();
                    oCenter.currentid = oCenter.rd[3].ToString();
                }

                
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

            oCenter.rd.Close();
            oCenter.pusvOpenConnection();

            // get name
            string sSqlName = " SELECT * FROM tb_employee WHERE emp_id=@empid";

            oCenter.cmd.Parameters.Clear();
            oCenter.cmd.Parameters.AddWithValue("@empid", oCenter.currentid);
            oCenter.cmd.CommandType = CommandType.Text;
            oCenter.cmd.CommandText = sSqlName;
            oCenter.rd = oCenter.cmd.ExecuteReader();

            string nName;
            string nLastName;
            if (oCenter.rd.HasRows)
            {
                while (oCenter.rd.Read())
                {
                    oCenter.currentName = oCenter.rd["emp_name"].ToString();
                    oCenter.currentLastName = oCenter.rd["emp_lastname"].ToString();
                }
            }
            oCenter.rd.Close();

            this.txtPassword.Text = string.Empty;
            this.txtUsername.Text = string.Empty;
            FrmMain Frm = new FrmMain();
            Frm.Show();
            this.Hide();
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
