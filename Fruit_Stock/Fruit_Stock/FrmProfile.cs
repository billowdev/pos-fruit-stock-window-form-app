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
            AC.closeConnection();

            if (AC.currentStatus == "user")
            {
                showAllDataUser();

                dgvAllMember.Hide();
                btnEdit.Enabled = false;
                btnNew.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;

            }
            // -------------------------------------------- Admin --------------------------------------- //
            else
            {
                showAllMember();
            }
        }

        private void showAllDataUser()
        {
            

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
                // it is fill all data from tb_login to dataGridView
                txtUsername.Text = dgvAllMember.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPassword.Text = dgvAllMember.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtStatus.Text = dgvAllMember.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEMPID.Text = dgvAllMember.Rows[e.RowIndex].Cells[4].Value.ToString();

                
                AC.sql = "SELECT * FROM tb_employee WHERE emp_id = @empid";
                AC.cmd.Parameters.Clear();
                AC.cmd.CommandType = CommandType.Text;
                AC.cmd.CommandText = AC.sql;

                AC.cmd.Parameters.AddWithValue("@empid", this.txtEMPID.Text.Trim().ToString());
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

            catch
            {
                MessageBox.Show("Error", "Error krub",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataMember()
        {
            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.Font = new Font("Ms Sans Serif", 10, FontStyle.Regular);
            //dgvAllStduent.ColumnHeadersDefaultCellStyle = cs;
            //dgvAllStduent.Columns[0].HeaderText = "รหัสนักศึกษา";
            //dgvAllStduent.Columns[1].HeaderText = "ชื่อ";
            //dgvAllStduent.Columns[2].HeaderText = "นามสกุล";
            //dgvAllStduent.Columns[3].HeaderText = "วันเดือนปีเกิด";
            //dgvAllStduent.Columns[4].HeaderText = "น้ำหนัก";

            //dgvAllStduent.Columns[0].Width = 120;
            //dgvAllStduent.Columns[1].Width = 140;
            //dgvAllStduent.Columns[2].Width = 140;
            //dgvAllStduent.Columns[3].Width = 140;
            //dgvAllStduent.Columns[4].Width = 70;

        }
    }
}

