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
using System.Data;

namespace Fruit_Stock
{
    public partial class FrmHistoryStockReport : Form
    {
        public FrmHistoryStockReport()
        {
            InitializeComponent();
        }
        oCenter ocn = new oCenter();
        bool bCheck = false;
        string sSql;
        DataSet dsStock = new DataSet();
        DataSet dsSearchStock = new DataSet();
        OleDbDataAdapter daLoad;

        private void prvShowAllStock()
        {
            bCheck = false;
            sSql = "select * from tb_import";
            dsStock = ocn.pudsLoadData(sSql, "tb_import", dsStock);

            if (bCheck == true)
            {
                dsStock.Tables["tb_import"].Clear();
            }

            if (dsStock.Tables["tb_import"].Rows.Count != 0)
            {
                bCheck = true;
                dgvAllHistoryStock.ReadOnly = true;
                dgvAllHistoryStock.DataSource = dsStock.Tables["tb_import"];
            }
            else
            {
                bCheck = false;
            }
        }

        private void prvFormatDataGrid()
        {
            try
            {
                dgvAllHistoryStock.Update();
                dgvAllHistoryStock.Refresh();
                DataGridViewCellStyle cs = new DataGridViewCellStyle();
                cs.Font = new Font("Ms Sans Serif", 12, FontStyle.Regular);
                dgvAllHistoryStock.ColumnHeadersDefaultCellStyle = cs;
                dgvAllHistoryStock.Columns[0].HeaderText = "รหัสการนำเข้า";
                dgvAllHistoryStock.Columns[1].HeaderText = "ชื่อสินค้า";
                dgvAllHistoryStock.Columns[2].HeaderText = "จำนวน";
                dgvAllHistoryStock.Columns[3].HeaderText = "วันที่";
                dgvAllHistoryStock.Columns[4].HeaderText = "รหัสพนักงาน";

                dgvAllHistoryStock.Columns[0].Width = 160;
                dgvAllHistoryStock.Columns[1].Width = 400;
                dgvAllHistoryStock.Columns[2].Width = 240;
                dgvAllHistoryStock.Columns[3].Width = 240;
                dgvAllHistoryStock.Columns[4].Width = 160;
            }
            catch
            {

            }

        }

        private void FrmHistoryStockReport_Load(object sender, EventArgs e)
        {
            //prvShowAllStock();
            prvFormatDataGrid();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            bool IsFind = false;

            //prvSearch();
            

            DataSet dsHistoryStock = new DataSet();

            //string sSqlLoad = "select * from tb_import where im_id between #" + dtpFromDate.Value.ToString("d") + "# and #" + dtpToDate.Value.ToString("d") + "#";
            string sSqlLoad = "SELECT * FROM tb_import WHERE im_id Between @FromDate and @ToDate";
            oCenter.pusvOpenConnection();
            OleDbDataAdapter da = new OleDbDataAdapter(sSqlLoad, oCenter.conn);
            da.SelectCommand.Parameters.AddWithValue("@FromDate", dtpFromDate.Value);
            da.SelectCommand.Parameters.AddWithValue("@ToDate", dtpToDate.Value);
            da.Fill(dsHistoryStock);
            oCenter.pusvCloseConnection();
            dgvAllHistoryStock.DataSource = dsHistoryStock;
            //MessageBox.Show(sSqlLoad);

            //daLoad = new OleDbDataAdapter(sSqlLoad, oCenter.conn);
            //daLoad.Fill(dsHistoryStock, "tb_import");

            //if (IsFind == true)
            //{
            //    dsHistoryStock.Tables["tb_import"].Clear();
            //}

            //if (dsStock.Tables["tb_import"].Rows.Count != 0)
            //{
            //    IsFind = true;
            //    dgvAllHistoryStock.ReadOnly = true;
            //    dgvAllHistoryStock.DataSource = dsHistoryStock.Tables["tb_import"];
            //}
            //else
            //{
            //    IsFind = false;
            //}
            //dgvAllHistoryStock.Refresh();

        }

        private void prvSearch()
        {
            
            bool bCheck = false;

            //string sSqlSelect = " SELECT * FROM tb_import WHERE im_id+im_name+emp_id LIKE '%" + txtSearch.Text.Trim() + "%' ORDER BY im_id DESC;";

            //string sSqlSelect = " SELECT * FROM tb_import WHERE im_date BETWEEN " +
            //    dtpFromDate.Value.ToString("dd/MM/yyyy") + " AND " + dtpToDate.Value.ToString("dd/MM/yyyy");

            string sSqlSelect = " SELECT * FROM tb_import WHERE im_date BETWEEN '" + dtpFromDate.Value + "' AND '" + dtpToDate.Value + "'";



            if (bCheck == true)
            {
                dsSearchStock.Tables["tb_import"].Clear();
            }

            OleDbDataAdapter da = new OleDbDataAdapter(sSqlSelect, oCenter.conn);
            da.Fill(dsSearchStock, "tb_import");

            if (dsSearchStock.Tables["tb_import"].Rows.Count != 0)
            {
                bCheck = true;
                dgvAllHistoryStock.ReadOnly = true;
                dgvAllHistoryStock.DataSource = dsSearchStock.Tables["tb_import"];
            }
            else
            {
                bCheck = false;
            }
            dgvAllHistoryStock.Refresh();

        }

    }
}
