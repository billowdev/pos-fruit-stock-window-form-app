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
        double dTotalBefore = 0;
        double dPriceAll = 0;
        double dCashCustomer = 0;
        double dChange = 0;
        double dDiscount = 0;
        double TotalAfter = 0;

        public bool pbCheckAction = false;
        public DataGridView pdgvOrder;
        oCenter ocn = new oCenter();
        public DataSet pds = new DataSet();
        public DataSet pds2 = new DataSet();
        bool bCheck = false;
        double dPreviousQty = 0; // Qty Product
        double dNewQty = 0;
        double dPresentQty = 0; // Qty Product After Operating with newQty
        public double OrderPrice;
        public double OrderTotal;
        public string OrderName;


        private void btnClose_Click(object sender, EventArgs e)
        {
            pbCheckAction = false;
            this.Close();
        }
        public DataSet pDS = new DataSet();
        public cryBill rptBill = new cryBill();
        

        private void FrmCheckBill_Load(object sender, EventArgs e)
        {

            txtCash.Focus();
            dgvOrder.DataSource = pds.Tables[0];

            prvFormatDataGrid();

            for (int nRow = 0; nRow < pds.Tables[0].Rows.Count; nRow++)
            {
                lbCUSID.Text = pds.Tables[0].Rows[nRow][3].ToString();
                string sSqlName = "select cus_name from tb_customer where cus_id='" + lbCUSID.Text + "'";
                DataSet dsCUSNAME = new DataSet();
                dsCUSNAME = ocn.pudsLoadData(sSqlName, "tb_customer", dsCUSNAME);

                if (dsCUSNAME.Tables["tb_customer"].Rows.Count != 0)
                {
                    lbCUSNAME.Text = dsCUSNAME.Tables["tb_customer"].Rows[0]["cus_name"].ToString();
                }

                dPriceAll += Convert.ToDouble(pds.Tables[0].Rows[nRow][7].ToString());
            }
            lbTotal.Text = "0.00";
            lbChange.Text = "0.00";
            lbPrice.Text = dPriceAll.ToString("#,##0.00");
            btnCheckBill.Enabled = false;
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
                dPreviousQty = Convert.ToInt32(checkDS.Tables["tb_product"].Rows[0]["pro_quantity"].ToString()); // Qty Product
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
                MessageBox.Show("Update Fail", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void prvInsertOrder(string _sOID, string _sOQty, string _sCusID, string _sPID, string _sDate)
        {

            oCenter.pusvCloseConnection();
            oCenter.pusvOpenConnection();
            try
            {
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
            } catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        string sOID, sOQty, sCusID, sPID, sDate;

        public string OrderID;
        public string OrderQty;
        public string OrderDate ;
        public string OrderCID ;
        public string OrderPID ;
        public string OrderUnit ;


        private void btnCal_Click(object sender, EventArgs e)
        {
     
            if (txtCash.Text == "")
            {
                MessageBox.Show("กรอกเงินสด", "คำนวณไม่ได้", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDouble(txtCash.Text) <= 0)
            {
                MessageBox.Show("กรุณากรอกจำนวนเงิน", "คำนวณไม่ได้", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDiscount.Text == "")
            {
                lbDiscount.Text = "0";
            }

            lbDiscount.Text = txtDiscount.Text; //  SHOW FOR CHECKBILL
            dDiscount = Convert.ToDouble(lbDiscount.Text);
            dPriceAll = Convert.ToDouble(lbPrice.Text); // ค่าใช้จ่าย

            TotalAfter = dPriceAll - dDiscount;  // ราคาหลัง คิดส่วนลด
            
            lbCash.Text = txtCash.Text; //  SHOW FOR CHECKBILL
            
            lbTotal.Text = Convert.ToString(TotalAfter);  //  SHOW FOR CHECKBILL

            dCashCustomer = Convert.ToDouble(txtCash.Text); // เงินสด
            // =========================================================
            lbChange.Text = Convert.ToString(Convert.ToDouble(lbCash.Text) - Convert.ToDouble(lbTotal.Text));
            dChange = Convert.ToDouble(lbChange.Text);
            btnCheckBill.Enabled = true;

        }

        private void btnCheckBill_Click(object sender, EventArgs e)
        {
            //dtOrder.Columns.Add("oOid");
            //dtOrder.Columns.Add("oQty");
            //dtOrder.Columns.Add("oDate");
            //dtOrder.Columns.Add("oCID");
            //dtOrder.Columns.Add("oPID");
            //dtOrder.Columns.Add("oUnit");
            //dtOrder.Columns.Add("oPrice");
            //dtOrder.Columns.Add("oTotal");

            for (int nRow = 0; nRow < pds.Tables[0].Rows.Count; nRow++)
            {
                sOID = pds.Tables[0].Rows[nRow]["oOid"].ToString();
                sOQty = pds.Tables[0].Rows[nRow]["oQty"].ToString();
                sDate = pds.Tables[0].Rows[nRow]["oDate"].ToString();
                sCusID = pds.Tables[0].Rows[nRow]["oCID"].ToString();
                sPID = pds.Tables[0].Rows[nRow]["oPID"].ToString();

                prvInsertOrder(sOID, sOQty, sCusID, sPID, sDate);

                prvUpdateProduct(sPID, sOQty);

            }

            // ===================================================================================================================================

            dsBillReport dsBillR = new dsBillReport();
            FrmReport Frm = new FrmReport();
            Frm.sReport = "CheckBill";

            for (int nRow = 0; nRow < dgvOrder.Rows.Count - 1; nRow++)
            {
                OrderID = dgvOrder.Rows[nRow].Cells[0].Value.ToString();
                OrderQty = dgvOrder.Rows[nRow].Cells[1].Value.ToString();
                OrderDate = dgvOrder.Rows[nRow].Cells[2].Value.ToString();
                OrderCID = dgvOrder.Rows[nRow].Cells[3].Value.ToString();
                OrderPID = dgvOrder.Rows[nRow].Cells[4].Value.ToString();
                OrderUnit = dgvOrder.Rows[nRow].Cells[5].Value.ToString();
                OrderPrice = Convert.ToDouble(dgvOrder.Rows[nRow].Cells[6].Value.ToString());
                OrderTotal = Convert.ToDouble(dgvOrder.Rows[nRow].Cells[7].Value.ToString());

                dsBillR.Tables[0].Rows.Add(OrderID, OrderName, OrderQty, OrderPID, OrderUnit, OrderPrice);

                string sPSql = "Select * from tb_product where pro_id='" + OrderPID + "'";
                pDS = ocn.pudsLoadData(sPSql, "tb_product", pDS);
                if (pDS.Tables["tb_product"].Rows.Count > 0)
                {
                    OrderName = pDS.Tables["tb_product"].Rows[0]["pro_name"].ToString();
                }
            }

            Frm.rptBill.SetDataSource(dsBillR);
            
            Frm.rptBill.SetParameterValue("oPrice", lbTotal.Text);
            Frm.rptBill.SetParameterValue("oDiscount", lbDiscount.Text);
            Frm.rptBill.SetParameterValue("oCash", lbCash.Text);
            Frm.rptBill.SetParameterValue("oChange", lbChange.Text);
            Frm.rptBill.SetParameterValue("oCusid", OrderCID);
            Frm.rptBill.SetParameterValue("oEmpid", oCenter.currentid);

            Frm.ShowDialog();
            this.Close();

        }

    }


}
