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

        double dPreviousQty = 0; // Qty Product
        double dNewQty = 0;
        double dPresentQty = 0; // Qty Product After Operating with newQty

        public cryBill rptBill = new cryBill();

        private void prv_CheckBill()
        {
            //if (Convert.ToDouble(lbTotal.Text) <= 0)
            //{
            //    MessageBox.Show("total price should not less than zero", "Msg",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            //dPreviousQty = Convert.ToInt32(lbStockQuantity.Text); // Qty Product
            //dNewQty = Convert.ToInt32(txtOrderQty.Text);  // Qty Order
            //dPresentQty = dPreviousQty - dNewQty; // Qty Product After Operating with newQty

            //if (txtCash.Text == "")
            //{
            //    MessageBox.Show("Please Enter Cash", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (Convert.ToDouble(txtCash.Text) < Convert.ToDouble(lbTotal.Text))
            //{
            //    MessageBox.Show("You must enter cash more than or equal total value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //// Insert From Data Grid
            ////for (int i = 0; i < dataGridView1.Rows.Count; i++)
            ////{
            ////    StrQuery = @"INSERT INTO tableName VALUES ("
            ////        + dataGridView1.Rows[i].Cells["ColumnName"].Text + ", "
            ////        + dataGridView1.Rows[i].Cells["ColumnName"].Text + ");";
            ////    comm.CommandText = StrQuery;
            ////    comm.ExecuteNonQuery();
            ////}


            //// ============= Update Quantity at tb_product after import ========================= //
            //oCenter.pusvCloseConnection();
            //oCenter.pusvOpenConnection();

            //OleDbCommand cmdUpdate = new OleDbCommand();

            //sSql = " UPDATE tb_product SET pro_quantity=@updateQty WHERE pro_id=@PID";
            //cmdUpdate.Parameters.Clear();
            //cmdUpdate.Parameters.AddWithValue("@updateQty", dPresentQty);
            //cmdUpdate.Parameters.AddWithValue("@PID", txtProID.Text.Trim().ToString());

            //cmdUpdate.CommandType = CommandType.Text;
            //cmdUpdate.CommandText = sSql;
            //cmdUpdate.Connection = oCenter.conn;
            //cmdUpdate.ExecuteNonQuery();

            //ocn.dBillTotal = Convert.ToDouble(lbTotal.Text);
            //ocn.dBillCash = Convert.ToDouble(txtCash.Text);
            //ocn.dBillChange = Convert.ToDouble(txtCash.Text) - Convert.ToDouble(lbTotal.Text);

            //lbAmount.Text = (Convert.ToDouble(txtCash.Text) - Convert.ToDouble(lbTotal.Text)).ToString("#,##00.00");

            //// =============  END Update Quantity at tb_product after import ========================= //

            //oCenter.pusvCloseConnection();
            //oCenter.pusvOpenConnection();

            //// ============================================== Insert to tb_order ========================= //
            //OleDbCommand cmdOrder = new OleDbCommand();
            //string sSqlOder = "INSERT INTO tb_order(order_id, order_quantity, order_date, cus_id, pro_id) VALUES ('" +
            //    txtOrderID.Text + "','" +
            //    txtOrderQty.Text + "','" +
            //    dtpOrder.Value + "','" +
            //    txtCustomerID.Text + "','" +
            //    txtProID.Text + "')";

            //cmdOrder.CommandType = CommandType.Text;
            //cmdOrder.CommandText = sSqlOder;
            //cmdOrder.Connection = oCenter.conn;
            //cmdOrder.ExecuteNonQuery();

            //// ============================================== END Insert to tb_order ========================= //



            //prvShowAllOrder();
            //prvClearAll();

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
