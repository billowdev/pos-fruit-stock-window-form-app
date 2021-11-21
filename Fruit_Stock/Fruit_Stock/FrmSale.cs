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
    public partial class FrmSale : Form
    {
        public FrmSale()
        {
            InitializeComponent();
        }
        bool bCheck = false;
       

        oCenter ocn = new oCenter();
        public double dCash = 0;
        public double dChange = 0;
        public double dTotal = 0;
        double dCalTotal = 0;
        double sumTotal = 0;

        DataGridView dgvPublic;
        DataTable dtOrder = new DataTable();

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            /*
             // Column 
                tb_order column
                -------------------
                order_id,order_quantity,order_date,cus_id,pro_id

                tb_product
                ----------------------
                pro_id,pro_name,pro_price,pro_unit,pro_quantity,im_id

                tb_customer
                ----------------------
                cus_id,cus_name,cus_lastname,cus_phone
             */
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

            dgvStateOrder.DataSource = dtOrder; // ให้ค่า เป็นค่าจาก DataTable

            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.Font = new Font("Ms Sans Serif", 10, FontStyle.Regular);
            dgvStateOrder.ColumnHeadersDefaultCellStyle = cs;
            dgvStateOrder.Columns[0].HeaderText = "รหัสการสั่งซื้อ";
            dgvStateOrder.Columns[1].HeaderText = "จำนวนที่สั่งซื้อ";
            dgvStateOrder.Columns[2].HeaderText = "วันที่สั่งซื้อ";
            dgvStateOrder.Columns[3].HeaderText = "รหัสลูกค้า";
            dgvStateOrder.Columns[4].HeaderText = "รหัสสินค้า";
            dgvStateOrder.Columns[5].HeaderText = "หน่วย";
            dgvStateOrder.Columns[6].HeaderText = "ราคาสินค้า";
            dgvStateOrder.Columns[7].HeaderText = "ราคารวม";

            dgvStateOrder.Columns[0].Width = 160;
            dgvStateOrder.Columns[1].Width = 120;
            dgvStateOrder.Columns[2].Width = 240;
            dgvStateOrder.Columns[3].Width = 160;
            dgvStateOrder.Columns[4].Width = 160;
            dgvStateOrder.Columns[5].Width = 160;
            dgvStateOrder.Columns[6].Width = 120;
            dgvStateOrder.Columns[7].Width = 140;

            // ====================================== END Data Grid Order ================================ //

            // AutoID                     Field Name        Table Name Head  Last      
            txtOrderID.Text = ocn.pusAutoID("pro_id", "tb_order", "O" + DateTime.Now.Date.ToString("MMyy"), "00000"); // PID001

            //txtCash.Text = dCash.ToString("#,##0.00");
            lbTotal.Text = dTotal.ToString("#,##0.00");
            btnCheckBill.Enabled = false;
            dtpOrder.Value = DateTime.Now;
        }

        // Method for show all product when form load to data grid view dgvAllOrder
       

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            prvOpenListProduct();
        }

        private void prvOpenListProduct()
        {
            
            FrmListStockProduct Frm = new FrmListStockProduct();
            Frm.ShowDialog(this);
            //dgvPublic = dgvStateOrder;
            //Frm.pdgvPublic = dgvAllOrder;
            txtProID.Text = Frm.psPid;
            txtProName.Text = Frm.psPname;
            txtProPrice.Text = Frm.psPprice;
            txtProUnit.Text = Frm.psPunit;
            lbStockQuantity.Text = Frm.psPquantity;
        }

        DataSet nds = new DataSet();
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

            //  ===================== Add to data gridview   =====================  //
            dtOrder.Rows.Add(txtOrderID.Text, txtOrderQty.Text, dtpOrder.Value,
                            txtCustomerID.Text, txtProID.Text, txtProUnit.Text, Convert.ToDouble(txtProPrice.Text).ToString("#,##0.00"), 
                            (Convert.ToDouble(txtProPrice.Text) * Convert.ToDouble(txtOrderQty.Text)).ToString("#,##0.00")
                            );
            //  ====================== Calculate Total ======================== //
            
            dgvStateOrder.DataSource = dtOrder;


            //for (int nRow = 0; nRow <= dtOrder.Rows.Count; nRow++)
            //{

            //    dCalTotal = Convert.ToDouble(dgvStateOrder.Rows[nRow].Cells["oQty"].Value) *
            //        Convert.ToDouble(dgvStateOrder.Rows[nRow].Cells["oPrice"].Value);

            //}
            //dTotal = dCalTotal;
            //lbTotal.Text = dTotal.ToString("#,##0.00");


            lbTotal.Text = sumTotal.ToString("#,##0.00");

            //  ===================== END Add to data gridview   =====================  //
           
            btnCheckBill.Enabled = true;
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

        private void dgvStateOrder_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //dgvStateOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvStateOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && ((e.ColumnIndex == 3)))
            {
                if (dgvStateOrder.Rows[e.RowIndex].Cells[3].Value.ToString().Trim() == "")
                {
                    dgvStateOrder.Rows[e.RowIndex].Cells[3].Value = 0;
                }
                if (dgvStateOrder.Rows[e.RowIndex].Cells[4].Value.ToString().Trim() == "")
                {
                    dgvStateOrder.Rows[e.RowIndex].Cells[4].Value = 0;
                }
                
                prvSum();
                dgvStateOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvStateOrder.Rows[e.RowIndex].Selected = true;
                dgvStateOrder.Focus();
            }
        }

        private void prvSum()
        {
            txtProPrice.Text = "0.00";
            lbTotal.Text = "0.00";

            double dAmount = 0;
            for (int nRow = 0; nRow < dgvStateOrder.Rows.Count; nRow++)
            {
                if (dgvStateOrder.Rows[nRow].Cells[5].Value.ToString().Trim() != "")
                {
                    dAmount += Convert.ToDouble(dgvStateOrder.Rows[nRow].Cells[5].Value.ToString().Trim());
                }
                lbTotal.Text = dAmount.ToString("#,##0.00");
                double dTotal = 0;
                double dDiscount = 0;
            }

        }

      
    }
}

