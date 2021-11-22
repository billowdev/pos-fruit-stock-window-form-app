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
    public partial class FrmListCustomer : Form
    {
        public FrmListCustomer()
        {
            InitializeComponent();
        }
        public string psCusID;
        public string psCusName;
        public string psCusLastName;
        public string psCusPhone;

        string sCusID, sCusName, sCusLastName, sCusPhone;

        oCenter ocn = new oCenter();

        private void FrmListCustomer_Load(object sender, EventArgs e)
        {
            prvShowData();
            txtSearch.Text = "";
        }

        private void lsvShow_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            psCusID = lsvShow.SelectedItems[0].SubItems[0].Text;
            psCusName = lsvShow.SelectedItems[0].SubItems[1].Text;
            psCusLastName = lsvShow.SelectedItems[0].SubItems[2].Text;
            psCusPhone = lsvShow.SelectedItems[0].SubItems[3].Text;

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
                sSql = " SELECT * FROM tb_customer ORDER BY cus_id DESC;";
            }
            else
            {
                sSql = " SELECT * FROM tb_customer WHERE cus_id,cus_name,cus_lastname,cus_phone LIKE '%" + txtSearch.Text + "%' AND ORDER BY cus_id DESC;";
            }
            DataSet ds = new DataSet();
            ds = ocn.pudsLoadData(sSql, "tb_customer", ds);

            if (ds.Tables["tb_customer"].Rows.Count != 0)
            {
                sCusID = "";
                sCusName = "";
                sCusLastName = "";
                sCusPhone = "";



                for (int nRow = 0; nRow < ds.Tables["tb_customer"].Rows.Count; nRow++)
                {
                    sCusID = ds.Tables["tb_customer"].Rows[nRow]["cus_id"].ToString();
                    sCusName = ds.Tables["tb_customer"].Rows[nRow]["cus_name"].ToString();
                    sCusLastName = ds.Tables["tb_customer"].Rows[nRow]["cus_lastname"].ToString();
                    sCusPhone = ds.Tables["tb_customer"].Rows[nRow]["cus_phone"].ToString();

                    prvAddItem(sCusID, sCusName, sCusLastName, sCusPhone);
                }
            }
            txtSearch.Text = "";
        }

        private void prvAddItem(string _sCusID, string _sCusName, string _sCusLastName, string _sCusPhone)
        {
            // item pid
            ListViewItem oItem = new ListViewItem();
            oItem.Text = _sCusID;
            // sub item name & Unit
            // name
            ListViewItem.ListViewSubItem oItemSub = new ListViewItem.ListViewSubItem();
            oItemSub.Text = _sCusName;
            oItem.SubItems.Add(oItemSub);

            // unit
            oItemSub = new ListViewItem.ListViewSubItem();
            oItemSub.Text = _sCusLastName;
            oItem.SubItems.Add(oItemSub);

            oItemSub = new ListViewItem.ListViewSubItem();
            oItemSub.Text = _sCusPhone;
            oItem.SubItems.Add(oItemSub);

            // Add item to listview
            lsvShow.Items.Add(oItem);
        }

    }
}
