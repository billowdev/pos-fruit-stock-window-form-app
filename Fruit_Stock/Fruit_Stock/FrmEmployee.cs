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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        // ================================================= DEFIND =============================================  //
       
        oCenter ocn = new oCenter();         // Object Center    Database connect
        DataSet ds = new DataSet();         // DataSet  pass to dgv and ctystal report
        DataSet dsLogin = new DataSet();    // DataSet For Login data
        
        OleDbDataAdapter da;                // DataAdapter
        
        string sSql;
        string stateGenter = "";
        string sEMPID = "";
        string stateStatus;
        string sSqlAdd = "";
        string sSqlSelect = "";

        bool bCheckLogin = false;
        bool bCheck = false;

        // ================================================= DEFIND =============================================  //

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            // ================================== User ================================== //
            if (oCenter.currentStatus == "user")
            {
                prvShowForUserLogin();
                txtEMPID.Hide();
                dgvAllMember.Hide();
                dgvAllUser.Hide();
                gbStatus.Hide();
                btnNew.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                btnSearch.Hide();
                txtSearch.Hide();
                btnReport.Hide();
            }
            // ================================== Admin ================================== //
            else
            {
                // AutoID                     Field Name        Table Name Head  Last      
                txtEMPID.Text = ocn.pusAutoID("emp_id", "tb_employee", "emp", "000"); // P-0001
                lbUserStatus.Hide();
                lbID.Hide();
                prvShowAllMember();
                prvFormatDataEmployee();

                prvFormatDataUser();
                dgvAllMember.ReadOnly = true;
            }
        }

        private void prvShowAllMember()
        {
            /*------------------------------------------------- Detail ------------
            |  Function prvShowAllMember
            |
            |  Purpose:  this method user for show all data of employee from database
            |      Show to data grid veiw (dgvAllMember)
            |
            *-------------------------------------------------------------------*/

            try
            {
                string sSqlEmp = "select * from tb_employee";
                string sSqlLogin = "select * from tb_login";

                if (bCheck== true)
                {
                    ds.Tables["tb_employee"].Clear();
                }

                da = new OleDbDataAdapter(sSqlEmp, oCenter.conn);
                da.Fill(ds, "tb_employee");

                if (ds.Tables["tb_employee"].Rows.Count != 0)
                {
                    bCheck= true;
                    dgvAllMember.ReadOnly = true;
                    dgvAllMember.DataSource = ds.Tables["tb_employee"];
                }
                else
                {
                    bCheck= false;
                }

                // ------------------------- Login Section ------------------------------ //
                
                OleDbDataAdapter daLogin = new OleDbDataAdapter(sSqlLogin, oCenter.conn);

                if (bCheckLogin == true)
                {
                    ds.Tables["tb_login"].Clear();
                }

                //daLogin = new OleDbDataAdapter();
                daLogin.Fill(dsLogin, "tb_login");

                if (dsLogin.Tables["tb_login"].Rows.Count != 0)
                {
                    bCheckLogin = true;
                    dgvAllUser.ReadOnly = true;
                    dgvAllUser.DataSource = dsLogin.Tables["tb_login"];
                }
                else
                {
                    bCheckLogin = false;
                }
                bCheckLogin = false;
            }
            catch
            {

            }
        }

        private void prvShowForUserLogin()
        {
            /*------------------------------------------------- Detail --------
           |  Function prvShowForUserLogin
           |
           |  Purpose:  this method user for show data of user login
           |      
           |
           *-------------------------------------------------------------------*/

            sSql = "";
            sSql = " SELECT * FROM tb_login WHERE Username ='" + oCenter.currentUsername + "'";
            ds = ocn.pudsLoadData(sSql, "tb_login", ds);

            if (ds.Tables["tb_login"].Rows.Count != 0)
            {

                txtUsername.Text = ds.Tables["tb_login"].Rows[0]["Username"].ToString();
                txtPassword.Text = ds.Tables["tb_login"].Rows[0]["Password"].ToString();
                lbUserStatus.Text = ds.Tables["tb_login"].Rows[0]["Status"].ToString();

                txtUsername.Text = ds.Tables["tb_login"].Rows[0]["Username"].ToString();
                txtPassword.Text = ds.Tables["tb_login"].Rows[0]["Password"].ToString();
                lbUserStatus.Text = ds.Tables["tb_login"].Rows[0]["Status"].ToString();
                lbID.Text = ds.Tables["tb_login"].Rows[0]["emp_id"].ToString();

            }
            // ======================================== End  Get tb_ogin Data ================================================== //

            // Fill data to text box from table employee reference by empid use for admin and user account.
            try
            {
               
                sSql = " SELECT * FROM tb_employee WHERE emp_id='" + lbID.Text + "'";
                ds = ocn.pudsLoadData(sSql, "tb_employee", ds);

                if (ds.Tables["tb_employee"].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables["tb_employee"].Rows[0]["emp_name"].ToString();
                    txtLastName.Text = ds.Tables["tb_employee"].Rows[0]["emp_lastname"].ToString();

                    if (ds.Tables["tb_employee"].Rows[0]["emp_gender"].ToString() == "ชาย")
                    {
                        rdbMale.Checked = true;
                    }
                    else
                    {
                        rdbFemale.Checked = true;
                    }

                    dtpBirthDate.Value = Convert.ToDateTime(ds.Tables["tb_employee"].Rows[0]["emp_bdate"].ToString());
                    txtPhone.Text = ds.Tables["tb_employee"].Rows[0]["emp_phone"].ToString();

                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on private void fillEmployData(string emp_id): " + ex.Message, "mesg");
            }
            // ======================================== End  Fill all data from tb_login to dataGridView ================================================== //
        }


        private void prvClearAll()
        {
            /*------------------------------------------------- Detail --------
          |  Function prvClearAll
          |
          |  Purpose:  For clear all data on text box.
          |
          *-------------------------------------------------------------------*/

            txtEMPID.Text = "";
            txtLastName.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            txtUsername.Text = "";
            rdbUser.Checked = true;
            rdbAdmin.Checked = false;
        }

        private void prvCheckStateGender()
        {
            /*------------------------------------------------- Detail --------
          |  Function prvCheckStateGender
          |
          |  Purpose:  Check radio button gender state.
          |
          *-------------------------------------------------------------------*/

            if (rdbMale.Checked == true)
            {
                stateGenter = "ชาย";
            }
            else
            {
                stateGenter = "หญิง";
            }
        }

        private void prvCheckStateUsername()
        {
            /*------------------------------------------------- Detail --------
            |  Function prvCheckStateUsername
            |
            |  Purpose:  Check radio button user status state.
            |
            *-------------------------------------------------------------------*/

            if (rdbAdmin.Checked == true)
            {
                stateStatus = "admin";
            }
            else
            {
                stateStatus = "user";
            }
        }

      

        private void prvEditFunction()
        {
            /*------------------------------------------------- Detail --------
           |  Function prvEditFucntion
           |
           |  Purpose:  For update data tb_employee & tb_username
           |
           *-------------------------------------------------------------------*/

            prvCheckStateUsername();

            string sqlEdit;
            string sqlEditLogin;

            sqlEdit = " UPDATE tb_employee SET emp_name='" + txtName.Text
                + "',emp_lastname='" + txtLastName.Text
                + "',emp_gender='" + stateGenter
                + "',emp_bdate='" + dtpBirthDate.Value.GetDateTimeFormats('d')[0]
                + "'WHERE emp_id= '" + txtEMPID.Text + "'";

            sqlEditLogin = " UPDATE tb_login SET Username='" + txtUsername.Text
                + "',[Password]='" + txtPassword.Text
                + "',Status='" + stateStatus
                + "'WHERE emp_id= '" + txtEMPID.Text + "'";

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


        private void prvSave()
        {
            /*------------------------------------------------- Detail --------
           |  Function prvSave
           |
           |  Purpose:  Insert data to tb_employee & tb_username
           |
           *-------------------------------------------------------------------*/
            prvCheckStateGender();
            prvCheckStateUsername();

            if (txtEMPID.Text == "" ||
                txtName.Text == "" ||
                txtLastName.Text == "" ||
                txtUsername.Text == "" ||
                txtPassword.Text == "" ||
                txtPhone.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //txtEMPID.Focus();
                return;
            }

            try
            {
                string sqlAddEmp = "";
                string sqlAddLogin = "";
               

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

                    prvClearAll();
                    prvShowAllMember();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ไม่สามารถติดต่อฐานข้อมูลได้:" + ex.Message, "โปรดลองอีกครั้ง",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ### ======================================== ##   Data Grid View Format ## =================================  ### //
        private void prvFormatDataEmployee()
        {
            /*------------------------------------------------- Detail --------
           |  Function prvCheckStateUsername
           |
           |  Purpose:  Format data grid view Employee
           |
           *-------------------------------------------------------------------*/
            try
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
            catch
            {

            }

           
        }
        // ### ======================================== ##   END Data Grid View Format ## =================================  ### //


        private void prvFormatDataUser()
        {
            /*------------------------------------------------- Detail --------
           |  Function pevFormatDataUser
           |
           |  Purpose:  Format data grid view of username and password data
           |
           *-------------------------------------------------------------------*/

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

        private void prvDelete()
        {
         /*------------------------------------------------- Detail --------
         |  Function prvDelete
         |
         |  Purpose:  ! Delete Data select record
         |
         *-------------------------------------------------------------------*/
            try
            {
                if (txtEMPID.Text == "")
                {
                    MessageBox.Show("กรุณาเลือกข้อมูลที่จะลบ", "ผิดพลาด");
                    return;
                }

                string stateEMPID = txtEMPID.Text;
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
                    prvClearAll();
                    prvShowAllMember();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message.ToString(), "โปรดลองอีกครั้ง",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void prvSearch()
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อความที่ต้องการค้นหา", "Msg", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSearch.Text.Trim() != "")
            {

                sSqlAdd = " WHERE " + sSql + " emp_id+emp_name+emp_lastname+emp_phone LIKE '%" + txtSearch.Text.Trim() + "%' ";
            }
            
            sSqlSelect = " SELECT * " +"FROM tb_employee" + " " + sSqlAdd + " ORDER BY emp_id Desc;";

            if (bCheck == true)
            {
                ds.Tables["tb_employee"].Clear();
            }

            da = new OleDbDataAdapter(sSqlSelect, oCenter.conn);
            da.Fill(ds, "tb_employee");


            if (ds.Tables["tb_employee"].Rows.Count != 0)
            {
                bCheck = true;
                dgvAllMember.ReadOnly = true;
                dgvAllMember.DataSource = ds.Tables["tb_employee"];


                // If dgvAllMember are have multirow : then Search from tb_login multirow too.. By WHERE emp_id is equal
                for (int nRow = 0; nRow <= ds.Tables["tb_employee"].Rows.Count - 1; nRow++)
                {
                    string selectUser = "SELECT * FROM tb_login WHERE emp_id='"
                        + ds.Tables["tb_employee"].Rows[nRow]["emp_id"].ToString() + "'";

                    OleDbDataAdapter da_user = new OleDbDataAdapter(selectUser, oCenter.conn);
                    da_user.Fill(ds, "tb_login");

                }

                dgvAllUser.ReadOnly = true;
                dgvAllUser.DataSource = ds.Tables["tb_login"];

            }
            else
            {
                bCheck = false;
            }
            dgvAllMember.Refresh();
            btnSearch.Enabled = false;
        }




        // =================================================================================================================== //
        //                                                                                                                   //
        //                                                    Event                                                          //
        //                                                                                                                   //
        // =================================================================================================================== //

        private void btnNew_Click(object sender, EventArgs e)
        {
            prvClearAll();
            // AutoID                     Field Name        Table Name Head  Last      
            txtEMPID.Text = ocn.pusAutoID("emp_id", "tb_employee", "emp", "000"); // P-0001
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            prvSave();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            oCenter.pusvCloseConnection();
            oCenter.pusvOpenConnection();

            if (txtName.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลที่จะแก้ไขให้ครบ", "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            try
            {
                if (MessageBox.Show("คุณต้องการแก้ไขข้อมูลใช่หรือไม่", "ยืนยัน",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (oCenter.currentStatus == "user")
                    {
                        prvEditFunction();
                    }
                    else
                    {
                        prvEditFunction();
                        prvClearAll();
                        prvShowAllMember();
                    }
                }
            }
            catch
            {
                // COM object that has been separated from it underlying RCW cannot be used. 
                prvEditFunction();
                prvClearAll();
                prvShowAllMember();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            prvDelete();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            prvSearch();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (btnSearch.Enabled == true)
                {
                    prvSearch();
                }
                else
                {
                    prvShowAllMember();
                    //txtSearch.Text = "";
                    btnSearch.Enabled = true;
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
          
            FrmReport Frm = new FrmReport();
            Frm.sReport = "AllEmployee";
            // DataSet
            Frm.rptEmployee.SetDataSource(ds);
            Frm.ShowDialog();
        }

        // ================================== Event Cell mouse up data gridview ================================== // 
        private void dgvAllMember_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DataSet dsLogin = new DataSet();
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

                dtpBirthDate.Value = Convert.ToDateTime(dgvAllMember.Rows[e.RowIndex].Cells[4].Value);
                txtPhone.Text = dgvAllMember.Rows[e.RowIndex].Cells[5].Value.ToString();

                // ==================================== Get tb_ogin Data ====================================================== //

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

        // ================================== END Event Cell mouse up data gridview ================================== // 




        // ---------------------------------- Menu Exit ---------------------- // 
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrintDetail_Click(object sender, EventArgs e)
        {
            if (txtEMPID.Text == "")
            {
                MessageBox.Show("Please select employee ");
                return;
            }

            DataSet dsDetail = new DataSet();

            sSql = " select * from tb_employee where emp_id='" + txtEMPID.Text + "'";

            OleDbDataAdapter da = new OleDbDataAdapter(sSql, oCenter.conn);
            da.Fill(dsDetail, "tb_employee");

            FrmReport Frm = new FrmReport();
            Frm.sReport = "DetailEmployee";
            Frm.rptDetailEmployee.SetDataSource(dsDetail);
            Frm.ShowDialog();

            bCheck = false;
        }
    }
}

