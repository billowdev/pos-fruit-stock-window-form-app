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
    public partial class FrmSale : Form
    {
        public FrmSale()
        {
            InitializeComponent();
        }
        oCenter ocn = new oCenter();
        bool bCheck = false;
        public DataGridView pdgvStateOrder;

        public double dCash = 0;
        public double dChange = 0;
        public double dTotal = 0;
        double dCalTotal = 0;
        double sumTotal = 0;
        double dRaw = 0;
        DataSet dsCheck = new DataSet();
        //int nCurrentRow;
        bool bCheckCal = false;
        string conStr;
        List<string> sListGlobalCheck = new List<string>();
        bool bCheckFirstOrder = true;
        DataTable dtOrder = new DataTable();
        string stateOrder = "";
        bool bBillFinish = false;
        public DataSet dsSend = new DataSet();

        DataTable RawTable = new DataTable();


        private void FrmOrder_Load(object sender, EventArgs e)
        {
            // AutoID                     Field Name        Table Name Head  Last      
            txtOrderID.Text = ocn.pusAutoID("order_id", "tb_order", "O" + DateTime.Now.Date.ToString("MMyy"), "00000"); // PID001

            bCheckFirstOrder = true;
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

            RawTable.Columns.Add("oOid");
            RawTable.Columns.Add("oQty");
            RawTable.Columns.Add("oDate");
            RawTable.Columns.Add("oCID");
            RawTable.Columns.Add("oPID");
            RawTable.Columns.Add("oUnit");
            RawTable.Columns.Add("oPrice");
            RawTable.Columns.Add("oTotal");

            // ======================== DataGridView State Order =====//

            dgvStateOrder.DataSource = dtOrder; // ให้ค่า เป็นค่าจาก DataTable

            // ====================================== END Data Grid Order ================================ //

            
            stateOrder = txtOrderID.Text;
            //txtCash.Text = dCash.ToString("#,##0.00");
            lbTotal.Text = dTotal.ToString("#,##0.00");
            btnCheckBill.Enabled = false;
            dtpOrder.Value = DateTime.Now;
            prvFormatData();
        }

        // Method for show all product when form load to data grid view dgvAllOrder
       

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = stateOrder;
            prvOpenListProduct();
            prvFormatData();
           
        }

        private void prvFormatData()
        {
            try
            {
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

                dgvStateOrder.Columns[0].Width = 140;
                dgvStateOrder.Columns[1].Width = 80;
                dgvStateOrder.Columns[2].Width = 180;
                dgvStateOrder.Columns[3].Width = 160;
                dgvStateOrder.Columns[4].Width = 120;
                dgvStateOrder.Columns[5].Width = 140;
                dgvStateOrder.Columns[6].Width = 100;
                dgvStateOrder.Columns[7].Width = 120;
            }
            catch { }
           
        }
        private void prvOpenListProduct()
        {
            
            FrmListStockProduct Frm = new FrmListStockProduct();
            Frm.ShowDialog(this);

            txtProID.Text = Frm.psPid;
            txtProName.Text = Frm.psPname;
            txtProPrice.Text = Frm.psPprice;
            txtProUnit.Text = Frm.psPunit;
            lbStockQuantity.Text = Frm.psPquantity;

            bCheckFirstOrder = false;
        }
        
        private void prvCalculateTotal()
        {
            if (Convert.ToDouble(txtOrderQty.Text) > Convert.ToDouble(lbStockQuantity.Text))
            {
                MessageBox.Show("ไม่สามารถซื้อเกินสต๊อกได้ กรุณาเพิ่มสต๊อกสินค้า", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOrderQty.Text = "";
                return;
            }
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

            //========================================================================================================================//

            if (sListGlobalCheck.Count > 0)
            {
                foreach (var item in sListGlobalCheck)
                {
                    if (item == txtProID.Text)
                    {
                        MessageBox.Show("ไม่สามารถสั่งสินค้า ชนิดนี้ซ้ำอีกได้เนื่องจาก อยู่ในสถานะออร์เดอร์", "กรุณารีเฟรชออร์เดอร์ หรือ เลือกสินค้าตัวใหม่", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            if (bCheckFirstOrder == false)
            {
                if (bCheckFirstOrder == false)
                {
                    conStr = "";
                    // ============= Auto ID ORDER
                    string[] aStr = new string[] { stateOrder };

                    var newList = aStr[0].Skip(0);
                    
                    foreach (var str in newList)
                    {
                        if (str.ToString() != "O")
                        {
                            conStr += str.ToString();
                        }
                    }

                    dRaw = Convert.ToDouble(conStr) + 1;
                    stateOrder = "O" + dRaw.ToString();
                    txtOrderID.Text = "O" + dRaw.ToString();
                    // ============= Auto ID ORDER
                }
                else
                {
                    stateOrder = txtOrderID.Text;
                    //string[] aStr = new string[] { stateOrder };

                    //var newList = aStr[0].Skip(0);
                }
            }

            string raw = txtProID.Text;
            sListGlobalCheck.Add(raw);
            //========================================================================================================================//

            //  ===================== Add to data gridview   =====================  //
            dtOrder.Rows.Add(txtOrderID.Text, txtOrderQty.Text, dtpOrder.Value,
                            txtCustomerID.Text, txtProID.Text, txtProUnit.Text, Convert.ToDouble(txtProPrice.Text).ToString("#,##0.00"), 
                            (Convert.ToDouble(txtProPrice.Text) * Convert.ToDouble(txtOrderQty.Text)).ToString("#,##0.00")
                            );
            //  ====================== Calculate Total ======================== //
            sumTotal += Convert.ToDouble(txtProPrice.Text) * Convert.ToDouble(txtOrderQty.Text);
            dgvStateOrder.DataSource = dtOrder;
            
            lbTotal.Text = sumTotal.ToString("#,##0.00");

            //  ===================== END Add to data gridview   =====================  //
           
            btnCheckBill.Enabled = true;
        }

        

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
                prvCalculateTotal();
                bCheckCal = true;
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
            if (txtCustomerID.Text == "" || txtOrderID.Text == "" || txtOrderQty.Text == "" || txtProID.Text == "")
            {
            MessageBox.Show("กรุณาเลือกสินค้า หรือ ลูกค้า", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bCheckFirstOrder = true;
            if (bCheck == true)
            {
                dtOrder.Clear();
            }
            FrmCheckBill Frm = new FrmCheckBill();

            dsSend.Tables.Add(dtOrder);

            Frm.pds = dsSend;
            //Frm.pDS.Tables.Add(dtOrder);
            Frm.ShowDialog();
            bCheckCal = false;
            bCheck = false;
            // AutoID                     Field Name        Table Name Head  Last      
            txtOrderID.Text = ocn.pusAutoID("order_id", "tb_order", "O" + DateTime.Now.Date.ToString("MMyy"), "00000"); //O112100001
            bBillFinish = true;
            if (bBillFinish == true)
            {
                dtOrder.Clear();
            }
            bBillFinish = false;
        }

       

        private void dgvStateOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if ((e.RowIndex >= 0) && ((e.ColumnIndex == 3)))
            //{
            //    if (dgvStateOrder.Rows[e.RowIndex].Cells[3].Value.ToString().Trim() == "")
            //    {
            //        dgvStateOrder.Rows[e.RowIndex].Cells[3].Value = 0;
            //    }
            //    if (dgvStateOrder.Rows[e.RowIndex].Cells[4].Value.ToString().Trim() == "")
            //    {
            //        dgvStateOrder.Rows[e.RowIndex].Cells[4].Value = 0;
            //    }

            //    prvSum();
            //    dgvStateOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //    dgvStateOrder.Rows[e.RowIndex].Selected = true;
            //    dgvStateOrder.Focus();

            //    pdgvStateOrder = dgvStateOrder;
            //}
        }

   
        
    }
}

