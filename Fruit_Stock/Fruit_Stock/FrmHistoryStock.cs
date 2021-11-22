﻿using System;
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
    public partial class FrmHistoryStock : Form
    {
        public FrmHistoryStock()
        {
            InitializeComponent();
        }
        oCenter ocn = new oCenter();
        bool bCheck = false;
        string sSql;
        DataSet dsStock = new DataSet();
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
                dgvAllStock.ReadOnly = true;
                dgvAllStock.DataSource = dsStock.Tables["tb_import"];
            }
            else
            {
                bCheck = false;
            }
        }


        private void prvClearAll()
        {

            txtProQuantity.Text = "";
            txtProQuantity.Focus();
            dtpProImport.Value = Convert.ToDateTime(DateTime.Now.ToString("dd.MM.yyyy"));

        }

        private void prvFormatDataGrid()
        {
            try
            {
                dgvAllStock.Update();
                dgvAllStock.Refresh();
                DataGridViewCellStyle cs = new DataGridViewCellStyle();
                cs.Font = new Font("Ms Sans Serif", 10, FontStyle.Regular);
                dgvAllStock.ColumnHeadersDefaultCellStyle = cs;
                dgvAllStock.Columns[0].HeaderText = "รหัสการนำเข้า";
                dgvAllStock.Columns[1].HeaderText = "ชื่อสินค้า";
                dgvAllStock.Columns[2].HeaderText = "จำนวน";
                dgvAllStock.Columns[3].HeaderText = "วันที่";
                dgvAllStock.Columns[4].HeaderText = "รหัสพนักงาน";

                dgvAllStock.Columns[0].Width = 220;
                dgvAllStock.Columns[1].Width = 500;
                dgvAllStock.Columns[2].Width = 240;
                dgvAllStock.Columns[3].Width = 260;
                dgvAllStock.Columns[4].Width = 220;
            }
            catch
            {

            }

        }

        private void FrmHistoryStock_Load(object sender, EventArgs e)
        {
            prvShowAllStock();
            prvFormatDataGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            prvSearch();
        }
        private void prvSearch()
        {
            bool bCheck = false;

            if (txtSearch.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อความที่ต้องการค้นหา", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataSet dsSearchStock = new DataSet();
            string sSqlSelect = " SELECT * FROM tb_import WHERE im_id+im_name+emp_id LIKE '%" + txtSearch.Text.Trim() + "%' ORDER BY im_id DESC;";

            if (bCheck == true)
            {
                dsSearchStock.Tables["tb_import"].Clear();
            }

            OleDbDataAdapter da = new OleDbDataAdapter(sSqlSelect, oCenter.conn);
            da.Fill(dsSearchStock, "tb_import");

            if (dsSearchStock.Tables["tb_import"].Rows.Count != 0)
            {
                bCheck = true;
                dgvAllStock.ReadOnly = true;
                dgvAllStock.DataSource = dsSearchStock.Tables["tb_import"];
            }
            else
            {
                bCheck = false;
            }
            dgvAllStock.Refresh();
            btnSearch.Enabled = false;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            prvShowAllStock();
            txtSearch.Text = "";
            btnSearch.Enabled = true;
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
                    prvShowAllStock();
                    //txtSearch.Text = "";
                    btnSearch.Enabled = true;
                }
            }
        }

        private void dgvAllStock_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == dgvAllStock.Rows.Count)
            {
                return;
            }
            try
            {
                txtProIMID.Text = dgvAllStock.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtProName.Text = dgvAllStock.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtProQuantity.Text = dgvAllStock.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpProImport.Value = Convert.ToDateTime(dgvAllStock.Rows[e.RowIndex].Cells[3].Value);
                txtEMPID.Text = dgvAllStock.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {

            }

            // ==================================== Get Employee Data ====================================================== //
            
            //oCenter ocn = new oCenter();
            DataSet dsEmp = new DataSet();

            string sSqlSelect = "select * from tb_employee WHERE emp_id='" + txtEMPID.Text + "'";
            dsEmp = ocn.pudsLoadData(sSqlSelect, "tb_employee", dsEmp);

            if (dsEmp.Tables["tb_employee"].Rows.Count != 0)
            {

               txtEMPName.Text = dsEmp.Tables["tb_employee"].Rows[0]["emp_name"].ToString() + " " + 
                                dsEmp.Tables["tb_employee"].Rows[0]["emp_lastname"].ToString();

            }
            // ======================================== End  Get tb_ogin Data ================================================== //
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmHistoryStockFilter Frm = new FrmHistoryStockFilter();
            Frm.ShowDialog();

            //FrmReportHistoryStock Frm = new FrmReportHistoryStock();
            //Frm.ShowDialog();
        }
    }
    }

