using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Stock
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
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
            
            oCenter ocn = new oCenter();
            DataSet dsLogin = new DataSet();

            string sSql = " SELECT * FROM tb_login WHERE Username='" + txtUsername.Text.Trim() + "' AND" +
                " Password='" + txtPassword.Text.Trim() + "'";

            dsLogin = ocn.puds_LoadData(sSql, "tb_login", dsLogin);

            if (dsLogin.Tables["tb_login"].Rows.Count != 0)
            {
                oCenter.currentUsername = txtUsername.Text.Trim();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Fail !!!", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
