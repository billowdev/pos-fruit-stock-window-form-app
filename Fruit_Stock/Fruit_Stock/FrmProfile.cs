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
        private void FrmProfile_Load(object sender, EventArgs e)
        {
            // ---------------------------------------------- User  ---------------------- // 
            if (AC.currentStatus == "user")
            {
                showAllDataUser();
                txtStatus.Hide();
                dgvAllMember.Hide();
                //btnEdit.Enabled = false;
                btnNew.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;

            }
            // -------------------------------------------- Admin --------------------------------------- //
            else
            {
                lbUserStatus.Hide();
                showAllMember();
                FormatDataMember();
                dgvAllMember.ReadOnly = true;
            }
        }
        // ---------------------------------------------- Function Show All data User ---------------------- // 
        private void showAllDataUser()
        {
            AC.rd.Close();
            AC.openConnection();
            sSql = "";

            sSql = " SELECT * FROM tb_login WHERE Username ='" + AC.currentUsername + "'";
            AC.cmd.Connection = AC.conn;
            AC.cmd.CommandText = sSql;
            AC.cmd.ExecuteNonQuery();

            AC.rd = AC.cmd.ExecuteReader();

            if (AC.rd.HasRows)
            {
                while (AC.rd.Read())
                {
                    txtUsername.Text = AC.rd[1].ToString();
                    txtPassword.Text = AC.rd[2].ToString();
                    lbUserStatus.Text = AC.rd[3].ToString();
                    txtEMPID.Text = AC.rd[4].ToString();
                }
            }

            AC.rd.Close();
            AC.openConnection();

            // when account is user
            if (txtEMPID.Text != "")
            {
                fillEmployData(txtEMPID.Text);
            }
        }

        // ---------------------------------------------- Function Show All Member for Admin ---------------------- // 
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

        // ---------------------------------- Event Cell mouse up data gridview ---------------------- // 
        private void dgvAllMember_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtEMPID.Text = "";
            txtLastName.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            txtStatus.Text = "";
            txtUsername.Text = "";

            txtUsername.Text = dgvAllMember.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPassword.Text = dgvAllMember.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtStatus.Text = dgvAllMember.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEMPID.Text = dgvAllMember.Rows[e.RowIndex].Cells[4].Value.ToString();

            fillEmployData(this.txtEMPID.Text);

            //if (e.RowIndex == dgvAllMember.Rows.Count)
            //{
            //    return;
            //}
            //else
            //{
               
            //}


        }

        // Data GridViewFormat
        private void FormatDataMember()
        {
            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.Font = new Font("Ms Sans Serif", 10, FontStyle.Regular);
            dgvAllMember.ColumnHeadersDefaultCellStyle = cs;
            dgvAllMember.Columns[0].HeaderText = "NO";
            dgvAllMember.Columns[1].HeaderText = "ชื่อผู้ใช้";
            dgvAllMember.Columns[2].HeaderText = "รหัสผ่าน";
            dgvAllMember.Columns[3].HeaderText = "สถานะ";
            dgvAllMember.Columns[4].HeaderText = "รหัสพนักงาน";

            dgvAllMember.Columns[0].Width = 40;
            dgvAllMember.Columns[1].Width = 130;
            dgvAllMember.Columns[2].Width = 130;
            dgvAllMember.Columns[3].Width = 60;
            dgvAllMember.Columns[4].Width = 100;

        }


        // Function for fill data to text box from table employee reference by empid use for admin and user account
        private void fillEmployData(string emp_id)
        {
            AC.closeConnection();
            try
            {

                // it is fill all data from tb_login to dataGridView
                

                sSql = "";
                sSql = " SELECT * FROM tb_employee WHERE emp_id='"+ emp_id + "'";

                AC.cmd.CommandType = CommandType.Text;
                AC.cmd.CommandText = sSql;

                //AC.cmd.Parameters.Clear();
                //AC.cmd.Parameters.AddWithValue("@empid", emp_id.Trim().ToString());
                AC.openConnection();


                AC.rd = AC.cmd.ExecuteReader();

                if (AC.rd.HasRows)
                {
                    while (AC.rd.Read())
                    {
                       

                        txtName.Text = AC.rd[1].ToString();
                        txtLastName.Text = AC.rd[2].ToString();

                        if (AC.rd[3].ToString() == "ชาย")
                        {
                            rdbMale.Checked = true;
                        }
                        else
                        {
                            rdbFemale.Checked = true;
                        }

                        dtpBirthDate.Value = Convert.ToDateTime(AC.rd[4]);
                        txtPhone.Text = AC.rd[5].ToString();
                    }
                }
                AC.rd.Close();
                AC.closeConnection();
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


    }
}
        
