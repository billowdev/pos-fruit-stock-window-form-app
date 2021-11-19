using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Fruit_Stock.static_classes;

namespace Fruit_Stock
{
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }
        bool bCheck = false;
        string sSql;
        DataSet dsStock = new DataSet();
        oCenter ocn = new oCenter();

        private void FrmStock_Load(object sender, EventArgs e)
        {
            puvShowAllStock();
            puvFormatDataGrid();
            // AutoID                     Field Name   Table Name Head  Last      
            txtProIMID.Text = ocn.pusAutoID("im_id", "tb_import", "im", "000000"); // im000001

        }
        public void puvShowAllStock()
        {
            bCheck = false;
            sSql = "select * from tb_import";
            dsStock = ocn.pudsLoadData(sSql, "tb_import", dsStock );

            if (bCheck == true)
            {
                dsStock .Tables["tb_import"].Clear();
            }

            if (dsStock .Tables["tb_import"].Rows.Count != 0)
            {
                bCheck = true;
                dgvAllStock.ReadOnly = true;
                dgvAllStock.DataSource = dsStock .Tables["tb_import"];
            }
            else
            {
                bCheck = false;
            }
        }

        public void puvClearAll()
        {
            txtProID.Text = "";
            txtProName.Text = "";
            txtProUnit.Text = "";
            // AutoID                     Field Name   Table Name Head  Last      
            txtProIMID.Text = ocn.pusAutoID("im_id", "tb_import", "im", "000000"); // im000001

            txtProQuantity.Text = "";
            txtProQuantity.Focus();
            dtpProImport.Value = Convert.ToDateTime(DateTime.Now.ToString("dd.MM.yyyy"));

        }

        private void puvFormatDataGrid()
        {
            try
            {
                DataGridViewCellStyle cs = new DataGridViewCellStyle();
                cs.Font = new Font("Ms Sans Serif", 10, FontStyle.Regular);
                dgvAllStock.ColumnHeadersDefaultCellStyle = cs;
                dgvAllStock.Columns[0].HeaderText = "รหัสการนำเข้า";
                dgvAllStock.Columns[1].HeaderText = "ชื่อสินค้า";
                dgvAllStock.Columns[2].HeaderText = "จำนวน";
                dgvAllStock.Columns[3].HeaderText = "วันที่";
                dgvAllStock.Columns[4].HeaderText = "รหัสพนักงาน";

                dgvAllStock.Columns[0].Width = 110;
                dgvAllStock.Columns[1].Width = 300;
                dgvAllStock.Columns[2].Width = 100;
                dgvAllStock.Columns[3].Width = 160;
                dgvAllStock.Columns[4].Width = 110;
            }
            catch
            {

            }
            
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmListProduct Frm = new FrmListProduct();
            Frm.ShowDialog();
            //Frm.psPid = txtProID.Text;
            //Frm.psPname = txtProName.Text;
            //Frm.psPunit = txtProUnit.Text;
            if (Frm.psPid != "")
            {
                txtProID.Text = Frm.psPid;
                txtProName.Text = Frm.psPname;
                txtProUnit.Text = Frm.psPunit;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (txtProID.Text == "" || txtProName.Text == "" || txtProUnit.Text == "")
            {
                MessageBox.Show("กรุณาเลือกข้อมูลสินค้า", "Msg", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (txtProIMID.Text == "")
            {
                MessageBox.Show("กรุณากรอกรหัสการนำเข้าสินค้า", "Msg", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtProID.Focus();
                return;
            }
            if (txtProQuantity.Text == "")
            {
                MessageBox.Show("กรุณากรอกจำนวนสินค้าที่นำเข้า", "Msg", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            oCenter.pusvCloseConnection();
            oCenter.pusvOpenConnection();

            // ============================================== Insert to tb_import ========================= //
            OleDbCommand cmdInsert = new OleDbCommand();
            sSql = " INSERT INTO tb_import(im_id,im_name,im_quantity,im_date,emp_id) VALUES(@id,@name,@quantity,@date,@empid)";
            cmdInsert.Parameters.Clear();

            cmdInsert.Parameters.AddWithValue("@id", txtProIMID.Text.Trim().ToString());
            cmdInsert.Parameters.AddWithValue("@name", txtProName.Text.Trim().ToString());
            cmdInsert.Parameters.AddWithValue("@quantity", txtProQuantity.Text.Trim().ToString());
            cmdInsert.Parameters.AddWithValue("@date", dtpProImport.Value.GetDateTimeFormats('d')[0]);
            cmdInsert.Parameters.AddWithValue("@empid", oCenter.currentid);
          

            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.CommandText = sSql;
            cmdInsert.Connection = oCenter.conn;
            cmdInsert.ExecuteNonQuery();
            // ============================================== END Insert to tb_import ========================= //

            // ============= Select All From tb_product Where Proid = txtProID.Text ========================= //
            oCenter.pusvCloseConnection();
            oCenter.pusvOpenConnection();
            OleDbCommand cmdSelect = new OleDbCommand();
            DataSet dsProduct = new DataSet();
            sSql = " SELECT * FROM tb_product WHERE pro_id='" + txtProID.Text +"'";

            dsProduct = ocn.pudsLoadData(sSql, "tb_product", dsProduct);
            int previousQty = 0;

            if (dsProduct.Tables["tb_product"].Rows.Count != 0)
            {
                previousQty = Convert.ToInt32(dsProduct.Tables["tb_product"].Rows[0]["pro_quantity"].ToString());
                
            }
            // ============= END Select All From tb_product Where Proid = txtProID.Text ========================= //


            // ============= Update Quantity at tb_product after import ========================= //
            oCenter.pusvCloseConnection();
            oCenter.pusvOpenConnection();

            OleDbCommand cmdUpdate = new OleDbCommand();
            DataSet dsUpdate = new DataSet();
            sSql = " UPDATE * FROM tb_product WHERE pro_id=@id";
            cmdUpdate.Parameters.Clear();
            cmdUpdate.Parameters.AddWithValue("@id", txtProID.Text.Trim().ToString());

            int importQty = Convert.ToInt32(txtProQuantity.Text);
            int presentQty = importQty + previousQty;

            sSql = " UPDATE tb_product SET pro_quantity=@updateQty, im_id=@imid WHERE pro_id=@pro_id";
            cmdUpdate.Parameters.Clear();
            cmdUpdate.Parameters.AddWithValue("@updateQty", presentQty);
            cmdUpdate.Parameters.AddWithValue("@imid", txtProIMID.Text.Trim().ToString());
            cmdUpdate.Parameters.AddWithValue("@pro_id", txtProID.Text.Trim().ToString());

            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.CommandText = sSql;
            cmdUpdate.Connection = oCenter.conn;
            cmdUpdate.ExecuteNonQuery();

            puvShowAllStock();
            puvClearAll();
            

            // =============  END Update Quantity at tb_product after import ========================= //
        }

        private void btnHistoryStock_Click(object sender, EventArgs e)
        {
            FrmHistoryStock Frm = new FrmHistoryStock();
            Frm.MdiParent = this;
            Frm.Show();
        }
    }
}
