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


    }
}

