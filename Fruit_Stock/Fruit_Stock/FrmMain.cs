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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            
            fProfile.ShowDialog();
           
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}

