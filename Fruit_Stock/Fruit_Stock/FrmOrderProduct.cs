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
using System.Data;
using System.Data.OleDb;

namespace Fruit_Stock
{
    public partial class FrmOrderProduct : Form
    {
        public FrmOrderProduct()
        {
            InitializeComponent();
        }

        bool bCheck = false;
        DataGridView dgvPublic;
        oCenter ocn = new oCenter();
        public double dCash = 0;
        public double dChange = 0;
        public double dTotal = 0;

        string sSql = "";
        DataSet dsOrder = new DataSet();

        double dPreviousQty = 0; // Qty Product
        double dNewQty = 0;
        double dPresentQty = 0; // Qty Product After Operating with newQty

        DataTable dtOrder = new DataTable();

        private void FrmOrderProduct_Load(object sender, EventArgs e)
        {

            // ====================================== Data Grid Order ================================ //
            dtOrder.Columns.Add("");


            // ====================================== END Data Grid Order ================================ //

            prvShowAllOrder();
            prvFormatDataGrid();
            // AutoID                     Field Name        Table Name Head  Last      
            txtOrderID.Text = ocn.pusAutoID("pro_id", "tb_order", "O" + DateTime.Now.Date.ToString("MMyy"), "00000"); // PID001

            txtCash.Text = dCash.ToString("#,##0.00");
            lbTotal.Text = dTotal.ToString("#,##0.00");
            lbChange.Text = dChange.ToString("#,##0.00");
            btnSale.Enabled = false;
            dtpOrder.Value = DateTime.Now;
        }

        // Method for show all product when form load to data grid view dgvAllOrder
        private void prvShowAllOrder()
        {
            bCheck = false;
            sSql = "select * from tb_order";
            dsOrder = ocn.pudsLoadData(sSql, "tb_order", dsOrder);

            if (bCheck == true)
            {
                dsOrder.Tables["tb_order"].Clear();
            }

            if (dsOrder.Tables["tb_order"].Rows.Count != 0)
            {
                bCheck = true;
                dgvAllOrder.ReadOnly = true;
                dgvAllOrder.DataSource = dsOrder.Tables["tb_order"];
            }
            else
            {
                bCheck = false;
            }
            // ----------------------------------------------------------------------------------- //
        }

