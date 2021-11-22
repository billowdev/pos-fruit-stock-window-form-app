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
using System.Data.OleDb;

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
        public DataSet pds = new DataSet();
        public DataSet pds2 = new DataSet();
        bool bCheck = false;
        double dPreviousQty = 0; // Qty Product
        double dNewQty = 0;
        double dPresentQty = 0; // Qty Product After Operating with newQty
        
        

        private void prv_CheckBill()
        {
   
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
            prvFormatDataGrid();
      
            dgvOrder.DataSource = pds.Tables[0];

            lbChange.Text = Convert.ToDouble(pdCash).ToString("#,##0.00");
            lbTotal.Text = Convert.ToDouble(pdCash).ToString("#,##0.00");
            lbTotalAfter.Text = Convert.ToDouble(pdCash).ToString("#,##0.00");
            lbDiscount.Text = Convert.ToDouble(pdCash).ToString("#,##0.00");

            
        }

        private void prvFormatDataGrid()
        {
            try
            {
                DataGridViewCellStyle cs = new DataGridViewCellStyle();
                cs.Font = new Font("Ms Sans Serif", 10, FontStyle.Regular);
                dgvOrder.ColumnHeadersDefaultCellStyle = cs;
                dgvOrder.Columns[0].HeaderText = "รหัสการสั่งซื้อ";
                dgvOrder.Columns[1].HeaderText = "จำนวนที่สั่งซื้อ";
                dgvOrder.Columns[2].HeaderText = "วันที่สั่งซื้อ";
                dgvOrder.Columns[3].HeaderText = "รหัสลูกค้า";
                dgvOrder.Columns[4].HeaderText = "รหัสสินค้า";
                dgvOrder.Columns[5].HeaderText = "หน่วย";
                dgvOrder.Columns[6].HeaderText = "ราคาสินค้า";
                dgvOrder.Columns[7].HeaderText = "ราคารวม";

                dgvOrder.Columns[0].Width = 120;
                dgvOrder.Columns[1].Width = 120;
                dgvOrder.Columns[2].Width = 180;
                dgvOrder.Columns[3].Width = 160;
                dgvOrder.Columns[4].Width = 160;
                dgvOrder.Columns[5].Width = 160;
                dgvOrder.Columns[6].Width = 100;
                dgvOrder.Columns[7].Width = 120;
            }
            catch { }
            
        }

        private void prvUpdateProduct(string _sPID, string _dUpdateQty)
        {
            oCenter.pusvCloseConnection();
            oCenter.pusvOpenConnection();
            string sSql = " SELECT * FROM tb_product WHERE pro_id='" + _sPID + "'";
            DataSet checkDS = new DataSet();

            checkDS = ocn.pudsLoadData(sSql, "tb_product", checkDS);

            if (checkDS.Tables["tb_product"].Rows.Count != 0)
            {
                dPreviousQty = Convert.ToInt32( checkDS.Tables["tb_product"].Rows[0]["pro_quantity"].ToString() ); // Qty Product
                dNewQty = Convert.ToDouble(_dUpdateQty);  // Qty Order
                dPresentQty = dPreviousQty - dNewQty; // Qty Product After Operating with newQty

                // ============= Update Quantity at tb_product after import ========================= //
                oCenter.pusvCloseConnection();
                oCenter.pusvOpenConnection();

                OleDbCommand cmdUpdate = new OleDbCommand();

                sSql = " UPDATE tb_product SET pro_quantity=@updateQty WHERE pro_id=@PID";
                cmdUpdate.Parameters.Clear();
                cmdUpdate.Parameters.AddWithValue("@updateQty", _dUpdateQty);
                cmdUpdate.Parameters.AddWithValue("@PID", _sPID);

                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = sSql;
                cmdUpdate.Connection = oCenter.conn;
                cmdUpdate.ExecuteNonQuery();

                // =============  END Update Quantity at tb_product after import ========================= //
            }
            else
            {
                MessageBox.Show("Login Fail !!!", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void prvInsertOrder(string _sOID, string _sOQty, string _sCusID, string _sPID, string _sDate)
        {

            oCenter.pusvCloseConnection();
            oCenter.pusvOpenConnection();

            // ============================================== Insert to tb_order ========================= //
            OleDbCommand cmdOrder = new OleDbCommand();
            string sSqlOder = "INSERT INTO tb_order(order_id, order_quantity, order_date, cus_id, pro_id) VALUES ('" +
                _sOID + "','" +
                _sOQty + "','" +
                _sDate + "','" +
                _sCusID + "','" +
                _sPID + "')";

            cmdOrder.CommandType = CommandType.Text;
            cmdOrder.CommandText = sSqlOder;
            cmdOrder.Connection = oCenter.conn;
            cmdOrder.ExecuteNonQuery();
        }

        string sOID, sOQty, sCusID, sPID, sDate;
        


        cryBill rptCryBill = new cryBill();
        private void btnCheckBill_Click(object sender, EventArgs e)
        {
            //dgvOrder.Columns[0].HeaderText = "รหัสการสั่งซื้อ";
            //dgvOrder.Columns[1].HeaderText = "จำนวนที่สั่งซื้อ";
            //dgvOrder.Columns[2].HeaderText = "วันที่สั่งซื้อ";
            //dgvOrder.Columns[3].HeaderText = "รหัสลูกค้า";
            //dgvOrder.Columns[4].HeaderText = "รหัสสินค้า";
            //dgvOrder.Columns[5].HeaderText = "หน่วย";
            //dgvOrder.Columns[6].HeaderText = "ราคาสินค้า";
            //dgvOrder.Columns[7].HeaderText = "ราคารวม";
            //dtOrder.Columns.Add("oOid");
            //dtOrder.Columns.Add("oQty");
            //dtOrder.Columns.Add("oDate");
            //dtOrder.Columns.Add("oCID");
            //dtOrder.Columns.Add("oPID");
            //dtOrder.Columns.Add("oUnit");
            //dtOrder.Columns.Add("oPrice");
            //dtOrder.Columns.Add("oTotal");

            for (int iTem=0; iTem < pds.Tables[0].Rows.Count; iTem++)
            {
                sOID = pds.Tables[0].Rows[iTem]["oOid"].ToString();
                sOQty = pds.Tables[0].Rows[iTem]["oQty"].ToString();
                sDate = pds.Tables[0].Rows[iTem]["oDate"].ToString();
                sCusID = pds.Tables[0].Rows[iTem]["oCID"].ToString();
                sPID = pds.Tables[0].Rows[iTem]["oPID"].ToString();

                prvInsertOrder(sOID, sOQty, sCusID, sPID, sDate);

                prvUpdateProduct(sPID, sOQty);

            }

            // ===================================================================================================================================


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
