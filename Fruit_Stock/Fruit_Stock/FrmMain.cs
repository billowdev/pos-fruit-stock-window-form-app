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
            stsPageStatus.Text = " >>    หน้าหลัก    <<";
        }

        private void mnuProfile_Click(object sender, EventArgs e)
        {
            if (ocn.pub_CloseChildForm(this, "FrmProfile") == false)
            {
                stsPageStatus.Text = " >>    หน้าข้อมูลพนักงาน    <<";
                lbWelcome.Dispose();
                pbMain.Dispose();
                FrmEmployee Frm = new FrmEmployee();
                Frm.MdiParent = this;
                Frm.Show();
            }
        }

        private void mnuStock_Click(object sender, EventArgs e)
        {
            if (ocn.pub_CloseChildForm(this, "FrmStock") == false)
            {
                stsPageStatus.Text = " >>    หน้าสต๊อกสินค้า    <<";
                lbWelcome.Dispose();
                pbMain.Hide();
                FrmStock Frm = new FrmStock();
                Frm.MdiParent = this;
                Frm.Show();
            }

        }


        private void mnuProduct_Click(object sender, EventArgs e)
        {
            if (ocn.pub_CloseChildForm(this, "FrmProduct") == false)
            {
                stsPageStatus.Text = " >>    หน้าเพิ่มสินค้า    <<";
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

        private void mnuHistoryStock_Click(object sender, EventArgs e)
        {
            stsPageStatus.Text = " >>    หน้าประวัติการสต๊อกสินค้า    <<";
            lbWelcome.Dispose();
            pbMain.Dispose();
            FrmHistoryStock Frm = new FrmHistoryStock();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void cmuCustomer_Click(object sender, EventArgs e)
        {
            if (ocn.pub_CloseChildForm(this, "FrmCustomer") == false)
            {
                stsPageStatus.Text = " >>    หน้าข้อมูลลูกค้า    <<";
                lbWelcome.Dispose();
                pbMain.Dispose();
                FrmCustomer Frm = new FrmCustomer();
                Frm.MdiParent = this;
                Frm.Show();
            }
        }

        private void mnuSale_Click(object sender, EventArgs e)
        {
            if (ocn.pub_CloseChildForm(this, "FrmOrderProduct") == false)
            {
                stsPageStatus.Text = " >>    หน้าขายสินค้า    <<";
                lbWelcome.Dispose();
                pbMain.Dispose();
                FrmOrderProduct Frm = new FrmOrderProduct();
                Frm.MdiParent = this;
                Frm.Show();
            }
        }

        private void cmuHistoryOrder_Click(object sender, EventArgs e)
        {
            if (ocn.pub_CloseChildForm(this, "FrmOrderHistory") == false)
            {
                stsPageStatus.Text = " >>    หน้าประวัติการสั่งซื้อสินค้า    <<";
                lbWelcome.Dispose();
                pbMain.Dispose();
                FrmOrderHistory Frm = new FrmOrderHistory();
                Frm.MdiParent = this;
                Frm.Show();
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("ออกจากโปรแกรมใช่หรือไม่", "Msg",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                try
                {
                    Application.Exit(); // Collection was modified; enumeration operation may not execute.'
                }
                catch
                {
                    Environment.Exit(1);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("ออกจากโปรแกรมใช่หรือไม่", "Msg",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                try
                {
                    Application.Exit(); // Collection was modified; enumeration operation may not execute.'
                }
                catch
                {
                    Environment.Exit(1);
                }
            }
        }

        private void cmuFTSale_Click(object sender, EventArgs e)
        {
            if (ocn.pub_CloseChildForm(this, "FrmSale") == false)
            {
                stsPageStatus.Text = " >>    หน้าขาย    <<";
                lbWelcome.Dispose();
                pbMain.Dispose();
                FrmSale Frm = new FrmSale();
                Frm.MdiParent = this;
                Frm.Show();
            }
        }
    }
}

