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
        string sData1, sData2;

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
                dtpBirthDate.CustomFormat = "dd MMM yyyy";
                lbUserStatus.Hide();
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

                oCenter.pusvOpenConnection();
                string sSqlSelect =
                
                sSqlSelect = "select * from tb_login WHERE emp_id='" + sEMPID + "'";
                
                oCenter.rd.Close();
                oCenter.pusvOpenConnection();

                //oCenter.sql = "select * from tb_login where Username = '" + oCenter.currentUsername + "'";
                oCenter.cmd.Connection = oCenter.conn;
                oCenter.cmd.CommandText = sSqlSelect;
                oCenter.cmd.ExecuteNonQuery();

                oCenter.rd = oCenter.cmd.ExecuteReader();

                if (oCenter.rd.HasRows)
                {
                    while (oCenter.rd.Read())
                    {
                        txtUsername.Text = oCenter.rd[0].ToString();
                        txtPassword.Text = oCenter.rd[1].ToString();
                        lbUserStatus.Text = oCenter.rd[2].ToString();
                        txtStatus.Text = oCenter.rd[2].ToString();
                        txtEMPID.Text = oCenter.rd[3].ToString();
                    }
                }

                oCenter.rd.Close();
                oCenter.pusvOpenConnection();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error krub",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (txtName.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลที่จะแก้ไขให้ครบ", "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            string sqlEdit;
            string sqlEditLogin;
            //OleDbCommand comEdit = new OleDbCommand();
            try
            {
                if (MessageBox.Show("คุณต้องการแก้ไขข้อมูลใช่หรือไม่", "ยืนยัน",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sqlEdit = " UPDATE tb_employee SET emp_name='" + txtName.Text
                        + "',emp_lastname='" + txtLastName.Text
                        + "',emp_gender='" + stateGenter
                        + "',emp_bdate='" + Convert.ToDateTime(dtpBirthDate.Value.ToString("dd/mm/yyyy"))
                        + "'WHERE emp_id= '" + sEMPID + "'";

                    sqlEditLogin = " UPDATE tb_login SET Username='" + txtUsername.Text
                        + "',[Password]='" + txtPassword.Text
                        + "',Status='" + txtStatus.Text
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



                    clearAll();
                    ShowAllMember();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ข้อมูลผิดพลาด", "ผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        


