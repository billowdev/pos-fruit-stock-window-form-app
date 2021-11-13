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
    public partial class FrmProfile : Form
    {
        public FrmProfile()
        {
            InitializeComponent();
        }
        OleDbDataAdapter da;

        private void FrmProfile_Load(object sender, EventArgs e)
        {

            AC.openConnection();

            if (AC.currentStatus == "user")
            {
                btnEdit.Enabled = false;
                btnNew.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
            }
            else
            {
                showAllMember();


           
            }


        }
        private void showAllMember() {
            string sqlMember = "select * from tb_login";
            if (AC.IsFind == true)
            {
                AC.ds.Tables["tb_login"].Clear();
            }

            da = new OleDbDataAdapter(sqlMember, AC.conn);
            da.Fill(AC.ds, "tb_login");
         

            if (AC.ds.Tables["tb_login"].Rows.Count != 0)
            {
                AC.IsFind = true;
                dgvAllMember.ReadOnly = true;
                dgvAllMember.DataSource = AC.ds.Tables["tb_login"];
            }
            else
            {
                AC.IsFind = false;
            }
        }
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


        private void dgvAllMember_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == dgvAllMember.Rows.Count - 1)
            {
                return;
            }
            try
            {

                txtUsername.Text = dgvAllMember.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPassword.Text = dgvAllMember.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtStatus.Text = dgvAllMember.Rows[e.RowIndex].Cells[3].Value.ToString();

            }
            catch
            {
                MessageBox.Show("Error", "Error krub",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

