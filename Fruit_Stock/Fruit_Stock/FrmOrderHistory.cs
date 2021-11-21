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
    public partial class FrmOrderHistory : Form
    {
        public FrmOrderHistory()
        {
            InitializeComponent();
        }
        DataGridView dgvPublic;
        DataGridView dgvBill;
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
            dgvAllOrder.Columns[2].HeaderText = "วันที่สั่งซื้อ";
            dgvAllOrder.Columns[3].HeaderText = "รหัสลูกค้า";
            dgvAllOrder.Columns[4].HeaderText = "รหัสสินค้า";

            dgvAllOrder.Columns[0].Width = 180;
            dgvAllOrder.Columns[1].Width = 180;
            dgvAllOrder.Columns[2].Width = 180;
            dgvAllOrder.Columns[3].Width = 220;
            dgvAllOrder.Columns[4].Width = 180;
        }
    }
}
