using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
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
        OleDbDataReader loginReader;
        // ==========================================
        DataSet dsLogin = new DataSet();

        private void prvCheckLogin()
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
            string sSql = " SELECT * FROM tb_login WHERE Username='" + txtUsername.Text.Trim() + "' AND" +
                " Password='" + txtPassword.Text.Trim() + "'";
            dsLogin = ocn.pudsLoadData(sSql, "tb_login", dsLogin);

            if (dsLogin.Tables["tb_login"].Rows.Count != 0)
            {
                //MessageBox.Show();

                oCenter.currentUsername = dsLogin.Tables["tb_login"].Rows[0]["Username"].ToString();
                oCenter.currentStatus = dsLogin.Tables["tb_login"].Rows[0]["Status"].ToString();
                oCenter.currentid = dsLogin.Tables["tb_login"].Rows[0]["emp_id"].ToString();

                prvGetEmployee();
                FrmMain Frm = new FrmMain();
                Frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Fail !!!", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void prvGetEmployee()
        {
            oCenter.pusvOpenConnection();

            // get name
            string sSqlName = " SELECT * FROM tb_employee WHERE emp_id=@empid";

            oCenter.cmd.Parameters.Clear();
            oCenter.cmd.Parameters.AddWithValue("@empid", oCenter.currentid);
            oCenter.cmd.CommandType = CommandType.Text;
            oCenter.cmd.CommandText = sSqlName;
            loginReader = oCenter.cmd.ExecuteReader();

            if (loginReader.HasRows)
            {
                while (loginReader.Read())
                {
                    oCenter.currentName = loginReader["emp_name"].ToString();
                    oCenter.currentLastName = loginReader["emp_lastname"].ToString();
                }
            }
        }


        // =================================================================================================================== //
        //                                                                                                                   //
        //                                                    Event                                                          //
        //                                                                                                                   //
        // =================================================================================================================== //

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
            prvCheckLogin();
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
