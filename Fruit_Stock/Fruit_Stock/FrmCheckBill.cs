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
    public partial class FrmCheckBill : Form
    {
        public FrmCheckBill()
        {
            InitializeComponent();
        }
        public double pdTotal = 0;
        public double pdCash = 0;
        public double pdChange = 0;
        public bool pbCheckAction = false;

        public cryBill rptBill = new cryBill();

        private void prv_CheckBill()
        {
            if (Convert.ToDouble(lbTotal.Text) <= 0)
            {
                MessageBox.Show("total price should not less than zero", "Msg",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pdCash = Convert.ToDouble(txtCash.Text);
            pdChange = Convert.ToDouble(lbChange.Text);
            pbCheckAction = true;
            this.Close();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            pbCheckAction = false;
            this.Close();
        }

        private void FrmCheckBill_Load(object sender, EventArgs e)
        {
            
                 // crytal report control
            cryReportBill.ReportSource = rptBill;

            lbTotal.Text = Convert.ToDouble(pdCash).ToString("#,##0.00");
        }

        private void btnCheckBill_Click(object sender, EventArgs e)
        {
            prv_CheckBill();
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbTotal.Text == "")
                {
                    return;
                }

                if (Convert.ToDouble(lbTotal.Text) <= 0)
                {
                    return;
                }

                double dOut = Convert.ToDouble(txtCash.Text) - Convert.ToDouble(lbTotal.Text);
                lbChange.Text = dOut.ToString("#,##0.00");


            }
            catch (Exception ex)
            {
                txtCash.Text = "0";
                lbChange.Text = "0.00";
                return;
            }
        }

        private void txtCash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                prv_CheckBill();
            }
        }
    }
}
