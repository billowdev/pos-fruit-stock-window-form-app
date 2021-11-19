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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        string sSql="";
        oCenter ocn = new oCenter();
        DataSet dsProduct = new DataSet();
        bool IsFind = false;
       
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            if (txtProID.Text == "")
            {
                // AutoID                     Field Name        Table Name Head  Last      
                txtProID.Text = ocn.pusAutoID("pro_id", "tb_product", "PID", "000"); // PID001
                txtUnit.Text = "กิโลกรัม";
                lbStockQuantity.Text = "0";
                txtProName.Focus();
            }
            dgvAllProduct.ReadOnly = true;
            prvShowAllProduct();
            prvFormatDataGrid();
        }

        // Method for show all product when form load to data grid view dgvAllProduct
        private void prvShowAllProduct()
        {
            IsFind = false;
            sSql = "select * from tb_product";
            dsProduct = ocn.pudsLoadData(sSql, "tb_product", dsProduct);

            if (IsFind == true)
            {
                dsProduct.Tables["tb_product"].Clear();
            }

            if (dsProduct.Tables["tb_product"].Rows.Count != 0)
            {
                IsFind = true;
                dgvAllProduct.ReadOnly = true;
                dgvAllProduct.DataSource = dsProduct.Tables["tb_product"];
            }
            else
            {
                IsFind = false;
            }
            
            // ----------------------------------------------------------------------------------- //
        }

        // Method for format datagridview
        private void prvFormatDataGrid()
        {
            dgvAllProduct.Update();
            dgvAllProduct.Refresh();

            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.Font = new Font("Ms Sans Serif", 10, FontStyle.Regular);
            dgvAllProduct.ColumnHeadersDefaultCellStyle = cs;
            dgvAllProduct.Columns[0].HeaderText = "รหัสสินค้า";
            dgvAllProduct.Columns[1].HeaderText = "ชื่อสินค้า";
            dgvAllProduct.Columns[2].HeaderText = "ราคาต่อหน่วย";
            dgvAllProduct.Columns[3].HeaderText = "หน่วย";
            dgvAllProduct.Columns[4].HeaderText = "จำนวน";
            dgvAllProduct.Columns[5].HeaderText = "หมายเลขนำเข้าล่าสุด";

            dgvAllProduct.Columns[0].Width = 140;
            dgvAllProduct.Columns[1].Width = 320;
            dgvAllProduct.Columns[2].Width = 160;
            dgvAllProduct.Columns[3].Width = 160;
            dgvAllProduct.Columns[4].Width = 160;
            dgvAllProduct.Columns[5].Width = 160;
        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvAllProduct_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.RowIndex == dgvAllProduct.Rows.Count)
            {
                return;
            }
            try
            {
                txtProID.Text = dgvAllProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtProName.Text = dgvAllProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtProPrice.Text = dgvAllProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                //cmbUnit.SelectedItem = dgvAllProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtUnit.Text = dgvAllProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                lbStockQuantity.Text = dgvAllProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            prvClearAll();
        }

        private void prvClearAll()
        {
            txtProID.Text = "";
            txtProName.Text = "";
            txtProPrice.Text = "";
            //cmbUnit.SelectedItem = "";
            txtUnit.Text = "กิโลกรัม";
            lbStockQuantity.Text = "0";
            // AutoID                     Field Name        Table Name Head  Last      
            txtProID.Text = ocn.pusAutoID("pro_id", "tb_product", "PID", "000"); // PID001
            txtProName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProID.Text == "")
            {
                MessageBox.Show("กรุณากรอกรหัสสินค้า", "Msg", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtProID.Focus();
                return;
            }
            if (txtProName.Text == "" || txtProPrice.Text == "" || txtUnit.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "Msg", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            string sSqlInsert = "";
            sSqlInsert = " INSERT INTO tb_product(pro_id,pro_name,pro_price,pro_unit,pro_quantity) VALUES(@id,@name,@price,@unit,@quantity)";
            oCenter.pusvCloseConnection();
            oCenter.pusvOpenConnection();
            OleDbCommand cmdInsert = new OleDbCommand();
            cmdInsert.Parameters.Clear();

            cmdInsert.Parameters.AddWithValue("@id", txtProID.Text.Trim().ToString());
            cmdInsert.Parameters.AddWithValue("@name", txtProName.Text.Trim().ToString());
            cmdInsert.Parameters.AddWithValue("@price", txtProPrice.Text.Trim().ToString());
            cmdInsert.Parameters.AddWithValue("@unit", txtUnit.Text.Trim().ToString());
            cmdInsert.Parameters.AddWithValue("@quantity", 0);
                                     // AutoID     Field Name  Table Name Head  Last      
            //string im_id = ocn.pusAutoID("im_id", "tb_import", "im", "000000"); // im000001
            //cmdInsert.Parameters.AddWithValue("@imid", im_id);

            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.CommandText = sSqlInsert;
            cmdInsert.Connection = oCenter.conn;
            cmdInsert.ExecuteNonQuery();

            prvClearAll();
            prvShowAllProduct();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProID.Text == "")
                {
                    MessageBox.Show("กรุณาเลือกข้อมูลที่จะลบ", "ผิดพลาด");
                    return;
                }
                String sqlDelProduct = "DELETE FROM tb_product WHERE pro_id='" + txtProID.Text + "'";
                oCenter.pusvOpenConnection();

                OleDbCommand comDelProduct = new OleDbCommand(sqlDelProduct, oCenter.conn);

                if (MessageBox.Show("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", "ยืนยัน",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    comDelProduct.ExecuteNonQuery();
                    MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "ผลการดำเนินการ");
                    prvClearAll();
                    prvShowAllProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error btnDelete_Click" + ex.Message.ToString(), "โปรดลองอีกครั้ง",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("คุณต้องการแก้ข้อมูลนี้ใช่หรือไม่", "ยืนยัน",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sqlEdit;

                    sqlEdit = " UPDATE tb_product SET pro_name='" + txtProName.Text
                        + "',pro_price='" + txtProPrice.Text
                        + "',pro_unit='" + txtUnit.Text
                        + "'WHERE pro_id='" + txtProID.Text + "'";

                    oCenter.pusvCloseConnection();
                    oCenter.pusvOpenConnection();
                    OleDbCommand cmdEdit = new OleDbCommand();
                    cmdEdit.CommandType = CommandType.Text;
                    cmdEdit.CommandText = sqlEdit;
                    cmdEdit.Connection = oCenter.conn;
                    cmdEdit.ExecuteNonQuery();

                    MessageBox.Show("แก้ไขข้อมูลเรียบร้อยแล้ว");
                    prvClearAll();
                    prvShowAllProduct();
                }


            } catch (Exception ex)
            {
                
                MessageBox.Show("Erro EDIT:" + ex.Message, "Msg", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            prvShowAllProduct();
            prvFormatDataGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool bCheck = false;

            if (txtSearch.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อความที่ต้องการค้นหา", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataSet dsSearchProduct = new DataSet();
            string sSqlSelect = " SELECT * FROM tb_product WHERE pro_id+pro_name+pro_unit+im_id LIKE '%" + txtSearch.Text.Trim() +"%' ORDER BY pro_id DESC;";

            if (bCheck == true)
            {
                dsSearchProduct.Tables["tb_product"].Clear();
            }

            OleDbDataAdapter da = new OleDbDataAdapter(sSqlSelect, oCenter.conn);
            da.Fill(dsSearchProduct, "tb_product");

            if (dsSearchProduct.Tables["tb_product"].Rows.Count != 0)
            {
                bCheck = true;
                dgvAllProduct.ReadOnly = true;
                dgvAllProduct.DataSource = dsSearchProduct.Tables["tb_product"];
            }
            else
            {
                bCheck = false;
            }
            dgvAllProduct.Refresh();
            btnSearch.Enabled = false;
        }

        private void btnSearchRefresh_Click(object sender, EventArgs e)
        {
            prvShowAllProduct();
            txtSearch.Text = "";
            btnSearch.Enabled = true;
        }
    }
}



