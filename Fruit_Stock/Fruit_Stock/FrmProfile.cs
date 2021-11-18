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
        string stateGenter = "";

        oCenter ocn = new oCenter();

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            // ---===================User  ---------------------- // 
            if (oCenter.currentStatus == "user")
            {
                ShowForUserLogin();
                txtStatus.Hide();
                dgvAllMember.Hide();
                //btnEdit.Enabled = false;
                btnNew.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                txtStatus.Hide();
                mnuDelete.Enabled = false;
                mnuNew.Enabled = false;

            }
            // ================================== Admin ================================== //
            else
            {
                lsvUser.Hide();
                lbUserStatus.Hide();
                ShowAllMember();
                FormatDataEmployee();

                showAllDataUser();
                FormatDataUser();

                dgvAllMember.ReadOnly = true;
            }
        }

        // ================================== Function Show All data User ================================== // 
        private void showAllDataUser()
        {
            string sSqlLoginData = "SELECT * FROM tb_login";

            if (oCenter.IsFind == true)
            {
                oCenter.ds.Tables["tb_login"].Clear();
            }

            da = new OleDbDataAdapter(sSqlLoginData, oCenter.conn);
            da.Fill(oCenter.ds, "tb_login");

            if (oCenter.ds.Tables["tb_login"].Rows.Count != 0)
            {
                oCenter.IsFind = true;
                dgvAllMember.ReadOnly = true;
                dgvAllMember.DataSource = oCenter.ds.Tables["tb_login"];
            }
            else
            {
                oCenter.IsFind = false;
            }
        }

        // ================================== Function Show All Member for Admin ================================== // 
        private void ShowAllMember()
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

        private void ShowForUserLogin()
        {
            oCenter.rd.Close();
            oCenter.pusvOpenConnection();
            sSql = "";

            sSql = " SELECT * FROM tb_login WHERE Username ='" + oCenter.currentUsername + "'";
            oCenter.cmd.Connection = oCenter.conn;
            oCenter.cmd.CommandText = sSql;
            oCenter.cmd.ExecuteNonQuery();

            oCenter.rd = oCenter.cmd.ExecuteReader();

            if (oCenter.rd.HasRows)
            {
                while (oCenter.rd.Read())
                {
                    txtUsername.Text = oCenter.rd[1].ToString();
                    txtPassword.Text = oCenter.rd[2].ToString();
                    lbUserStatus.Text = oCenter.rd[3].ToString();
                    txtEMPID.Text = oCenter.rd[4].ToString();
                }
            }

            oCenter.rd.Close();
            oCenter.pusvCloseConnection();

            FillEmployData(txtEMPID.Text);
            
        }

        // ================================== Event Cell mouse up data gridview ================================== // 
        private void dgvAllMember_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }




        // Function for fill data to text box from table employee reference by empid use for admin and user account
        private void FillEmployData(string emp_id)
        {
            oCenter.pusvCloseConnection();
            try
            {

                // it is fill all data from tb_login to dataGridView


                sSql = "";
                sSql = " SELECT * FROM tb_employee WHERE emp_id='" + emp_id + "'";

                oCenter.cmd.CommandType = CommandType.Text;
                oCenter.cmd.CommandText = sSql;

                //oCenter.cmd.Parameters.Clear();
                //oCenter.cmd.Parameters.AddWithValue("@empid", emp_id.Trim().ToString());
                oCenter.pusvOpenConnection();


                oCenter.rd = oCenter.cmd.ExecuteReader();

                if (oCenter.rd.HasRows)
                {
                    while (oCenter.rd.Read())
                    {


                        txtName.Text = oCenter.rd[1].ToString();
                        txtLastName.Text = oCenter.rd[2].ToString();

                        if (oCenter.rd[3].ToString() == "ชาย")
                        {
                            rdbMale.Checked = true;
                        }
                        else
                        {
                            rdbFemale.Checked = true;
                        }

                        dtpBirthDate.Value = Convert.ToDateTime(oCenter.rd[4]);
                        txtPhone.Text = oCenter.rd[5].ToString();
                    }
                }
                oCenter.rd.Close();
                oCenter.pusvCloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on private void fillEmployData(string emp_id): " + ex.Message, "mesg");
            }
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

        private void FormatDataUser()
        {
            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.Font = new Font("Ms Sans Serif", 10, FontStyle.Regular);
            dgvAllMember.ColumnHeadersDefaultCellStyle = cs;
            dgvAllMember.Columns[0].HeaderText = "ชื่อผู้ใช้";
            dgvAllMember.Columns[1].HeaderText = "รหัสผ่าน";
            dgvAllMember.Columns[2].HeaderText = "สถานะ";
            dgvAllMember.Columns[3].HeaderText = "รหัสพนักงาน";

            dgvAllMember.Columns[0].Width = 120;
            dgvAllMember.Columns[1].Width = 120;
            dgvAllMember.Columns[2].Width = 120;
            dgvAllMember.Columns[3].Width = 120;
        }

        private void btnUserData_Click(object sender, EventArgs e)
        {
            dgvAllMember.Hide();
            lsvUser.Show();

        }

        private void btnEmployeeData_Click(object sender, EventArgs e)
        {
            lsvUser.Hide();
            dgvAllMember.Show();

        }
    }
}
        


