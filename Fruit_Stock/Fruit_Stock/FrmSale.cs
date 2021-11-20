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
    public partial class FrmSale : Form
    {
        public FrmSale()
        {
            InitializeComponent();
        }
        oCenter ocn = new oCenter();
        double dCash = 0;
        double dChange = 0;
        DataGridView dgvPublic;
        string sSql = "";
        int nCurrentRow;

        private void prvClear()
        {
            txtOrderID.Text = "";
            txtDiscount.Text = "";
            lbPrice.Text = "";
            lbTotal.Text = "";

            txtOrderID.Text = ocn.pusAutoID("pro_id", "tb_order", "O" + DateTime.Now.Date.ToString("MMyy"), "00000"); // PID001


        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            prvOpenListProduct();
        }

        private void prvOpenListProduct()
        {
            dgvPublic = dgvShow;
            FrmListStockProduct frm = new FrmListStockProduct();
            frm.pnCurrentRow = nCurrentRow;
            frm.pdgvPublic = dgvPublic;
            frm.ShowDialog(this);
            btnBrowse.Visible = false;
            if (dgvShow.Rows[nCurrentRow].Cells[0].Value.ToString().Trim() != "")
            {
                if (prvShowPrice(dgvShow.Rows[nCurrentRow].Cells[0].Value.ToString().Trim(), nCurrentRow) == "")
                {
                    MessageBox.Show("No Cost product", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvShow.Rows.RemoveAt(nCurrentRow);
                    return;
                }

                dgvShow.Rows[nCurrentRow].DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
                dgvShow.Rows[nCurrentRow].DefaultCellStyle.SelectionForeColor = Color.Maroon;
                dgvShow.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dgvShow.CurrentCell = dgvShow.Rows[nCurrentRow].Cells[3];
                dgvShow.Focus();
            }
        }

        private string prvShowPrice(string _sSendpro_id, int _nRow)
        {
            string sCheck = "";
            DataSet ds = new DataSet();
            sSql = " SELECT (SELECT TOP 1 pro_price FROM tb_product WHERE pro_id=tb_product.pro_id) AS Cost " +
                " FROM tb_product WHERE pro_id='" + _sSendpro_id + "'";
            ds = ocn.pudsLoadData(sSql, "tb_product", ds);
            if (ds.Tables["tb_product"].Rows.Count != 0)
            {
                sCheck = ds.Tables["tb_product"].Rows[0]["pro_price"].ToString();
                dgvShow.Rows[_nRow].Cells[4].Value = sCheck;
            }

            return sCheck;

        }

        private void prvSum()
        {
            lbPrice.Text = "0.00";
            lbTotal.Text = "0.00";

            double dAmount = 0;
            for (int nRow = 0; nRow < dgvShow.Rows.Count; nRow++)
            {
                if (dgvShow.Rows[nRow].Cells[5].Value.ToString().Trim() != "")
                {
                    dAmount += Convert.ToDouble(dgvShow.Rows[nRow].Cells[5].Value.ToString().Trim());
                }
                lbTotal.Text = dAmount.ToString("#,##0.00");
                double dTotal = 0;
                double dDiscount = 0;

                if (txtDiscount.Text.Trim() != "")
                {
                    dDiscount = Convert.ToDouble(txtDiscount.Text.Trim());
                }

                dTotal = dAmount - dDiscount;
                lbTotal.Text = dTotal.ToString("#,##0.00");
            }

        }
        // Method Update Stock
        private void prvUpdateStock()
        {
            for (int nRow = 0; nRow < dgvShow.Rows.Count; nRow++)
            {
                ocn.puvUpdateStock(dgvShow.Rows[nRow].Cells[0].Value.ToString(),
                    Convert.ToDouble(dgvShow.Rows[nRow].Cells[3].Value.ToString()), false);
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(lbTotal.Text.Trim()) <= 0.00)
            {
                MessageBox.Show("sum cost it will not 0.00", "Msg", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (dgvShow.Rows.Count <= 0)
            {
                MessageBox.Show("Please Select Product", "Msg", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            for (int nRow = 0; nRow < dgvShow.Rows.Count; nRow++)
            {
                if (dgvShow.Rows[nRow].Cells[0].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("Input Data No Successs", "Msg", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (dgvShow.Rows[nRow].Cells[1].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("Input Data No Successs", "Msg", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (dgvShow.Rows[nRow].Cells[2].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("Input Data No Successs", "Msg", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (dgvShow.Rows[nRow].Cells[3].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("Input Data No Successs", "Msg", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (dgvShow.Rows[nRow].Cells[4].Value.ToString().Trim() == "")
                {
                    MessageBox.Show("Input Data No Successs", "Msg", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (Convert.ToDouble(dgvShow.Rows[nRow].Cells[3].Value.ToString().Trim()) <= 0.00)
                {
                    MessageBox.Show("Input Quantity >= 0", "Msg", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    dgvShow.SelectionMode = DataGridViewSelectionMode.CellSelect;
                    dgvShow.CurrentCell = dgvShow.Rows[nRow].Cells[3];
                    dgvShow.Focus();
                    return;
                }

                if (Convert.ToDouble(dgvShow.Rows[nRow].Cells[5].Value.ToString().Trim()) <= 0.00)
                {
                    MessageBox.Show("Sum Cost >= 0", "Msg", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    dgvShow.SelectionMode = DataGridViewSelectionMode.CellSelect;
                    dgvShow.CurrentCell = dgvShow.Rows[nRow].Cells[5];
                    dgvShow.Focus();
                    return;
                }

                DataSet dsCheckStock = new DataSet();
                sSql = " SELECT * FROM tb_product WHERE pro_id='" + dgvShow.Rows[nRow].Cells[0].Value.ToString() + "'";
                dsCheckStock = ocn.pudsLoadData(sSql, "tb_product", dsCheckStock);
                if (dsCheckStock.Tables["tb_product"].Rows.Count != 0)
                {
                    // check ว่าขายเกินไหม
                    if (Convert.ToDouble(dgvShow.Rows[nRow].Cells[3].Value.ToString()) >
                        Convert.ToDouble(dsCheckStock.Tables["tb_product"].Rows[0]["pro_quantity"].ToString()))
                    {
                        MessageBox.Show("Can't Sale this Product ID: " + dgvShow.Rows[nRow].Cells[0].Value.ToString(), "Msg",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(" The product is not in stock Product ID:  " + dgvShow.Rows[nRow].Cells[0].ToString(), "msg",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // ====================================
                    // Check Bill
                    if (txtDiscount.Text == "")
                    {
                        txtDiscount.Text = "0.00";
                    }

                    dCash = 0;
                    dChange = 0;

                    FrmCheckBill Frm = new FrmCheckBill();
                    Frm.pdTotal = Convert.ToDouble(lbTotal.Text);
                    Frm.ShowDialog();
                    dCash = Frm.pdCash;
                    dChange = Frm.pdChange;

                    // ====================================
                    DataSet ds = new DataSet();
                    sSql = " SELECT * FROM tb_order";

                    ds = ocn.pudsLoadData(sSql, "tb_order", ds);
                    if (ds.Tables["tb_order"].Rows.Count <= 0)
                    {
                        DataRow dr = ds.Tables["tb_order"].NewRow();
                        dr["order_id"] = txtOrderID.Text;
                        dr["DocDate"] = DateTime.Now.ToString("dd/MM/yyyy");
                        dr["Price"] = Convert.ToDouble(lbPrice.Text);
                        dr["Discount"] = Convert.ToDouble(txtDiscount.Text);
                        dr["Total"] = Convert.ToDouble(lbTotal.Text);

                        ds.Tables["tb_order"].Rows.Add(dr);

                        oCenter.da.Update(ds, "tb_order");
                    }

                    string sDelete = " DELETE FROM SaleSub WHERE DocNo='" + txtOrderID.Text + "'";
                    ocn.pubActionData(sDelete);

                    for (int nSale = 0; nSale < dgvShow.Rows.Count; nSale++)
                    {
                        DataSet dsAddSub = new DataSet();
                        sSql = " SELECT * FROM tb_orderSub WHERE ID=0";

                        dsAddSub = ocn.pudsLoadData(sSql, "tb_orderSub", dsAddSub);
                        if (dsAddSub.Tables["tb_orderSub"].Rows.Count <= 0)
                        {
                            DataRow dr = dsAddSub.Tables["tb_orderSub"].NewRow();
                            dr["DocNo"] = txtOrderID.Text;
                            dr["DocDate"] = DateTime.Now.ToString("dd/MM/yyyy");
                            dr["pro_id"] = dgvShow.Rows[nSale].Cells[0].Value.ToString();
                            dr["Name"] = dgvShow.Rows[nSale].Cells[1].Value.ToString();
                            dr["Unit"] = dgvShow.Rows[nSale].Cells[2].Value.ToString();
                            dr["Quantity"] = Convert.ToDouble(dgvShow.Rows[nSale].Cells[3].Value.ToString());
                            dr["Agv"] = Convert.ToDouble(dgvShow.Rows[nSale].Cells[4].Value.ToString());
                            dr["Total"] = Convert.ToDouble(dgvShow.Rows[nSale].Cells[5].Value.ToString());

                            dsAddSub.Tables["tb_orderSub"].Rows.Add(dr);
                            oCenter.da.Update(dsAddSub, "tb_orderSub");
                        }
                    }
                    prvUpdateStock();
                    printDoc.Print();
                    prvClear();

                }
            }
        }

        private void dgvShow_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dgvShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dgvShow.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
            {
                DataGridViewCell oCell = dgvShow.CurrentCell;
                Rectangle oRect = dgvShow.GetCellDisplayRectangle(oCell.ColumnIndex, oCell.RowIndex, true);
                btnBrowse.Top = oRect.Top + dgvShow.Top;
                btnBrowse.Height = oRect.Height;
                btnBrowse.Left = dgvShow.Left + (dgvShow.Columns[0].Width - btnBrowse.Width);
                btnBrowse.Visible = true;
                btnBrowse.Focus();
                e.Cancel = true;

            }
        }

        private void dgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                dgvShow.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
                dgvShow.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Maroon;
                nCurrentRow = e.RowIndex;

            }
        }

        private void dgvShow_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && ((e.ColumnIndex == 3)))
            {
                if (dgvShow.Rows[e.RowIndex].Cells[3].Value.ToString().Trim() == "")
                {
                    dgvShow.Rows[e.RowIndex].Cells[3].Value = 0;
                }
                if (dgvShow.Rows[e.RowIndex].Cells[4].Value.ToString().Trim() == "")
                {
                    dgvShow.Rows[e.RowIndex].Cells[4].Value = 0;
                }
                dgvShow.Rows[e.RowIndex].Cells[5].Value = (Convert.ToDouble(dgvShow.Rows[e.RowIndex].Cells[3].Value.ToString())
                    * Convert.ToDouble(dgvShow.Rows[e.RowIndex].Cells[4].Value.ToString())).ToString("#,##0.00");
                prvSum();
                dgvShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvShow.Rows[e.RowIndex].Selected = true;
                dgvShow.Focus();
            }
        }

        private void dgvShow_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.RowIndex >= 0) && e.ColumnIndex >= 0)
            {
                switch (e.ColumnIndex)
                {
                    case 3:
                    case 4:
                    case 5:
                        e.CellStyle.Format = "#,##0.00";
                        break;
                }
            }
        }

        private void dgvShow_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.RowIndex >= 0 && e.ColumnIndex >= 0))
            {
                DataGridViewCell oCell = dgvShow.CurrentCell;
                Rectangle oRect = dgvShow.GetCellDisplayRectangle(oCell.ColumnIndex, oCell.RowIndex, true);
                btnBrowse.Top = oRect.Top + dgvShow.Top;
                btnBrowse.Height = oRect.Height;
                btnBrowse.Left = dgvShow.Left + (dgvShow.Columns[0].Width - btnBrowse.Width);
                btnBrowse.Visible = true;
                btnBrowse.Focus();

            }
            else
            {
                btnBrowse.Visible = false;
            }
        }

        private void dgvShow_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.RowIndex >= 0 && e.ColumnIndex >= 0))
            {
                DataGridViewCell oCell = dgvShow.CurrentCell;
                Rectangle oRect = dgvShow.GetCellDisplayRectangle(oCell.ColumnIndex, oCell.RowIndex, true);
                if (e.ColumnIndex == 0)
                {
                    btnBrowse.Top = oRect.Top + dgvShow.Top;
                    btnBrowse.Height = oRect.Height;
                    btnBrowse.Left = dgvShow.Left + (dgvShow.Columns[0].Width - btnBrowse.Width);
                    btnBrowse.Visible = true;
                    btnBrowse.Focus();
                }
                else if (e.ColumnIndex == 3)
                {
                    dgvShow.SelectionMode = DataGridViewSelectionMode.CellSelect;
                }
                else
                {
                    btnBrowse.Visible = false;
                    dgvShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                prvSum();
                txtDiscount.Text = Convert.ToDouble(txtDiscount.Text).ToString("#,##0.00");
            }
        }

        private void mnuAdd_Click(object sender, EventArgs e)
        {
            dgvShow.Rows.Add();
            dgvShow.Rows[dgvShow.Rows.Count - 1].Cells[0].Value = "";
            dgvShow.Rows[dgvShow.Rows.Count - 1].Cells[1].Value = "";
            dgvShow.Rows[dgvShow.Rows.Count - 1].Cells[2].Value = "";
            dgvShow.Rows[dgvShow.Rows.Count - 1].Cells[3].Value = "";
            dgvShow.Rows[dgvShow.Rows.Count - 1].Cells[4].Value = "";
            dgvShow.Rows[dgvShow.Rows.Count - 1].Cells[5].Value = "";

            dgvShow.FirstDisplayedScrollingColumnIndex = dgvShow.Rows.Count - 1;
            nCurrentRow = dgvShow.Rows.Count - 1;
            prvOpenListProduct();
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (((nCurrentRow > -1) && (nCurrentRow < dgvShow.Rows.Count)) &&
               MessageBox.Show("Are you sure to Delete ?", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            dgvShow.Rows.RemoveAt(nCurrentRow);
            dgvShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            prvSum();
            btnBrowse.Visible = false;
            if (nCurrentRow < dgvShow.Rows.Count)
            {
                dgvShow.Rows[nCurrentRow].Selected = true;
            }
            else if (dgvShow.Rows.Count > 0)
            {
                nCurrentRow = dgvShow.Rows.Count - 1;
                dgvShow.Rows[nCurrentRow].Selected = true;
            }
        }

        private void FrmSale_Load(object sender, EventArgs e)
        {
            prvClear();
        }
    }
}
