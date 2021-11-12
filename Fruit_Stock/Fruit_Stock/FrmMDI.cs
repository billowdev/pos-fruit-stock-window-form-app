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
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void mnuProfile_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmProfile f = new FrmProfile();
            f.ShowDialog();
            f = null;
        }

        private void mnuInvoice_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmInvoice f = new FrmInvoice();
            f.ShowDialog();
            f = null;
        }

        private void mnuHistoryInvoice_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            FrmHistoryInvoice f = new FrmHistoryInvoice();
            f.ShowDialog();
            f = null;
        }

        private void mnuStock_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmStock f = new FrmStock();
            f.ShowDialog();
            f = null;
        }
    }
}
