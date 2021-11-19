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
            stsName.Text = "| Welcome: " + oCenter.currentName + " " + oCenter.currentLastName +
                            " Your Status is : " + oCenter.currentStatus + " |";

            lbWelcome.Text = "Welcome " + oCenter.currentName;
            lbWelcome.Show();

            // option loading page
            pbLoad.Dispose();
            //lbWelcome.Dispose();
            //stsName.Text = "";
        }

        private void mnuProfile_Click(object sender, EventArgs e)
        {
            if (ocn.pub_CloseChildForm(this, "FrmProfile") == false)
            {
                lbWelcome.Dispose();
                pbMain.Dispose();
                FrmProfile Frm = new FrmProfile();
                Frm.MdiParent = this;
                Frm.Show();
            }
        }

        private void mnuStock_Click(object sender, EventArgs e)
        {
            if (ocn.pub_CloseChildForm(this, "FrmStock") == false)
            {
                lbWelcome.Dispose();
                pbMain.Hide();
                FrmStock Frm = new FrmStock();
                Frm.MdiParent = this;
                Frm.Show();
            }

        }

        private void mnuSale_Click(object sender, EventArgs e)
        {
            if (ocn.pub_CloseChildForm(this, "FrmSale") == false)
            {
                lbWelcome.Dispose();
                pbMain.Dispose();
                FrmSale Frm = new FrmSale();
                Frm.MdiParent = this;
                Frm.Show();
            }
        }

        private void mnuProduct_Click(object sender, EventArgs e)
        {
            if (ocn.pub_CloseChildForm(this, "FrmProduct") == false)
            {
                lbWelcome.Dispose();
                pbMain.Dispose();
                FrmProduct Frm = new FrmProduct();
                Frm.MdiParent = this;
                Frm.Show();
            }
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {
            lbWelcome.Dispose();
            pbMain.Dispose();
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

                //Application.Exit(); // Collection was modified; enumeration operation may not execute.'
                Environment.Exit(1);
            }
        }

        private void timTimeLoading_Tick(object sender, EventArgs e)
        {
            timTimeLoading.Stop();
            pbLoad.Dispose();
            lbWelcome.Show();
            stsName.Text = "| Welcome: " + oCenter.currentName + " " + oCenter.currentLastName +
                            " Your Status is : " + oCenter.currentStatus + " |";
        }

        private void mnuHistoryStock_Click(object sender, EventArgs e)
        {
            lbWelcome.Dispose();
            pbMain.Dispose();
            FrmHistoryStock Frm = new FrmHistoryStock();
            Frm.MdiParent = this;
            Frm.Show();
        }
    }
}

