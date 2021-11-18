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

        oCenter ocn = new oCenter();
        
        private void FrmMain_Load(object sender, EventArgs e)
        {
            pbMain.Hide();
            FrmLogin Frm = new FrmLogin();
            Frm.ShowDialog();


        }
        private void mnuProfile_Click(object sender, EventArgs e)
        {

            if (ocn.pub_CloseChildForm(this, "FrmProfile") == false)
            {
                lbUsernameStatus.Hide();
                FrmProfile Frm = new FrmProfile();
                Frm.MdiParent = this;
                Frm.Show();
            }
        }



        private void mnuLogout_Click(object sender, EventArgs e)
        {
            oCenter.currentUsername = "";
            if (ocn.pub_CloseChildForm(this, "FrmLogin") == false)
            {
                lbUsernameStatus.Hide();
                FrmLogin Frm = new FrmLogin();
                Frm.MdiParent = this;
                Frm.Show();
            }
        }


        private void mnuInvoice_Click(object sender, EventArgs e)
        {
            if (ocn.pub_CloseChildForm(this, "FrmInvoice") == false)
            {
                lbUsernameStatus.Hide();
                FrmInvoice Frm = new FrmInvoice();
                Frm.MdiParent = this;
                Frm.Show();
            }

        }

        private void mnuSale_Click(object sender, EventArgs e)
        {

            if (ocn.pub_CloseChildForm(this, "FrmSale") == false)
            {
                lbUsernameStatus.Hide();
                FrmSale Frm = new FrmSale();
                Frm.MdiParent = this;
                Frm.Show();
            }


        }

        private void mnuProduct_Click(object sender, EventArgs e)
        {
            if (ocn.pub_CloseChildForm(this, "FrmProduct") == false)
            {
                lbUsernameStatus.Hide();
                FrmProduct Frm = new FrmProduct();
                Frm.MdiParent = this;
                Frm.Show();
            }
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {
            lbUsernameStatus.Hide();
            System.Diagnostics.Process.Start("https://www.google.com");
        }

        private void timTime_Tick(object sender, EventArgs e)
        {
            stsTime.Text = DateTime.Now.AddSeconds(1).ToString("dd/MM/yyyy HH:MM:ss");

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("ออกจากโปรแกรมใช่หรือไม่", "Msg",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                try
                {
                    Application.Exit();
                }
                catch { }
            }
        }
    }
}

