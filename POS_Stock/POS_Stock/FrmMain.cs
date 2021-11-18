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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        oCenter ocn = new oCenter();

        private void timTime_Tick(object sender, EventArgs e)
        {
            stsTime.Text = DateTime.Now.AddSeconds(1).ToString("dd/MM/yyyy HH:MM:ss");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            pbMain.Hide();
            FrmLogin Frm = new FrmLogin();
            Frm.ShowDialog();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("ออกจากโปรแกรมใช่หรือไม่", "Msg",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
             
                Application.Exit();

            }
        }
   
        private void mnuProfile_Click(object sender, EventArgs e)
        {
            if (ocn.pub_CloseChildForm(this, "FrmProfile") == false)
            {
                FrmProfile Frm = new FrmProfile();
                Frm.MdiParent = this;
                Frm.Show();
            }
        }

        private void mnuInvoice_Click(object sender, EventArgs e)
        {
            if (ocn.pub_CloseChildForm(this, "FrmInvoice") == false)
            {
                FrmInvoice Frm = new FrmInvoice();
                Frm.MdiParent = this;
                Frm.Show();
            }
        }
        private void mnuOrder_Click(object sender, EventArgs e)
        {
            if (ocn.pub_CloseChildForm(this, "FrmSale") == false)
            {
                FrmOrder Frm = new FrmOrder();
                Frm.MdiParent = this;
                Frm.Show();
            }
        }
    }
}
