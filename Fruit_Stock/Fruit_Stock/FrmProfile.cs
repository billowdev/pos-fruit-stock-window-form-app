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
        string sSql;
        FrmLogin fLogin = new FrmLogin();
        string stateGenter = "";

        oCenter ocn = new oCenter();

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            // ---===================User  ---------------------- // 
            if (oCenter.currentStatus == "user")
            {
                lbAllData.Hide();
                showAllDataUser();
                txtStatus.Hide();
                dgvAllMember.Hide();
                //btnEdit.Enabled = false;
                btnNew.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                txtStatus.Hide();
                pbProfile.Hide();
                mnuDelete.Enabled = false;
                mnuNew.Enabled = false;
            }
            // ================================== Admin ================================== //
            else
            {
                dgvUserData.Hide();
                lbUserStatus.Hide();
                ShowAllMember();
                FormatDataEmployee();
                dgvAllMember.ReadOnly = true;
            }
        }

        // ================================== Function Show All data User ================================== // 
        private void showAllDataUser()
        {
          
        }

        // ================================== Function Show All Member for Admin ================================== // 
        private void ShowAllMember()
        {
            string sqlStu = "select * from tb_employee";
            if (oCenter.IsFind == true)
            {
                oCenter.ds.Tables["tb_employee"].Clear();
            }

            da = new OleDbDataAdapter(sqlStu, oCenter.conn);
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


        // ================================== Event Cell mouse up data gridview ================================== // 
        private void dgvAllMember_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
         
        }




        // Function for fill data to text box from table employee reference by empid use for admin and user account
        private void fillEmployData(string emp_id)
        {
          
        }

        // ---------------------------------- Menu Exit ---------------------- // 
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ---------------------------------- Back to Main ---------------------- // 
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            txtEMPID.Text = "";
            txtLastName.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            txtStatus.Text = "";
            txtUsername.Text = "";
        }

        private void checkStateGender()
        {
            if (rdbMale.Checked == true)
            {
                stateGenter = "ชาย";
            }
            else
            {
                stateGenter = "หญิง";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            checkStateGender();


        }


        private void FormatDataEmployee()
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

        private void btnUserData_Click(object sender, EventArgs e)
        {
            dgvAllMember.Hide();
            dgvUserData.Show();
            btnEmployeeData.Enabled = false;
        }

        private void btnEmployeeData_Click(object sender, EventArgs e)
        {
            dgvAllMember.Show();
            dgvUserData.Hide();
            btnUserData.Enabled = false;
        }
    }
}
        


