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
        public DataGridView pdgvOrder;
        oCenter ocn = new oCenter();

        double dPreviousQty = 0; // Qty Product
        double dNewQty = 0;
        double dPresentQty = 0; // Qty Product After Operating with newQty

        

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
            ////for (int i = 0; i < dgvOrder.Rows.Count; i++)
            ////{
            ////    StrQuery = @"INSERT INTO tableName VALUES ("
            ////        + dgvOrder.Rows[i].Cells["ColumnName"].Text + ", "
            ////        + dgvOrder.Rows[i].Cells["ColumnName"].Text + ");";
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
        public DataSet pDS = new DataSet();
        public cryBill rptBill = new cryBill();

        private void FrmCheckBill_Load(object sender, EventArgs e)
        {
            DataTable dtOrder = new DataTable();
            // ====================================== Data Grid Order ================================ //
            dtOrder.Columns.Add("oOid");
            dtOrder.Columns.Add("oQty");
            dtOrder.Columns.Add("oDate");
            dtOrder.Columns.Add("oCID");
            dtOrder.Columns.Add("oPID");
            dtOrder.Columns.Add("oUnit");
            dtOrder.Columns.Add("oPrice");
            dtOrder.Columns.Add("oTotal");

            // ======================== DataGridView State Order =====//
            FrmSale Frm = new FrmSale();
            pdgvOrder = Frm.pdgvStateOrder;
            //dgvOrder.DataSource = dtOrder; // ให้ค่า เป็นค่าจาก DataTable
            dgvOrder.DataSource = pDS;


            //DataGridViewCellStyle cs = new DataGridViewCellStyle();
            //cs.Font = new Font("Ms Sans Serif", 10, FontStyle.Regular);
            //dgvOrder.ColumnHeadersDefaultCellStyle = cs;
            //dgvOrder.Columns[0].HeaderText = "รหัสการสั่งซื้อ";
            //dgvOrder.Columns[1].HeaderText = "จำนวนที่สั่งซื้อ";
            //dgvOrder.Columns[2].HeaderText = "วันที่สั่งซื้อ";
            //dgvOrder.Columns[3].HeaderText = "รหัสลูกค้า";
            //dgvOrder.Columns[4].HeaderText = "รหัสสินค้า";
            //dgvOrder.Columns[5].HeaderText = "หน่วย";
            //dgvOrder.Columns[6].HeaderText = "ราคาสินค้า";
            //dgvOrder.Columns[7].HeaderText = "ราคารวม";

            //dgvOrder.Columns[0].Width = 160;
            //dgvOrder.Columns[1].Width = 120;
            //dgvOrder.Columns[2].Width = 240;
            //dgvOrder.Columns[3].Width = 160;
            //dgvOrder.Columns[4].Width = 160;
            //dgvOrder.Columns[5].Width = 160;
            //dgvOrder.Columns[6].Width = 120;
            //dgvOrder.Columns[7].Width = 140;

            //// crytal report control
            //cryReportBill.ReportSource = pdgvOrder;
            //cryBill cr = new cryBill();
            ////cr.SetDataSource(pDS);
            //cryReportBill.ReportSource = pdgvOrder;

            lbChange.Text = Convert.ToDouble(pdCash).ToString("#,##0.00");
            lbTotal.Text = Convert.ToDouble(pdCash).ToString("#,##0.00");
            lbTotalAfter.Text = Convert.ToDouble(pdCash).ToString("#,##0.00");
            lbDiscount.Text = Convert.ToDouble(pdCash).ToString("#,##0.00");
        }

        cryBill rptCryBill = new cryBill();
        private void btnCheckBill_Click(object sender, EventArgs e)
        {
            //prv_CheckBill();

            rptCryBill.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait;
            rptCryBill.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4;
            // AutoID                     Field Name        Table Name Head  Last      
            string sPrint = ocn.pusAutoID("pro_id", "tb_order", "O" + DateTime.Now.Date.ToString("MMyy"), "00000"); // PID001
           
            //rptCryBill.ExportToHttpResponse(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, response, true, "test");

            rptCryBill.SummaryInfo.ReportTitle = sPrint;
            rptCryBill.PrintToPrinter(1, false, 0, 1);

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
