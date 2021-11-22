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
    public partial class FrmOrderHistory : Form
    {
        public FrmOrderHistory()
        {
            InitializeComponent();
        }

        string sSql = "";
        bool bCheck = false;
        DataSet dsOrder = new DataSet();
        oCenter ocn = new oCenter();

        private void prvShowAllOrder()
        {
            sSql = "select * from tb_order";
            dsOrder = ocn.pudsLoadData(sSql, "tb_order", dsOrder);

            if (bCheck == true)
            {
                dsOrder.Tables["tb_order"].Clear();
            }

            if (dsOrder.Tables["tb_order"].Rows.Count != 0)
            {
                bCheck = true;
                dgvAllOrderHistory.ReadOnly = true;
                dgvAllOrderHistory.DataSource = dsOrder.Tables["tb_order"];
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
            try
            {
                dgvAllOrderHistory.Update();
                dgvAllOrderHistory.Refresh();

                DataGridViewCellStyle cs = new DataGridViewCellStyle();
                cs.Font = new Font("Ms Sans Serif", 10, FontStyle.Regular);
                dgvAllOrderHistory.ColumnHeadersDefaultCellStyle = cs;
                dgvAllOrderHistory.Columns[0].HeaderText = "รหัสการสั่งซื้อ";
                dgvAllOrderHistory.Columns[1].HeaderText = "จำนวนที่สั่งซื้อ";
                dgvAllOrderHistory.Columns[2].HeaderText = "วันที่สั่งซื้อ";
                dgvAllOrderHistory.Columns[3].HeaderText = "รหัสลูกค้า";
                dgvAllOrderHistory.Columns[4].HeaderText = "รหัสสินค้า";

                dgvAllOrderHistory.Columns[0].Width = 260;
                dgvAllOrderHistory.Columns[1].Width = 200;
                dgvAllOrderHistory.Columns[2].Width = 300;
                dgvAllOrderHistory.Columns[3].Width = 220;
                dgvAllOrderHistory.Columns[4].Width = 260;
            } catch { }
            
        }

        private void prvSearch()
        {

            if (txtSearch.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อความที่ต้องการค้นหา", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string sSqlSelect = " SELECT * FROM tb_order WHERE im_id+im_name+emp_id LIKE '%" + txtSearch.Text.Trim() + "%' ORDER BY im_id DESC;";

            if (bCheck == true)
            {
                dsOrder.Tables["tb_order"].Clear();
            }

            OleDbDataAdapter da = new OleDbDataAdapter(sSqlSelect, oCenter.conn);
            da.Fill(dsOrder, "tb_order");

            if (dsOrder.Tables["tb_order"].Rows.Count != 0)
            {
                bCheck = true;
                dgvAllOrderHistory.ReadOnly = true;
                dgvAllOrderHistory.DataSource = dsOrder.Tables["tb_order"];
            }
            else
            {
                bCheck = false;
            }
            dgvAllOrderHistory.Refresh();
            btnSearch.Enabled = false;

        }

        private void prvClearAll()
        {
            txtProName.Text = "";
            txtProID.Text = "";
            txtOderID.Text = "";
            txtQuantity.Text = "";
            txtProID.Text = "";
            txtSearch.Focus();
            dtpOrderDate.Value = DateTime.Now;
        }

        private void prvFillterDate()
        {

            //prvSearch();
            string sSqlLoad = "SELECT * FROM tb_order WHERE im_date Between " +
                                dtpFromDate.Value.ToString("#dd-MM-yyyy#") + " and " +
                                dtpToDate.Value.ToString("#dd-MM-yyyy#") + "";
            oCenter.pusvOpenConnection();
            OleDbDataAdapter da = new OleDbDataAdapter(sSqlLoad, oCenter.conn);

            da = new OleDbDataAdapter(sSqlLoad, oCenter.conn);
            da.Fill(dsOrder, "tb_order");

            if (bCheck == true)
            {
                dsOrder.Tables["tb_order"].Clear();
            }

            if (dsOrder.Tables["tb_order"].Rows.Count != 0)
            {
                bCheck = true;
                dgvAllOrderHistory.ReadOnly = true;
                dgvAllOrderHistory.DataSource = dsOrder.Tables["tb_order"];
            }
            else
            {
                bCheck = false;
            }
            dgvAllOrderHistory.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            prvSearch();
        }

        private void FrmOrderHistory_Load(object sender, EventArgs e)
        {
            prvShowAllOrder();
            prvFormatDataGrid();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {

                if (btnSearch.Enabled == true)
                {
                    prvSearch();
                }
                else
                {
                    prvShowAllOrder();
                    //txtSearch.Text = "";
                    btnSearch.Enabled = true;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            prvClearAll();
            prvShowAllOrder();
            txtSearch.Text = "";
            btnSearch.Enabled = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            prvFillterDate();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmReport Frm = new FrmReport();
            Frm.sReport = "AllOrder";
            Frm.rptOrder.SetDataSource(dsOrder);
            Frm.ShowDialog();
        }

        private void dgvAllOrderHistory_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == dgvAllOrderHistory.Rows.Count)
            {
                return;
            }
            try
            {
                txtOderID.Text = dgvAllOrderHistory.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtQuantity.Text = dgvAllOrderHistory.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpOrderDate.Value = Convert.ToDateTime(dgvAllOrderHistory.Rows[e.RowIndex].Cells[2].Value);
                txtCustomerID.Text = dgvAllOrderHistory.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtProID.Text = dgvAllOrderHistory.Rows[e.RowIndex].Cells[4].Value.ToString();
                
                string sSqlSelect = "select * from tb_product where pro_id='"+ txtProID.Text + "'";
                DataSet sds = new DataSet();
                sds = ocn.pudsLoadData(sSqlSelect, "tb_product", sds);
                if (sds.Tables["tb_product"].Rows.Count > 0)
                {
                    txtProName.Text = sds.Tables["tb_product"].Rows[0]["pro_name"].ToString();
                }

                oCenter.pusvCloseConnection();
                oCenter.pusvOpenConnection();

                string sSqlSelect2 = "select * from tb_customer where cus_id='" + txtCustomerID.Text + "'";
             
                sds = ocn.pudsLoadData(sSqlSelect2, "tb_customer", sds);
                if (sds.Tables["tb_customer"].Rows.Count > 0)
                {
                    txtCusName.Text = sds.Tables["tb_customer"].Rows[0]["cus_name"].ToString() + " " + sds.Tables["tb_customer"].Rows[0]["cus_lastname"].ToString();
                }



            }
            catch { }

           
        }
    }
}
