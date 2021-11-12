using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruit_Stock
{
    public partial class FrmProfile : Form
    {
        public FrmProfile()
        {
            InitializeComponent();
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tb_admin' table. You can move, or remove it, as needed.
            this.tb_adminTableAdapter.Fill(this.appData.tb_admin);
            // TODO: This line of code loads data into the 'appData.tb_login' table. You can move, or remove it, as needed.
            this.tb_loginTableAdapter.Fill(this.appData.tb_login);

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmMain f = new FrmMain();
            f.ShowDialog();
            f = null;
        }

  
    }
}
