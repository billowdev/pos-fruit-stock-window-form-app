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
    public partial class FrmListStockProduct : Form
    {
        public FrmListStockProduct()
        {
            InitializeComponent();
        }
        oCenter ocn = new oCenter();
        string sProID, sProName, sProPrice, sProUnit, sProQuantity;
        public string psPid, psPname, psPprice, psPunit, psPquantity;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sSql = " SELECT * FROM tb_product WHERE pro_id+pro_name+pro_unit LIKE '%" + txtSearch.Text + "%' pro_quantity<>0 ORDER BY pro_id DESC;";
        }

        private void FrmListStockProduct_Load(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            prvShowData();
        }

        public DataGridView pdgvPublic; // for call at other from
        public int pnCurrentRow; // public current row

        private void lsvShow_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int nI = 0; nI < pdgvPublic.Rows.Count; nI++)
            {
                if ((pdgvPublic.Rows[nI].Cells[0].Value.ToString() != "") &&
                        (pdgvPublic.Rows[nI].Cells[0].Value.ToString() == lsvShow.SelectedItems[0].SubItems[0].Text))
                {
                    MessageBox.Show("Product is already exit! \n Select other!!", "msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
          
            psPid = lsvShow.SelectedItems[0].SubItems[0].Text;
            psPname = lsvShow.SelectedItems[0].SubItems[1].Text;
            psPprice = lsvShow.SelectedItems[0].SubItems[2].Text;
            psPunit = lsvShow.SelectedItems[0].SubItems[3].Text;
            psPquantity = lsvShow.SelectedItems[0].SubItems[4].Text;


            if (lsvShow.SelectedItems[0].SubItems[0].Text != "")
            {
                this.Close();
            }
        }

        private void prvShowData()
        {

            lsvShow.Items.Clear();
            string sSql = "";

            if (txtSearch.Text.Trim() == "")
            {
                sSql = " SELECT * FROM tb_product ORDER BY pro_id DESC;";
            }
            else
            {
                sSql = " SELECT * FROM tb_product WHERE pro_id+pro_name+pro_unit LIKE '%" + txtSearch.Text + "%' AND ORDER BY pro_id DESC;";
            }
            DataSet ds = new DataSet();
            ds = ocn.pudsLoadData(sSql, "tb_product", ds);

            if (ds.Tables["tb_product"].Rows.Count != 0)
            {
                sProID = "";
                sProName = "";
                sProPrice = "";
                sProUnit = "";
                sProQuantity = "";

                for (int nRow = 0; nRow < ds.Tables["tb_product"].Rows.Count; nRow++)
                {
                    sProID = ds.Tables["tb_product"].Rows[nRow]["pro_id"].ToString();
                    sProName = ds.Tables["tb_product"].Rows[nRow]["pro_name"].ToString();
                    sProPrice = Convert.ToDouble(ds.Tables["tb_product"].Rows[nRow]["pro_price"].ToString()).ToString("#,##0.00");
                    sProUnit = ds.Tables["tb_product"].Rows[nRow]["pro_unit"].ToString();
                    sProQuantity = ds.Tables["tb_product"].Rows[nRow]["pro_quantity"].ToString();

                    prvAddItem(sProID, sProName, sProPrice, sProUnit, sProQuantity);
                }
            }
            txtSearch.Text = "";
            //-----------------------------------------------------
           
            
        }

        private void prvAddItem(string _sPid, string _sPName, string _sPPrice, string _sPUnit, string _sPQuantity)
        {
            // item pid
            ListViewItem oItem = new ListViewItem();
            oItem.Text = _sPid;
            // sub item 
            ListViewItem.ListViewSubItem oItemSub = new ListViewItem.ListViewSubItem();
            // name
            oItemSub.Text = _sPName;
            oItem.SubItems.Add(oItemSub);

            // Price
            oItemSub = new ListViewItem.ListViewSubItem();
            oItemSub.Text = _sPPrice;
            oItem.SubItems.Add(oItemSub);

            // Unit
            oItemSub = new ListViewItem.ListViewSubItem();
            oItemSub.Text = _sPUnit;
            oItem.SubItems.Add(oItemSub);

            // Quantity
            oItemSub = new ListViewItem.ListViewSubItem();
            oItemSub.Text = _sPQuantity;

            oItem.SubItems.Add(oItemSub);
            // Add item to listview
            lsvShow.Items.Add(oItem);
        }
    }
}
