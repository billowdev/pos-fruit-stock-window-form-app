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
    public partial class FrmListProduct : Form
    {
        public FrmListProduct()
        {
            InitializeComponent();
        }
        string sPid, sPname, sPUnit;
        public string psPid, psPname, psPunit;
        public DataGridView pdgvPublic;

        private void lsvProduct_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            psPid = lsvProduct.SelectedItems[0].SubItems[0].Text;
            psPname = lsvProduct.SelectedItems[0].SubItems[1].Text;
            psPunit = lsvProduct.SelectedItems[0].SubItems[2].Text;

            if (lsvProduct.SelectedItems[0].SubItems[0].Text != "")
            {
                this.Close();
            }
        }

        oCenter ocn = new oCenter();

        private void FrmListProduct_Load(object sender, EventArgs e)
        {

            txtSearch.Text = "";
            prvShowData();
        }

        private void prvAddItem(string _sPid, string _sName, string _sUnit)
        {
            // item pid
            ListViewItem oItem = new ListViewItem();
            oItem.Text = _sPid;
            // sub item name & Unit
            ListViewItem.ListViewSubItem oItemSub = new ListViewItem.ListViewSubItem();
            // name
            oItemSub.Text = _sName;
            oItem.SubItems.Add(oItemSub);
            // unit
            oItemSub = new ListViewItem.ListViewSubItem();
            oItemSub.Text = _sUnit;

            oItem.SubItems.Add(oItemSub);
            // Add item to listview
            lsvProduct.Items.Add(oItem);
        }

        private void prvShowData()
        {
            lsvProduct.Items.Clear();
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
                sPid = "";
                sPname = "";
                sPUnit = "";

                for (int nRow = 0; nRow < ds.Tables["tb_product"].Rows.Count; nRow++)
                {
                    sPid = ds.Tables["tb_product"].Rows[nRow]["pro_id"].ToString();
                    sPname = ds.Tables["tb_product"].Rows[nRow]["pro_name"].ToString();
                    sPUnit = ds.Tables["tb_product"].Rows[nRow]["pro_unit"].ToString();

                    prvAddItem(sPid, sPname, sPUnit);
                }
            }
            txtSearch.Text = "";
        }

    }
}
