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
    public partial class FrmEmployeeFilter : Form
    {
        public FrmEmployeeFilter()
        {
            InitializeComponent();
        }
        OleDbDataAdapter da;
        string sSql;
        string stateGenter = "";
        string sEMPID = "";
        string stateStatus;
        bool IsFind = false;
        DataSet dsUser = new DataSet();

        public cryEmployee rptEmployee = new cryEmployee();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            prvSearch();
        }
        private void prvSearch()
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อความที่ต้องการค้นหา", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sSqlAdd = "";
            string sSqlSelect = "";
            if (txtSearch.Text.Trim() != "")
            {

                sSqlAdd = " WHERE " + sSql + " emp_id+emp_name+emp_lastname+emp_phone LIKE '%" + txtSearch.Text.Trim() + "%' ";
            }
            sSqlSelect = " SELECT * " +
                        "FROM tb_employee" +
                        " " + sSqlAdd + " ORDER BY emp_id Desc;";


            if (IsFind == true)
            {
                dsUser.Tables["tb_employee"].Clear();
            }

            da = new OleDbDataAdapter(sSqlSelect, oCenter.conn);
            da.Fill(dsUser, "tb_employee");


            if (dsUser.Tables["tb_employee"].Rows.Count != 0)
            {
                IsFind = true;
                dgvAllMember.ReadOnly = true;
                dgvAllMember.DataSource = dsUser.Tables["tb_employee"];

                
                OleDbDataAdapter da_user = new OleDbDataAdapter();

                // If dgvAllMember are have multirow : then Search from tb_login multirow too.. By WHERE emp_id is equal
                for (int nRow = 0; nRow <= dsUser.Tables["tb_employee"].Rows.Count - 1; nRow++)
                {
                    string selectUser = "SELECT * FROM tb_login WHERE emp_id='"
                        + dsUser.Tables["tb_employee"].Rows[nRow]["emp_id"].ToString() + "'";

                    da_user = new OleDbDataAdapter(selectUser, oCenter.conn);
                    da_user.Fill(dsUser, "tb_login");

                }

            }
            else
            {
                IsFind = false;
            }
            dgvAllMember.Refresh();
            btnSearch.Enabled = false;
        }

        private void prvShowAllMember()
        {
            string sSqlEmp = "select * from tb_employee";

            if (oCenter.IsFind == true)
            {
                oCenter.ds.Tables["tb_employee"].Clear();
            }

            da = new OleDbDataAdapter(sSqlEmp, oCenter.conn);
            da.Fill(oCenter.ds, "tb_employee");

            if (oCenter.ds.Tables["tb_employee"].Rows.Count != 0)
            {
                oCenter.IsFind = true;
                dgvAllMember.ReadOnly = true;
                dgvAllMember.DataSource = oCenter.ds.Tables["tb_employee"];
            }
            else
            {
                oCenter.IsFind = false;
            }

          
        }
        private void prvFormatDataEmployee()
        {
            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.Font = new Font("Ms Sans Serif", 10, FontStyle.Regular);
            dgvAllMember.ColumnHeadersDefaultCellStyle = cs;
            dgvAllMember.Columns[0].HeaderText = "รหัสพนักงาน";
            dgvAllMember.Columns[1].HeaderText = "ชื่อ";
            dgvAllMember.Columns[2].HeaderText = "นามสกุล";
            dgvAllMember.Columns[3].HeaderText = "เพศ";
            dgvAllMember.Columns[4].HeaderText = "วันเดือนปีเกิด";
            dgvAllMember.Columns[5].HeaderText = "เบอร์โทร";

            dgvAllMember.Columns[0].Width = 120;
            dgvAllMember.Columns[1].Width = 220;
            dgvAllMember.Columns[2].Width = 220;
            dgvAllMember.Columns[3].Width = 60;
            dgvAllMember.Columns[4].Width = 160;
            dgvAllMember.Columns[5].Width = 160;
        }

        private void FrmReportEmployee_Load(object sender, EventArgs e)
        {
            prvShowAllMember();
            prvFormatDataEmployee();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            // Form Report Employee
            FrmReportEmployee Frm = new FrmReportEmployee();
                                         // DataGridView
            Frm.rptEmployee.SetDataSource(dsUser);
            Frm.ShowDialog();
        }
    }
}