        private void prvFormatDataGrid()
        {
            dgvAllOrder.Update();
            dgvAllOrder.Refresh();

            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.Font = new Font("Ms Sans Serif", 10, FontStyle.Regular);
            dgvAllOrder.ColumnHeadersDefaultCellStyle = cs;
            dgvAllOrder.Columns[0].HeaderText = "รหัสการสั่งซื้อ";
            dgvAllOrder.Columns[1].HeaderText = "จำนวนที่สั่งซื้อ";
            dgvAllOrder.Columns[2].HeaderText = "วันที่สั่งซื้อ";
            dgvAllOrder.Columns[3].HeaderText = "รหัสลูกค้า";
            dgvAllOrder.Columns[4].HeaderText = "รหัสสินค้า";

            dgvAllOrder.Columns[0].Width = 180;
            dgvAllOrder.Columns[1].Width = 180;
            dgvAllOrder.Columns[2].Width = 180;
            dgvAllOrder.Columns[3].Width = 220;
            dgvAllOrder.Columns[4].Width = 180;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            prvOpenListProduct();
            lbTotal.Text = "";
            txtCash.Text = "";
            lbChange.Text = "";
        }
        private void prvOpenListProduct()
        {
            dgvPublic = dgvAllOrder;
            FrmListStockProduct Frm = new FrmListStockProduct();
            Frm.pdgvPublic = dgvPublic;
            Frm.ShowDialog(this);

            txtProID.Text = Frm.psPid;
            txtProName.Text = Frm.psPname;
            txtProPrice.Text = Frm.psPprice;
            txtProUnit.Text = Frm.psPunit;
            lbStockQuantity.Text = Frm.psPquantity;
        }
        private void prvCalculateTotal()
        {
            if (txtOrderQty.Text == "")
            {
                MessageBox.Show("Enter Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtProID.Text == "")
            {
                MessageBox.Show("Add Product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCustomerID.Text == "")
            {
                MessageBox.Show("Add Customer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lbStockQuantity.Text == "")
            {
                MessageBox.Show("Please Select other product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToInt32(txtOrderQty.Text) == 0)
            {
                MessageBox.Show("Please Enter Quantity more than zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToInt32(txtOrderQty.Text) < 0)
            {
                MessageBox.Show("Please Enter Quantity more than zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToInt32(txtOrderQty.Text) > Convert.ToInt32(lbStockQuantity.Text))
            {
                MessageBox.Show("Can't Order more than product stock \n please check stock or select other product", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            dPreviousQty = Convert.ToInt32(lbStockQuantity.Text); // Qty Product
            dNewQty = Convert.ToInt32(txtOrderQty.Text);  // Qty Order
            dPresentQty = dPreviousQty - dNewQty; // Qty Product After Operating with newQty

            lbTotal.Text = dTotal.ToString("#,##0.00");

            dTotal = Convert.ToDouble(txtOrderQty.Text) * Convert.ToDouble(txtProPrice.Text);

            lbTotal.Text = dTotal.ToString("#,##0.00");

            btnSale.Enabled = true;
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            prvCalculateTotal();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FrmListCustomer Frm = new FrmListCustomer();
            Frm.ShowDialog();

            if (Frm.psCusID != "")
            {
                txtCustomerID.Text = Frm.psCusID;
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (txtCash.Text == "")
            {
                MessageBox.Show("Please Enter Cash", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDouble(txtCash.Text) < Convert.ToDouble(lbTotal.Text))
            {
                MessageBox.Show("You must enter cash more than or equal total value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ============= Update Quantity at tb_product after import ========================= //
            oCenter.pusvCloseConnection();
            oCenter.pusvOpenConnection();

            OleDbCommand cmdUpdate = new OleDbCommand();

            sSql = " UPDATE tb_product SET pro_quantity=@updateQty WHERE pro_id=@PID";
            cmdUpdate.Parameters.Clear();
            cmdUpdate.Parameters.AddWithValue("@updateQty", dPresentQty);
            cmdUpdate.Parameters.AddWithValue("@PID", txtProID.Text.Trim().ToString());

            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.CommandText = sSql;
            cmdUpdate.Connection = oCenter.conn;
            cmdUpdate.ExecuteNonQuery();

            ocn.dBillTotal = Convert.ToDouble(lbTotal.Text);
            ocn.dBillCash = Convert.ToDouble(txtCash.Text);
            ocn.dBillChange = Convert.ToDouble(txtCash.Text) - Convert.ToDouble(lbTotal.Text);

            lbChange.Text = (Convert.ToDouble(txtCash.Text) - Convert.ToDouble(lbTotal.Text)).ToString("#,##00.00");

            // =============  END Update Quantity at tb_product after import ========================= //

            oCenter.pusvCloseConnection();
            oCenter.pusvOpenConnection();

            // ============================================== Insert to tb_order ========================= //
            OleDbCommand cmdOrder = new OleDbCommand();
            string sSqlOder = "INSERT INTO tb_order(order_id, order_quantity, order_date, cus_id, pro_id) VALUES ('" +
                txtOrderID.Text + "','" +
                txtOrderQty.Text + "','" +
                dtpOrder.Value + "','" +
                txtCustomerID.Text + "','" +
                txtProID.Text + "')";

            cmdOrder.CommandType = CommandType.Text;
            cmdOrder.CommandText = sSqlOder;
            cmdOrder.Connection = oCenter.conn;
            cmdOrder.ExecuteNonQuery();

            // ============================================== END Insert to tb_order ========================= //


            prvShowAllOrder();
            prvClearAll();



          

        }
        private void prvClearAll()
        {
            txtOrderID.Text = "";
            txtOrderQty.Text = "";
            txtCustomerID.Text = "";
            txtProID.Text = "";
            txtProName.Text = "";
            txtProPrice.Text = "";
            txtProUnit.Text = "";
            lbStockQuantity.Text = "";

        }
    }
}
