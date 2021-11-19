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
        string sEMPID = "";
        string stateStatus;
        


        oCenter ocn = new oCenter();

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            // ---===================User  ---------------------- // 
            if (oCenter.currentStatus == "user")
            {
                ShowForUserLogin();
                txtEMPID.Hide();
                dgvAllMember.Hide();
                dgvAllUser.Hide();
                gbStatus.Hide();
                btnNew.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                mnuDelete.Enabled = false;
                mnuNew.Enabled = false;

            }
            // ================================== Admin ================================== //
            else
            {
                
                lbUserStatus.Hide();
                lbID.Hide();
                ShowAllMember();
                FormatDataEmployee();

                FormatDataUser();

                dgvAllMember.ReadOnly = true;
            }
        }



        // ================================== Function Show All Member for Admin ================================== // 
        private void ShowAllMember()
        {
            string sSqlEmp = "select * from tb_employee";
            string sSqlLogin = "select * from tb_login";

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

            // ------------------------------------------------------- //
            DataSet dsLogin = new DataSet();
            OleDbDataAdapter daLogin = new OleDbDataAdapter(sSqlLogin, oCenter.conn);
            bool bCheck = false;

            if (bCheck == true)
            {
                dsLogin.Tables["tb_login"].Clear();
            }

            //daLogin = new OleDbDataAdapter();
            daLogin.Fill(dsLogin, "tb_login");

            if (dsLogin.Tables["tb_login"].Rows.Count != 0)
            {
                bCheck = true;
                dgvAllUser.ReadOnly = true;
                dgvAllUser.DataSource = dsLogin.Tables["tb_login"];
            }
            else
            {
                bCheck = false;
            }


        }

        private void ShowForUserLogin()
        {

            // ==================================== Get tb_ogin Data ====================================================== //

            DataSet dsLogin = new DataSet();

            sSql = "";
            sSql = " SELECT * FROM tb_login WHERE Username ='" + oCenter.currentUsername + "'";
            dsLogin = ocn.pudsLoadData(sSql, "tb_login", dsLogin);

            if (dsLogin.Tables["tb_login"].Rows.Count != 0)
            {

                txtUsername.Text = dsLogin.Tables["tb_login"].Rows[0]["Username"].ToString();
                txtPassword.Text = dsLogin.Tables["tb_login"].Rows[0]["Password"].ToString();
                lbUserStatus.Text = dsLogin.Tables["tb_login"].Rows[0]["Status"].ToString();

                txtUsername.Text = dsLogin.Tables["tb_login"].Rows[0]["Username"].ToString();
                txtPassword.Text = dsLogin.Tables["tb_login"].Rows[0]["Password"].ToString();
                lbUserStatus.Text = dsLogin.Tables["tb_login"].Rows[0]["Status"].ToString();
                lbID.Text = dsLogin.Tables["tb_login"].Rows[0]["emp_id"].ToString();

            }
            // ======================================== End  Get tb_ogin Data ================================================== //

            


            // for fill data to text box from table employee reference by empid use for admin and user account
            try
            {

                // ==================================== it is fill all data from tb_login to dataGridView ====================================================== //

                //oCenter ocn = new oCenter();
                DataSet dsEmp = new DataSet();

                sSql = " SELECT * FROM tb_employee WHERE emp_id='" + lbID.Text + "'";
                dsEmp = ocn.pudsLoadData(sSql, "tb_employee", dsEmp);

                if (dsEmp.Tables["tb_employee"].Rows.Count != 0)
                {

                    txtName.Text = dsEmp.Tables["tb_employee"].Rows[0]["emp_name"].ToString();
                    txtLastName.Text = dsEmp.Tables["tb_employee"].Rows[0]["emp_lastname"].ToString();

                    if (dsEmp.Tables["tb_employee"].Rows[0]["emp_gender"].ToString() == "ชาย")
                    {
                        rdbMale.Checked = true;
                    }
                    else
                    {
                        rdbFemale.Checked = true;
                    }

                    dtpBirthDate.Value = Convert.ToDateTime(dsEmp.Tables["tb_employee"].Rows[0]["emp_bdate"].ToString());
                    txtPhone.Text = dsEmp.Tables["tb_employee"].Rows[0]["phone"].ToString();

                }
                // ======================================== End  it is fill all data from tb_login to dataGridView ================================================== //

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on private void fillEmployData(string emp_id): " + ex.Message, "mesg");
            }

        }

      
        // ================================== Event Cell mouse up data gridview ================================== // 
        private void dgvAllMember_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == dgvAllMember.Rows.Count)
            {
                return;
            }
            try
            {
                sEMPID = dgvAllMember.Rows[e.RowIndex].Cells[0].Value.ToString();

                txtEMPID.Text = sEMPID;

                txtName.Text = dgvAllMember.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = dgvAllMember.Rows[e.RowIndex].Cells[2].Value.ToString();
                stateGenter = dgvAllMember.Rows[e.RowIndex].Cells[3].Value.ToString();

                if (stateGenter == "ชาย")
                {
                    rdbMale.Checked = true;
                }
                else
                {
                    rdbFemale.Checked = true;
                }


                //dtpBirthDate.CustomFormat = "dd.MMM-yyyy";
                dtpBirthDate.Value = Convert.ToDateTime(dgvAllMember.Rows[e.RowIndex].Cells[4].Value);

                txtPhone.Text = dgvAllMember.Rows[e.RowIndex].Cells[5].Value.ToString();

                // ==================================== Get tb_ogin Data ====================================================== //

                //oCenter ocn = new oCenter();
                DataSet dsLogin = new DataSet();

                string sSqlSelect = "select * from tb_login WHERE emp_id='" + sEMPID + "'";
                dsLogin = ocn.pudsLoadData(sSqlSelect, "tb_login", dsLogin);

                if (dsLogin.Tables["tb_login"].Rows.Count != 0)
                {

                    txtUsername.Text = dsLogin.Tables["tb_login"].Rows[0]["Username"].ToString();
                    txtPassword.Text = dsLogin.Tables["tb_login"].Rows[0]["Password"].ToString();
                    lbUserStatus.Text = dsLogin.Tables["tb_login"].Rows[0]["Status"].ToString();

                    stateStatus = dsLogin.Tables["tb_login"].Rows[0]["Status"].ToString();
                    if (stateStatus == "user")
                    {
                        rdbUser.Checked = true;
                    }
                    else
                    {
                        rdbAdmin.Checked = true;
                    }
                    txtEMPID.Text = dsLogin.Tables["tb_login"].Rows[0]["emp_id"].ToString();

                }
                // ======================================== End  Get tb_ogin Data ================================================== //

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error krub",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------------------------- Menu Exit ---------------------- // 
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearAll();
            // AutoID                     Field Name        Table Name Head  Last      
            txtEMPID.Text = ocn.pusAutoID("emp_id", "tb_employee", "emp", "000"); // P-0001
        }

        private void clearAll()
        {
            txtEMPID.Text = "";
            txtLastName.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            txtUsername.Text = "";
            rdbUser.Checked = true;
            rdbAdmin.Checked = false;
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
            if (txtName.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลที่จะแก้ไขให้ครบ", "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            
            //OleDbCommand comEdit = new OleDbCommand();
            try
            {
                string sqlEdit;
                string sqlEditLogin;

                if (MessageBox.Show("คุณต้องการแก้ไขข้อมูลใช่หรือไม่", "ยืนยัน",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (oCenter.currentStatus == "user")
                    {
                        puvEditFunction();
                    }
                    else
                    {
                        puvEditFunction();
                        clearAll();
                        ShowAllMember();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ข้อมูลผิดพลาด:" + ex.Message, "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void puvEditFunction()
        {
            if (rdbAdmin.Checked == true)
            {
                stateStatus = "admin";
            }
            else
            {
                stateStatus = "user";
            }

            string sqlEdit;
            string sqlEditLogin;
        
            sqlEdit = " UPDATE tb_employee SET emp_name='" + txtName.Text
                + "',emp_lastname='" + txtLastName.Text
                + "',emp_gender='" + stateGenter
                + "',emp_bdate='" + dtpBirthDate.Value.GetDateTimeFormats('d')[0]
                + "'WHERE emp_id= '" + sEMPID + "'";

            sqlEditLogin = " UPDATE tb_login SET Username='" + txtUsername.Text
                + "',[Password]='" + txtPassword.Text
                + "',Status='" + stateStatus
                + "'WHERE emp_id= '" + sEMPID + "'";

            oCenter.pusvOpenConnection();

            oCenter.cmd.CommandType = CommandType.Text;
            oCenter.cmd.CommandText = sqlEdit;
            oCenter.cmd.Connection = oCenter.conn;
            oCenter.cmd.ExecuteNonQuery();

            // ================== tb_login ===============/
            oCenter.pusvOpenConnection();

            oCenter.cmd.CommandType = CommandType.Text;
            oCenter.cmd.CommandText = sqlEditLogin;
            oCenter.cmd.Connection = oCenter.conn;
            oCenter.cmd.ExecuteNonQuery();

            MessageBox.Show("แก้ไขข้อมูลเรียบร้อยแล้ว");
            
        }

        // ======================================== ##  btnSave_Click Event  ## ================================= //
        private void btnSave_Click(object sender, EventArgs e)
        {
            checkStateGender();
            if (txtEMPID.Text == "" ||
                txtName.Text == "" ||
                txtLastName.Text == "" ||
                txtUsername.Text == "" ||
                txtPassword.Text == ""||
                txtPhone.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtEMPID.Focus();
                return;
            }

            string sqlAddEmp = "";
            string sqlAddLogin = "";

            try
            {
                if (rdbAdmin.Checked == true)
                {
                    stateStatus = "admin";
                }
                else
                {
                    stateStatus = "user";
                }

                if (MessageBox.Show("เพิ่มข้อมูลใช่หรือไม่", "เพิ่มข้อมูล",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // ===============================  Insert Data Into tb_employee =============================== //
                    oCenter.pusvCloseConnection();

                    oCenter.pusvOpenConnection();

                    sqlAddEmp = " INSERT INTO tb_employee(emp_id,emp_name,emp_lastname,emp_gender,emp_bdate,emp_phone) VALUES(@id,@name,@lastname,@gender,@bdate,@phone)";

                    oCenter.cmd.Parameters.Clear();

                    oCenter.cmd.Parameters.AddWithValue("@id", txtEMPID.Text.Trim().ToString());
                    oCenter.cmd.Parameters.AddWithValue("@name", txtName.Text.Trim().ToString());
                    oCenter.cmd.Parameters.AddWithValue("@lastname", txtLastName.Text.Trim().ToString());
                    oCenter.cmd.Parameters.AddWithValue("@gender", stateGenter);
                    oCenter.cmd.Parameters.AddWithValue("@bdate", dtpBirthDate.Value.GetDateTimeFormats('d')[0]);
                    oCenter.cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim().ToString());

                    oCenter.cmd.CommandType = CommandType.Text;
                    oCenter.cmd.CommandText = sqlAddEmp;
                    oCenter.cmd.Connection = oCenter.conn;
                    oCenter.cmd.ExecuteNonQuery();

                    // ========================================  Insert Data Into tb_login ==================================== //
                    oCenter.pusvOpenConnection();

                    sqlAddLogin = " INSERT INTO tb_login(Username, [Password], Status, emp_id) VALUES(@status,@user,@pass,@id)";

                    oCenter.cmd.Parameters.Clear();
                    oCenter.cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim().ToString());
                    oCenter.cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim().ToString());
                    oCenter.cmd.Parameters.AddWithValue("@status", stateStatus);
                    oCenter.cmd.Parameters.AddWithValue("@id", txtEMPID.Text.Trim().ToString());

                    oCenter.cmd.CommandType = CommandType.Text;
                    oCenter.cmd.CommandText = sqlAddLogin;
                    oCenter.cmd.Connection = oCenter.conn;
                    oCenter.cmd.ExecuteNonQuery();

                    // ===============================  END Insert Data Into tb_login & tb_employee =============================== //
                    MessageBox.Show("ได้บันทึกข้อมูลเรียบร้อยแล้ว", "ผลการดำเนินการ");


                    clearAll();
                    ShowAllMember();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ไม่สามารถติดต่อฐานข้อมูลได้:"+ ex.Message, "โปรดลองอีกครั้ง",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ### ======================================== ##  END btnSave_Click Event  ## =================================  ### //

        // ### ======================================== ##   Employee Data Grid View Format ## =================================  ### //
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

        // ### ======================================== ##   END Data Grid View Format ## =================================  ### //

        // ### ======================================== ##   btnDelete_Click ## =================================  ### //
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEMPID.Text == "")
                {
                    MessageBox.Show("กรุณาเลือกข้อมูลที่จะลบ", "ผิดพลาด");
                    return;
                }
                string stateEMPID = "";
                stateEMPID = txtEMPID.Text;
                String sqlDelEmp = "DELETE FROM tb_employee WHERE emp_id='" + stateEMPID + "'";
                String sqlDelLogin = "DELETE FROM tb_login WHERE emp_id='" + stateEMPID + "'";
                oCenter.pusvOpenConnection();

                OleDbCommand comDelEmp = new OleDbCommand(sqlDelEmp, oCenter.conn);
                OleDbCommand comDelLogin = new OleDbCommand(sqlDelLogin, oCenter.conn);

                if (MessageBox.Show("คุณต้องการลบข้อมูลนี้ใช่หรือไม่", "ยืนยัน",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    comDelEmp.ExecuteNonQuery();
                    comDelLogin.ExecuteNonQuery();
                    MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "ผลการดำเนินการ");
                    clearAll();
                    ShowAllMember();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex.Message.ToString(), "โปรดลองอีกครั้ง",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ### ======================================== ##   END btnDelete_Click ## =================================  ### //


        // ### ======================================== ##   Data Grid View Format ## =================================  ### //

        private void FormatDataUser()
        {
            //dgvAllUser.ColumnCount = 3;
            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.Font = new Font("Ms Sans Serif", 10, FontStyle.Regular);
            dgvAllUser.ColumnHeadersDefaultCellStyle = cs;
            dgvAllUser.Columns[0].HeaderText = "Username";
            dgvAllUser.Columns[1].HeaderText = "Password";
            dgvAllUser.Columns[2].HeaderText = "Status";
            dgvAllUser.Columns[3].HeaderText = "รหัสพนักงาน";

            dgvAllUser.Columns[0].Width = 240;
            dgvAllUser.Columns[1].Width = 240;
            dgvAllUser.Columns[2].Width = 180;
            dgvAllUser.Columns[3].Width = 220;
        }

      
    }
}
        


