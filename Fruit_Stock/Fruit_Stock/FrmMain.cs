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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }



        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FrmProfile f = new FrmProfile();
            f.ShowDialog();
            f = null;
            this.Close();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            FrmInvoice f = new FrmInvoice();
            f.ShowDialog();
            f = null;
            this.Close();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FrmStock f = new FrmStock();
            f.ShowDialog();
            f = null;
            this.Close();
        }

        private void btnHistoryInvoice_Click(object sender, EventArgs e)
        {
            FrmHistoryInvoice f = new FrmHistoryInvoice();
            f.ShowDialog();
            f = null;
            this.Close();
        }
    }
}
