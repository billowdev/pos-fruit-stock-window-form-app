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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        FrmProfile fProfile = new FrmProfile();
        FrmInvoice fInvoice = new FrmInvoice();
        FrmLogin fLogin = new FrmLogin();

        private void mnuProfile_Click(object sender, EventArgs e)
        {
            fProfile.ShowDialog();
        }


   
        private void FrmMain_Load(object sender, EventArgs e)
        {

            //if (AC.currentUsername == null)
            //{
            //    fLogin.ShowDialog();
            //}
            if (AC.currentUsername != null)
            {
                lbName.Text = "Username: " + AC.currentUsername + " Status " + AC.currentStatus;
            }
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Logout", "msg", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                fLogin.ShowDialog();
                this.Close();
                AC.currentUsername = null;
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Exit", "msg", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private void mnuInvoice_Click(object sender, EventArgs e)
        {
            fInvoice.ShowDialog();
        }

        private void mnuSale_Click(object sender, EventArgs e)
        {
            FrmSale fSale = new FrmSale();
            fSale.ShowDialog();
        }
    }
}

