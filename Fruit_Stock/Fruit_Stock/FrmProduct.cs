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

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            puvShowAllProduct();
            puvFormatDataGrid();
        }

        // Method for show all product when form load to data grid view dgvAllProduct
        private void puvShowAllProduct()
        {
             sSql = "select * from tb_product";

            // ------------------------------------------------------- //
            DataSet ds = new DataSet();
            oCenter.da = new OleDbDataAdapter(sSql, oCenter.conn);

            bool bCheck = false;

            if (bCheck == true)
            {
                ds.Tables["tb_product"].Clear();
            }

            //daLogin = new OleDbDataAdapter();
            oCenter.da.Fill(ds, "tb_product");

            if (ds.Tables["tb_product"].Rows.Count != 0)
            {
                bCheck = true;
                dgvAllProduct.ReadOnly = true;
                dgvAllProduct.DataSource = ds.Tables["tb_product"];
            }
            else
            {
                bCheck = false;
            }
        }

        // Method for format datagridview
        private void puvFormatDataGrid()
        {
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
            dgvAllProduct.Columns[2].Width = 220;
            dgvAllProduct.Columns[3].Width = 160;
            dgvAllProduct.Columns[4].Width = 220;
            dgvAllProduct.Columns[5].Width = 160;
        }
    }
}
