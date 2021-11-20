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
    public partial class FrmOrder : Form
    {
        public FrmOrder()
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

        int previousQty = 0; // Qty Product
        int newQty = 0;
        int presentQty = 0; // Qty Product After Operating with newQty

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            prvShowAllOrder();
            prvFormatDataGrid();
            // AutoID                     Field Name        Table Name Head  Last      
            txtOrderID.Text = ocn.pusAutoID("pro_id", "tb_order", "O"+ DateTime.Now.Date.ToString("MMyy"), "00000"); // PID001

            txtCash.Text = dCash.ToString("#,##0.00");
            lbTotal.Text = dTotal.ToString("#,##0.00");
            lbChange.Text = dChange.ToString("#,##0.00");
            btnSale.Enabled = false;

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

        // Method for format datagridview
        private void prvFormatDataGrid()
        {
            dgvAllOrder.Update();
            dgvAllOrder.Refresh();

            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.Font = new Font("Ms Sans Serif", 10, FontStyle.Regular);
            dgvAllOrder.ColumnHeadersDefaultCellStyle = cs;
            dgvAllOrder.Columns[0].HeaderText = "รหัสการสั่งซื้อ";
            dgvAllOrder.Columns[1].HeaderText = "จำนวนที่สั่งซื้อ";
            dgvAllOrder.Columns[2].HeaderText = "ราคารวม";
            dgvAllOrder.Columns[3].HeaderText = "วันที่สั่งซื้อ";
            dgvAllOrder.Columns[4].HeaderText = "รหัสลูกค้า";
            dgvAllOrder.Columns[5].HeaderText = "รหัสสินค้า";

            dgvAllOrder.Columns[0].Width = 120;
            dgvAllOrder.Columns[1].Width = 120;
            dgvAllOrder.Columns[2].Width = 120;
            dgvAllOrder.Columns[3].Width = 160;
            dgvAllOrder.Columns[4].Width = 120;
            dgvAllOrder.Columns[5].Width = 120;
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            prvOpenListProduct();
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
            //int previousQty = 0; // Qty Product
            //int newQty = 0;
            //int presentQty = 0; // Qty Product After Operating with newQty
            previousQty = Convert.ToInt32(lbStockQuantity.Text);
            newQty = Convert.ToInt32(txtOrderQty.Text);

            lbTotal.Text = dTotal.ToString("#,##0.00");

            dTotal = Convert.ToDouble(txtOrderQty.Text) * Convert.ToDouble(txtProPrice.Text);

            lbTotal.Text = dTotal.ToString("#,##0.00");

            btnSale.Enabled = true;
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            prvCalculateTotal();
        }
    }
}
